<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.ToggleSwitch1 = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.passwordreset = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.pn_login = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.txtunamelogin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtpasslogin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.pn_registrationemployer = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.rdoEmployee = New System.Windows.Forms.RadioButton()
        Me.rdoEmployer = New System.Windows.Forms.RadioButton()
        Me.txtfirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtsecondname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btncreateaccButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtuname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.radioEmployer = New System.Windows.Forms.RadioButton()
        Me.radioEmployee = New System.Windows.Forms.RadioButton()
        Me.Guna2Panel1.SuspendLayout()
        Me.pn_login.SuspendLayout()
        Me.pn_registrationemployer.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'ToggleSwitch1
        '
        Me.ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2Transition1.SetDecoration(Me.ToggleSwitch1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.ToggleSwitch1.Location = New System.Drawing.Point(29, 213)
        Me.ToggleSwitch1.Name = "ToggleSwitch1"
        Me.ToggleSwitch1.Size = New System.Drawing.Size(35, 20)
        Me.ToggleSwitch1.TabIndex = 7
        Me.ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Remember Me"
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.Animated = True
        Me.Guna2GradientButton1.AutoRoundedCorners = True
        Me.Guna2GradientButton1.BorderRadius = 21
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(29, 263)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(243, 45)
        Me.Guna2GradientButton1.TabIndex = 11
        Me.Guna2GradientButton1.Text = "LOGIN"
        '
        'passwordreset
        '
        Me.passwordreset.AutoSize = True
        Me.passwordreset.BackColor = System.Drawing.Color.Transparent
        Me.passwordreset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.passwordreset, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.passwordreset.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordreset.Location = New System.Drawing.Point(71, 322)
        Me.passwordreset.Name = "passwordreset"
        Me.passwordreset.Size = New System.Drawing.Size(170, 13)
        Me.passwordreset.TabIndex = 12
        Me.passwordreset.Text = " Forgot Username or Password?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(92, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "User Login"
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Transition1.SetDecoration(Me.Guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(922, 28)
        Me.Guna2Panel1.TabIndex = 15
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2Transition1.SetDecoration(Me.Guna2ControlBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.DimGray
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(858, 4)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(23, 21)
        Me.Guna2ControlBox2.TabIndex = 16
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Transition1.SetDecoration(Me.Guna2ControlBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.DimGray
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(887, 4)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(23, 21)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'pn_login
        '
        Me.pn_login.BackColor = System.Drawing.Color.Transparent
        Me.pn_login.Controls.Add(Me.radioEmployee)
        Me.pn_login.Controls.Add(Me.radioEmployer)
        Me.pn_login.Controls.Add(Me.Guna2GradientButton1)
        Me.pn_login.Controls.Add(Me.txtunamelogin)
        Me.pn_login.Controls.Add(Me.passwordreset)
        Me.pn_login.Controls.Add(Me.txtpasslogin)
        Me.pn_login.Controls.Add(Me.Label1)
        Me.pn_login.Controls.Add(Me.Label3)
        Me.pn_login.Controls.Add(Me.Guna2GradientButton2)
        Me.pn_login.Controls.Add(Me.ToggleSwitch1)
        Me.Guna2Transition1.SetDecoration(Me.pn_login, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pn_login.FillColor = System.Drawing.Color.White
        Me.pn_login.Location = New System.Drawing.Point(211, 79)
        Me.pn_login.Name = "pn_login"
        Me.pn_login.ShadowColor = System.Drawing.Color.Green
        Me.pn_login.ShadowDepth = 150
        Me.pn_login.ShadowShift = 8
        Me.pn_login.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.pn_login.Size = New System.Drawing.Size(310, 428)
        Me.pn_login.TabIndex = 17
        '
        'txtunamelogin
        '
        Me.txtunamelogin.Animated = True
        Me.txtunamelogin.BorderRadius = 8
        Me.txtunamelogin.BorderThickness = 2
        Me.txtunamelogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.txtunamelogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtunamelogin.DefaultText = ""
        Me.txtunamelogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtunamelogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtunamelogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtunamelogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtunamelogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtunamelogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunamelogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtunamelogin.IconLeft = Global.Ajira.My.Resources.Resources.avatar
        Me.txtunamelogin.Location = New System.Drawing.Point(29, 97)
        Me.txtunamelogin.Name = "txtunamelogin"
        Me.txtunamelogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtunamelogin.PlaceholderText = "Username"
        Me.txtunamelogin.SelectedText = ""
        Me.txtunamelogin.Size = New System.Drawing.Size(243, 46)
        Me.txtunamelogin.TabIndex = 5
        '
        'txtpasslogin
        '
        Me.txtpasslogin.Animated = True
        Me.txtpasslogin.BorderRadius = 8
        Me.txtpasslogin.BorderThickness = 2
        Me.txtpasslogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.txtpasslogin, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtpasslogin.DefaultText = ""
        Me.txtpasslogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpasslogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpasslogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpasslogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpasslogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpasslogin.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtpasslogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpasslogin.IconLeft = Global.Ajira.My.Resources.Resources.padlock
        Me.txtpasslogin.Location = New System.Drawing.Point(29, 149)
        Me.txtpasslogin.Name = "txtpasslogin"
        Me.txtpasslogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpasslogin.PlaceholderText = "Password"
        Me.txtpasslogin.SelectedText = ""
        Me.txtpasslogin.Size = New System.Drawing.Size(243, 46)
        Me.txtpasslogin.TabIndex = 6
        '
        'Guna2GradientButton2
        '
        Me.Guna2GradientButton2.Animated = True
        Me.Guna2GradientButton2.AutoRoundedCorners = True
        Me.Guna2GradientButton2.BorderRadius = 21
        Me.Guna2Transition1.SetDecoration(Me.Guna2GradientButton2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton2.FillColor2 = System.Drawing.Color.Transparent
        Me.Guna2GradientButton2.Font = New System.Drawing.Font("Segoe UI Historic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton2.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2GradientButton2.Image = Global.Ajira.My.Resources.Resources.right_arrow_6
        Me.Guna2GradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Guna2GradientButton2.ImageSize = New System.Drawing.Size(18, 18)
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(48, 354)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(212, 45)
        Me.Guna2GradientButton2.TabIndex = 13
        Me.Guna2GradientButton2.Text = "Create Account"
        '
        'pn_registrationemployer
        '
        Me.pn_registrationemployer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pn_registrationemployer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pn_registrationemployer.BackColor = System.Drawing.Color.Transparent
        Me.pn_registrationemployer.Controls.Add(Me.rdoEmployee)
        Me.pn_registrationemployer.Controls.Add(Me.rdoEmployer)
        Me.pn_registrationemployer.Controls.Add(Me.txtfirstname)
        Me.pn_registrationemployer.Controls.Add(Me.txtsecondname)
        Me.pn_registrationemployer.Controls.Add(Me.btncreateaccButton)
        Me.pn_registrationemployer.Controls.Add(Me.txtuname)
        Me.pn_registrationemployer.Controls.Add(Me.Label4)
        Me.pn_registrationemployer.Controls.Add(Me.txtpass)
        Me.pn_registrationemployer.Controls.Add(Me.Label6)
        Me.Guna2Transition1.SetDecoration(Me.pn_registrationemployer, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pn_registrationemployer.FillColor = System.Drawing.Color.White
        Me.pn_registrationemployer.Location = New System.Drawing.Point(498, 79)
        Me.pn_registrationemployer.Name = "pn_registrationemployer"
        Me.pn_registrationemployer.ShadowColor = System.Drawing.Color.Green
        Me.pn_registrationemployer.ShadowDepth = 150
        Me.pn_registrationemployer.ShadowShift = 8
        Me.pn_registrationemployer.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal
        Me.pn_registrationemployer.Size = New System.Drawing.Size(310, 428)
        Me.pn_registrationemployer.TabIndex = 18
        '
        'rdoEmployee
        '
        Me.rdoEmployee.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.rdoEmployee, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.rdoEmployee.Location = New System.Drawing.Point(142, 291)
        Me.rdoEmployee.Name = "rdoEmployee"
        Me.rdoEmployee.Size = New System.Drawing.Size(71, 17)
        Me.rdoEmployee.TabIndex = 18
        Me.rdoEmployee.TabStop = True
        Me.rdoEmployee.Text = "Employee"
        Me.rdoEmployee.UseVisualStyleBackColor = True
        '
        'rdoEmployer
        '
        Me.rdoEmployer.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.rdoEmployer, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.rdoEmployer.Location = New System.Drawing.Point(44, 291)
        Me.rdoEmployer.Name = "rdoEmployer"
        Me.rdoEmployer.Size = New System.Drawing.Size(68, 17)
        Me.rdoEmployer.TabIndex = 17
        Me.rdoEmployer.TabStop = True
        Me.rdoEmployer.Text = "Employer"
        Me.rdoEmployer.UseVisualStyleBackColor = True
        '
        'txtfirstname
        '
        Me.txtfirstname.Animated = True
        Me.txtfirstname.BorderRadius = 8
        Me.txtfirstname.BorderThickness = 2
        Me.txtfirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.txtfirstname, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtfirstname.DefaultText = ""
        Me.txtfirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtfirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtfirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfirstname.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtfirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfirstname.Location = New System.Drawing.Point(29, 73)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfirstname.PlaceholderText = "First name"
        Me.txtfirstname.SelectedText = ""
        Me.txtfirstname.Size = New System.Drawing.Size(243, 46)
        Me.txtfirstname.TabIndex = 16
        '
        'txtsecondname
        '
        Me.txtsecondname.Animated = True
        Me.txtsecondname.BorderRadius = 8
        Me.txtsecondname.BorderThickness = 2
        Me.txtsecondname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.txtsecondname, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtsecondname.DefaultText = ""
        Me.txtsecondname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtsecondname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtsecondname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsecondname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsecondname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsecondname.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtsecondname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsecondname.Location = New System.Drawing.Point(29, 126)
        Me.txtsecondname.Name = "txtsecondname"
        Me.txtsecondname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsecondname.PlaceholderText = "Second name"
        Me.txtsecondname.SelectedText = ""
        Me.txtsecondname.Size = New System.Drawing.Size(243, 46)
        Me.txtsecondname.TabIndex = 15
        '
        'btncreateaccButton
        '
        Me.btncreateaccButton.Animated = True
        Me.btncreateaccButton.AutoRoundedCorners = True
        Me.btncreateaccButton.BorderRadius = 21
        Me.Guna2Transition1.SetDecoration(Me.btncreateaccButton, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btncreateaccButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btncreateaccButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btncreateaccButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btncreateaccButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btncreateaccButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btncreateaccButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btncreateaccButton.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btncreateaccButton.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btncreateaccButton.ForeColor = System.Drawing.Color.White
        Me.btncreateaccButton.Location = New System.Drawing.Point(29, 322)
        Me.btncreateaccButton.Name = "btncreateaccButton"
        Me.btncreateaccButton.Size = New System.Drawing.Size(243, 45)
        Me.btncreateaccButton.TabIndex = 11
        Me.btncreateaccButton.Text = "Create Account"
        '
        'txtuname
        '
        Me.txtuname.Animated = True
        Me.txtuname.BorderRadius = 8
        Me.txtuname.BorderThickness = 2
        Me.txtuname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.txtuname, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtuname.DefaultText = ""
        Me.txtuname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtuname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtuname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtuname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtuname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtuname.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtuname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtuname.IconLeft = Global.Ajira.My.Resources.Resources.avatar
        Me.txtuname.Location = New System.Drawing.Point(29, 181)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtuname.PlaceholderText = "Username"
        Me.txtuname.SelectedText = ""
        Me.txtuname.Size = New System.Drawing.Size(243, 46)
        Me.txtuname.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 370)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "LOGIN"
        '
        'txtpass
        '
        Me.txtpass.Animated = True
        Me.txtpass.BorderRadius = 8
        Me.txtpass.BorderThickness = 2
        Me.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2Transition1.SetDecoration(Me.txtpass, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.txtpass.DefaultText = ""
        Me.txtpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpass.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpass.IconLeft = Global.Ajira.My.Resources.Resources.padlock
        Me.txtpass.Location = New System.Drawing.Point(29, 235)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpass.PlaceholderText = "Password"
        Me.txtpass.SelectedText = ""
        Me.txtpass.Size = New System.Drawing.Size(243, 46)
        Me.txtpass.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Label6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(92, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Register"
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        '
        'Guna2PictureBox1
        '
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.Image = Global.Ajira.My.Resources.Resources.Ajiraep
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(420, 605)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 4
        Me.Guna2PictureBox1.TabStop = False
        '
        'radioEmployer
        '
        Me.radioEmployer.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.radioEmployer, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.radioEmployer.Location = New System.Drawing.Point(39, 240)
        Me.radioEmployer.Name = "radioEmployer"
        Me.radioEmployer.Size = New System.Drawing.Size(68, 17)
        Me.radioEmployer.TabIndex = 19
        Me.radioEmployer.TabStop = True
        Me.radioEmployer.Text = "Employer"
        Me.radioEmployer.UseVisualStyleBackColor = True
        '
        'radioEmployee
        '
        Me.radioEmployee.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.radioEmployee, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.radioEmployee.Location = New System.Drawing.Point(133, 240)
        Me.radioEmployee.Name = "radioEmployee"
        Me.radioEmployee.Size = New System.Drawing.Size(71, 17)
        Me.radioEmployee.TabIndex = 19
        Me.radioEmployee.TabStop = True
        Me.radioEmployee.Text = "Employee"
        Me.radioEmployee.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(922, 606)
        Me.Controls.Add(Me.pn_login)
        Me.Controls.Add(Me.pn_registrationemployer)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.pn_login.ResumeLayout(False)
        Me.pn_login.PerformLayout()
        Me.pn_registrationemployer.ResumeLayout(False)
        Me.pn_registrationemployer.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Label1 As Label
    Friend WithEvents ToggleSwitch1 As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents txtpasslogin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtunamelogin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents passwordreset As Label
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents pn_login As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents pn_registrationemployer As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btncreateaccButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtuname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtfirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtsecondname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents rdoEmployee As RadioButton
    Friend WithEvents rdoEmployer As RadioButton
    Friend WithEvents radioEmployee As RadioButton
    Friend WithEvents radioEmployer As RadioButton
End Class
