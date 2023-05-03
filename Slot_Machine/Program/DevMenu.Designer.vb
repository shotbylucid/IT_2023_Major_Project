<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DevMenu
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
        Label2 = New Label()
        txt_DebitModifer = New TextBox()
        btn_DebitModifer = New Button()
        Label1 = New Label()
        txt_MoneyAmount = New TextBox()
        btn_AddMoney = New Button()
        btn_Add100 = New Button()
        btn_Add50 = New Button()
        btn_ForceClose = New Button()
        btn_Add10 = New Button()
        btnRestart = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 15)
        Label2.TabIndex = 19
        Label2.Text = "Debit Modifer"
        ' 
        ' txt_DebitModifer
        ' 
        txt_DebitModifer.Location = New Point(90, 125)
        txt_DebitModifer.Name = "txt_DebitModifer"
        txt_DebitModifer.Size = New Size(75, 23)
        txt_DebitModifer.TabIndex = 18
        ' 
        ' btn_DebitModifer
        ' 
        btn_DebitModifer.Location = New Point(171, 125)
        btn_DebitModifer.Name = "btn_DebitModifer"
        btn_DebitModifer.Size = New Size(75, 23)
        btn_DebitModifer.TabIndex = 17
        btn_DebitModifer.Text = "Modify"
        btn_DebitModifer.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 15)
        Label1.TabIndex = 16
        Label1.Text = "Add Money"
        ' 
        ' txt_MoneyAmount
        ' 
        txt_MoneyAmount.Location = New Point(90, 83)
        txt_MoneyAmount.Name = "txt_MoneyAmount"
        txt_MoneyAmount.Size = New Size(75, 23)
        txt_MoneyAmount.TabIndex = 15
        ' 
        ' btn_AddMoney
        ' 
        btn_AddMoney.Location = New Point(171, 83)
        btn_AddMoney.Name = "btn_AddMoney"
        btn_AddMoney.Size = New Size(75, 23)
        btn_AddMoney.TabIndex = 14
        btn_AddMoney.Text = "Add"
        btn_AddMoney.UseVisualStyleBackColor = True
        ' 
        ' btn_Add100
        ' 
        btn_Add100.Location = New Point(171, 13)
        btn_Add100.Name = "btn_Add100"
        btn_Add100.RightToLeft = RightToLeft.No
        btn_Add100.Size = New Size(75, 23)
        btn_Add100.TabIndex = 13
        btn_Add100.Text = "Add $100"
        btn_Add100.UseVisualStyleBackColor = True
        ' 
        ' btn_Add50
        ' 
        btn_Add50.Location = New Point(90, 13)
        btn_Add50.Name = "btn_Add50"
        btn_Add50.RightToLeft = RightToLeft.No
        btn_Add50.Size = New Size(75, 23)
        btn_Add50.TabIndex = 12
        btn_Add50.Text = "Add $50"
        btn_Add50.UseVisualStyleBackColor = True
        ' 
        ' btn_ForceClose
        ' 
        btn_ForceClose.Location = New Point(129, 196)
        btn_ForceClose.Name = "btn_ForceClose"
        btn_ForceClose.Size = New Size(75, 23)
        btn_ForceClose.TabIndex = 11
        btn_ForceClose.Text = "ForceClose"
        btn_ForceClose.UseVisualStyleBackColor = True
        ' 
        ' btn_Add10
        ' 
        btn_Add10.Location = New Point(9, 13)
        btn_Add10.Name = "btn_Add10"
        btn_Add10.RightToLeft = RightToLeft.No
        btn_Add10.Size = New Size(75, 23)
        btn_Add10.TabIndex = 10
        btn_Add10.Text = "Add $10"
        btn_Add10.UseVisualStyleBackColor = True
        ' 
        ' btnRestart
        ' 
        btnRestart.Location = New Point(48, 196)
        btnRestart.Name = "btnRestart"
        btnRestart.Size = New Size(75, 23)
        btnRestart.TabIndex = 20
        btnRestart.Text = "Restart"
        btnRestart.UseVisualStyleBackColor = True
        ' 
        ' DevMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(254, 231)
        Controls.Add(btnRestart)
        Controls.Add(Label2)
        Controls.Add(txt_DebitModifer)
        Controls.Add(btn_DebitModifer)
        Controls.Add(Label1)
        Controls.Add(txt_MoneyAmount)
        Controls.Add(btn_AddMoney)
        Controls.Add(btn_Add100)
        Controls.Add(btn_Add50)
        Controls.Add(btn_ForceClose)
        Controls.Add(btn_Add10)
        Name = "DevMenu"
        Text = "DevMenu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txt_DebitModifer As TextBox
    Friend WithEvents btn_DebitModifer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_MoneyAmount As TextBox
    Friend WithEvents btn_AddMoney As Button
    Friend WithEvents btn_Add100 As Button
    Friend WithEvents btn_Add50 As Button
    Friend WithEvents btn_ForceClose As Button
    Friend WithEvents btn_Add10 As Button
    Friend WithEvents btnRestart As Button
End Class
