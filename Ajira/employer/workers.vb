Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Frmworkers
    Private loadedRecords As Integer = 0 ' Track loaded records
    Private Const batchSize As Integer = 5 ' Load 5 workers at a time

    Private Sub Frmworkers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanel1.AutoScroll = True ' Enable scrolling
        LoadWorkers() ' Load initial batch of workers
        AddHandler FlowLayoutPanel1.Scroll, AddressOf FlowLayoutPanel1_Scroll ' Handle scrolling for lazy loading
    End Sub

    Private Sub LoadWorkers(Optional offset As Integer = 0)
        Dim connectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"

        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            ' Query to fetch worker details and calculate the average rating from the reviews table
            Dim query As String = "SELECT e.username, e.ProfilePicture, e.availability, e.Location, e.skills, " &
                              "COALESCE(AVG(r.rating), 0) AS average_rating " &
                              "FROM employee e " &
                              "LEFT JOIN reviews r ON e.username = r.employeeusername " &
                              "GROUP BY e.username, e.ProfilePicture, e.availability, e.Location, e.skills " &
                              "ORDER BY average_rating DESC " &
                              "LIMIT @batchSize OFFSET @offset"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@batchSize", batchSize)
                cmd.Parameters.AddWithValue("@offset", offset)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' Get worker details from the database
                        Dim username As String = reader("username").ToString()
                        Dim availability As String = reader("availability").ToString()
                        Dim location As String = reader("Location").ToString()
                        Dim skills As String = reader("skills").ToString()
                        Dim averageRating As Double = Convert.ToDouble(reader("average_rating"))
                        Dim profilePic As Byte() = If(reader("ProfilePicture") IsNot DBNull.Value, CType(reader("ProfilePicture"), Byte()), Nothing)

                        ' Add worker to the FlowLayoutPanel
                        AddWorkerToPanel(username, profilePic, availability, location, skills, averageRating)
                    End While
                End Using
            End Using
        End Using

        loadedRecords += batchSize ' Update the loaded records count
    End Sub


    Private Sub AddWorkerToPanel(username As String, profilePic As Byte(), availability As String, location As String, skills As String, rating As Double)
        ' Create a Panel for each worker
        Dim workerPanel As New Panel With {
            .Size = New Size(300, 200),
            .BackColor = Color.LightGray,
            .Margin = New Padding(10)
        }

        ' Create PictureBox for profile picture
        Dim pbProfilePic As New PictureBox With {
            .Size = New Size(80, 80),
            .Location = New Point(10, 10),
            .SizeMode = PictureBoxSizeMode.Zoom
        }
        If profilePic IsNot Nothing Then
            Using ms As New MemoryStream(profilePic)
                pbProfilePic.Image = Image.FromStream(ms)
            End Using
        End If

        ' Create Label for username
        Dim lblUsername As New Label With {
            .Text = "Username: " & username,
            .AutoSize = True,
            .Location = New Point(100, 10)
        }

        ' Create Label for availability
        Dim lblAvailability As New Label With {
            .Text = "Availability: " & availability,
            .AutoSize = True,
            .Location = New Point(100, 30)
        }

        ' Create Label for location
        Dim lblLocation As New Label With {
            .Text = "Location: " & location,
            .AutoSize = True,
            .Location = New Point(100, 50)
        }

        ' Create Label for skills
        Dim lblSkills As New Label With {
            .Text = "Skills: " & skills,
            .AutoSize = True,
            .Location = New Point(100, 70)
        }

        ' Create Label for average rating
        Dim lblRating As New Label With {
            .Text = "Rating: " & rating.ToString("F1"),
            .AutoSize = True,
            .Location = New Point(100, 90)
        }

        ' Create buttons for actions (e.g., View, Contact, Review)
        Dim btnView As New Button With {
            .Text = "View",
            .Location = New Point(10, 150),
            .Tag = username ' Use username as the Tag
        }
        AddHandler btnView.Click, AddressOf BtnView_Click

        Dim btnContact As New Button With {
            .Text = "Contact",
            .Location = New Point(100, 150),
            .Tag = username ' Use username as the Tag
        }
        AddHandler btnContact.Click, AddressOf BtnContact_Click

        Dim btnReview As New Button With {
            .Text = "Review",
            .Location = New Point(190, 150),
            .Tag = username ' Use username as the Tag
        }
        AddHandler btnReview.Click, AddressOf BtnReview_Click

        ' Add controls to the worker panel
        workerPanel.Controls.Add(pbProfilePic)
        workerPanel.Controls.Add(lblUsername)
        workerPanel.Controls.Add(lblAvailability)
        workerPanel.Controls.Add(lblLocation)
        workerPanel.Controls.Add(lblSkills)
        workerPanel.Controls.Add(lblRating)
        workerPanel.Controls.Add(btnView)
        workerPanel.Controls.Add(btnContact)
        workerPanel.Controls.Add(btnReview)

        ' Add worker panel to the FlowLayoutPanel
        FlowLayoutPanel1.Controls.Add(workerPanel)
    End Sub

    Private Sub BtnView_Click(sender As Object, e As EventArgs)
        Dim username As String = DirectCast(DirectCast(sender, Button).Tag, String)
        ' Open the frmpopup form with the selected worker's details using the username
        Using popup As New Frmpopup(username)
            popup.ShowDialog()
        End Using
    End Sub

    Private Sub BtnContact_Click(sender As Object, e As EventArgs)
        Dim username As String = DirectCast(DirectCast(sender, Button).Tag, String)
        ' Open message form
        Using messageForm As New frmMessageSelection()
            If messageForm.ShowDialog() = DialogResult.OK Then
                ' Send message using username instead of userId
                SendNotification(username, CurrentEmployerUsername, messageForm.SelectedMessage)
                MessageBox.Show("Notification sent.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    Private Sub BtnReview_Click(sender As Object, e As EventArgs)
        Dim username As String = DirectCast(sender, Button).Tag.ToString() ' Get the username from the button's tag
        ' Open the review form, passing the employee username and the current employer username
        Using reviewForm As New frmReview(username, CurrentEmployerUsername)
            reviewForm.ShowDialog() ' Show the form as a dialog
        End Using
    End Sub

    ' Helper function to get the current employer's username
    Private ReadOnly Property CurrentEmployerUsername As String
        Get
            Return Home.LoggedInUsername ' Return the currently logged-in employer's username
        End Get
    End Property

    Private Sub SendNotification(employeeUsername As String, employerUsername As String, message As String)
        Dim connectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "INSERT INTO notifications (EmployeeUsername, EmployerUsername, Message, DateSent) VALUES (@EmployeeUsername, @EmployerUsername, @Message, @DateSent)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EmployeeUsername", employeeUsername) ' Use username
                cmd.Parameters.AddWithValue("@EmployerUsername", employerUsername) ' Use username
                cmd.Parameters.AddWithValue("@Message", message)
                cmd.Parameters.AddWithValue("@DateSent", DateTime.Now)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Handle lazy loading on scrolling
    Private Sub FlowLayoutPanel1_Scroll(sender As Object, e As ScrollEventArgs)
        If FlowLayoutPanel1.VerticalScroll.Value + FlowLayoutPanel1.VerticalScroll.LargeChange >= FlowLayoutPanel1.VerticalScroll.Maximum Then
            ' Load more workers when scrolled to the bottom
            LoadWorkers(loadedRecords)
        End If
    End Sub

    ' Get the current employer's username (logic depends on your login system)
    Private Function GetCurrentEmployerUsername() As String
        ' Logic to retrieve current employer's username from the session
        Return Home.LoggedInUsername ' Example: return the employer's username
    End Function
End Class
