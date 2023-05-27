<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_RegisterUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Btm_RegisterUser = New Button()
        Lbl_Nome = New Label()
        Txt_Nome = New TextBox()
        Lbl_CPF = New Label()
        Txt_CPF = New TextBox()
        Lbl_Telefone = New Label()
        Txt_Telefone = New TextBox()
        Lbl_Email = New Label()
        Txt_Email = New TextBox()
        Lbl_Sexo = New Label()
        Txt_Sexo = New TextBox()
        Lbl_Endereco = New Label()
        Txt_Endereço = New TextBox()
        Lbl_Nascimento = New Label()
        Txt_Nascimento = New TextBox()
        SuspendLayout()
        ' 
        ' Btm_RegisterUser
        ' 
        Btm_RegisterUser.Location = New Point(574, 70)
        Btm_RegisterUser.Name = "Btm_RegisterUser"
        Btm_RegisterUser.Size = New Size(94, 29)
        Btm_RegisterUser.TabIndex = 0
        Btm_RegisterUser.Text = "Cadastrar"
        Btm_RegisterUser.UseVisualStyleBackColor = True
        ' 
        ' Lbl_Nome
        ' 
        Lbl_Nome.AutoSize = True
        Lbl_Nome.Location = New Point(43, 47)
        Lbl_Nome.Name = "Lbl_Nome"
        Lbl_Nome.Size = New Size(50, 20)
        Lbl_Nome.TabIndex = 1
        Lbl_Nome.Text = "Nome"
        ' 
        ' Txt_Nome
        ' 
        Txt_Nome.Location = New Point(43, 70)
        Txt_Nome.Name = "Txt_Nome"
        Txt_Nome.Size = New Size(396, 27)
        Txt_Nome.TabIndex = 2
        ' 
        ' Lbl_CPF
        ' 
        Lbl_CPF.AutoSize = True
        Lbl_CPF.Location = New Point(40, 100)
        Lbl_CPF.Name = "Lbl_CPF"
        Lbl_CPF.Size = New Size(33, 20)
        Lbl_CPF.TabIndex = 3
        Lbl_CPF.Text = "CPF"
        ' 
        ' Txt_CPF
        ' 
        Txt_CPF.Location = New Point(43, 124)
        Txt_CPF.Name = "Txt_CPF"
        Txt_CPF.Size = New Size(396, 27)
        Txt_CPF.TabIndex = 4
        ' 
        ' Lbl_Telefone
        ' 
        Lbl_Telefone.AutoSize = True
        Lbl_Telefone.Location = New Point(40, 154)
        Lbl_Telefone.Name = "Lbl_Telefone"
        Lbl_Telefone.Size = New Size(66, 20)
        Lbl_Telefone.TabIndex = 5
        Lbl_Telefone.Text = "Telefone"
        ' 
        ' Txt_Telefone
        ' 
        Txt_Telefone.Location = New Point(40, 177)
        Txt_Telefone.Name = "Txt_Telefone"
        Txt_Telefone.Size = New Size(396, 27)
        Txt_Telefone.TabIndex = 6
        ' 
        ' Lbl_Email
        ' 
        Lbl_Email.AutoSize = True
        Lbl_Email.Location = New Point(40, 207)
        Lbl_Email.Name = "Lbl_Email"
        Lbl_Email.Size = New Size(52, 20)
        Lbl_Email.TabIndex = 7
        Lbl_Email.Text = "E-mail"
        ' 
        ' Txt_Email
        ' 
        Txt_Email.Location = New Point(43, 230)
        Txt_Email.Name = "Txt_Email"
        Txt_Email.Size = New Size(396, 27)
        Txt_Email.TabIndex = 8
        ' 
        ' Lbl_Sexo
        ' 
        Lbl_Sexo.AutoSize = True
        Lbl_Sexo.Location = New Point(40, 260)
        Lbl_Sexo.Name = "Lbl_Sexo"
        Lbl_Sexo.Size = New Size(41, 20)
        Lbl_Sexo.TabIndex = 9
        Lbl_Sexo.Text = "Sexo"
        ' 
        ' Txt_Sexo
        ' 
        Txt_Sexo.Location = New Point(43, 283)
        Txt_Sexo.Name = "Txt_Sexo"
        Txt_Sexo.Size = New Size(396, 27)
        Txt_Sexo.TabIndex = 10
        ' 
        ' Lbl_Endereco
        ' 
        Lbl_Endereco.AutoSize = True
        Lbl_Endereco.Location = New Point(40, 313)
        Lbl_Endereco.Name = "Lbl_Endereco"
        Lbl_Endereco.Size = New Size(71, 20)
        Lbl_Endereco.TabIndex = 11
        Lbl_Endereco.Text = "Endereço"
        ' 
        ' Txt_Endereço
        ' 
        Txt_Endereço.Location = New Point(43, 336)
        Txt_Endereço.Name = "Txt_Endereço"
        Txt_Endereço.Size = New Size(396, 27)
        Txt_Endereço.TabIndex = 12
        ' 
        ' Lbl_Nascimento
        ' 
        Lbl_Nascimento.AutoSize = True
        Lbl_Nascimento.Location = New Point(43, 366)
        Lbl_Nascimento.Name = "Lbl_Nascimento"
        Lbl_Nascimento.Size = New Size(145, 20)
        Lbl_Nascimento.TabIndex = 13
        Lbl_Nascimento.Text = "Data de Nascimento"
        ' 
        ' Txt_Nascimento
        ' 
        Txt_Nascimento.Location = New Point(43, 389)
        Txt_Nascimento.Name = "Txt_Nascimento"
        Txt_Nascimento.Size = New Size(396, 27)
        Txt_Nascimento.TabIndex = 14
        ' 
        ' Frm_RegisterUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Txt_Nascimento)
        Controls.Add(Lbl_Nascimento)
        Controls.Add(Txt_Endereço)
        Controls.Add(Lbl_Endereco)
        Controls.Add(Txt_Sexo)
        Controls.Add(Lbl_Sexo)
        Controls.Add(Txt_Email)
        Controls.Add(Lbl_Email)
        Controls.Add(Txt_Telefone)
        Controls.Add(Lbl_Telefone)
        Controls.Add(Txt_CPF)
        Controls.Add(Lbl_CPF)
        Controls.Add(Txt_Nome)
        Controls.Add(Lbl_Nome)
        Controls.Add(Btm_RegisterUser)
        Name = "Frm_RegisterUser"
        Text = "Cadastrar usuário"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btm_RegisterUser As Button
    Friend WithEvents Lbl_Nome As Label
    Friend WithEvents Txt_Nome As TextBox
    Friend WithEvents Lbl_CPF As Label
    Friend WithEvents Txt_CPF As TextBox
    Friend WithEvents Lbl_Telefone As Label
    Friend WithEvents Txt_Telefone As TextBox
    Friend WithEvents Lbl_Email As Label
    Friend WithEvents Txt_Email As TextBox
    Friend WithEvents Lbl_Sexo As Label
    Friend WithEvents Txt_Sexo As TextBox
    Friend WithEvents Lbl_Endereco As Label
    Friend WithEvents Txt_Endereço As TextBox
    Friend WithEvents Lbl_Nascimento As Label
    Friend WithEvents Txt_Nascimento As TextBox
End Class
