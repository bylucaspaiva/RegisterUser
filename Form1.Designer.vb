<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterUser
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
        RegisterUserBtm = New Button()
        SuspendLayout()
        ' 
        ' RegisterUserBtm
        ' 
        RegisterUserBtm.Location = New Point(345, 337)
        RegisterUserBtm.Name = "RegisterUserBtm"
        RegisterUserBtm.Size = New Size(94, 29)
        RegisterUserBtm.TabIndex = 0
        RegisterUserBtm.Text = "Cadastrar"
        RegisterUserBtm.UseVisualStyleBackColor = True
        ' 
        ' RegisterUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RegisterUserBtm)
        Name = "RegisterUser"
        Text = "Cadastrar usuário"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
    End Sub

    Friend WithEvents RegisterUserBtm As Button
End Class
