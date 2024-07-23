<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class services
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
        Me.btncreateaccButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.SuspendLayout()
        '
        'btncreateaccButton
        '
        Me.btncreateaccButton.Animated = True
        Me.btncreateaccButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btncreateaccButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btncreateaccButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btncreateaccButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btncreateaccButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btncreateaccButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btncreateaccButton.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.btncreateaccButton.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btncreateaccButton.ForeColor = System.Drawing.Color.White
        Me.btncreateaccButton.Location = New System.Drawing.Point(307, 202)
        Me.btncreateaccButton.Name = "btncreateaccButton"
        Me.btncreateaccButton.Size = New System.Drawing.Size(186, 47)
        Me.btncreateaccButton.TabIndex = 13
        Me.btncreateaccButton.Text = "services"
        '
        'services
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btncreateaccButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "services"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btncreateaccButton As Guna.UI2.WinForms.Guna2GradientButton
End Class
