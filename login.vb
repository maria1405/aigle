Imports System.Data.OleDb
Public Class login
    Dim ruta As String
    Dim ds As New DataSet
    Dim Conexion As OleDbConnection
    Dim cadenaconexion As String
    Public csql As New conexion
    Dim data As New DataSet
    Dim isAdmin As Boolean
    'Dim dbcon As New OleDb.OleDbConnection
    'Dim dbup As New OleDb.OleDbCommand

    Private Sub lnklbl_registrarse_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Hide()
        Registro.Hide()
    End Sub

    Private Sub btn_enter_Click(sender As Object, e As EventArgs) Handles btn_enter.Click
        Try
            data = csql.sentencia("Select * from Users where (username='" & txt_user.Text & "' And password ='" & txt_password.Text & "')")
            If data.Tables(0).Rows.Count = 1 Then
                Timer1.Start()
            Else
                Static tried As Integer
                tried = tried + 1
                MsgBox("ESTIMADO USUARIO, TIENES " & (5 - tried) & " INTENTOS PARA PROBAR QUE ES EL USUARIO CORRECTO", "Aigle | e-Learning")
                If tried = 5 Then
                    MsgBox("EL SISTEMA SE CERRARÁ, GRACIAS", MsgBoxStyle.Critical, "Aigle | e-Learning")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error detectado", "Aigle | e-Learning")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            If data.Tables(0).Rows(0)(5) = 0 Then
                isAdmin = False
            ElseIf data.Tables(0).Rows(0)(5) = 1 Then
                isAdmin = True
            End If
            Dim misCursos As New Cursos(data.Tables(0).Rows(0)(0), isAdmin)
            misCursos.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub lnklbl_registrarse_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklbl_registrarse.LinkClicked
        Me.Hide()
        Registro.Show()
    End Sub



End Class
