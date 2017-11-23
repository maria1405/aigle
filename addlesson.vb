Imports System.Data.OleDb
Public Class addlesson
    Dim ruta As String
    Dim ds As New DataSet
    Dim Conexion As OleDbConnection
    Dim cadenaconexion As String
    Public csql As New conexion
    Dim data As New DataSet

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Try
            csql.sentencia("INSERT INTO Lessons(name, description, cover)
VALUES('" & txt_name.Text & "','" & txt_description.Text & "','" & 0 & "')")
            MsgBox("REGÍSTRADO CORRECTAMENTE")
            'limpiar
            txt_name.Text = ""
            txt_description.Text = ""
            data = csql.sentencia("SELECT * FROM Lessons") 'TABLA VENTAS
        Catch ex As Exception
            MsgBox("ERROR EN LA SINTAXIS DE LOS CAMPOS" & ex.Message)
        End Try
    End Sub
End Class