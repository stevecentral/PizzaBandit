<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameOver
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
        Me.Yes = New System.Windows.Forms.Button()
        Me.No = New System.Windows.Forms.Button()
        Me.gameOver_lbl = New System.Windows.Forms.Label()
        Me.playAgain_lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Yes
        '
        Me.Yes.Location = New System.Drawing.Point(64, 179)
        Me.Yes.Name = "Yes"
        Me.Yes.Size = New System.Drawing.Size(75, 23)
        Me.Yes.TabIndex = 0
        Me.Yes.Text = "Play Again"
        Me.Yes.UseVisualStyleBackColor = True
        '
        'No
        '
        Me.No.Location = New System.Drawing.Point(257, 179)
        Me.No.Name = "No"
        Me.No.Size = New System.Drawing.Size(75, 23)
        Me.No.TabIndex = 1
        Me.No.Text = "Quit"
        Me.No.UseVisualStyleBackColor = True
        '
        'gameOver_lbl
        '
        Me.gameOver_lbl.AutoSize = True
        Me.gameOver_lbl.BackColor = System.Drawing.Color.Black
        Me.gameOver_lbl.Font = New System.Drawing.Font("Segoe Script", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gameOver_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gameOver_lbl.Location = New System.Drawing.Point(110, 57)
        Me.gameOver_lbl.Name = "gameOver_lbl"
        Me.gameOver_lbl.Size = New System.Drawing.Size(203, 46)
        Me.gameOver_lbl.TabIndex = 2
        Me.gameOver_lbl.Text = "Game Over "
        '
        'playAgain_lbl
        '
        Me.playAgain_lbl.AutoSize = True
        Me.playAgain_lbl.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playAgain_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.playAgain_lbl.Location = New System.Drawing.Point(49, 119)
        Me.playAgain_lbl.Name = "playAgain_lbl"
        Me.playAgain_lbl.Size = New System.Drawing.Size(315, 36)
        Me.playAgain_lbl.TabIndex = 3
        Me.playAgain_lbl.Text = "Would you like to play again"
        '
        'GameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(424, 261)
        Me.Controls.Add(Me.playAgain_lbl)
        Me.Controls.Add(Me.gameOver_lbl)
        Me.Controls.Add(Me.No)
        Me.Controls.Add(Me.Yes)
        Me.Name = "GameOver"
        Me.Text = "GameOver"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Yes As System.Windows.Forms.Button
    Friend WithEvents No As System.Windows.Forms.Button
    Friend WithEvents gameOver_lbl As System.Windows.Forms.Label
    Friend WithEvents playAgain_lbl As System.Windows.Forms.Label
End Class
