<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMessages
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
        Me.btnMarkAsRead = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReply = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cboContacts = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'btnMarkAsRead
        '
        Me.btnMarkAsRead.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMarkAsRead.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMarkAsRead.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMarkAsRead.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMarkAsRead.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMarkAsRead.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnMarkAsRead.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMarkAsRead.ForeColor = System.Drawing.Color.White
        Me.btnMarkAsRead.Location = New System.Drawing.Point(1022, 548)
        Me.btnMarkAsRead.Name = "btnMarkAsRead"
        Me.btnMarkAsRead.Size = New System.Drawing.Size(180, 45)
        Me.btnMarkAsRead.TabIndex = 1
        Me.btnMarkAsRead.Text = "MarkAsRead"
        '
        'btnReply
        '
        Me.btnReply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReply.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReply.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReply.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.btnReply.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReply.ForeColor = System.Drawing.Color.White
        Me.btnReply.Location = New System.Drawing.Point(1022, 599)
        Me.btnReply.Name = "btnReply"
        Me.btnReply.Size = New System.Drawing.Size(180, 45)
        Me.btnReply.TabIndex = 2
        Me.btnReply.Text = "Reply"
        '
        'cboContacts
        '
        Me.cboContacts.BackColor = System.Drawing.Color.Transparent
        Me.cboContacts.BorderColor = System.Drawing.Color.Black
        Me.cboContacts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboContacts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContacts.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboContacts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboContacts.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboContacts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cboContacts.ItemHeight = 30
        Me.cboContacts.Location = New System.Drawing.Point(1022, 467)
        Me.cboContacts.Name = "cboContacts"
        Me.cboContacts.Size = New System.Drawing.Size(180, 36)
        Me.cboContacts.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1024, 446)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select Contact"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(992, 632)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'frmMessages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1225, 657)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboContacts)
        Me.Controls.Add(Me.btnReply)
        Me.Controls.Add(Me.btnMarkAsRead)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMessages"
        Me.Text = ","
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnMarkAsRead As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReply As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cboContacts As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
