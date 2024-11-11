<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class jobspost
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
        Me.txtJobTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtJobDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLocation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtpStartDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.dtpEndDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnPostJob = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EndDate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProposedPayment = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtJobTitle
        '
        Me.txtJobTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJobTitle.DefaultText = ""
        Me.txtJobTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtJobTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtJobTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtJobTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtJobTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJobTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtJobTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJobTitle.Location = New System.Drawing.Point(171, 69)
        Me.txtJobTitle.Name = "txtJobTitle"
        Me.txtJobTitle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJobTitle.PlaceholderText = ""
        Me.txtJobTitle.SelectedText = ""
        Me.txtJobTitle.Size = New System.Drawing.Size(374, 36)
        Me.txtJobTitle.TabIndex = 0
        '
        'txtJobDescription
        '
        Me.txtJobDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJobDescription.DefaultText = ""
        Me.txtJobDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtJobDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtJobDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtJobDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtJobDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJobDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtJobDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJobDescription.Location = New System.Drawing.Point(171, 253)
        Me.txtJobDescription.Name = "txtJobDescription"
        Me.txtJobDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJobDescription.PlaceholderText = ""
        Me.txtJobDescription.SelectedText = ""
        Me.txtJobDescription.Size = New System.Drawing.Size(394, 170)
        Me.txtJobDescription.TabIndex = 1
        '
        'txtLocation
        '
        Me.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLocation.DefaultText = ""
        Me.txtLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLocation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLocation.Location = New System.Drawing.Point(380, 165)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLocation.PlaceholderText = ""
        Me.txtLocation.SelectedText = ""
        Me.txtLocation.Size = New System.Drawing.Size(165, 36)
        Me.txtLocation.TabIndex = 2
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Checked = True
        Me.dtpStartDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpStartDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(171, 475)
        Me.dtpStartDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpStartDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(129, 36)
        Me.dtpStartDate.TabIndex = 3
        Me.dtpStartDate.Value = New Date(2024, 9, 8, 0, 33, 46, 254)
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Checked = True
        Me.dtpEndDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpEndDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEndDate.Location = New System.Drawing.Point(430, 475)
        Me.dtpEndDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpEndDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(135, 36)
        Me.dtpEndDate.TabIndex = 4
        Me.dtpEndDate.Value = New Date(2024, 9, 8, 0, 34, 9, 462)
        '
        'btnPostJob
        '
        Me.btnPostJob.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPostJob.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPostJob.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPostJob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPostJob.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnPostJob.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPostJob.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPostJob.Location = New System.Drawing.Point(308, 548)
        Me.btnPostJob.Name = "btnPostJob"
        Me.btnPostJob.Size = New System.Drawing.Size(125, 45)
        Me.btnPostJob.TabIndex = 5
        Me.btnPostJob.Text = "POST"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(176, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Job Title"
        '
        'EndDate
        '
        Me.EndDate.AutoSize = True
        Me.EndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDate.Location = New System.Drawing.Point(460, 452)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(80, 20)
        Me.EndDate.TabIndex = 9
        Me.EndDate.Text = "EndDate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(185, 452)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "StartDate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(207, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 24)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "JobDescription"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(387, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Location"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label2)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtProposedPayment)
        Me.Guna2ShadowPanel1.Controls.Add(Me.dtpEndDate)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label6)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtJobTitle)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label5)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtJobDescription)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label4)
        Me.Guna2ShadowPanel1.Controls.Add(Me.txtLocation)
        Me.Guna2ShadowPanel1.Controls.Add(Me.EndDate)
        Me.Guna2ShadowPanel1.Controls.Add(Me.dtpStartDate)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btnPostJob)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(236, 25)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 5
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ShadowPanel1.ShadowDepth = 200
        Me.Guna2ShadowPanel1.ShadowShift = 10
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(754, 608)
        Me.Guna2ShadowPanel1.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Proposed Payment"
        '
        'txtProposedPayment
        '
        Me.txtProposedPayment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProposedPayment.DefaultText = ""
        Me.txtProposedPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProposedPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProposedPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProposedPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProposedPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProposedPayment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtProposedPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProposedPayment.Location = New System.Drawing.Point(171, 165)
        Me.txtProposedPayment.Name = "txtProposedPayment"
        Me.txtProposedPayment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProposedPayment.PlaceholderText = ""
        Me.txtProposedPayment.SelectedText = ""
        Me.txtProposedPayment.Size = New System.Drawing.Size(191, 36)
        Me.txtProposedPayment.TabIndex = 13
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 652)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1337, 61)
        Me.Guna2Panel1.TabIndex = 58
        '
        'jobspost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1337, 713)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "jobspost"
        Me.Text = ","
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtJobTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtJobDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLocation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpStartDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents dtpEndDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnPostJob As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EndDate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProposedPayment As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
