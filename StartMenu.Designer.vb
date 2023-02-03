<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartMenu))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Difficulty = New System.Windows.Forms.Button()
        Me.character_btn = New System.Windows.Forms.Button()
        Me.UserTextbox = New System.Windows.Forms.TextBox()
        Me.user = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(440, 644)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(233, 60)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start Game"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Difficulty
        '
        Me.Difficulty.AutoSize = True
        Me.Difficulty.BackColor = System.Drawing.Color.Transparent
        Me.Difficulty.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Italic)
        Me.Difficulty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Difficulty.Location = New System.Drawing.Point(235, 595)
        Me.Difficulty.Name = "Difficulty"
        Me.Difficulty.Size = New System.Drawing.Size(176, 75)
        Me.Difficulty.TabIndex = 1
        Me.Difficulty.Text = "difficulty"
        Me.Difficulty.UseVisualStyleBackColor = False
        '
        'character_btn
        '
        Me.character_btn.AutoSize = True
        Me.character_btn.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Italic)
        Me.character_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.character_btn.Location = New System.Drawing.Point(698, 590)
        Me.character_btn.Name = "character_btn"
        Me.character_btn.Size = New System.Drawing.Size(301, 85)
        Me.character_btn.TabIndex = 2
        Me.character_btn.Text = "Character Select"
        Me.character_btn.UseVisualStyleBackColor = True
        '
        'UserTextbox
        '
        Me.UserTextbox.Location = New System.Drawing.Point(485, 546)
        Me.UserTextbox.Name = "UserTextbox"
        Me.UserTextbox.Size = New System.Drawing.Size(150, 20)
        Me.UserTextbox.TabIndex = 3
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.user.Location = New System.Drawing.Point(462, 507)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(188, 36)
        Me.user.TabIndex = 4
        Me.user.Text = "Enter Your User"
        '
        'StartMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1184, 749)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.UserTextbox)
        Me.Controls.Add(Me.character_btn)
        Me.Controls.Add(Me.Difficulty)
        Me.Controls.Add(Me.Button1)
        Me.Name = "StartMenu"
        Me.Text = "StartMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Difficulty As System.Windows.Forms.Button
    Friend WithEvents character_btn As System.Windows.Forms.Button
    Friend WithEvents UserTextbox As System.Windows.Forms.TextBox
    Friend WithEvents user As System.Windows.Forms.Label
End Class
