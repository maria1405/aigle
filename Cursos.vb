Imports System.Data.OleDb
Public Class Cursos
    Public csql As New conexion
    Dim data As New DataSet
    Dim userId As Integer
    Dim courseId As Integer
    Public Sub New(ByVal userIdParameter As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        userId = userIdParameter
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Cursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            data = csql.sentencia("SELECT * FROM Courses")
            Dim counter As Integer = data.Tables(0).Rows.Count
            For index = 0 To counter - 1
                tablecourses.RowStyles.Add(New RowStyle())
                tablecourses.RowCount += 1
                Dim lbl As Object = New Label()
                Dim idCourse As Integer = data.Tables(0).Rows(index)(0)
                lbl.name = idCourse
                Dim label As Label = lbl
                lbl.autosize = True
                lbl.text = data.Tables(0).Rows(index)(1)
                tablecourses.Controls.Add(lbl, 0, tablecourses.RowCount - 1)
                AddHandler label.Click, AddressOf myClickHandler
            Next
        Catch ex As Exception
            MsgBox("ERROR EN LA SINTAXIS DE LOS CAMPOS" & ex.Message)
        End Try
    End Sub
    Private Sub myClickHandler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim curso As New Curso(userId, sender.name)
        curso.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkaddcourse.LinkClicked
        Me.Hide()
        Dim addCourse As New add_cursos(userId)
        addCourse.Show()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class