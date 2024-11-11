Imports MySql.Data.MySqlClient
Imports System.IO

Public Class employeehome

    ' Declare a Timer for real-time image updates
    Private WithEvents ImageUpdateTimer As New Timer()

    Private Sub Employeehome_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Fetch and display the message count when the form loads
        Dim messageCount As Integer = GetMessageCount()
        lblMessageCount.Text = messageCount.ToString() ' Assuming lblMessageCount is a label to display the count

        ' Set timer interval to 5 seconds (5000 ms) for real-time image updates
        ImageUpdateTimer.Interval = 5000
        ImageUpdateTimer.Start()

        ' Load the initial image when the form loads
        LoadBackgroundImageForUser()
        LoadEmployeeDetails(Home.LoggedInUsername)
        ' Load and display the user's details (first name, last name, profile picture)
        LoadUserDetails()
    End Sub

    ' Function to fetch message count for the logged-in user
    Private Function GetMessageCount() As Integer
        Dim messageCount As Integer = 0
        Dim connectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Directly count the messages in the notifications table using the Username
                Dim messageQuery As String = "SELECT COUNT(*) FROM notifications WHERE EmployeeUsername = @EmployeeUsername"

                Using cmd As New MySqlCommand(messageQuery, connection)
                    cmd.Parameters.AddWithValue("@EmployeeUsername", Home.LoggedInUsername)
                    messageCount = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

        Return messageCount
    End Function

    ' Timer Tick event for real-time image updates
    Private Sub ImageUpdateTimer_Tick(sender As Object, e As EventArgs) Handles ImageUpdateTimer.Tick
        LoadBackgroundImageForUser()
    End Sub

    ' Function to load background image for the logged-in user
    Private Sub LoadBackgroundImageForUser()
        Dim connectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Query to get the background image from the database
                Dim commandText As String = "SELECT bgimage FROM employee WHERE Username = @Username"
                Using cmd As New MySqlCommand(commandText, connection)
                    cmd.Parameters.AddWithValue("@Username", Home.LoggedInUsername)

                    ' Retrieve the BLOB data (image) from the database
                    Dim imageBytes As Byte() = CType(cmd.ExecuteScalar(), Byte())

                    ' Check if the data exists
                    If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                        ' Convert byte array to Image object
                        Using ms As New MemoryStream(imageBytes)
                            Dim backgroundImage As Image = Image.FromStream(ms)

                            ' Set the image as the background for Guna2Panel3
                            Guna2Panel3.BackgroundImage = backgroundImage
                            Guna2Panel3.BackgroundImageLayout = ImageLayout.Stretch
                        End Using
                    Else
                        MessageBox.Show("No background image found in the database.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load background image: " & ex.Message)
        End Try
    End Sub

    ' Function to load the user's details and display them
    Private Sub LoadUserDetails()
        Dim connectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Query to get the user's first name, second name, and profile picture
                Dim query As String = "SELECT FirstName, secondname, ProfilePicture FROM employee WHERE Username = @Username"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Username", Home.LoggedInUsername)

                    ' Retrieve the user details
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Display the user's first name and last name
                            lblfname.Text = reader("FirstName").ToString()
                            lblsname.Text = reader("secondname").ToString()

                            ' Load the profile picture
                            If Not IsDBNull(reader("ProfilePicture")) Then
                                Dim profileImageBytes As Byte() = CType(reader("ProfilePicture"), Byte())
                                Using ms As New MemoryStream(profileImageBytes)
                                    Guna2CirclePictureBox1.Image = Image.FromStream(ms)
                                End Using
                            End If

                            ' Display the employee's average rating using the Username
                            LoadEmployeeDetails(Home.LoggedInUsername)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load user details: " & ex.Message)
        End Try
    End Sub

    Private Function GetAverageRating(username As String) As Double
        Dim avgRating As Double = 0.0
        ' Query to calculate average rating for an employee using employeeusername
        Dim query As String = "SELECT AVG(rating) AS AverageRating FROM reviews WHERE employeeusername = @Username"

        Using conn As New MySqlConnection("Server=localhost;Database=ajira;Uid=root;Pwd=;")
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", username)

                Try
                    conn.Open()
                    Dim result = cmd.ExecuteScalar()
                    If Not IsDBNull(result) Then
                        avgRating = Convert.ToDouble(result)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error fetching average rating: " & ex.Message)
                End Try
            End Using
        End Using

        Return avgRating
    End Function

    Private Sub DisplayAverageRating(username As String)
        ' Get the average rating from the database
        Dim avgRating As Double = GetAverageRating(username)

        ' Assuming ratings are out of 5, convert to percentage for the progress bar (0-100)
        Dim percentage As Integer = CInt((avgRating / 5) * 100)

        ' Set the value of the Guna circular progress bar
        gunaCircularProgressBar.Value = percentage
        gunaCircularProgressBar.Text = avgRating.ToString("0.00") & " / 5.0" ' Display the average rating in the circular progress bar

        ' Set the value of the label to display the numeric average rating
        Lblrating.Text = "Average Rating:" & Environment.NewLine & avgRating.ToString("0.00") & " / 5.0"
    End Sub
    Private Sub InitializeForm()
        ' Assuming you have already placed lblRating on the form
        Lblrating.Font = New Font("Arial", 12, FontStyle.Bold)
        Lblrating.ForeColor = Color.DarkBlue
        Lblrating.AutoSize = True
    End Sub

    Private Sub LoadEmployeeDetails(username As String)
        ' Display the average rating using the Username
        DisplayAverageRating(username)
    End Sub
    Private Sub DisplayJobListings()
        Dim connectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"
        Dim query As String = "
        SELECT jobtitle, jobdescription, location, start_date, end_date, ProposedPayment 
        FROM job_posts"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Fetch all job posts
                Using cmd As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Clear existing controls from GunaPanel1
                        GunaPanel.Controls.Clear()

                        ' Loop through the job posts and display them
                        While reader.Read()
                            ' Create controls dynamically for each job post
                            Dim jobPanel As New Guna.UI2.WinForms.Guna2Panel()
                            jobPanel.Size = New Size(GunaPanel.Width - 20, 100)
                            jobPanel.Padding = New Padding(10)
                            jobPanel.Margin = New Padding(5)
                            jobPanel.BorderStyle = BorderStyle.FixedSingle

                            ' Add job title label
                            Dim jobTitleLabel As New Label()
                            jobTitleLabel.Text = "Job Title: " & reader("jobtitle").ToString()
                            jobTitleLabel.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                            jobTitleLabel.ForeColor = Color.Black
                            jobTitleLabel.AutoSize = True

                            ' Add job description label
                            Dim jobDescriptionLabel As New Label()
                            jobDescriptionLabel.Text = "Description: " & reader("jobdescription").ToString()
                            jobDescriptionLabel.Font = New Font("Segoe UI", 9, FontStyle.Regular)
                            jobDescriptionLabel.ForeColor = Color.Black
                            jobDescriptionLabel.AutoSize = True

                            ' Add location label
                            Dim locationLabel As New Label()
                            locationLabel.Text = "Location: " & reader("location").ToString()
                            locationLabel.Font = New Font("Segoe UI", 9, FontStyle.Regular)
                            locationLabel.ForeColor = Color.Black
                            locationLabel.AutoSize = True

                            ' Add start and end date label
                            Dim dateLabel As New Label()
                            dateLabel.Text = "Start Date: " & Convert.ToDateTime(reader("start_date")).ToString("d") &
                                             " - End Date: " & Convert.ToDateTime(reader("end_date")).ToString("d")
                            dateLabel.Font = New Font("Segoe UI", 9, FontStyle.Regular)
                            dateLabel.ForeColor = Color.Black
                            dateLabel.AutoSize = True

                            ' Add proposed payment label
                            Dim paymentLabel As New Label()
                            paymentLabel.Text = "Proposed Payment: " & reader("ProposedPayment").ToString()
                            paymentLabel.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                            paymentLabel.ForeColor = Color.Green
                            paymentLabel.AutoSize = True

                            ' Add the labels to the jobPanel
                            jobPanel.Controls.Add(jobTitleLabel)
                            jobPanel.Controls.Add(jobDescriptionLabel)
                            jobPanel.Controls.Add(locationLabel)
                            jobPanel.Controls.Add(dateLabel)
                            jobPanel.Controls.Add(paymentLabel)

                            ' Arrange the labels vertically
                            jobTitleLabel.Location = New Point(10, 10)
                            jobDescriptionLabel.Location = New Point(10, 30)
                            locationLabel.Location = New Point(10, 50)
                            dateLabel.Location = New Point(10, 70)
                            paymentLabel.Location = New Point(10, 90)

                            ' Add the jobPanel to the GunaPanel1
                            GunaPanel.Controls.Add(jobPanel)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load job listings: " & ex.Message)
        End Try
    End Sub


End Class
