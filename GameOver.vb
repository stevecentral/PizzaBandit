Public Class GameOver

    Private Sub Yes_Click(sender As Object, e As EventArgs) Handles Yes.Click
        MainForm.ResetPizza()
        Me.Hide()
    End Sub

    Private Sub No_Click(sender As Object, e As EventArgs) Handles No.Click
        Quit = True
        Me.Hide()
    End Sub
End Class