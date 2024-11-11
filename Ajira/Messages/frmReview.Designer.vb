<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReview
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
        Me.txtReview = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.nudRating = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.lblEmployeeUsername = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'txtReview
        '
        Me.txtReview.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReview.DefaultText = ""
        Me.txtReview.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtReview.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtReview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReview.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReview.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReview.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtReview.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReview.Location = New System.Drawing.Point(427, 114)
        Me.txtReview.Name = "txtReview"
        Me.txtReview.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReview.PlaceholderText = "Enter Review"
        Me.txtReview.SelectedText = ""
        Me.txtReview.Size = New System.Drawing.Size(538, 276)
        Me.txtReview.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.Ajira.My.Resources.Resources.blue_01
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(3, -8)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(425, 568)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'nudRating
        '
        Me.nudRating.BackColor = System.Drawing.Color.Transparent
        Me.nudRating.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nudRating.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nudRating.Location = New System.Drawing.Point(434, 424)
        Me.nudRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudRating.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudRating.Name = "nudRating"
        Me.nudRating.Size = New System.Drawing.Size(136, 38)
        Me.nudRating.TabIndex = 2
        Me.nudRating.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(434, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Review Text"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(446, 401)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Rating"
        '
        'btnSubmit
        '
        Me.btnSubmit.AutoRoundedCorners = True
        Me.btnSubmit.BorderRadius = 21
        Me.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(766, 473)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(180, 45)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit Review"
        '
        'lblEmployeeUsername
        '
        Me.lblEmployeeUsername.AutoSize = True
        Me.lblEmployeeUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeUsername.Location = New System.Drawing.Point(434, 56)
        Me.lblEmployeeUsername.Name = "lblEmployeeUsername"
        Me.lblEmployeeUsername.Size = New System.Drawing.Size(53, 20)
        Me.lblEmployeeUsername.TabIndex = 6
        Me.lblEmployeeUsername.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(434, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Employee Username"
        '
        'frmReview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 560)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblEmployeeUsername)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtReview)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudRating)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReview"
        Me.Text = ","
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label2 As Label
    Friend WithEvents txtReview As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nudRating As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblEmployeeUsername As Label
End Class
