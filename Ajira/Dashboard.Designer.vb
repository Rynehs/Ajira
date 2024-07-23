
Imports MySql.Data.MySqlClient
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard
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
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.profile = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2ShadowPanel5 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.mainPanel = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.panelhome = New System.Windows.Forms.Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ShadowPanel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainPanel.SuspendLayout()
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
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Text = "Ajira"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowFormToolStripMenuItem, Me.CloseAppToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(135, 48)
        '
        'ShowFormToolStripMenuItem
        '
        Me.ShowFormToolStripMenuItem.Name = "ShowFormToolStripMenuItem"
        Me.ShowFormToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ShowFormToolStripMenuItem.Text = "Show Form"
        '
        'CloseAppToolStripMenuItem
        '
        Me.CloseAppToolStripMenuItem.Name = "CloseAppToolStripMenuItem"
        Me.CloseAppToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.CloseAppToolStripMenuItem.Text = "Close App"
        '
        'ShadowPanel1
        '
        Me.ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.ShadowPanel1.Controls.Add(Me.profile)
        Me.ShadowPanel1.Controls.Add(Me.Guna2GradientButton1)
        Me.ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.ShadowPanel1.Location = New System.Drawing.Point(12, 146)
        Me.ShadowPanel1.Name = "ShadowPanel1"
        Me.ShadowPanel1.Radius = 15
        Me.ShadowPanel1.ShadowColor = System.Drawing.Color.Green
        Me.ShadowPanel1.Size = New System.Drawing.Size(184, 431)
        Me.ShadowPanel1.TabIndex = 0
        '
        'profile
        '
        Me.profile.Animated = True
        Me.profile.AutoRoundedCorners = True
        Me.profile.BorderRadius = 22
        Me.profile.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.profile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.profile.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.profile.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.profile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.profile.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.profile.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.profile.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.profile.ForeColor = System.Drawing.Color.White
        Me.profile.Location = New System.Drawing.Point(13, 76)
        Me.profile.Name = "profile"
        Me.profile.Size = New System.Drawing.Size(158, 46)
        Me.profile.TabIndex = 1
        Me.profile.Text = "Profile"
        Me.profile.UseTransparentBackground = True
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.Animated = True
        Me.Guna2GradientButton1.AutoRoundedCorners = True
        Me.Guna2GradientButton1.BorderRadius = 22
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(13, 24)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(158, 46)
        Me.Guna2GradientButton1.TabIndex = 0
        Me.Guna2GradientButton1.Text = "Home"
        Me.Guna2GradientButton1.UseTransparentBackground = True
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Guna2CirclePictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2CirclePictureBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox2.ImageRotate = 0!
        Me.Guna2CirclePictureBox2.InitialImage = Nothing
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(897, 28)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(110, 107)
        Me.Guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2CirclePictureBox2.TabIndex = 3
        Me.Guna2CirclePictureBox2.TabStop = False
        '
        'Guna2ShadowPanel5
        '
        Me.Guna2ShadowPanel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ShadowPanel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel5.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel5.Location = New System.Drawing.Point(897, 149)
        Me.Guna2ShadowPanel5.Name = "Guna2ShadowPanel5"
        Me.Guna2ShadowPanel5.Radius = 15
        Me.Guna2ShadowPanel5.ShadowColor = System.Drawing.Color.Green
        Me.Guna2ShadowPanel5.Size = New System.Drawing.Size(219, 428)
        Me.Guna2ShadowPanel5.TabIndex = 1
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.DimGray
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1110, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(23, 21)
        Me.Guna2ControlBox1.TabIndex = 4
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.DimGray
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1081, 12)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(23, 21)
        Me.Guna2ControlBox2.TabIndex = 17
        '
        'mainPanel
        '
        Me.mainPanel.Controls.Add(Me.panelhome)
        Me.mainPanel.Controls.Add(Me.Guna2PictureBox1)
        Me.mainPanel.Controls.Add(Me.Guna2ControlBox2)
        Me.mainPanel.Controls.Add(Me.Guna2ControlBox1)
        Me.mainPanel.Controls.Add(Me.Guna2ShadowPanel5)
        Me.mainPanel.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.mainPanel.Controls.Add(Me.ShadowPanel1)
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.mainPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(1145, 625)
        Me.mainPanel.TabIndex = 3
        '
        'panelhome
        '
        Me.panelhome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelhome.Location = New System.Drawing.Point(202, 28)
        Me.panelhome.Name = "panelhome"
        Me.panelhome.Size = New System.Drawing.Size(689, 594)
        Me.panelhome.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BorderRadius = 1
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2PictureBox1.Image = Global.Ajira.My.Resources.Resources.Ajiraeoo
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(184, 128)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 18
        Me.Guna2PictureBox1.TabStop = False
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1145, 625)
        Me.Controls.Add(Me.mainPanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ShadowPanel1.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainPanel.ResumeLayout(False)
        Me.mainPanel.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ShowFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

    Private Sub Guna2ShadowPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub





    Private Sub Guna2CirclePictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox2.Click

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Home.Show()
    End Sub

    Friend WithEvents mainPanel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ShadowPanel5 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents profile As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents panelhome As Panel
End Class
