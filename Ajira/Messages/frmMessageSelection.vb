Public Class frmMessageSelection
    Public Property SelectedMessage As String = ""
    Public Property IsCustomMessage As Boolean = False

    Private Sub btnUseSystemMessage_Click(sender As Object, e As EventArgs) Handles btnUseSystemMessage.Click
        SelectedMessage = "You have been contacted by an employer."
        IsCustomMessage = False
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnUseCustomMessage_Click(sender As Object, e As EventArgs) Handles btnUseCustomMessage.Click
        If String.IsNullOrWhiteSpace(txtCustomMessage.Text) Then
            MessageBox.Show("Please enter a custom message.")
            Return
        End If
        SelectedMessage = txtCustomMessage.Text
        IsCustomMessage = True
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
