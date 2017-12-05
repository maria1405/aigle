Public Class conexion
    Private cadena As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=elearningtec;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    Private conexion As New SqlClient.SqlConnection(cadena)
    Public Function sentencia(ByVal sql As String) As DataSet
        Dim ds As New DataSet
        Try
            conexion.Open()
            Dim adaptador As New SqlClient.SqlDataAdapter(sql, conexion)
            adaptador.Fill(ds)
            adaptador.Dispose()
            conexion.Close()
            Return ds
        Catch ex As Exception
            MessageBox.Show("Tuvimos un problema al resolver la petición.", "Aigle | e-Learning")
            Return Nothing
        End Try
    End Function
End Class
