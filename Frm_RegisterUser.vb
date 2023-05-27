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

    End Sub
End Class
