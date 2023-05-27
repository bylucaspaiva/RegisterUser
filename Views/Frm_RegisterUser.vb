Public Class Frm_RegisterUser
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub RegisterUserBtm_Click(sender As Object, e As EventArgs) Handles Btm_RegisterUser.Click
        Dim Nome = Txt_Nome.Text
        Dim CPF = Txt_CPF.Text
        Dim Nascimento = Txt_Nascimento.Text
        Dim Sexo = Txt_Sexo.Text
        Dim Endereco = Txt_Endereço.Text
        Dim Telefone = Txt_Telefone.Text
        Dim Email = Txt_Email.Text

        Dim databaseManager As New DatabaseManager()

        databaseManager.InserirUsuario(CPF, Nome, Telefone, Email, Sexo, Endereco, Nascimento)

        MessageBox.Show("Usuário inserido com sucesso!")

    End Sub
End Class
