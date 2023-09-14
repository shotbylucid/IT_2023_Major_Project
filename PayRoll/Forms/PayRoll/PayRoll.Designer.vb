<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayRoll
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Button1 = New Button()
        lsb_Output = New ListBox()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(58, 54)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(555, 39)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(58, 114)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(555, 39)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(58, 180)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(555, 39)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(58, 242)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(555, 39)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(58, 302)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(555, 39)
        TextBox5.TabIndex = 4
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(58, 367)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(555, 39)
        TextBox6.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(58, 441)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 46)
        Button1.TabIndex = 6
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lsb_Output
        ' 
        lsb_Output.FormattingEnabled = True
        lsb_Output.ItemHeight = 32
        lsb_Output.Location = New Point(647, 55)
        lsb_Output.Name = "lsb_Output"
        lsb_Output.Size = New Size(435, 356)
        lsb_Output.TabIndex = 7
        ' 
        ' PayRoll
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1153, 531)
        Controls.Add(lsb_Output)
        Controls.Add(Button1)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "PayRoll"
        Text = "PayRoll"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lsb_Output As ListBox
End Class
