<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Capturedform
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Capturedform))
        Me.TryAgain = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.Captured = New System.Windows.Forms.PictureBox()
        Me.AnimateCaptureTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Captured, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TryAgain
        '
        Me.TryAgain.Location = New System.Drawing.Point(72, 215)
        Me.TryAgain.Name = "TryAgain"
        Me.TryAgain.Size = New System.Drawing.Size(75, 23)
        Me.TryAgain.TabIndex = 0
        Me.TryAgain.Text = "Try Again"
        Me.TryAgain.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(246, 215)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(75, 23)
        Me.QuitButton.TabIndex = 1
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'Captured
        '
        Me.Captured.Image = CType(resources.GetObject("Captured.Image"), System.Drawing.Image)
        Me.Captured.Location = New System.Drawing.Point(147, 76)
        Me.Captured.Name = "Captured"
        Me.Captured.Size = New System.Drawing.Size(100, 100)
        Me.Captured.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Captured.TabIndex = 2
        Me.Captured.TabStop = False
        '
        'AnimateCaptureTimer
        '
        Me.AnimateCaptureTimer.Enabled = True
        Me.AnimateCaptureTimer.Interval = 50
        '
        'Capturedform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(404, 285)
        Me.Controls.Add(Me.Captured)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.TryAgain)
        Me.Name = "Capturedform"
        Me.Text = "Capturedform"
        CType(Me.Captured, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TryAgain As Button
    Friend WithEvents QuitButton As Button
    Friend WithEvents Captured As PictureBox
    Friend WithEvents AnimateCaptureTimer As System.Windows.Forms.Timer
End Class
