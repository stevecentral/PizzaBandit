Public Class Difficulties

    Private Sub Difficulties_Load(sender As Object, e As EventArgs) Handles Me.Load
        difficulty = EasyD
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
    End Sub

    Private Sub easy_Click(sender As Object, e As EventArgs) Handles easy.Click
        difficulty = EasyD
        Call ChangeDificulties()
        Me.Hide()
    End Sub

    Private Sub medium_Click(sender As Object, e As EventArgs) Handles medium.Click
        difficulty = MediumD
        Call ChangeDificulties()
        Me.Hide()
    End Sub

    Private Sub hard_Click(sender As Object, e As EventArgs) Handles hard.Click
        difficulty = HardD
        Call ChangeDificulties()
        Me.Hide()
    End Sub

    Public Sub ChangeDificulties()
        If difficulty = EasyD Then
            reggieSpeed = 10
            cageSpeed = 5
        ElseIf difficulty = MediumD Then
            reggieSpeed = 10
            cageSpeed = 10
        ElseIf difficulty = HardD Then
            cageSpeed = 15
            reggieSpeed = 10
        Else
            Console.WriteLine("SHould not get here")
        End If
        Console.WriteLine("Changed Difficulty")
    End Sub



End Class