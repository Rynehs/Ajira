
Imports MySql.Data.MySqlClient
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeDash
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2DragControl2 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelhome = New System.Windows.Forms.Panel()
        Me.gunaPanel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Buttonsettings = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.home = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.toggleButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Btnjobs = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMessageCount = New Guna.UI2.WinForms.Guna2Button()
        Me.logoutButton = New Guna.UI2.WinForms.Guna2Button()
        Me.profile = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Panel1.SuspendLayout()
        Me.gunaPanel2.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1478, 5)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(23, 21)
        Me.Guna2ControlBox2.TabIndex = 21
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.DarkRed
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1501, 5)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(23, 21)
        Me.Guna2ControlBox1.TabIndex = 20
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1536, 33)
        Me.Guna2Panel1.TabIndex = 22
        '
        'Guna2DragControl2
        '
        Me.Guna2DragControl2.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl2.TargetControl = Me.Guna2Panel1
        Me.Guna2DragControl2.UseTransparentDrag = True
        '
        'panelhome
        '
        Me.panelhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.panelhome.Location = New System.Drawing.Point(199, 32)
        Me.panelhome.Name = "panelhome"
        Me.panelhome.Size = New System.Drawing.Size(1337, 713)
        Me.panelhome.TabIndex = 0
        '
        'gunaPanel2
        '
        Me.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.gunaPanel2.Controls.Add(Me.Buttonsettings)
        Me.gunaPanel2.Controls.Add(Me.Guna2PictureBox1)
        Me.gunaPanel2.Controls.Add(Me.home)
        Me.gunaPanel2.Controls.Add(Me.toggleButton)
        Me.gunaPanel2.Controls.Add(Me.Btnjobs)
        Me.gunaPanel2.Controls.Add(Me.btnMessageCount)
        Me.gunaPanel2.Controls.Add(Me.logoutButton)
        Me.gunaPanel2.Controls.Add(Me.profile)
        Me.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.gunaPanel2.Location = New System.Drawing.Point(0, 33)
        Me.gunaPanel2.Name = "gunaPanel2"
        Me.gunaPanel2.Size = New System.Drawing.Size(200, 712)
        Me.gunaPanel2.TabIndex = 25
        '
        'Buttonsettings
        '
        Me.Buttonsettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Buttonsettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Buttonsettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Buttonsettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Buttonsettings.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Buttonsettings.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Buttonsettings.ForeColor = System.Drawing.Color.White
        Me.Buttonsettings.Image = Global.Ajira.My.Resources.Resources.settings
        Me.Buttonsettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Buttonsettings.ImageSize = New System.Drawing.Size(35, 35)
        Me.Buttonsettings.Location = New System.Drawing.Point(0, 608)
        Me.Buttonsettings.Name = "Buttonsettings"
        Me.Buttonsettings.Size = New System.Drawing.Size(200, 45)
        Me.Buttonsettings.TabIndex = 0
        Me.Buttonsettings.Text = "Settings"
        Me.Buttonsettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Guna2PictureBox1.Image = Global.Ajira.My.Resources.Resources.blue_03
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 41)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(200, 145)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'home
        '
        Me.home.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.home.Animated = True
        Me.home.AutoRoundedCorners = True
        Me.home.BackColor = System.Drawing.Color.Transparent
        Me.home.BorderColor = System.Drawing.Color.DimGray
        Me.home.BorderRadius = 21
        Me.home.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.home.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.home.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.home.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.home.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.home.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.home.ForeColor = System.Drawing.Color.White
        Me.home.Image = Global.Ajira.My.Resources.Resources.home1
        Me.home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.home.ImageSize = New System.Drawing.Size(35, 35)
        Me.home.Location = New System.Drawing.Point(0, 209)
        Me.home.Name = "home"
        Me.home.Size = New System.Drawing.Size(200, 45)
        Me.home.TabIndex = 1
        Me.home.Text = "Home"
        Me.home.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.home.UseTransparentBackground = True
        '
        'toggleButton
        '
        Me.toggleButton.BackgroundImage = Global.Ajira.My.Resources.Resources.menu_bar
        Me.toggleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.toggleButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.toggleButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.toggleButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.toggleButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.toggleButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.toggleButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.toggleButton.ForeColor = System.Drawing.Color.White
        Me.toggleButton.Image = Global.Ajira.My.Resources.Resources.menu_bar
        Me.toggleButton.ImageSize = New System.Drawing.Size(40, 40)
        Me.toggleButton.Location = New System.Drawing.Point(3, 3)
        Me.toggleButton.Name = "toggleButton"
        Me.toggleButton.Size = New System.Drawing.Size(43, 41)
        Me.toggleButton.TabIndex = 0
        '
        'Btnjobs
        '
        Me.Btnjobs.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnjobs.BorderColor = System.Drawing.Color.DimGray
        Me.Btnjobs.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btnjobs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btnjobs.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btnjobs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btnjobs.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Btnjobs.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Btnjobs.ForeColor = System.Drawing.Color.White
        Me.Btnjobs.Image = Global.Ajira.My.Resources.Resources.posting
        Me.Btnjobs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Btnjobs.ImageSize = New System.Drawing.Size(35, 35)
        Me.Btnjobs.Location = New System.Drawing.Point(0, 366)
        Me.Btnjobs.Name = "Btnjobs"
        Me.Btnjobs.Size = New System.Drawing.Size(200, 45)
        Me.Btnjobs.TabIndex = 25
        Me.Btnjobs.Text = "Jobs"
        Me.Btnjobs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnMessageCount
        '
        Me.btnMessageCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMessageCount.BackColor = System.Drawing.Color.Transparent
        Me.btnMessageCount.BorderColor = System.Drawing.Color.DimGray
        Me.btnMessageCount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMessageCount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMessageCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMessageCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMessageCount.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnMessageCount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnMessageCount.ForeColor = System.Drawing.Color.White
        Me.btnMessageCount.Image = Global.Ajira.My.Resources.Resources.messege
        Me.btnMessageCount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnMessageCount.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnMessageCount.Location = New System.Drawing.Point(0, 315)
        Me.btnMessageCount.Name = "btnMessageCount"
        Me.btnMessageCount.Size = New System.Drawing.Size(200, 45)
        Me.btnMessageCount.TabIndex = 0
        Me.btnMessageCount.Text = "Messages"
        Me.btnMessageCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'logoutButton
        '
        Me.logoutButton.Animated = True
        Me.logoutButton.AnimatedGIF = True
        Me.logoutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.logoutButton.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.logoutButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.logoutButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.logoutButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.logoutButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.logoutButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.logoutButton.FillColor = System.Drawing.Color.Transparent
        Me.logoutButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.logoutButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.logoutButton.Image = Global.Ajira.My.Resources.Resources.logout
        Me.logoutButton.ImageSize = New System.Drawing.Size(60, 60)
        Me.logoutButton.Location = New System.Drawing.Point(0, 654)
        Me.logoutButton.Name = "logoutButton"
        Me.logoutButton.Size = New System.Drawing.Size(200, 58)
        Me.logoutButton.TabIndex = 0
        Me.logoutButton.Text = ","
        '
        'profile
        '
        Me.profile.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.profile.Animated = True
        Me.profile.AutoRoundedCorners = True
        Me.profile.BackColor = System.Drawing.Color.Transparent
        Me.profile.BorderColor = System.Drawing.Color.DimGray
        Me.profile.BorderRadius = 21
        Me.profile.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.profile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.profile.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.profile.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.profile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.profile.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.profile.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.profile.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.profile.ForeColor = System.Drawing.Color.White
        Me.profile.Image = Global.Ajira.My.Resources.Resources.user2
        Me.profile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.profile.ImageSize = New System.Drawing.Size(35, 35)
        Me.profile.Location = New System.Drawing.Point(0, 262)
        Me.profile.Name = "profile"
        Me.profile.Size = New System.Drawing.Size(200, 45)
        Me.profile.TabIndex = 0
        Me.profile.Text = "Profile"
        Me.profile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.profile.UseTransparentBackground = True
        '
        'EmployeeDash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1536, 745)
        Me.Controls.Add(Me.gunaPanel2)
        Me.Controls.Add(Me.panelhome)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EmployeeDash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ","
        Me.Guna2Panel1.ResumeLayout(False)
        Me.gunaPanel2.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm

    Private Sub Guna2ShadowPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        home.Show()
    End Sub
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl2 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Timer1 As Timer
    Friend WithEvents gunaPanel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents profile As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents home As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents logoutButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelhome As Panel
    Friend WithEvents btnMessageCount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btnjobs As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents toggleButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Buttonsettings As Guna.UI2.WinForms.Guna2Button
End Class
