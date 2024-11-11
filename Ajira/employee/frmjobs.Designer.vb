<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmJobs
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
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnexport = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvJobs = New System.Windows.Forms.DataGridView()
        Me.txtFilter = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.dgvJobs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(1128, 597)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button1.TabIndex = 2
        Me.Guna2Button1.Text = "close"
        '
        'btnexport
        '
        Me.btnexport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnexport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnexport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnexport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnexport.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnexport.ForeColor = System.Drawing.Color.White
        Me.btnexport.Location = New System.Drawing.Point(1128, 654)
        Me.btnexport.Name = "btnexport"
        Me.btnexport.Size = New System.Drawing.Size(180, 45)
        Me.btnexport.TabIndex = 3
        Me.btnexport.Text = "Export"
        '
        'dgvJobs
        '
        Me.dgvJobs.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJobs.Location = New System.Drawing.Point(632, 12)
        Me.dgvJobs.Name = "dgvJobs"
        Me.dgvJobs.Size = New System.Drawing.Size(688, 484)
        Me.dgvJobs.TabIndex = 4
        '
        'txtFilter
        '
        Me.txtFilter.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFilter.DefaultText = ""
        Me.txtFilter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilter.Location = New System.Drawing.Point(743, 521)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFilter.PlaceholderText = ""
        Me.txtFilter.SelectedText = ""
        Me.txtFilter.Size = New System.Drawing.Size(167, 36)
        Me.txtFilter.TabIndex = 5
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.Ajira.My.Resources.Resources.blue_01
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-14, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(640, 721)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'frmJobs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1337, 713)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.dgvJobs)
        Me.Controls.Add(Me.btnexport)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmJobs"
        Me.Text = "frmjobs"
        CType(Me.dgvJobs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnexport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgvJobs As DataGridView
    Friend WithEvents txtFilter As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
