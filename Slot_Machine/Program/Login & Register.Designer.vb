<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login___Register
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
        btn_SignIn = New Button()
        btn_Register = New Button()
        btn_DevMenu = New Button()
        txt_UserName = New TextBox()
        txt_PassWord = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btn_SignIn
        ' 
        btn_SignIn.Location = New Point(51, 91)
        btn_SignIn.Name = "btn_SignIn"
        btn_SignIn.Size = New Size(75, 23)
        btn_SignIn.TabIndex = 0
        btn_SignIn.Text = "Sign In"
        btn_SignIn.UseVisualStyleBackColor = True
        ' 
        ' btn_Register
        ' 
        btn_Register.Location = New Point(192, 91)
        btn_Register.Name = "btn_Register"
        btn_Register.Size = New Size(75, 23)
        btn_Register.TabIndex = 1
        btn_Register.Text = "Register"
        btn_Register.UseVisualStyleBackColor = True
        ' 
        ' btn_DevMenu
        ' 
        btn_DevMenu.Location = New Point(124, 140)
        btn_DevMenu.Name = "btn_DevMenu"
        btn_DevMenu.Size = New Size(75, 23)
        btn_DevMenu.TabIndex = 2
        btn_DevMenu.Text = "DevMenu"
        btn_DevMenu.UseVisualStyleBackColor = True
        ' 
        ' txt_UserName
        ' 
        txt_UserName.Location = New Point(40, 34)
        txt_UserName.Name = "txt_UserName"
        txt_UserName.Size = New Size(100, 23)
        txt_UserName.TabIndex = 3
        ' 
        ' txt_PassWord
        ' 
        txt_PassWord.Location = New Point(182, 34)
        txt_PassWord.Name = "txt_PassWord"
        txt_PassWord.PasswordChar = "*"c
        txt_PassWord.Size = New Size(100, 23)
        txt_PassWord.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(61, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 5
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(202, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 6
        Label2.Text = "Password"
        ' 
        ' Login___Register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(327, 185)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt_PassWord)
        Controls.Add(txt_UserName)
        Controls.Add(btn_DevMenu)
        Controls.Add(btn_Register)
        Controls.Add(btn_SignIn)
        Name = "Login___Register"
        Text = "Login___Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_SignIn As Button
    Friend WithEvents btn_Register As Button
    Friend WithEvents btn_DevMenu As Button
    Friend WithEvents txt_UserName As TextBox
    Friend WithEvents txt_PassWord As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
