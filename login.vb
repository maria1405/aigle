Imports Datos
Imports Entidad
Public Class login

    Dim fu As New Fusuario
    Dim eu As New Eusuario

    Private Sub lnklbl_registrarse_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Hide()
        Registro.Hide()
    End Sub

    Private Sub btn_enter_Click(sender As Object, e As EventArgs) Handles btn_enter.Click
        Try
            If txt_password.Text = eu._username And txt_user.Text = eu._password Then
                Dim dt As New DataTable

                eu._username = txt_user.Text
                eu._password = txt_password.Text
                dt = fu.validationuser(eu)
                Timer1.Start()

            Else
                Static tried As Integer
                tried = tried + 1
                MsgBox("ESTIMADO USUARIO, TIENES " & (5 - tried) & " INTENTOS PARA PROBAR QUE ES EL USUARIO CORRECTO")
                If tried = 5 Then
                    MsgBox("EL SISTEMA SE CERRARÁ, GRACIAS", MsgBoxStyle.Critical, "SISTEMA")
                End If
                MsgBox("no funciono ni madres fer")
                End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Me.Hide()
            MsgBox("BIENVENIDO A AIGLE " & txt_user.Text)
            INDEX.Show()
        End If
    End Sub
End Class
