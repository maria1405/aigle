Imports System.Data.SqlClient
Imports Entidad

Public Class Fusuario

    Inherits conexion

    Public Function validationuser(ByVal dts As Eusuario) As DataTable
        conectado()
        cmd = New SqlCommand("p_login")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnn

        cmd.Parameters.AddWithValue("@username", dts._username)
        cmd.Parameters.AddWithValue("@password", dts._password)

        If cmd.ExecuteNonQuery Then
            Using dt As New DataTable
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                    Return dt
                End Using
            End Using
        Else
            Return Nothing
        End If

    End Function


End Class
