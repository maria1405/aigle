Imports System.Data.OleDb
Public Class Registro
    Dim ruta As String
    Dim ds As New DataSet
    Dim Conexion As OleDbConnection
    Dim cadenaconexion As String
    Public csql As New conexion
    Dim data As New DataSet

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Try

            If txt_conf_pass.Text = txt_passw.Text Then
                csql.sentencia("INSERT INTO Users(name, last_name, email, username, role, password)
VALUES('" & txt_nombre.Text & "','" & txt_ap.Text & "','" & txt_email.Text & "','" & txt_usu.Text & "','" & 0 & "','" & txt_passw.Text & "')")
                MsgBox("REGÍSTRADO CORRECTAMENTE")
                'limpiar
                txt_ap.Text = ""
                txt_conf_pass.Text = ""
                txt_email.Text = ""
                txt_nombre.Text = ""
                txt_passw.Text = ""
                txt_usu.Text = ""
                data = csql.sentencia("SELECT * FROM Users") 'TABLA VENTAS
            Else
                MsgBox("CONFIRMA LA CONTRASEÑA")

            End If



        Catch ex As Exception
            MsgBox("ERROR EN LA SINTAXIS DE LOS CAMPOS" & ex.Message)


        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        txt_ap.Text = ""
        txt_conf_pass.Text = ""
        txt_email.Text = ""
        txt_nombre.Text = ""
        txt_passw.Text = ""
        txt_usu.Text = ""
    End Sub
End Class