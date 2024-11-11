<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OTPRequestAndVerificationForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.txtEmailOrUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnRequestOtp = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.GroupBoxotp = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2ProgressIndicator1 = New Guna.UI2.WinForms.Guna2ProgressIndicator()
        Me.txtOtp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnVerifyOtp = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lblAccountStatus = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.GroupBoxotp.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_ACTIVATE
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'txtEmailOrUsername
        '
        Me.txtEmailOrUsername.AutoRoundedCorners = True
        Me.txtEmailOrUsername.BorderRadius = 25
        Me.txtEmailOrUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmailOrUsername.DefaultText = ""
        Me.txtEmailOrUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmailOrUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmailOrUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailOrUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailOrUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailOrUsername.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtEmailOrUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailOrUsername.Location = New System.Drawing.Point(35, 40)
        Me.txtEmailOrUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmailOrUsername.Name = "txtEmailOrUsername"
        Me.txtEmailOrUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailOrUsername.PlaceholderText = "Enter Username or Email"
        Me.txtEmailOrUsername.SelectedText = ""
        Me.txtEmailOrUsername.Size = New System.Drawing.Size(262, 53)
        Me.txtEmailOrUsername.TabIndex = 7
        '
        'BtnRequestOtp
        '
        Me.BtnRequestOtp.AutoRoundedCorners = True
        Me.BtnRequestOtp.BorderRadius = 20
        Me.BtnRequestOtp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnRequestOtp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnRequestOtp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnRequestOtp.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnRequestOtp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnRequestOtp.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BtnRequestOtp.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BtnRequestOtp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnRequestOtp.ForeColor = System.Drawing.Color.White
        Me.BtnRequestOtp.Location = New System.Drawing.Point(35, 100)
        Me.BtnRequestOtp.Name = "BtnRequestOtp"
        Me.BtnRequestOtp.Size = New System.Drawing.Size(126, 42)
        Me.BtnRequestOtp.TabIndex = 8
        Me.BtnRequestOtp.Text = "Request Reset"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.DimGray
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(425, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(32, 27)
        Me.Guna2ControlBox1.TabIndex = 9
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblTimer)
        Me.Guna2ShadowPanel1.Controls.Add(Me.GroupBoxotp)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblAccountStatus)
        Me.Guna2ShadowPanel1.Controls.Add(Me.BtnRequestOtp)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtEmailOrUsername)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(422, 36)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Guna2ShadowPanel1.ShadowShift = 7
        Me.Guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(342, 445)
        Me.Guna2ShadowPanel1.TabIndex = 10
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(167, 113)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(0, 17)
        Me.lblTimer.TabIndex = 15
        '
        'GroupBoxotp
        '
        Me.GroupBoxotp.Controls.Add(Me.Guna2ProgressIndicator1)
        Me.GroupBoxotp.Controls.Add(Me.txtOtp)
        Me.GroupBoxotp.Controls.Add(Me.BtnVerifyOtp)
        Me.GroupBoxotp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBoxotp.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBoxotp.Location = New System.Drawing.Point(0, 148)
        Me.GroupBoxotp.Name = "GroupBoxotp"
        Me.GroupBoxotp.Size = New System.Drawing.Size(336, 146)
        Me.GroupBoxotp.TabIndex = 15
        '
        'Guna2ProgressIndicator1
        '
        Me.Guna2ProgressIndicator1.Location = New System.Drawing.Point(132, 0)
        Me.Guna2ProgressIndicator1.Name = "Guna2ProgressIndicator1"
        Me.Guna2ProgressIndicator1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Guna2ProgressIndicator1.Size = New System.Drawing.Size(53, 49)
        Me.Guna2ProgressIndicator1.TabIndex = 15
        '
        'txtOtp
        '
        Me.txtOtp.AutoRoundedCorners = True
        Me.txtOtp.BorderRadius = 23
        Me.txtOtp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOtp.DefaultText = ""
        Me.txtOtp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtOtp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOtp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOtp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOtp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOtp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtOtp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOtp.Location = New System.Drawing.Point(35, 43)
        Me.txtOtp.Name = "txtOtp"
        Me.txtOtp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOtp.PlaceholderText = ""
        Me.txtOtp.SelectedText = ""
        Me.txtOtp.Size = New System.Drawing.Size(262, 48)
        Me.txtOtp.TabIndex = 14
        '
        'BtnVerifyOtp
        '
        Me.BtnVerifyOtp.AutoRoundedCorners = True
        Me.BtnVerifyOtp.BorderRadius = 20
        Me.BtnVerifyOtp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnVerifyOtp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnVerifyOtp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnVerifyOtp.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnVerifyOtp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnVerifyOtp.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BtnVerifyOtp.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.BtnVerifyOtp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnVerifyOtp.ForeColor = System.Drawing.Color.White
        Me.BtnVerifyOtp.Location = New System.Drawing.Point(35, 97)
        Me.BtnVerifyOtp.Name = "BtnVerifyOtp"
        Me.BtnVerifyOtp.Size = New System.Drawing.Size(123, 42)
        Me.BtnVerifyOtp.TabIndex = 12
        Me.BtnVerifyOtp.Text = "Verify OTP"
        '
        'lblAccountStatus
        '
        Me.lblAccountStatus.AutoSize = True
        Me.lblAccountStatus.Location = New System.Drawing.Point(236, 12)
        Me.lblAccountStatus.Name = "lblAccountStatus"
        Me.lblAccountStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblAccountStatus.TabIndex = 9
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(352, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(469, 30)
        Me.Guna2Panel1.TabIndex = 11
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2PictureBox1.Image = Global.Ajira.My.Resources.Resources.blue_011
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(352, 493)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 6
        Me.Guna2PictureBox1.TabStop = False
        '
        'OTPRequestAndVerificationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 493)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OTPRequestAndVerificationForm"
        Me.Text = ","
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.GroupBoxotp.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents txtEmailOrUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BtnRequestOtp As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents lblAccountStatus As Label
    Friend WithEvents BtnVerifyOtp As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtOtp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblTimer As Label
    Friend WithEvents GroupBoxotp As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2ProgressIndicator1 As Guna.UI2.WinForms.Guna2ProgressIndicator
End Class
