<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homeemployer
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.lblMessageCount = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Txtsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Btnsearch = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel9 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel8 = New Guna.UI2.WinForms.Guna2Panel()
        Me.guna2CircleProgressBar1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.lblsname = New System.Windows.Forms.Label()
        Me.lblfname = New System.Windows.Forms.Label()
        Me.employerpic = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CirclePictureBox4 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2CirclePictureBox5 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2CirclePictureBox3 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel8.SuspendLayout()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.employerpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'lblMessageCount
        '
        Me.lblMessageCount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMessageCount.AutoSize = True
        Me.lblMessageCount.BackColor = System.Drawing.Color.Transparent
        Me.lblMessageCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageCount.ForeColor = System.Drawing.Color.Red
        Me.lblMessageCount.Location = New System.Drawing.Point(1194, 4)
        Me.lblMessageCount.Name = "lblMessageCount"
        Me.lblMessageCount.Size = New System.Drawing.Size(19, 20)
        Me.lblMessageCount.TabIndex = 25
        Me.lblMessageCount.Text = "0"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 175)
        Me.Splitter1.TabIndex = 4
        Me.Splitter1.TabStop = False
        '
        'Txtsearch
        '
        Me.Txtsearch.AutoRoundedCorners = True
        Me.Txtsearch.BackColor = System.Drawing.Color.Transparent
        Me.Txtsearch.BorderRadius = 19
        Me.Txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txtsearch.DefaultText = ""
        Me.Txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtsearch.ForeColor = System.Drawing.Color.Black
        Me.Txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txtsearch.Location = New System.Drawing.Point(7, 7)
        Me.Txtsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtsearch.Name = "Txtsearch"
        Me.Txtsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txtsearch.PlaceholderText = "Search"
        Me.Txtsearch.SelectedText = ""
        Me.Txtsearch.Size = New System.Drawing.Size(257, 41)
        Me.Txtsearch.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.Location = New System.Drawing.Point(6, 450)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1207, 166)
        Me.Guna2Panel1.TabIndex = 14
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel5.Location = New System.Drawing.Point(0, 622)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(1225, 35)
        Me.Guna2Panel5.TabIndex = 10
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 175)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1225, 33)
        Me.Guna2Panel2.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Displa usernamae"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Guna2Panel3.Controls.Add(Me.Btnsearch)
        Me.Guna2Panel3.Controls.Add(Me.lblMessageCount)
        Me.Guna2Panel3.Controls.Add(Me.Guna2Button3)
        Me.Guna2Panel3.Controls.Add(Me.Splitter1)
        Me.Guna2Panel3.Controls.Add(Me.Txtsearch)
        Me.Guna2Panel3.Controls.Add(Me.Guna2CirclePictureBox4)
        Me.Guna2Panel3.Controls.Add(Me.Guna2CirclePictureBox5)
        Me.Guna2Panel3.Controls.Add(Me.Guna2CirclePictureBox3)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(1225, 175)
        Me.Guna2Panel3.TabIndex = 9
        '
        'Btnsearch
        '
        Me.Btnsearch.AutoRoundedCorners = True
        Me.Btnsearch.BackColor = System.Drawing.Color.Transparent
        Me.Btnsearch.BorderRadius = 21
        Me.Btnsearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btnsearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btnsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btnsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btnsearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Btnsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Btnsearch.ForeColor = System.Drawing.Color.White
        Me.Btnsearch.Location = New System.Drawing.Point(271, 7)
        Me.Btnsearch.Name = "Btnsearch"
        Me.Btnsearch.Size = New System.Drawing.Size(108, 45)
        Me.Btnsearch.TabIndex = 27
        Me.Btnsearch.Text = "Search"
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.BorderRadius = 15
        Me.Panel9.BorderThickness = 4
        Me.Panel9.Location = New System.Drawing.Point(617, 214)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(596, 230)
        Me.Panel9.TabIndex = 12
        '
        'Guna2Panel8
        '
        Me.Guna2Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Guna2Panel8.BorderRadius = 30
        Me.Guna2Panel8.BorderThickness = 8
        Me.Guna2Panel8.Controls.Add(Me.guna2CircleProgressBar1)
        Me.Guna2Panel8.Location = New System.Drawing.Point(320, 214)
        Me.Guna2Panel8.Name = "Guna2Panel8"
        Me.Guna2Panel8.Size = New System.Drawing.Size(291, 230)
        Me.Guna2Panel8.TabIndex = 11
        '
        'guna2CircleProgressBar1
        '
        Me.guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.guna2CircleProgressBar1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White
        Me.guna2CircleProgressBar1.Location = New System.Drawing.Point(40, 12)
        Me.guna2CircleProgressBar1.Minimum = 0
        Me.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1"
        Me.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.guna2CircleProgressBar1.Size = New System.Drawing.Size(205, 205)
        Me.guna2CircleProgressBar1.TabIndex = 0
        Me.guna2CircleProgressBar1.Text = "Guna2CircleProgressBar1"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.BackgroundImage = Global.Ajira.My.Resources.Resources.blue_02
        Me.Guna2ShadowPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2Button2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblsname)
        Me.Guna2ShadowPanel1.Controls.Add(Me.lblfname)
        Me.Guna2ShadowPanel1.Controls.Add(Me.employerpic)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(6, 87)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.ShadowDepth = 200
        Me.Guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(308, 356)
        Me.Guna2ShadowPanel1.TabIndex = 13
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.AutoRoundedCorners = True
        Me.Guna2Button2.BorderRadius = 21
        Me.Guna2Button2.BorderThickness = 1
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.White
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button2.Location = New System.Drawing.Point(152, 262)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(126, 45)
        Me.Guna2Button2.TabIndex = 2
        Me.Guna2Button2.Text = "Guna2Button2"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BorderRadius = 21
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(20, 262)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(126, 45)
        Me.Guna2Button1.TabIndex = 0
        Me.Guna2Button1.Text = "Guna2Button1"
        '
        'lblsname
        '
        Me.lblsname.AutoSize = True
        Me.lblsname.Font = New System.Drawing.Font("Swis721 BlkEx BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsname.Location = New System.Drawing.Point(173, 152)
        Me.lblsname.Name = "lblsname"
        Me.lblsname.Size = New System.Drawing.Size(52, 14)
        Me.lblsname.TabIndex = 1
        Me.lblsname.Text = "NAME"
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Font = New System.Drawing.Font("Swis721 BlkEx BT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfname.Location = New System.Drawing.Point(79, 152)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(52, 14)
        Me.lblfname.TabIndex = 0
        Me.lblfname.Text = "NAME"
        '
        'employerpic
        '
        Me.employerpic.FillColor = System.Drawing.Color.Maroon
        Me.employerpic.ImageRotate = 0!
        Me.employerpic.Location = New System.Drawing.Point(89, 4)
        Me.employerpic.Name = "employerpic"
        Me.employerpic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.employerpic.Size = New System.Drawing.Size(124, 117)
        Me.employerpic.TabIndex = 0
        Me.employerpic.TabStop = False
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.AutoRoundedCorners = True
        Me.Guna2Button3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.BorderRadius = 20
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Image = Global.Ajira.My.Resources.Resources.bell1
        Me.Guna2Button3.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2Button3.Location = New System.Drawing.Point(1165, 3)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(57, 43)
        Me.Guna2Button3.TabIndex = 26
        '
        'Guna2CirclePictureBox4
        '
        Me.Guna2CirclePictureBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2CirclePictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox4.Image = Global.Ajira.My.Resources.Resources.instagram
        Me.Guna2CirclePictureBox4.ImageRotate = 0!
        Me.Guna2CirclePictureBox4.Location = New System.Drawing.Point(1135, 110)
        Me.Guna2CirclePictureBox4.Name = "Guna2CirclePictureBox4"
        Me.Guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox4.Size = New System.Drawing.Size(49, 50)
        Me.Guna2CirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox4.TabIndex = 3
        Me.Guna2CirclePictureBox4.TabStop = False
        '
        'Guna2CirclePictureBox5
        '
        Me.Guna2CirclePictureBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2CirclePictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox5.Image = Global.Ajira.My.Resources.Resources.facebook
        Me.Guna2CirclePictureBox5.ImageRotate = 0!
        Me.Guna2CirclePictureBox5.Location = New System.Drawing.Point(1062, 110)
        Me.Guna2CirclePictureBox5.Name = "Guna2CirclePictureBox5"
        Me.Guna2CirclePictureBox5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox5.Size = New System.Drawing.Size(49, 50)
        Me.Guna2CirclePictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox5.TabIndex = 2
        Me.Guna2CirclePictureBox5.TabStop = False
        '
        'Guna2CirclePictureBox3
        '
        Me.Guna2CirclePictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2CirclePictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox3.Image = Global.Ajira.My.Resources.Resources.whatsapp
        Me.Guna2CirclePictureBox3.ImageRotate = 0!
        Me.Guna2CirclePictureBox3.Location = New System.Drawing.Point(994, 110)
        Me.Guna2CirclePictureBox3.Name = "Guna2CirclePictureBox3"
        Me.Guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox3.Size = New System.Drawing.Size(49, 50)
        Me.Guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox3.TabIndex = 1
        Me.Guna2CirclePictureBox3.TabStop = False
        '
        'Homeemployer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1225, 657)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Guna2Panel8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Homeemployer"
        Me.Text = "-"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel8.ResumeLayout(False)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.employerpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblsname As Label
    Friend WithEvents lblfname As Label
    Friend WithEvents employerpic As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblMessageCount As Label
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Txtsearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CirclePictureBox4 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2CirclePictureBox5 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2CirclePictureBox3 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Panel9 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel8 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents guna2CircleProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Btnsearch As Guna.UI2.WinForms.Guna2Button
End Class
