<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BeatLevelForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BeatLevelForm))
        Me.Con = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Con
        '
        Me.Con.AutoSize = True
        Me.Con.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Italic)
        Me.Con.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Con.Location = New System.Drawing.Point(309, 496)
        Me.Con.Name = "Con"
        Me.Con.Size = New System.Drawing.Size(177, 66)
        Me.Con.TabIndex = 0
        Me.Con.Text = "Continue"
        Me.Con.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.AutoSize = True
        Me.QuitButton.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Italic)
        Me.QuitButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.QuitButton.Location = New System.Drawing.Point(707, 496)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(104, 66)
        Me.QuitButton.TabIndex = 1
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'BeatLevelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1184, 749)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.Con)
        Me.Name = "BeatLevelForm"
        Me.Text = "Congratulations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Con As System.Windows.Forms.Button
    Friend WithEvents QuitButton As System.Windows.Forms.Button
End Class
