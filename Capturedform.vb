Public Class Capturedform
    Dim AnimationCounter As Integer = 0
    Private Sub TryAgain_Click(sender As Object, e As EventArgs) Handles TryAgain.Click
        Me.Hide()
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Quit = True
        Me.Close()
    End Sub

    Private Sub Capturedform_Load(sender As Object, e As EventArgs) Handles Me.Load
        AnimateCaptureTimer.Enabled = True

        Captured.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\" & CharacterDirectory & "\Trapped Sequence\" & AcronymString & "trapped0.bmp")
    End Sub

    Private Sub AnimateCaptureTimer_Tick(sender As Object, e As EventArgs) Handles AnimateCaptureTimer.Tick
        If AnimationCounter < 4 Then
            AnimationCounter += 1
        Else
            AnimationCounter = 0

        End If
        Captured.Image = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\Pics\" & CharacterDirectory & "\Trapped Sequence\" & AcronymString & "trapped" & AnimationCounter.ToString() & ".bmp")
        Console.WriteLine("Print here")
    End Sub
End Class