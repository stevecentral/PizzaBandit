Public Class BeatLevelForm

    Private Sub Con_Click(sender As Object, e As EventArgs) Handles Con.Click
        MainForm.ResetPizza()
        Me.Hide()
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Quit = True
        Me.Hide()
    End Sub
End Class