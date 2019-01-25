<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TicTacToe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TicTacToe))
        Me.Button0 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.XLabel = New System.Windows.Forms.Label()
        Me.OLabel = New System.Windows.Forms.Label()
        Me.RestartButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button0
        '
        Me.Button0.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button0.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button0.Location = New System.Drawing.Point(38, 12)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(100, 100)
        Me.Button0.TabIndex = 0
        Me.Button0.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(144, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 100)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(250, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 100)
        Me.Button2.TabIndex = 2
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(38, 118)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 100)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(144, 118)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 100)
        Me.Button4.TabIndex = 4
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(250, 118)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 100)
        Me.Button5.TabIndex = 5
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(38, 224)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 100)
        Me.Button6.TabIndex = 6
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(144, 224)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 100)
        Me.Button7.TabIndex = 7
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(250, 224)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(100, 100)
        Me.Button8.TabIndex = 8
        Me.Button8.UseVisualStyleBackColor = False
        '
        'XLabel
        '
        Me.XLabel.AutoSize = True
        Me.XLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.XLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XLabel.Location = New System.Drawing.Point(140, 336)
        Me.XLabel.Margin = New System.Windows.Forms.Padding(3)
        Me.XLabel.Name = "XLabel"
        Me.XLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.XLabel.Size = New System.Drawing.Size(31, 30)
        Me.XLabel.TabIndex = 10
        Me.XLabel.Text = "X"
        '
        'OLabel
        '
        Me.OLabel.AutoSize = True
        Me.OLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OLabel.Location = New System.Drawing.Point(212, 336)
        Me.OLabel.Margin = New System.Windows.Forms.Padding(3)
        Me.OLabel.Name = "OLabel"
        Me.OLabel.Padding = New System.Windows.Forms.Padding(5)
        Me.OLabel.Size = New System.Drawing.Size(32, 30)
        Me.OLabel.TabIndex = 11
        Me.OLabel.Text = "O"
        '
        'RestartButton
        '
        Me.RestartButton.BackgroundImage = CType(resources.GetObject("RestartButton.BackgroundImage"), System.Drawing.Image)
        Me.RestartButton.Location = New System.Drawing.Point(38, 334)
        Me.RestartButton.Name = "RestartButton"
        Me.RestartButton.Size = New System.Drawing.Size(32, 32)
        Me.RestartButton.TabIndex = 15
        Me.RestartButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.BackgroundImage = CType(resources.GetObject("ResetButton.BackgroundImage"), System.Drawing.Image)
        Me.ResetButton.Location = New System.Drawing.Point(76, 334)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(32, 32)
        Me.ResetButton.TabIndex = 17
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'TicTacToe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(384, 401)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.RestartButton)
        Me.Controls.Add(Me.OLabel)
        Me.Controls.Add(Me.XLabel)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button0)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TicTacToe"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "TicTacToe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button0 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents XLabel As Label
    Friend WithEvents OLabel As Label
    Friend WithEvents RestartButton As Button
    Friend WithEvents ResetButton As Button
End Class
