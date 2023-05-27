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

    Public Function ObterUsuarios() As List(Of Usuario)
        Dim usuarios As New List(Of Usuario)()

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = QueryManager.GetSelectQuery

                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim usuario As New Usuario()
                            usuario.CPF = reader.GetString(0)
                            usuario.Nome = reader.GetString(1)
                            usuario.Telefone = reader.GetString(2)
                            usuario.Email = reader.GetString(3)
                            usuario.Sexo = reader.GetString(4)
                            usuario.Endereco = reader.GetString(5)
                            usuario.DataNascimento = reader.GetDateTime(6)
                            usuarios.Add(usuario)
                        End While
                    End Using
                End Using
            Catch ex As Exception
                Throw New Exception("Erro ao obter usuários do banco de dados: " & ex.Message)
            End Try
        End Using

        Return usuarios
    End Function
End Class
