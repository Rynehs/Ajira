Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class frmMessages
    ' Form-level variables
    Private selectedContact As String = String.Empty

    Private Sub FrmMessages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadContacts()
        FlowLayoutPanel1.AutoScroll = True ' Enable scrolling for the chat view
    End Sub

    ' Function to load messages and display them as chat bubbles
    Private Sub LoadMessages()
        If String.IsNullOrEmpty(selectedContact) Then
            MessageBox.Show("Please select a contact to view the conversation.")
            Return
        End If

        Dim connectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"
        Dim username As String = Home.LoggedInUsername

        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            ' Query to retrieve messages between the logged-in user and the selected contact
            Dim query As String = "SELECT Message, DateSent, EmployerUsername " &
                                  "FROM notifications " &
                                  "WHERE (EmployeeUsername = @EmployeeUsername AND EmployerUsername = @ContactUsername) " &
                                  "OR (EmployeeUsername = @ContactUsername AND EmployerUsername = @EmployeeUsername) " &
                                  "ORDER BY DateSent ASC"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EmployeeUsername", username)
                cmd.Parameters.AddWithValue("@ContactUsername", selectedContact)

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Clear existing messages
                FlowLayoutPanel1.Controls.Clear()


                For Each row As DataRow In dt.Rows
                    Dim message As String = row("Message").ToString()
                    Dim dateSent As DateTime = Convert.ToDateTime(row("DateSent"))
                    Dim sender As String = row("EmployerUsername").ToString()

                    ' Create a new message bubble (Panel)
                    Dim messageBubble As New Panel With {
                        .Padding = New Padding(10),
                        .Margin = New Padding(5),
                        .AutoSize = True,
                        .AutoScroll = True,
                        .MaximumSize = New Size(400, 0) ' Increase the max width for the bubble
                    }

                    ' Create a label to indicate whether the message was sent or received
                    Dim lblType As New Label With {
                        .AutoSize = True,
                        .Font = New Font("Arial", 9, FontStyle.Bold),
                        .Padding = New Padding(0, 0, 0, 5) ' Add padding below the label for spacing
                    }

                    ' Determine if the message was sent by the logged-in user or received
                    If sender = username Then
                        lblType.Text = "Sent"
                        lblType.ForeColor = Color.Blue
                    Else
                        lblType.Text = "Received"
                        lblType.ForeColor = Color.Green
                    End If

                    messageBubble.Controls.Add(lblType) ' Add the label to the message bubble

                    ' Create a Label for the message content
                    Dim lblMessage As New Label With {
                        .Text = message,
                        .AutoSize = True,
                        .MaximumSize = New Size(350, 0), ' Increase the max width for the message content
                        .Font = New Font("Arial", 10, FontStyle.Regular)
                    }
                    messageBubble.Controls.Add(lblMessage)

                    ' Create a Label for the date sent
                    Dim lblDate As New Label With {
                        .Text = dateSent.ToString("g"),
                        .AutoSize = True,
                        .ForeColor = Color.Gray,
                        .Font = New Font("Arial", 8),
                        .Padding = New Padding(5, 0, 0, 0)
                    }
                    messageBubble.Controls.Add(lblDate)

                    ' Create a Reply button for each message bubble
                    Dim btnReplyToMessage As New Button With {
                        .Text = "Reply",
                        .Tag = message, ' Store the message content in the button's Tag property
                        .AutoSize = True,
                        .Margin = New Padding(5)
                    }
                    AddHandler btnReplyToMessage.Click, AddressOf BtnReplyToMessage_Click
                    messageBubble.Controls.Add(btnReplyToMessage)

                    ' Style and align the message bubble
                    If sender = username Then
                        ' Message sent by logged-in user (right-aligned)
                        messageBubble.BackColor = Color.LightBlue
                        messageBubble.Dock = DockStyle.Right
                        lblMessage.ForeColor = Color.Black
                    Else
                        ' Message received from the contact (left-aligned)
                        messageBubble.BackColor = Color.LightGray
                        messageBubble.Dock = DockStyle.Left
                        lblMessage.ForeColor = Color.Black
                    End If

                    ' Add the message bubble to the FlowLayoutPanel
                    FlowLayoutPanel1.Controls.Add(messageBubble)
                Next


            End Using
        End Using
    End Sub
    Private Sub BtnReplyToMessage_Click(sender As Object, e As EventArgs)
        ' Retrieve the message from the button's Tag property
        Dim selectedMessage As String = CType(sender, Button).Tag.ToString()

        ' Open the reply form, passing the selected message as a reference
        Using replyForm As New frmReply(selectedContact, Home.LoggedInUsername, selectedMessage)
            If replyForm.ShowDialog() = DialogResult.OK Then
                LoadMessages() ' Refresh the conversation after sending a reply
            End If
        End Using
    End Sub

    ' Load contacts into the ComboBox for selection
    Private Sub LoadContacts()
        Dim connectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"
        Dim username As String = Home.LoggedInUsername

        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            ' Query to get distinct contacts for the logged-in user
            Dim query As String = "SELECT DISTINCT EmployerUsername " &
                                  "FROM notifications " &
                                  "WHERE EmployeeUsername = @EmployeeUsername " &
                                  "OR EmployerUsername = @EmployeeUsername"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EmployeeUsername", username)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim contact As String = reader("EmployerUsername").ToString()
                    cboContacts.Items.Add(contact)
                End While
            End Using
        End Using
    End Sub

    ' Handle contact selection to load the conversation
    Private Sub CboContacts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboContacts.SelectedIndexChanged
        selectedContact = cboContacts.SelectedItem.ToString()
        LoadMessages()
    End Sub

    ' Handle Reply Button Click
    Private Sub BtnReply_Click(sender As Object, e As EventArgs) Handles btnReply.Click
        If String.IsNullOrEmpty(selectedContact) Then
            MessageBox.Show("Please select a contact to reply to.")
            Return
        End If

        Using replyForm As New frmReply(selectedContact, Home.LoggedInUsername)
            If replyForm.ShowDialog() = DialogResult.OK Then
                LoadMessages() ' Refresh the conversation after sending a reply
            End If
        End Using
    End Sub




End Class
