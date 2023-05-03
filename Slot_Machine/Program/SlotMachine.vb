Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class SlotMachine

    ' Count the number of times we get 12
    Dim count As Integer = 500

    Private Sub btn_Spin_Click(sender As Object, e As EventArgs) Handles btn_Spin.Click
        ' Clear any previous results
        tbx_SlotOne.Clear()
        tbx_SlotTwo.Clear()
        tbx_SlotThree.Clear()

        ' Holds number of time 12 is gotten for your cash each round
        Dim count1 As Integer

        ' Create random number generator
        Dim rand As New Random()

        ' Get the bet amount from the TextBox control
        Dim betAmount As Integer = CDec(tbx_BetAmount.Text)

        ' Subtract the bet amount from the bank balance
        count -= betAmount

        ' Get the selected roll value from the ComboBox control
        Dim rollValue As Integer = CInt(cmb_RollValue.SelectedItem)


        ' Get the selected number of rolls from the ComboBox control
        ' Dim rollAmount As Integer = CInt(cmb_RollAmount.SelectedItem)


        ' Get the selected difficulty level from the ComboBox control
        Dim difficultyLevel As Integer = CInt(cmb_DifficultyLevel.SelectedItem)

        ' Set the reward multiplier based on the difficulty level
        Dim rewardMultiplier As Decimal = 1.0
        Dim rollAmount As Integer
        Select Case difficultyLevel
            Case 1
                rewardMultiplier = 1.0
                rollAmount = 500
            Case 2
                rewardMultiplier = 1.5
                rollAmount = 250
            Case 3
                rewardMultiplier = 2.0
                rollAmount = 1
            Case Else
                rewardMultiplier = 1.0
        End Select

        ' Spin first slot
        Dim slot1 As Integer = rand.Next(1, 7)

        ' Spin second slot
        Dim slot2 As Integer = rand.Next(1, 7)

        ' Spin third slot
        Dim slot3 As Integer = rand.Next(1, 7)

        ' Add up the dice
        ' Dim total As Integer = slot1 + slot2 + slot3

        ' Display result
        tbx_SlotOne.Text() = slot1
        tbx_SlotTwo.Text() = slot2
        tbx_SlotThree.Text() = slot3

        ' Check if we got the selected roll value
        If slot1 = rollValue Then
            count += betAmount * rewardMultiplier
            count1 += betAmount * rewardMultiplier
        End If

        If slot2 = rollValue Then
            count += betAmount * rewardMultiplier
            count1 += betAmount * rewardMultiplier
        End If

        If slot3 = rollValue Then
            count += betAmount * rewardMultiplier
            count1 += betAmount * rewardMultiplier
        End If

        ' Shows your balance
        Dim BankBal As Decimal
        BankBal = count
        tbx_BankBal.Text() = "Balance: " & BankBal

        ' Shows how much you won
        Dim CashBal As Decimal
        CashBal = count1
        tbx_CashWon.Text = "Cash Won: " & CashBal

    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click

    End Sub

    Private Sub btn_DevMenu_Click(sender As Object, e As EventArgs) Handles btn_DevMenu.Click

        DevMenu.Visible = True

    End Sub

    Private Sub SlotMachine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Login___Register.Visible = False

        ' Shows your balance
        Dim BankBal As Decimal
        BankBal = count
        tbx_BankBal.Text() = "Balance: " & BankBal

        ' Displays "Cash Won:" text
        tbx_CashWon.Text = "Cash Won: "

        ' Displays text indicating where to put your bet
        tbx_BetAmount.Text() = "Place Bet Here"

        ' Populate the ComboBox control with the possible roll values
        cmb_RollValue.Items.AddRange({2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12})
        cmb_RollValue.SelectedIndex = 0


        ' Populate the ComboBox control with the amount of rolls 
        ' cmb_RollAmount.Items.AddRange({10, 25, 50, 100, 250, 500, 650, 1300, 1350, 1500})
        ' cmb_RollAmount.SelectedIndex = 0


        cmb_DifficultyLevel.Items.AddRange({1, 2, 3})
        cmb_DifficultyLevel.SelectedIndex = 0

    End Sub
End Class