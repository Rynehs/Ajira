Imports MySql.Data.MySqlClient

Public Class jobmessage

    Dim connectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"
    Private employerUsername As String

    ' Constructor to accept employer ID
    Public Sub New(ByVal username As String)
        ' This call is required by the designer.
        InitializeComponent()


        employerUsername = username
    End Sub

    ' Method to send the message
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim message As String = txtMessage.Text
        Dim employeeUsername As String = Home.LoggedInUsername ' Use the logged-in employee username

        ' Validate if the message is not empty
        If String.IsNullOrWhiteSpace(message) Then
            MessageBox.Show("Please enter a message.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Insert the message into the notifications table
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim query As String = "INSERT INTO jobnotifications (employeeusername, employerusername, message, notification_date) " &
                                      "VALUES (@employeeusername, @employerusername, @message, NOW())"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@employeeusername", employeeUsername) ' Employee's username is the sender
                    cmd.Parameters.AddWithValue("@employerusername", employerUsername) ' Employer is the receiver
                    cmd.Parameters.AddWithValue("@message", message)

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Message sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End Using
            Catch ex As MySqlException
                MessageBox.Show("An error occurred while sending the message: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

End Class
