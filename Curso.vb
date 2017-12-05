Imports System.Data.OleDb
Public Class Curso
    Dim courseId As Integer
    Dim userId As Integer
    Dim Conexion As OleDbConnection
    Dim cadenaconexion As String
    Public csql As New conexion
    Dim data As New DataSet
    Dim lessons As New DataSet
    Dim isAdmin As Boolean

    Public Sub New(ByVal userIdParameter As Integer, ByVal idCourse As Integer, ByVal isAdminParameter As Boolean)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        courseId = idCourse
        userId = userIdParameter
        isAdmin = isAdminParameter
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub Curso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addLesson.Visible = isAdmin
        Try
            data = csql.sentencia("SELECT * FROM Courses WHERE (id='" & courseId & "')")
            lessons = csql.sentencia("SELECT * FROM Lessons WHERE (course_id='" & courseId & "')")
            Me.Text = data.Tables(0).Rows(0)(1)
            courseName.Text = data.Tables(0).Rows(0)(1)
            Dim counter As Integer = lessons.Tables(0).Rows.Count
            For index = 0 To counter - 1
                tablelessons.RowStyles.Add(New RowStyle())
                tablelessons.RowCount += 1

                Dim idLesson As Integer = lessons.Tables(0).Rows(index)(0)

                Dim lbl As Object = New Label()
                lbl.name = idLesson
                Dim label As Label = lbl
                lbl.autosize = True
                lbl.text = lessons.Tables(0).Rows(index)(1)
                tablelessons.Controls.Add(lbl, 0, tablelessons.RowCount - 1)

                Dim deleteLesson As Object = New Label
                Dim deleteLessonClick As Label = deleteLesson
                deleteLesson.text = "Eliminar lección"
                deleteLessonClick.ForeColor = Color.Red
                deleteLesson.name = idLesson
                deleteLesson.visible = isAdmin

                Dim lessonEdit As Object = New Label()
                Dim lessonEditRes As Label = lessonEdit
                lessonEditRes.ForeColor = Color.Blue
                lessonEditRes.Name = idLesson
                lessonEditRes.Text = "Editar"

                tablelessons.Controls.Add(lbl, 0, tablelessons.RowCount - 1)
                AddHandler label.Click, AddressOf myClickHandler

                If isAdmin Then
                    tablelessons.Controls.Add(lessonEdit, 1, tablelessons.RowCount - 1)
                    tablelessons.Controls.Add(deleteLesson, 2, tablelessons.RowCount - 1)

                    AddHandler deleteLessonClick.Click, AddressOf destroyLesson
                    AddHandler lessonEditRes.Click, AddressOf editLesson
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Tuvimos un problema al resolver la petición.", "Aigle | e-Learning")
        End Try
    End Sub
    Private Sub editLesson(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim addLesson As New addlesson(userId, courseId, isAdmin, False, sender.name)
        addLesson.Refresh()
        addLesson.Show()
        Me.Close()
    End Sub
    Private Sub destroyLesson(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            data = csql.sentencia("DELETE FROM Lessons WHERE (id='" & sender.name & "')")
            Dim curso As New Curso(userId, courseId, isAdmin)
            Me.Close()
            curso.Refresh()
            curso.Show()
            MessageBox.Show("Se eliminó correctamente la lección.", "Aigle | e-Learning")
        Catch ex As Exception
            MessageBox.Show("Tuvimos un error, trabajamos en solucionarlo.", "Aigle | e-Learning")
        End Try
    End Sub
    Private Sub myClickHandler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim lesson As New Leccion(userId, sender.name, isAdmin)
        lesson.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblvolcursos.Click
        Dim courses As New Cursos(userId, isAdmin)
        courses.Show()
        Me.Hide()
    End Sub

    Private Sub addLesson_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles addLesson.LinkClicked
        Dim addLesson As New addlesson(userId, courseId, isAdmin, True, 0)
        addLesson.Show()
        Me.Close()
    End Sub
End Class