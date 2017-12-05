Imports System.Data.OleDb
Public Class add_cursos
    Dim ruta As String
    Dim ds As New DataSet
    Dim Conexion As OleDbConnection
    Dim cadenaconexion As String
    Public csql As New conexion
    Dim data As New DataSet

    Dim userId As Integer
    Dim isAdmin, isNew As Boolean
    Dim idCourse As Integer = 0
    Public Sub New(ByVal userIdParameter As Integer, ByVal isAdminParameter As Boolean, ByVal isNewResource As Boolean, idCourseParameter As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        userId = userIdParameter
        isAdmin = isAdminParameter
        isNew = isNewResource
        idCourse = idCourseParameter
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If isNew Then
            Try
                csql.sentencia("INSERT INTO Courses(name, description, user_id)
VALUES('" & txt_name.Text & "','" & txt_description.Text & "','" & userId & "')")
                'limpiar
                txt_name.Text = ""
                txt_description.Text = ""
                Me.Hide()
                Dim Cursos As New Cursos(userId, isAdmin)
                Cursos.Refresh()
                Cursos.Show()
            Catch ex As Exception
                MessageBox.Show("ERROR EN LA SINTAXIS DE LOS CAMPOS" & ex.Message, "Aigle | e-Learning")
            End Try
        ElseIf isNew = False Then
            csql.sentencia("UPDATE Courses SET name ='" & txt_name.Text & "', description='" & txt_description.Text & "' WHERE (id='" & idCourse & "')")
            Dim courses As New Cursos(userId, isAdmin)
            courses.Refresh()
            courses.Show()
            Me.Close()
            MessageBox.Show("Se ha actualizado exitosamente.", "Aigle | e-Learning")
        End If
    End Sub

    Private Sub add_cursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If isNew = False Then
            data = csql.sentencia("SELECT * FROM Courses WHERE id='" & idCourse & "'")
            txt_name.Text = data.Tables(0).Rows(0)(1)
            txt_description.Text = data.Tables(0).Rows(0)(2)
        End If
    End Sub
End Class