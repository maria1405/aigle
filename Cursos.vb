Imports System.Data.OleDb
Public Class Cursos
    Public csql As New conexion
    Dim data As New DataSet
    Dim userId As Integer
    Dim courseId As Integer
    Dim isAdmin As Boolean
    Public Sub New(ByVal userIdParameter As Integer, ByVal isAdminParameter? As Boolean)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        userId = userIdParameter
        isAdmin = isAdminParameter
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Cursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        linkaddcourse.Visible = isAdmin
        admin.Visible = isAdmin
        Try
            data = csql.sentencia("SELECT * FROM Courses")
            Dim counter As Integer = data.Tables(0).Rows.Count
            For index = 0 To counter - 1
                Dim idCourse As Integer = data.Tables(0).Rows(index)(0)

                tablecourses.RowStyles.Add(New RowStyle())
                tablecourses.RowCount += 1

                Dim lbl As Object = New Label()
                Dim label As Label = lbl
                lbl.name = idCourse
                lbl.autosize = True
                lbl.text = data.Tables(0).Rows(index)(1)

                Dim courseDestroy As Object = New Label()
                Dim courseDelete As Label = courseDestroy
                courseDelete.ForeColor = Color.Red
                courseDestroy.name = idCourse
                courseDestroy.text = "Eliminar curso"

                Dim courseEdit As Object = New Label()
                Dim courseEditRes As Label = courseEdit
                courseEditRes.ForeColor = Color.Blue
                courseEditRes.Name = idCourse
                courseEditRes.Text = "Editar"

                tablecourses.Controls.Add(lbl, 0, tablecourses.RowCount - 1)
                AddHandler label.Click, AddressOf myClickHandler

                If isAdmin Then
                    tablecourses.Controls.Add(courseEdit, 1, tablecourses.RowCount - 1)
                    tablecourses.Controls.Add(courseDestroy, 2, tablecourses.RowCount - 1)
                    AddHandler courseEditRes.Click, AddressOf editHandler
                    AddHandler courseDelete.Click, AddressOf destroyHandler
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Tuvimos un problema al resolver la petición.", "Aigle | e-Learning")
        End Try
    End Sub
    Private Sub editHandler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim editCourse As New add_cursos(userId, isAdmin, False, sender.name)
            editCourse.Refresh()
            editCourse.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Tuvimos un problemas, trabajamos en solucionarlo.", "Aigle | e-Learning")
        End Try
    End Sub
    Private Sub destroyHandler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            csql.sentencia("DELETE FROM Lessons WHERE (course_id='" & sender.name & "')")
            data = csql.sentencia("DELETE FROM Courses WHERE (id='" & sender.name & "')")
            Dim cursos As New Cursos(userId, isAdmin)
            Me.Close()
            cursos.Refresh()
            cursos.Show()
            MessageBox.Show("Se eliminó correctamente el curso.", "Aigle | e-Learning")
        Catch ex As Exception
            MessageBox.Show("Tuvimos un error, trabajamos en solucionarlo.", "Aigle | e-Learning")
        End Try
    End Sub
    Private Sub myClickHandler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim curso As New Curso(userId, sender.name, isAdmin)
        curso.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkaddcourse.LinkClicked
        Me.Hide()
        Dim addCourse As New add_cursos(userId, isAdmin, True, 0)
        addCourse.Show()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub backToCourse_Click(sender As Object, e As EventArgs) Handles backToCourse.Click
        Dim login As New login()
        login.Refresh()
        login.Show()
        Me.Close()
    End Sub

    Private Sub admin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles admin.LinkClicked
        Dim users As New Users(isAdmin, userId)
        users.Show()
        Me.Close()
    End Sub
End Class