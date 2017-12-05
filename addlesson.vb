Imports System.Data.OleDb
Public Class addlesson
    Dim ruta As String
    Dim ds As New DataSet
    Dim Conexion As OleDbConnection
    Dim cadenaconexion, route As String
    Public csql As New conexion
    Dim data As New DataSet
    Dim idCourse, userId As Integer
    Dim idLesson As Integer = 0
    Dim isAdmin, isNew As Boolean
    Public Sub New(ByVal userIdParameter As Integer, ByVal idCourseParameter As Integer, ByVal isAdminParameter As Boolean, ByVal isNewResource As Boolean, idLessonParameter As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        userId = userIdParameter
        idCourse = idCourseParameter
        isAdmin = isAdminParameter
        isNew = isNewResource
        idLesson = idLessonParameter
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If isNew Then
            Try
                csql.sentencia("INSERT INTO Lessons(name, description, course_id, url_video) VALUES('" & txt_name.Text & "','" & txt_description.Text & "','" & idCourse & "', '" & txt_url.Text & "')")
                'limpiar
                txt_name.Text = ""
                txt_description.Text = ""
                Dim course As New Curso(userId, idCourse, isAdmin)
                course.Refresh()
                course.Show()
                Me.Close()
            Catch ex As Exception
                MsgBox("Tuvimos un error, trabajamos en solucionarlo.", "Aigle | e-Learning")
            End Try
        ElseIf isNew = False Then
            csql.sentencia("UPDATE Lessons SET name ='" & txt_name.Text & "', description='" & txt_description.Text & "', url_video='" & txt_url.Text & "' WHERE (id='" & idLesson & "')")
            Dim course As New Curso(userId, idCourse, isAdmin)
            course.Refresh()
            course.Show()
            Me.Hide()
            MsgBox("Se ha actualizado exitosamente.", "Aigle | e-Learning")
        End If

    End Sub

    Private Sub btn_examinar_Click(sender As Object, e As EventArgs) Handles btn_examinar.Click
        opfile.ShowDialog()
        route = opfile.FileName
        txt_url.Text = route
    End Sub

    Private Sub addlesson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isNew = False Then
            data = csql.sentencia("SELECT * FROM Lessons WHERE (id='" & idLesson & "')")
            txt_name.Text = data.Tables(0).Rows(0)(1)
            txt_description.Text = data.Tables(0).Rows(0)(2)
            txt_url.Text = data.Tables(0).Rows(0)(3)
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Dim course As New Curso(userId, idCourse, isAdmin)
        course.Show()
        Me.Close()
    End Sub
End Class