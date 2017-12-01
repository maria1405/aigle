Imports System.Data.OleDb
Public Class Cursos
    Public csql As New conexion
    Dim data As New DataSet
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Leccion.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Curso.Show()
        Me.Hide()
    End Sub

    Private Sub Cursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            data = csql.sentencia("SELECT * FROM Courses")
            Dim counter As Integer = data.Tables(0).Rows.Count
            For index = 0 To counter - 1
                tablecourses.RowStyles.Add(New RowStyle())
                tablecourses.RowCount += 1
                Dim lbl As Object = New Label()
                lbl.autosize = True
                lbl.text = data.Tables(0).Rows(index)(1)
                tablecourses.Controls.Add(lbl, 0, tablecourses.RowCount - 1)
            Next
        Catch ex As Exception
            MsgBox("ERROR EN LA SINTAXIS DE LOS CAMPOS" & ex.Message)
        End Try
    End Sub
End Class