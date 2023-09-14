<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBoxUsername = New TextBox()
        TextBoxPassword = New TextBox()
        LabelPasswordStrength = New Label()
        LabelError = New Label()
        ButtonClearNewUser = New Button()
        ButtonCreateAccount = New Button()
        ButtonLogin = New Button()
        SuspendLayout()
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.Location = New Point(69, 69)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.Size = New Size(200, 39)
        TextBoxUsername.TabIndex = 0
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Location = New Point(341, 69)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.Size = New Size(200, 39)
        TextBoxPassword.TabIndex = 1
        ' 
        ' LabelPasswordStrength
        ' 
        LabelPasswordStrength.AutoSize = True
        LabelPasswordStrength.Location = New Point(152, 256)
        LabelPasswordStrength.Name = "LabelPasswordStrength"
        LabelPasswordStrength.Size = New Size(83, 32)
        LabelPasswordStrength.TabIndex = 2
        LabelPasswordStrength.Text = "Label1"
        ' 
        ' LabelError
        ' 
        LabelError.AutoSize = True
        LabelError.Location = New Point(476, 256)
        LabelError.Name = "LabelError"
        LabelError.Size = New Size(83, 32)
        LabelError.TabIndex = 3
        LabelError.Text = "Label1"
        ' 
        ' ButtonClearNewUser
        ' 
        ButtonClearNewUser.Location = New Point(28, 391)
        ButtonClearNewUser.Name = "ButtonClearNewUser"
        ButtonClearNewUser.Size = New Size(150, 46)
        ButtonClearNewUser.TabIndex = 4
        ButtonClearNewUser.Text = "Clear New User"
        ButtonClearNewUser.UseVisualStyleBackColor = True
        ' 
        ' ButtonCreateAccount
        ' 
        ButtonCreateAccount.Location = New Point(210, 391)
        ButtonCreateAccount.Name = "ButtonCreateAccount"
        ButtonCreateAccount.Size = New Size(150, 46)
        ButtonCreateAccount.TabIndex = 5
        ButtonCreateAccount.Text = "New User"
        ButtonCreateAccount.UseVisualStyleBackColor = True
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.Location = New Point(391, 391)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(150, 46)
        ButtonLogin.TabIndex = 6
        ButtonLogin.Text = "New User"
        ButtonLogin.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonLogin)
        Controls.Add(ButtonCreateAccount)
        Controls.Add(ButtonClearNewUser)
        Controls.Add(LabelError)
        Controls.Add(LabelPasswordStrength)
        Controls.Add(TextBoxPassword)
        Controls.Add(TextBoxUsername)
        Name = "LoginForm"
        Text = "LoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents LabelPasswordStrength As Label
    Friend WithEvents LabelError As Label
    Friend WithEvents ButtonClearNewUser As Button
    Friend WithEvents ButtonCreateAccount As Button
    Friend WithEvents ButtonLogin As Button
End Class
