Imports System.Data.OleDb
Public Class Registro
    Dim ruta As String
    Dim ds As New DataSet
    Dim Conexion As OleDbConnection
    Dim cadenaconexion As String
    Public csql As New conexion
    Dim data As New DataSet
    Dim dt As New DataSet
    Dim isAdmin As Boolean
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Try
            dt = csql.sentencia("SELECT username FROM Users WHERE (username Like '" & txt_usu.Text & "')")
            If dt.Tables(0).Rows.Count >= 1 Then
                MsgBox("Lo sentimos, el nombre de usuario ya exite.", "Aigle | e-Learning")
            Else
                If txt_conf_pass.Text = txt_passw.Text Then
                    csql.sentencia("INSERT INTO Users(name, last_name, email, username, role, password)
VALUES('" & txt_nombre.Text & "','" & txt_ap.Text & "','" & txt_email.Text & "','" & txt_usu.Text & "','" & 0 & "','" & txt_passw.Text & "')")
                    data = csql.sentencia("SELECT * FROM Users WHERE(username='" & txt_usu.Text & "' and email='" & txt_email.Text & "' and password='" & txt_passw.Text & "')")
                    If data.Tables(0).Rows(0)(5) = 0 Then
                        isAdmin = False
                    ElseIf data.Tables(0).Rows(0)(5) = 1 Then
                        isAdmin = True
                    End If
                    Dim courses As New Cursos(data.Tables(0).Rows(0)(0), isAdmin)
                    courses.Show()
                    Me.Close()
                Else
                    MsgBox("Tus contraseñas no coinciden.", "Aigle | e-Learning")
                End If
            End If
        Catch ex As Exception
            MsgBox("Tuvimos un error, trabajamos en solucionarlo pronto. ", "Aigle | e-Learning")
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        login.Show()
        Me.Close()
    End Sub
End Class