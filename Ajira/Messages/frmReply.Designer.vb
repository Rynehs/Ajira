<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReply
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
        Me.lblSelectedMessage = New System.Windows.Forms.Label()
        Me.btnSendReply = New Guna.UI2.WinForms.Guna2Button()
        Me.txtReplyMessage = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelectedMessage
        '
        Me.lblSelectedMessage.AutoSize = True
        Me.lblSelectedMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedMessage.Location = New System.Drawing.Point(399, 159)
        Me.lblSelectedMessage.Name = "lblSelectedMessage"
        Me.lblSelectedMessage.Size = New System.Drawing.Size(142, 20)
        Me.lblSelectedMessage.TabIndex = 0
        Me.lblSelectedMessage.Text = "OriginalMessage"
        '
        'btnSendReply
        '
        Me.btnSendReply.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSendReply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSendReply.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSendReply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSendReply.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSendReply.ForeColor = System.Drawing.Color.White
        Me.btnSendReply.Location = New System.Drawing.Point(720, 489)
        Me.btnSendReply.Name = "btnSendReply"
        Me.btnSendReply.Size = New System.Drawing.Size(136, 45)
        Me.btnSendReply.TabIndex = 1
        Me.btnSendReply.Text = "Send Reply"
        '
        'txtReplyMessage
        '
        Me.txtReplyMessage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReplyMessage.DefaultText = ""
        Me.txtReplyMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtReplyMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtReplyMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReplyMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReplyMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReplyMessage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtReplyMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReplyMessage.Location = New System.Drawing.Point(383, 214)
        Me.txtReplyMessage.Name = "txtReplyMessage"
        Me.txtReplyMessage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReplyMessage.PlaceholderText = "Enter Reply"
        Me.txtReplyMessage.SelectedText = ""
        Me.txtReplyMessage.Size = New System.Drawing.Size(473, 269)
        Me.txtReplyMessage.TabIndex = 3
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.DarkRed
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(863, 1)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(27, 24)
        Me.Guna2ControlBox1.TabIndex = 4
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(902, 27)
        Me.Guna2Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(399, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Message"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.Ajira.My.Resources.Resources.blue_01
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 25)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(393, 527)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 7
        Me.Guna2PictureBox1.TabStop = False
        '
        'frmReply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 546)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.txtReplyMessage)
        Me.Controls.Add(Me.btnSendReply)
        Me.Controls.Add(Me.lblSelectedMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReply"
        Me.Text = ","
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSelectedMessage As Label
    Friend WithEvents btnSendReply As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtReplyMessage As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
