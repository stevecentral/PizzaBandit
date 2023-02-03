<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class character
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(character))
        Me.back = New System.Windows.Forms.Button()
        Me.Reggie_Button = New System.Windows.Forms.Button()
        Me.Pete_Button = New System.Windows.Forms.Button()
        Me.Suzie_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Transparent
        Me.back.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.back.Location = New System.Drawing.Point(65, 561)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(75, 46)
        Me.back.TabIndex = 0
        Me.back.Text = "back"
        Me.back.UseVisualStyleBackColor = False
        '
        'Reggie_Button
        '
        Me.Reggie_Button.AutoSize = True
        Me.Reggie_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Reggie_Button.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reggie_Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Reggie_Button.Location = New System.Drawing.Point(234, 358)
        Me.Reggie_Button.Name = "Reggie_Button"
        Me.Reggie_Button.Size = New System.Drawing.Size(92, 46)
        Me.Reggie_Button.TabIndex = 1
        Me.Reggie_Button.Text = "Reggie"
        Me.Reggie_Button.UseVisualStyleBackColor = False
        '
        'Pete_Button
        '
        Me.Pete_Button.AutoSize = True
        Me.Pete_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Pete_Button.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pete_Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Pete_Button.Location = New System.Drawing.Point(583, 616)
        Me.Pete_Button.Name = "Pete_Button"
        Me.Pete_Button.Size = New System.Drawing.Size(94, 46)
        Me.Pete_Button.TabIndex = 2
        Me.Pete_Button.Text = "Pete"
        Me.Pete_Button.UseVisualStyleBackColor = False
        '
        'Suzie_Button
        '
        Me.Suzie_Button.AutoSize = True
        Me.Suzie_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Suzie_Button.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Suzie_Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Suzie_Button.Location = New System.Drawing.Point(914, 358)
        Me.Suzie_Button.Name = "Suzie_Button"
        Me.Suzie_Button.Size = New System.Drawing.Size(85, 46)
        Me.Suzie_Button.TabIndex = 3
        Me.Suzie_Button.Text = "Suzie"
        Me.Suzie_Button.UseVisualStyleBackColor = False
        '
        'character
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1184, 749)
        Me.Controls.Add(Me.Suzie_Button)
        Me.Controls.Add(Me.Pete_Button)
        Me.Controls.Add(Me.Reggie_Button)
        Me.Controls.Add(Me.back)
        Me.Name = "character"
        Me.Text = "character"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents Reggie_Button As System.Windows.Forms.Button
    Friend WithEvents Pete_Button As System.Windows.Forms.Button
    Friend WithEvents Suzie_Button As System.Windows.Forms.Button
End Class
