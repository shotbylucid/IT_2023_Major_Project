Public Class Login___Register
    Private Sub btn_SignIn_Click(sender As Object, e As EventArgs) Handles btn_SignIn.Click

        If txt_UserName.Text() = "Admin" Then
            If txt_PassWord.Text() = "Admin123" Then

                SlotMachine.Visible = True

            ElseIf Not txt_PassWord.Text() = "" Then

                MessageBox.Show("Wrong Password, Try Again.")
                Return

            End If

        ElseIf Not txt_UserName.Text() = "" Then
            MessageBox.Show("Wrong Username or it does not Exist.")
            Return
        End If


    End Sub

    Private Sub btn_Register_Click(sender As Object, e As EventArgs) Handles btn_Register.Click

        If txt_UserName.Text() = "Blank" Then
            MessageBox.Show("Someth22ing")
            Return
        ElseIf Not "ASD" Then
            MessageBox.Show("Something")
            Return
        End If


    End Sub

    Private Sub btn_DevMenu_Click(sender As Object, e As EventArgs) Handles btn_DevMenu.Click

        DevMenu.Visible = True

    End Sub
End Class