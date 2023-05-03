Public Class DevMenu
    Private Sub btn_Add10_Click(sender As Object, e As EventArgs) Handles btn_Add10.Click

    End Sub

    Private Sub btn_Add50_Click(sender As Object, e As EventArgs) Handles btn_Add50.Click

    End Sub

    Private Sub btn_Add100_Click(sender As Object, e As EventArgs) Handles btn_Add100.Click

    End Sub

    Private Sub btn_AddMoney_Click(sender As Object, e As EventArgs) Handles btn_AddMoney.Click

    End Sub

    Private Sub btn_DebitModifer_Click(sender As Object, e As EventArgs) Handles btn_DebitModifer.Click

    End Sub

    Private Sub btn_ForceClose_Click(sender As Object, e As EventArgs) Handles btn_ForceClose.Click

        Close()

    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click

        SlotMachine.Visible = False
        SlotMachine.Visible = True

    End Sub
End Class