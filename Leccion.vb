Imports System.Data.OleDb
Public Class Leccion
    Dim userId As Integer
    Dim idLesson As Integer
    Dim lesson As DataSet
    Dim Conexion As OleDbConnection
    Dim cadenaconexion As String
    Public csql As New conexion
    Dim isAdmin As Boolean
    Public Sub New(ByVal userIdParameter As Integer, ByVal LessonId As Integer, ByVal isAdminParameter As Boolean)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        idLesson = LessonId
        userId = userIdParameter
        isAdmin = isAdminParameter
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Leccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblactualizar.Visible = isAdmin
        Try
            lesson = csql.sentencia("SELECT * FROM Lessons WHERE (id='" & idLesson & "')")
            lessonDescrition.Text = lesson.Tables(0).Rows(0)(2)
            Me.Text = lesson.Tables(0).Rows(0)(1)
            lessonTitle.Text = Me.Text
            player.URL = lesson.Tables(0).Rows(0)(3)
            ' video.Movie = lesson.Tables(0).Rows(0)(3)

        Catch ex As Exception
            MessageBox.Show("Tuvimos un error al cargar los datos, ¿nos perdonas?", "Aigle | e-Learning")
            Dim courses As New Cursos(userId, isAdmin)
            courses.Show()
            Me.Hide()
        End Try
    End Sub

    Private Sub backToCourse_Click(sender As Object, e As EventArgs) Handles backToCourse.Click
        Dim course As New Curso(userId, lesson.Tables(0).Rows(0)(4), isAdmin)
        course.Show()
        Me.Close()
    End Sub

    Private Sub lblactualizar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblactualizar.LinkClicked
        '' Aquí debemos de llamar a addLesson en su versión de actualizar su contenido.
        Dim addLesson As New addlesson(userId, lesson.Tables(0).Rows(0)(4), isAdmin, False, idLesson)
        addLesson.Refresh()
        addLesson.Show()
        Me.Close()
    End Sub
End Class