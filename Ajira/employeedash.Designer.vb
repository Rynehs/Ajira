
Imports MySql.Data.MySqlClient
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class employeeDash
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
        Me.home = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.profile = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2ShadowPanel5 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.mainPanel = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.panelhome = New System.Windows.Forms.Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ShadowPanel1.SuspendLayout()
        Me.mainPanel.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ShadowPanel1.Controls.Add(Me.home)
        Me.ShadowPanel1.Controls.Add(Me.profile)
        Me.ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.ShadowPanel1.Location = New System.Drawing.Point(12, 146)
        Me.ShadowPanel1.Name = "ShadowPanel1"
        Me.ShadowPanel1.Radius = 15
        Me.ShadowPanel1.ShadowColor = System.Drawing.Color.Green
        Me.ShadowPanel1.Size = New System.Drawing.Size(184, 431)
        Me.ShadowPanel1.TabIndex = 0
        '
        'home
        '
        Me.home.Animated = True
        Me.home.AutoRoundedCorners = True
        Me.home.BorderRadius = 22
        Me.home.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.home.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.home.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.home.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.home.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.home.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.home.ForeColor = System.Drawing.Color.White
        Me.home.Location = New System.Drawing.Point(13, 22)
        Me.home.Name = "home"
        Me.home.Size = New System.Drawing.Size(158, 46)
        Me.home.TabIndex = 1
        Me.home.Text = "Home"
        Me.home.UseTransparentBackground = True
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
        Me.profile.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profile.ForeColor = System.Drawing.Color.White
        Me.profile.Location = New System.Drawing.Point(13, 74)
        Me.profile.Name = "profile"
        Me.profile.Size = New System.Drawing.Size(158, 46)
        Me.profile.TabIndex = 0
        Me.profile.Text = "Profile"
        Me.profile.UseTransparentBackground = True
        '
        'Guna2ShadowPanel5
        '
        Me.Guna2ShadowPanel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ShadowPanel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel5.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel5.Location = New System.Drawing.Point(923, 149)
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
        Me.mainPanel.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.mainPanel.Controls.Add(Me.panelhome)
        Me.mainPanel.Controls.Add(Me.Guna2PictureBox1)
        Me.mainPanel.Controls.Add(Me.Guna2ControlBox2)
        Me.mainPanel.Controls.Add(Me.Guna2ControlBox1)
        Me.mainPanel.Controls.Add(Me.Guna2ShadowPanel5)
        Me.mainPanel.Controls.Add(Me.ShadowPanel1)
        Me.mainPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.mainPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(1145, 562)
        Me.mainPanel.TabIndex = 3
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(958, 28)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(117, 112)
        Me.Guna2CirclePictureBox1.TabIndex = 19
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'panelhome
        '
        Me.panelhome.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelhome.Location = New System.Drawing.Point(202, 28)
        Me.panelhome.Name = "panelhome"
        Me.panelhome.Size = New System.Drawing.Size(715, 531)
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
        'employeeDash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1145, 641)
        Me.Controls.Add(Me.mainPanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "employeeDash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ShadowPanel1.ResumeLayout(False)
        Me.mainPanel.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        home.Show()
    End Sub

    Friend WithEvents mainPanel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ShadowPanel5 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Friend WithEvents profile As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents home As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents panelhome As Panel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
