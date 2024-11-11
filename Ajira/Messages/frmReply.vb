Imports MySql.Data.MySqlClient

Public Class frmReply
    Private selectedContact As String
    Private loggedInUsername As String
    Private selectedMessage As String

    Public Sub New(selectedContact As String, loggedInUsername As String)
        Me.selectedContact = selectedContact
        Me.loggedInUsername = loggedInUsername
    End Sub

    ' Constructor to initialize with selected contact, user, and the selected message
    Public Sub New(contact As String, username As String, message As String)
        InitializeComponent()
        selectedContact = contact
        loggedInUsername = username
        selectedMessage = message

        ' Display the selected message as reference (optional)
        lblSelectedMessage.Text = "Replying to: " & selectedMessage
    End Sub

    ' Handle the Send Reply Button Click
    Private Sub BtnSendReply_Click(sender As Object, e As EventArgs) Handles btnSendReply.Click
        Dim replyMessage As String = txtReplyMessage.Text.Trim()

        If String.IsNullOrEmpty(replyMessage) Then
            MessageBox.Show("Please enter a message to reply.")
            Return
        End If

        ' Insert reply into the reply table
        Dim connectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"
        Dim query As String = "INSERT INTO reply (OriginalMessage, ReplyMessage, DateSent, EmployeeUsername, EmployerUsername) " &
                              "VALUES (@OriginalMessage, @ReplyMessage, @DateSent, @EmployeeUsername, @EmployerUsername)"

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@OriginalMessage", selectedMessage) ' Use selectedMessage here
                    cmd.Parameters.AddWithValue("@ReplyMessage", replyMessage)
                    cmd.Parameters.AddWithValue("@DateSent", DateTime.Now)
                    cmd.Parameters.AddWithValue("@EmployeeUsername", loggedInUsername)
                    cmd.Parameters.AddWithValue("@EmployerUsername", selectedContact)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Reply sent successfully!")
            DialogResult = DialogResult.OK ' Close the form and return OK status
        Catch ex As Exception
            MessageBox.Show("Error sending reply: " & ex.Message)
        End Try
    End Sub
End Class
