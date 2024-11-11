<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessageSelection
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
        Me.btnUseCustomMessage = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUseSystemMessage = New Guna.UI2.WinForms.Guna2Button()
        Me.txtCustomMessage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUseCustomMessage
        '
        Me.btnUseCustomMessage.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUseCustomMessage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUseCustomMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUseCustomMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUseCustomMessage.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnUseCustomMessage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUseCustomMessage.ForeColor = System.Drawing.Color.White
        Me.btnUseCustomMessage.Location = New System.Drawing.Point(619, 421)
        Me.btnUseCustomMessage.Name = "btnUseCustomMessage"
        Me.btnUseCustomMessage.Size = New System.Drawing.Size(180, 45)
        Me.btnUseCustomMessage.TabIndex = 0
        Me.btnUseCustomMessage.Text = "CustomMessage"
        '
        'btnUseSystemMessage
        '
        Me.btnUseSystemMessage.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUseSystemMessage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUseSystemMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUseSystemMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUseSystemMessage.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnUseSystemMessage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUseSystemMessage.ForeColor = System.Drawing.Color.White
        Me.btnUseSystemMessage.Location = New System.Drawing.Point(432, 421)
        Me.btnUseSystemMessage.Name = "btnUseSystemMessage"
        Me.btnUseSystemMessage.Size = New System.Drawing.Size(167, 45)
        Me.btnUseSystemMessage.TabIndex = 1
        Me.btnUseSystemMessage.Text = "SystemMessage"
        '
        'txtCustomMessage
        '
        Me.txtCustomMessage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomMessage.DefaultText = ""
        Me.txtCustomMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCustomMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCustomMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomMessage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCustomMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomMessage.Location = New System.Drawing.Point(432, 75)
        Me.txtCustomMessage.Name = "txtCustomMessage"
        Me.txtCustomMessage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCustomMessage.PlaceholderText = ""
        Me.txtCustomMessage.SelectedText = ""
        Me.txtCustomMessage.Size = New System.Drawing.Size(367, 340)
        Me.txtCustomMessage.TabIndex = 2
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.Ajira.My.Resources.Resources.blue_01
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-6, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(389, 507)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 3
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(844, 26)
        Me.Guna2Panel1.TabIndex = 4
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.DarkRed
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(806, 1)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(27, 23)
        Me.Guna2ControlBox1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(440, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Type Message Here"
        '
        'frmMessageSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 513)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.txtCustomMessage)
        Me.Controls.Add(Me.btnUseSystemMessage)
        Me.Controls.Add(Me.btnUseCustomMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMessageSelection"
        Me.Text = "frmMessageSelection"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUseCustomMessage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUseSystemMessage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCustomMessage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
End Class
