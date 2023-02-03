<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Difficulties
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Difficulties))
        Me.easy = New System.Windows.Forms.Button()
        Me.medium = New System.Windows.Forms.Button()
        Me.hard = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'easy
        '
        Me.easy.AutoSize = True
        Me.easy.BackColor = System.Drawing.Color.Transparent
        Me.easy.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Italic)
        Me.easy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.easy.Location = New System.Drawing.Point(259, 644)
        Me.easy.Name = "easy"
        Me.easy.Size = New System.Drawing.Size(103, 66)
        Me.easy.TabIndex = 0
        Me.easy.Text = "easy"
        Me.easy.UseVisualStyleBackColor = False
        '
        'medium
        '
        Me.medium.AutoSize = True
        Me.medium.BackColor = System.Drawing.Color.Transparent
        Me.medium.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Italic)
        Me.medium.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.medium.Location = New System.Drawing.Point(472, 644)
        Me.medium.Name = "medium"
        Me.medium.Size = New System.Drawing.Size(167, 66)
        Me.medium.TabIndex = 1
        Me.medium.Text = "medium"
        Me.medium.UseVisualStyleBackColor = False
        '
        'hard
        '
        Me.hard.AutoSize = True
        Me.hard.BackColor = System.Drawing.Color.Transparent
        Me.hard.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Italic)
        Me.hard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.hard.Location = New System.Drawing.Point(763, 644)
        Me.hard.Name = "hard"
        Me.hard.Size = New System.Drawing.Size(110, 66)
        Me.hard.TabIndex = 2
        Me.hard.Text = "hard"
        Me.hard.UseVisualStyleBackColor = False
        '
        'back
        '
        Me.back.AutoSize = True
        Me.back.BackColor = System.Drawing.Color.Transparent
        Me.back.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Italic)
        Me.back.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.back.Location = New System.Drawing.Point(131, 558)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(75, 34)
        Me.back.TabIndex = 3
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = False
        '
        'Difficulties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1184, 749)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.hard)
        Me.Controls.Add(Me.medium)
        Me.Controls.Add(Me.easy)
        Me.Name = "Difficulties"
        Me.Text = "Difficuties"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents easy As System.Windows.Forms.Button
    Friend WithEvents medium As System.Windows.Forms.Button
    Friend WithEvents hard As System.Windows.Forms.Button
    Friend WithEvents back As System.Windows.Forms.Button
End Class
