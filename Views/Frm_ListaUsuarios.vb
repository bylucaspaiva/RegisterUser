Public Class Frm_ListaUsuarios
    Private Sub Frm_ListaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarUsuarios()
    End Sub

    Private Sub CarregarUsuarios()
        Dim databaseManager As New DatabaseManager()

        Try
            Dim usuarios As List(Of Usuario) = databaseManager.ObterUsuarios()

            DataGridView1.DataSource = usuarios
        Catch ex As Exception
            MessageBox.Show("Erro ao obter usuários: " & ex.Message)
        End Try
    End Sub
End Class
