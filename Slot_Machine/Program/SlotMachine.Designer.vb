<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SlotMachine
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
        btn_Spin = New Button()
        tbx_SlotOne = New TextBox()
        tbx_SlotTwo = New TextBox()
        tbx_SlotThree = New TextBox()
        btn_Save = New Button()
        btn_DevMenu = New Button()
        cmb_RollValue = New ComboBox()
        cmb_DifficultyLevel = New ComboBox()
        tbx_CashWon = New TextBox()
        tbx_BankBal = New TextBox()
        tbx_BetAmount = New TextBox()
        SuspendLayout()
        ' 
        ' btn_Spin
        ' 
        btn_Spin.Location = New Point(117, 271)
        btn_Spin.Name = "btn_Spin"
        btn_Spin.Size = New Size(75, 23)
        btn_Spin.TabIndex = 0
        btn_Spin.Text = "Spin"
        btn_Spin.UseVisualStyleBackColor = True
        ' 
        ' tbx_SlotOne
        ' 
        tbx_SlotOne.Location = New Point(35, 79)
        tbx_SlotOne.Multiline = True
        tbx_SlotOne.Name = "tbx_SlotOne"
        tbx_SlotOne.Size = New Size(58, 132)
        tbx_SlotOne.TabIndex = 1
        ' 
        ' tbx_SlotTwo
        ' 
        tbx_SlotTwo.Location = New Point(124, 79)
        tbx_SlotTwo.Multiline = True
        tbx_SlotTwo.Name = "tbx_SlotTwo"
        tbx_SlotTwo.Size = New Size(58, 132)
        tbx_SlotTwo.TabIndex = 2
        ' 
        ' tbx_SlotThree
        ' 
        tbx_SlotThree.Location = New Point(212, 79)
        tbx_SlotThree.Multiline = True
        tbx_SlotThree.Name = "tbx_SlotThree"
        tbx_SlotThree.Size = New Size(58, 132)
        tbx_SlotThree.TabIndex = 3
        ' 
        ' btn_Save
        ' 
        btn_Save.Location = New Point(212, 271)
        btn_Save.Name = "btn_Save"
        btn_Save.Size = New Size(58, 23)
        btn_Save.TabIndex = 4
        btn_Save.Text = "Save"
        btn_Save.UseVisualStyleBackColor = True
        ' 
        ' btn_DevMenu
        ' 
        btn_DevMenu.Location = New Point(35, 271)
        btn_DevMenu.Name = "btn_DevMenu"
        btn_DevMenu.Size = New Size(58, 23)
        btn_DevMenu.TabIndex = 5
        btn_DevMenu.Text = "Dev"
        btn_DevMenu.UseVisualStyleBackColor = True
        ' 
        ' cmb_RollValue
        ' 
        cmb_RollValue.FormattingEnabled = True
        cmb_RollValue.Location = New Point(35, 26)
        cmb_RollValue.Name = "cmb_RollValue"
        cmb_RollValue.Size = New Size(58, 23)
        cmb_RollValue.TabIndex = 6
        ' 
        ' cmb_DifficultyLevel
        ' 
        cmb_DifficultyLevel.FormattingEnabled = True
        cmb_DifficultyLevel.Location = New Point(212, 26)
        cmb_DifficultyLevel.Name = "cmb_DifficultyLevel"
        cmb_DifficultyLevel.Size = New Size(58, 23)
        cmb_DifficultyLevel.TabIndex = 7
        ' 
        ' tbx_CashWon
        ' 
        tbx_CashWon.Location = New Point(168, 227)
        tbx_CashWon.Multiline = True
        tbx_CashWon.Name = "tbx_CashWon"
        tbx_CashWon.Size = New Size(89, 22)
        tbx_CashWon.TabIndex = 9
        ' 
        ' tbx_BankBal
        ' 
        tbx_BankBal.Location = New Point(47, 227)
        tbx_BankBal.Multiline = True
        tbx_BankBal.Name = "tbx_BankBal"
        tbx_BankBal.Size = New Size(89, 22)
        tbx_BankBal.TabIndex = 10
        ' 
        ' tbx_BetAmount
        ' 
        tbx_BetAmount.Location = New Point(110, 300)
        tbx_BetAmount.Multiline = True
        tbx_BetAmount.Name = "tbx_BetAmount"
        tbx_BetAmount.Size = New Size(89, 22)
        tbx_BetAmount.TabIndex = 11
        ' 
        ' SlotMachine
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(307, 322)
        Controls.Add(tbx_BetAmount)
        Controls.Add(tbx_BankBal)
        Controls.Add(tbx_CashWon)
        Controls.Add(cmb_DifficultyLevel)
        Controls.Add(cmb_RollValue)
        Controls.Add(btn_DevMenu)
        Controls.Add(btn_Save)
        Controls.Add(tbx_SlotThree)
        Controls.Add(tbx_SlotTwo)
        Controls.Add(tbx_SlotOne)
        Controls.Add(btn_Spin)
        Name = "SlotMachine"
        Text = "SlotMachine"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_Spin As Button
    Friend WithEvents tbx_SlotOne As TextBox
    Friend WithEvents tbx_SlotTwo As TextBox
    Friend WithEvents tbx_SlotThree As TextBox
    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_DevMenu As Button
    Friend WithEvents cmb_RollValue As ComboBox
    Friend WithEvents cmb_DifficultyLevel As ComboBox
    Friend WithEvents tbx_CashWon As TextBox
    Friend WithEvents tbx_BankBal As TextBox
    Friend WithEvents tbx_BetAmount As TextBox
End Class
