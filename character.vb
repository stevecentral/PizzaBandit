Public Class character

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
    End Sub

    Private Sub character_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CharacterSelect = ReggieSelect
    End Sub
    Private Sub character_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub Reggie_Button_Click(sender As Object, e As EventArgs) Handles Reggie_Button.Click
        CharacterSelect = ReggieSelect
        BackgroundImage = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/Pics/PB B Choose 1 Reggie.bmp")
    End Sub

    Private Sub Pete_Button_Click(sender As Object, e As EventArgs) Handles Pete_Button.Click
        CharacterSelect = PeteSelect
        BackgroundImage = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/Pics/PB B Choose 2 Cheeky.bmp")
    End Sub

    Private Sub Suzie_Button_Click(sender As Object, e As EventArgs) Handles Suzie_Button.Click
        CharacterSelect = SuzieSelect
        BackgroundImage = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/Pics/PB B Choose 3 Suzie.bmp")
    End Sub
End Class