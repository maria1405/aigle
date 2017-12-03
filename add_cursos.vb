Imports System.Data.OleDb
Public Class add_cursos
    Dim ruta As String
    Dim ds As New DataSet
    Dim Conexion As OleDbConnection
    Dim cadenaconexion As String
    Public csql As New conexion
    Dim data As New DataSet

    Dim userId As Integer
    Public Sub New(ByVal userIdParameter As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        userId = userIdParameter
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Try
            csql.sentencia("INSERT INTO Courses(name, description, cover, user_id)
VALUES('" & txt_name.Text & "','" & txt_description.Text & "','" & 0 & "','" & userId & "')")
            'limpiar
            txt_name.Text = ""
            txt_description.Text = ""
            Me.Hide()
            Dim Cursos As New Cursos(userId)
            Cursos.Refresh()
            Cursos.Show()
        Catch ex As Exception
            MsgBox("ERROR EN LA SINTAXIS DE LOS CAMPOS" & ex.Message)
        End Try
    End Sub

    Private Sub add_cursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class