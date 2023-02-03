Public Class StartMenu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        username = UserTextbox.Text
        instructions.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Difficulty_Click(sender As Object, e As EventArgs) Handles Difficulty.Click
        Difficulties.ShowDialog()
    End Sub

    Private Sub character_Click(sender As Object, e As EventArgs) Handles character_btn.Click
        character.ShowDialog()
    End Sub
End Class