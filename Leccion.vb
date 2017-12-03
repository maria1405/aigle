Imports System.Data.OleDb
Public Class Leccion
    Dim userId As Integer
    Dim idLesson As Integer
    Dim lesson As DataSet
    Dim Conexion As OleDbConnection
    Dim cadenaconexion As String
    Public csql As New conexion
    Public Sub New(ByVal userIdParameter As Integer, ByVal LessonId As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        idLesson = LessonId
        userId = userIdParameter
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Leccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lesson = csql.sentencia("SELECT * FROM Lessons WHERE (id='" & idLesson & "')")
            lessonDescrition.Text = lesson.Tables(0).Rows(0)(2)
            Me.Text = lesson.Tables(0).Rows(0)(1)
            lessonTitle.Text = Me.Text
        Catch ex As Exception
            MsgBox("Tuvimos un error al cargar los datos, ¿nos perdonas?")
            Dim courses As New Cursos(userId)
            courses.Show()
            Me.Hide()
        End Try
    End Sub

    Private Sub backToCourse_Click(sender As Object, e As EventArgs) Handles backToCourse.Click
        Dim course As New Curso(userId, lesson.Tables(0).Rows(0)(6))
        course.Show()
        Me.Hide()
    End Sub

    Private Sub lblactualizar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblactualizar.LinkClicked
        '' Aquí debemos de llamar a addLesson en su versión de actualizar su contenido.
    End Sub
End Class