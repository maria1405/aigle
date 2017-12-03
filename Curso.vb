Imports System.Data.OleDb
Public Class Curso
    Dim courseId As Integer
    Dim userId As Integer
    Dim Conexion As OleDbConnection
    Dim cadenaconexion As String
    Public csql As New conexion
    Dim data As New DataSet
    Dim lessons As New DataSet
    Public Sub New(ByVal userIdParameter As Integer, ByVal idCourse As Integer)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        courseId = idCourse
        userId = userIdParameter
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim Cursos As New Cursos("")
        Cursos.Refresh()
        Cursos.Show()
        Me.Hide()
    End Sub

    Private Sub Curso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            data = csql.sentencia("SELECT * FROM Courses WHERE (id='" & courseId & "')")
            lessons = csql.sentencia("SELECT * FROM Lessons WHERE (course_id='" & courseId & "')")
            Me.Text = data.Tables(0).Rows(0)(1)
            courseName.Text = data.Tables(0).Rows(0)(1)
            Dim counter As Integer = lessons.Tables(0).Rows.Count
            For index = 0 To counter - 1
                tablelessons.RowStyles.Add(New RowStyle())
                tablelessons.RowCount += 1
                Dim lbl As Object = New Label()
                Dim idLesson As Integer = lessons.Tables(0).Rows(index)(0)
                lbl.name = idLesson
                Dim label As Label = lbl
                lbl.autosize = True
                lbl.text = lessons.Tables(0).Rows(index)(1)
                tablelessons.Controls.Add(lbl, 0, tablelessons.RowCount - 1)
                AddHandler label.Click, AddressOf myClickHandler
            Next
        Catch ex As Exception
            MsgBox("ERROR EN LA SINTAXIS DE LOS CAMPOS" & ex.Message)
        End Try
    End Sub

    Private Sub myClickHandler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim lesson As New Leccion(userId, sender.name)
        lesson.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim courses As New Cursos(userId)
        courses.Show()
        Me.Hide()
    End Sub
End Class