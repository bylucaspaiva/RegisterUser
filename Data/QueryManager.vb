Public Class QueryManager
    Public Shared Function GetInsertQuery() As String
        Return "INSERT INTO [RegisterUser].[dbo].[User] (CPF, Nome, Telefone, Email, Sexo, Endereço, DataNascimento) VALUES (@CPF, @Nome, @Telefone, @Email, @Sexo, @Endereco, @DataNascimento)"
    End Function

    Public Shared Function GetSelectQuery() As String
        Return "SELECT CPF, Nome, Telefone, Email, Sexo, Endereço, DataNascimento FROM [RegisterUser].[dbo].[User]"
    End Function
End Class
