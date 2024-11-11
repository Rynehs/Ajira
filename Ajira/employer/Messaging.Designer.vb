<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Messaging
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
        Me.TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPageInbox = New System.Windows.Forms.TabPage()
        Me.DataGridViewSentMessages = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridViewReceivedMessages = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPageInbox.SuspendLayout()
        CType(Me.DataGridViewSentMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewReceivedMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageInbox)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1337, 713)
        Me.TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'TabPageInbox
        '
        Me.TabPageInbox.Controls.Add(Me.DataGridViewSentMessages)
        Me.TabPageInbox.Location = New System.Drawing.Point(4, 44)
        Me.TabPageInbox.Name = "TabPageInbox"
        Me.TabPageInbox.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageInbox.Size = New System.Drawing.Size(1329, 665)
        Me.TabPageInbox.TabIndex = 0
        Me.TabPageInbox.Text = "Sent Messages"
        Me.TabPageInbox.UseVisualStyleBackColor = True
        '
        'DataGridViewSentMessages
        '
        Me.DataGridViewSentMessages.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewSentMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSentMessages.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridViewSentMessages.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewSentMessages.Name = "DataGridViewSentMessages"
        Me.DataGridViewSentMessages.Size = New System.Drawing.Size(1329, 699)
        Me.DataGridViewSentMessages.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridViewReceivedMessages)
        Me.TabPage2.Location = New System.Drawing.Point(4, 184)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1329, 525)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Received Messages"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridViewReceivedMessages
        '
        Me.DataGridViewReceivedMessages.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewReceivedMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewReceivedMessages.GridColor = System.Drawing.SystemColors.Control
        Me.DataGridViewReceivedMessages.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewReceivedMessages.Name = "DataGridViewReceivedMessages"
        Me.DataGridViewReceivedMessages.Size = New System.Drawing.Size(1143, 699)
        Me.DataGridViewReceivedMessages.TabIndex = 0
        '
        'Messaging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1337, 713)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Messaging"
        Me.Text = ","
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageInbox.ResumeLayout(False)
        CType(Me.DataGridViewSentMessages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridViewReceivedMessages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPageInbox As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridViewSentMessages As DataGridView
    Friend WithEvents DataGridViewReceivedMessages As DataGridView
End Class
