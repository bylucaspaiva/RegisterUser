Public Class QueryManager
    Public Shared Function GetInsertQuery() As String
        Return "INSERT INTO [RegisterUser].[dbo].[User] (CPF, Nome, Telefone, Email, Sexo, Endereço, DataNascimento) VALUES (@CPF, @Nome, @Telefone, @Email, @Sexo, @Endereco, @DataNascimento)"
    End Function
End Class
