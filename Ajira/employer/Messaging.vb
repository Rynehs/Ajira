Imports MySql.Data.MySqlClient

Public Class Messaging
    ' Assuming you have a connection string defined
    Private connectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"
    Private Sub Messaging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the logged-in employer's username from the Home form
        Dim loggedInEmployerUsername As String = Home.LoggedInUsername ' Replace with actual reference to logged-in username

        ' Load sent and received messages into the respective tabs
        LoadSentMessages(loggedInEmployerUsername)
        LoadReceivedMessages(loggedInEmployerUsername)
    End Sub

    ' Load messages sent by the logged-in employer
    Private Sub LoadSentMessages(employerUsername As String)
        Dim query As String = "SELECT IsRead, EmployeeUsername, Message, EmployerUsername 
                               FROM notifications
                               WHERE EmployerUsername = @employerUsername
                               ORDER BY IsRead ASC, EmployeeUsername ASC"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@employerUsername", employerUsername)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    ' Bind data to the DataGridView in the "Sent Messages" tab
                    DataGridViewSentMessages.DataSource = dt

                    ' Optionally customize columns
                    DataGridViewSentMessages.Columns("IsRead").HeaderText = "Read Status"
                    DataGridViewSentMessages.Columns("EmployeeUsername").HeaderText = "Employee"
                    DataGridViewSentMessages.Columns("Message").HeaderText = "Message"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading sent messages: " & ex.Message)
        End Try
    End Sub

    ' Load messages received by the logged-in employer
    Private Sub LoadReceivedMessages(employerUsername As String)
        Dim query As String = "SELECT IsRead, EmployeeUsername, Message, EmployerUsername 
                               FROM notifications
                               WHERE EmployeeUsername = @employerUsername
                               ORDER BY IsRead ASC, EmployerUsername ASC"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@employerUsername", employerUsername)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    ' Bind data to the DataGridView in the "Received Messages" tab
                    DataGridViewReceivedMessages.DataSource = dt

                    ' Optionally customize columns
                    DataGridViewReceivedMessages.Columns("IsRead").HeaderText = "Read Status"
                    DataGridViewReceivedMessages.Columns("EmployerUsername").HeaderText = "Employer"
                    DataGridViewReceivedMessages.Columns("Message").HeaderText = "Message"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading received messages: " & ex.Message)
        End Try
    End Sub
End Class
