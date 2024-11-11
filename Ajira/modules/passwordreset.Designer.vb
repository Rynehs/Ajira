<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class passwordreset
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
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.resetnewpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.confirmnewpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.resetbutton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel1.SuspendLayout()
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
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'resetnewpassword
        '
        Me.resetnewpassword.Animated = True
        Me.resetnewpassword.AutoRoundedCorners = True
        Me.resetnewpassword.BorderRadius = 25
        Me.resetnewpassword.BorderThickness = 2
        Me.resetnewpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.resetnewpassword.DefaultText = ""
        Me.resetnewpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.resetnewpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.resetnewpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.resetnewpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.resetnewpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.resetnewpassword.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.resetnewpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.resetnewpassword.Location = New System.Drawing.Point(41, 114)
        Me.resetnewpassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.resetnewpassword.Name = "resetnewpassword"
        Me.resetnewpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.resetnewpassword.PlaceholderText = "newpassword"
        Me.resetnewpassword.SelectedText = ""
        Me.resetnewpassword.Size = New System.Drawing.Size(259, 52)
        Me.resetnewpassword.TabIndex = 0
        '
        'confirmnewpassword
        '
        Me.confirmnewpassword.Animated = True
        Me.confirmnewpassword.AutoRoundedCorners = True
        Me.confirmnewpassword.BorderRadius = 25
        Me.confirmnewpassword.BorderThickness = 2
        Me.confirmnewpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.confirmnewpassword.DefaultText = ""
        Me.confirmnewpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.confirmnewpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.confirmnewpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmnewpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmnewpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmnewpassword.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.confirmnewpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmnewpassword.Location = New System.Drawing.Point(41, 174)
        Me.confirmnewpassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.confirmnewpassword.Name = "confirmnewpassword"
        Me.confirmnewpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.confirmnewpassword.PlaceholderText = "confirm new password"
        Me.confirmnewpassword.SelectedText = ""
        Me.confirmnewpassword.Size = New System.Drawing.Size(259, 53)
        Me.confirmnewpassword.TabIndex = 1
        '
        'resetbutton
        '
        Me.resetbutton.AutoRoundedCorners = True
        Me.resetbutton.BorderRadius = 20
        Me.resetbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.resetbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.resetbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.resetbutton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.resetbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.resetbutton.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.resetbutton.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.resetbutton.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetbutton.ForeColor = System.Drawing.Color.White
        Me.resetbutton.Location = New System.Drawing.Point(90, 244)
        Me.resetbutton.Name = "resetbutton"
        Me.resetbutton.Size = New System.Drawing.Size(160, 42)
        Me.resetbutton.TabIndex = 2
        Me.resetbutton.Text = "Reset"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.resetbutton)
        Me.Guna2ShadowPanel1.Controls.Add(Me.resetnewpassword)
        Me.Guna2ShadowPanel1.Controls.Add(Me.confirmnewpassword)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(466, 24)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Green
        Me.Guna2ShadowPanel1.ShadowDepth = 150
        Me.Guna2ShadowPanel1.ShadowShift = 7
        Me.Guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(338, 473)
        Me.Guna2ShadowPanel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Back to Log In"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.Ajira.My.Resources.Resources.Ajiraep
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-1, -77)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(420, 605)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 5
        Me.Guna2PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(124, 367)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Find Account"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'passwordreset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(842, 509)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "passwordreset"
        Me.Text = "passwordreset"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents resetbutton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents confirmnewpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents resetnewpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label2 As Label
End Class
