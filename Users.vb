Imports System.Data.OleDb
Public Class Users
    Dim Conexion As OleDbConnection
    Dim cadenaconexion As String
    Public csql As New conexion
    Dim isAdmin As Boolean
    Dim data As DataSet
    Dim userId As Integer
    Public Sub New(ByVal isAdminParameter As Boolean, ByVal userIdParameter As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        isAdmin = isAdminParameter
        userId = userIdParameter
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            data = csql.sentencia("SELECT * FROM Users")
            Dim counter As Integer = data.Tables(0).Rows.Count
            For index = 0 To counter - 1
                userstable.RowStyles.Add(New RowStyle())
                userstable.RowCount += 1

                Dim idLesson As Integer = data.Tables(0).Rows(index)(0)

                Dim lbl As Object = New Label()
                lbl.name = idLesson
                Dim label As Label = lbl
                lbl.autosize = True
                lbl.text = data.Tables(0).Rows(index)(1) & " " & data.Tables(0).Rows(index)(2)

                ' Label convertir
                Dim conver As Object = New Label
                conver.name = data.Tables(0).Rows(index)(0)
                Dim convertir As Label = conver
                convertir.AutoSize = True
                convertir.ForeColor = Color.Green

                Dim txt_convert As String = ""
                If data.Tables(0).Rows(index)(5) = 0 Then
                    txt_convert = "Convertir a administrador"
                ElseIf data.Tables(0).Rows(index)(5) = 1 Then
                    txt_convert = "Convertir a estudiante"
                End If
                conver.tag = data.Tables(0).Rows(index)(5)
                conver.text = txt_convert


                ' Label eliminar usuario
                Dim delete As Object = New Label
                Dim destroyUser As Label = delete
                delete.name = data.Tables(0).Rows(index)(0)
                destroyUser.ForeColor = Color.Red
                delete.text = "Eliminar usuario"


                userstable.Controls.Add(lbl, 0, userstable.RowCount - 1)
                userstable.Controls.Add(conver, 1, userstable.RowCount - 1)
                userstable.Controls.Add(delete, 2, userstable.RowCount - 1)

                AddHandler convertir.Click, AddressOf convertirHandle
                AddHandler destroyUser.Click, AddressOf eliminarHandle

            Next
        Catch ex As Exception
            MessageBox.Show("Tuvimos un error, estamos trabajando en solucionarlo", "Aigle | e-Learning")
        End Try
    End Sub
    Private Sub convertirHandle(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If sender.tag = 0 Then
            Try
                csql.sentencia("UPDATE Users SET role='1' WHERE id='" & sender.name & "'")
                MessageBox.Show("Se actualizó con éxito.", "Aigle | e-Learning")
            Catch ex As Exception
                MessageBox.Show("Tuvimos un problema al procesar la información", "Aigle | e-Learning")
            End Try
        ElseIf sender.tag = 1 Then
            Try
                csql.sentencia("UPDATE Users SET role='0' WHERE id='" & sender.name & "'")
                MessageBox.Show("Se actualizó con éxito.", "Aigle | e-Learning")
            Catch ex As Exception
                MessageBox.Show("Tuvimos un problema al procesar la información", "Aigle | e-Learning")
            End Try
        End If
        Dim users As New Users(isAdmin, userId)
        users.Show()
        Me.Close()
    End Sub
    Private Sub eliminarHandle(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            csql.sentencia("DELETE Users WHERE id='" & sender.name & "'")
            Dim users As New Users(isAdmin, userId)
            users.Show()
            Me.Close()
            MessageBox.Show("Usuario eliminado.", "Aigle | e-Learning")
        Catch ex As Exception
            MessageBox.Show("Tuvimos un error al procesar la información.", "Aigle | e-Learning")
        End Try
    End Sub

    Private Sub lblvolcursos_Click(sender As Object, e As EventArgs) Handles lblvolcursos.Click
        Dim courses As New Cursos(userId, isAdmin)
        courses.Show()
        Me.Hide()
    End Sub
End Class