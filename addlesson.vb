Imports System.Data.OleDb
Public Class addlesson
    Dim ruta As String
    Dim ds As New DataSet
    Dim Conexion As OleDbConnection
    Dim cadenaconexion As String
    Public csql As New conexion
    Dim data As New DataSet
    Dim idCourse, userId As Integer

    Public Sub New(ByVal userIdParameter As Integer, ByVal idCourseParameter As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        userId = userIdParameter
        idCourse = idCourseParameter
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Try
            csql.sentencia("INSERT INTO Lessons(name, description, cover, course_id)
VALUES('" & txt_name.Text & "','" & txt_description.Text & "','" & 0 & "', '" & idCourse & "')")
            'limpiar
            txt_name.Text = ""
            txt_description.Text = ""
            Dim course As New Curso(userId, idCourse)
            course.Refresh()
            course.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("Tuvimos un error, trabajamos en solucionarlo.")
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Dim course As New Curso(userId, idCourse)
        course.Show()
        Me.Close()
    End Sub
End Class