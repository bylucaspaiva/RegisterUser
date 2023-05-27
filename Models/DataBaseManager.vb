Imports System.Data.SqlClient

Public Class DatabaseManager
    Private connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RegisterUser;Integrated Security=True;"

    Public Sub InserirUsuario(cpf As String, nome As String, telefone As String, email As String, sexo As String, endereco As String, dataNascimento As String)
        Dim query As String = QueryManager.GetInsertQuery()

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@CPF", cpf)
                    command.Parameters.AddWithValue("@Nome", nome)
                    command.Parameters.AddWithValue("@Telefone", telefone)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@Sexo", sexo)
                    command.Parameters.AddWithValue("@Endereco", endereco)
                    command.Parameters.AddWithValue("@DataNascimento", dataNascimento)

                    command.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw New Exception("Erro ao inserir usuário no banco de dados: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
