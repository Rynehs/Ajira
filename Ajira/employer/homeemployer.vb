Imports System.IO
Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class Homeemployer
    Private ReadOnly connectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"
    Public Shared LoggedInUsername As String
    ' Function to convert an image to a byte array
    Private Function ImageToByteArray(ByVal image As Image) As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Return ms.ToArray()
        End Using
    End Function

    ' Function to update the image in the database
    Private Sub UpdateImageInDatabase(ByVal imageBytes As Byte())
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim commandText As String = "UPDATE registration SET images = @images WHERE Username = @Username"
            Using cmd As New MySqlCommand(commandText, connection)
                cmd.Parameters.AddWithValue("@images", imageBytes)
                cmd.Parameters.AddWithValue("@Username", Home.LoggedInUsername)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Function to load the user's image when they log in
    Private Sub LoadUserImage()
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            Dim commandText As String = "SELECT ProfilePicture FROM registration WHERE Username = @Username"
            Using cmd As New MySqlCommand(commandText, connection)
                cmd.Parameters.AddWithValue("@Username", Home.LoggedInUsername)
                Dim imageBytes As Byte() = CType(cmd.ExecuteScalar(), Byte())
                If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                    Using ms As New MemoryStream(imageBytes)
                        ' Load the image into the PictureBox
                        employerpic.Image = Image.FromStream(ms)
                        ' Ensure the image fits the PictureBox
                        employerpic.SizeMode = PictureBoxSizeMode.StretchImage
                    End Using
                End If
            End Using
        End Using
    End Sub

    ' Load employer details, contacted employees, and recently registered employees on form load
    Private Sub Homeemployer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployerDetails()
        LoadBackgroundImageForUser()
        LoadContactedEmployees()
    End Sub
    Private Sub LoadBackgroundImageForUser()
        Dim connectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Query to get the background image (stored as a BLOB) from the database
                Dim commandText As String = "SELECT bgimage FROM employer WHERE Username = @Username"
                Using cmd As New MySqlCommand(commandText, connection)
                    cmd.Parameters.AddWithValue("@Username", Home.LoggedInUsername)

                    ' Retrieve the BLOB data from the database
                    Dim imageBytes As Byte() = CType(cmd.ExecuteScalar(), Byte())

                    ' Check if data exists
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


    ' Function to load the employer details
    Private Sub LoadEmployerDetails()
        Using conn As New MySqlConnection(connectionString)
            ' Query to fetch ProfilePicture, FirstName, and SecondName from registration table
            Dim cmd As New MySqlCommand("SELECT ProfilePicture, firstname, secondname FROM registration WHERE username = @username", conn)
            cmd.Parameters.AddWithValue("@username", Home.LoggedInUsername)

            Try
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    ' Load profile picture if available
                    Dim picData As Byte() = If(IsDBNull(reader("ProfilePicture")), Nothing, CType(reader("ProfilePicture"), Byte()))

                    If picData IsNot Nothing AndAlso picData.Length > 0 Then
                        Using ms As New IO.MemoryStream(picData)
                            employerpic.Image = Image.FromStream(ms)
                        End Using
                    Else
                        ' Load a default image if no profile picture is found
                        '   employerpic.Image = My.Resources.DefaultProfilePicture ' Assumes you have a default image in project resources
                    End If

                    ' Adjust the image to fit the PictureBox
                    employerpic.SizeMode = PictureBoxSizeMode.Zoom ' This will maintain aspect ratio and fit the image in the PictureBox

                    ' Load first name and second name
                    lblfname.Text = reader("firstname").ToString().ToUpper()
                    lblsname.Text = reader("secondname").ToString().ToUpper()
                Else
                    MessageBox.Show("No data found for the provided username.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                reader.Close()
            Catch ex As MySqlException
                MessageBox.Show("An error occurred while loading employer details: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    ' Function to load employees contacted by the employer
    Private Sub LoadContactedEmployees()
        Using conn As New MySqlConnection(connectionString)
            ' Updated query to join the notifications, employee, and registration tables to fetch the ProfilePicture from the registration table
            Dim cmd As New MySqlCommand("SELECT DISTINCT employee.username, employee.firstname, employee.secondname, registration.ProfilePicture 
                                     FROM notifications
                                     JOIN employee ON notifications.employeeusername = employee.username 
                                     JOIN registration ON employee.username = registration.username 
                                     WHERE notifications.employerusername = @username", conn)
            cmd.Parameters.AddWithValue("@username", Home.LoggedInUsername)

            Try
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                Panel9.Controls.Clear() ' Clear panel before adding employees

                While reader.Read()
                    ' Create a new panel for each employee
                    Dim employeePanel As New Panel With {
                    .Height = 100,
                    .Width = 300,
                    .BackColor = Color.LightGray,
                    .Padding = New Padding(10),
                    .Margin = New Padding(5),
                    .BorderStyle = BorderStyle.FixedSingle ' Add a border
                }

                    ' Add shadow effect using a custom method
                    AddShadowEffect(employeePanel)

                    ' Load employee details
                    Dim employeeName As String = reader("firstname").ToString() & " " & reader("secondname").ToString()

                    ' Create a label for the employee's name
                    Dim nameLabel As New Label With {
                    .Text = employeeName,
                    .AutoSize = True,
                    .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                    .Location = New Point(100, 10) ' Positioned next to the picture box
                }

                    ' Create a PictureBox for the employee's profile picture
                    Dim pictureBox As New PictureBox With {
                    .Width = 80,
                    .Height = 80,
                    .SizeMode = PictureBoxSizeMode.StretchImage,
                    .Location = New Point(10, 10), ' Positioned inside the panel
                    .BackColor = Color.White ' Optional: Set background color
                }

                    ' Load and display the employee's profile picture
                    If Not IsDBNull(reader("ProfilePicture")) Then
                        Dim imgBytes() As Byte = CType(reader("ProfilePicture"), Byte())
                        Using ms As New MemoryStream(imgBytes)
                            pictureBox.Image = Image.FromStream(ms)
                        End Using
                    Else
                        ' Optional: Set a default image if no photo is found
                        pictureBox.Image = Image.FromFile("path/to/default/image.png")
                    End If

                    ' Add mouse hover event to change the background color
                    AddHandler employeePanel.MouseEnter, Sub(s, e) employeePanel.BackColor = Color.FromArgb(240, 240, 240)
                    AddHandler employeePanel.MouseLeave, Sub(s, e) employeePanel.BackColor = Color.LightGray

                    ' Add the PictureBox and Label to the employee panel
                    employeePanel.Controls.Add(pictureBox)
                    employeePanel.Controls.Add(nameLabel)

                    ' Add the employee panel to the main panel (Panel9)
                    Panel9.Controls.Add(employeePanel)
                End While

                reader.Close()
            Catch ex As MySqlException
                MessageBox.Show("An error occurred while loading contacted employees: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub AddShadowEffect(panel As Panel)
        ' Create a shadow effect for the panel
        Dim shadow As New Panel With {
        .Height = panel.Height,
        .Width = panel.Width,
        .BackColor = Color.FromArgb(50, 0, 0, 0), ' Semi-transparent black
        .Location = New Point(panel.Location.X + 5, panel.Location.Y + 5) ' Offset for shadow
    }
        Panel9.Controls.Add(shadow) ' Add shadow to the main panel
        Panel9.Controls.SetChildIndex(shadow, 0) ' Send shadow behind the panel

    End Sub

    ' Image update functionality when PictureBox is clicked
    Private Sub Employerpic_Click(sender As Object, e As EventArgs) Handles employerpic.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png"
            openFileDialog.Title = "Select a Picture"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim selectedImage As Image = Image.FromFile(openFileDialog.FileName)
                employerpic.Image = selectedImage
                employerpic.SizeMode = PictureBoxSizeMode.StretchImage

                ' Convert the image to a byte array
                Dim imageBytes As Byte() = ImageToByteArray(selectedImage)

                ' Update the image in the database
                UpdateImageInDatabase(imageBytes)
            End If
        End Using
    End Sub

    ' Update employer progress based on jobs, engagements, and verified jobs
    Private Sub UpdateEmployerProgress()
        ' Fetch progress details from the database using the employer's unique userid
        Dim employerUserID As String = GetEmployerUserID(Home.LoggedInUsername)
        Dim totalJobs As Integer = GetTotalJobsPosted(employerUserID)
        Dim engagements As Integer = GetEmployeeEngagements(employerUserID)
        Dim verifiedJobs As Integer = GetVerifiedJobs(employerUserID)

        ' Calculate progress based on the formula
        Dim jobWeight As Double = 0.3
        Dim engagementWeight As Double = 0.3
        Dim verifiedWeight As Double = 0.4

        Dim totalProgress As Double = (totalJobs * jobWeight) + (engagements * engagementWeight) + (verifiedJobs * verifiedWeight)

        ' Ensure the progress value does not exceed 100%
        guna2CircleProgressBar1.Value = CInt(Math.Min(totalProgress, 100))
    End Sub

    ' Helper function to get the employer's user ID from the registration table
    Private Function GetEmployerUserID(ByVal username As String) As String
        Dim userID As String = ""
        Try
            Using conn As New MySqlConnection(connectionString)
                Dim cmd As New MySqlCommand("SELECT userid FROM registration WHERE username = @username", conn)
                cmd.Parameters.AddWithValue("@username", username)
                conn.Open()
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    userID = result.ToString()
                End If
            End Using
        Catch ex As Exception
            ' Handle the exception (log it or display a message)
        End Try
        Return userID
    End Function

    Private Function GetEmployeeEngagements(ByVal employerUserID As String) As Integer
        Dim engagements As Integer = 0
        Try
            Dim query As String = "SELECT COUNT(*) FROM engagements WHERE employer_userid = @employerUserID AND feedback_provided = TRUE"
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@employerUserID", employerUserID)
                    conn.Open()
                    engagements = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            ' Handle the exception
        End Try
        Return engagements
    End Function

    Private Function GetVerifiedJobs(ByVal employerUserID As String) As Integer
        ' Initialize the count of verified jobs to zero
        Dim verifiedJobs As Integer = 0

        Try
            ' SQL query to count verified jobs for the specified employer
            Dim query As String = "SELECT COUNT(*) FROM job_posts WHERE employer_userid = @employerUserID AND job_status = 'Verified'"

            ' Using statement to ensure the connection is disposed of properly
            Using conn As New MySqlConnection(connectionString)
                ' Create a command to execute the query
                Using cmd As New MySqlCommand(query, conn)
                    ' Adding the employer user ID as a parameter to prevent SQL injection
                    cmd.Parameters.AddWithValue("@employerUserID", employerUserID)

                    ' Open the connection
                    conn.Open()

                    ' Execute the command and retrieve the count of verified jobs
                    verifiedJobs = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            ' Log or handle the exception (you might want to log this error)
            MessageBox.Show("An error occurred while retrieving verified jobs: " & ex.Message)
        End Try

        ' Return the count of verified jobs
        Return verifiedJobs
    End Function


    Private Function GetTotalJobsPosted(ByVal employerUserID As String) As Integer
        Dim totalJobs As Integer = 0
        Try
            Dim query As String = "SELECT COUNT(*) FROM jobs WHERE employer_userid = @employerUserID"
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@employerUserID", employerUserID)
                    conn.Open()
                    totalJobs = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            ' Handle the exception
        End Try
        Return totalJobs
    End Function
    Private Sub DisplayEmployerProgress()
        Dim totalJobsPosted As Integer = 0
        Dim totalContactedEmployees As Integer = 0
        Dim totalVerifiedJobs As Integer = 0

        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            ' Get the total number of jobs posted
            Dim jobsCmd As New MySqlCommand("SELECT COUNT(*) FROM job_posts WHERE employerusername = @username", conn)
            jobsCmd.Parameters.AddWithValue("@username", Home.LoggedInUsername)
            totalJobsPosted = Convert.ToInt32(jobsCmd.ExecuteScalar())

            ' Get the total number of contacted employees
            Dim contactedCmd As New MySqlCommand("SELECT COUNT(DISTINCT employeeusername) FROM notifications WHERE employerusername = @username", conn)
            contactedCmd.Parameters.AddWithValue("@username", Home.LoggedInUsername)
            totalContactedEmployees = Convert.ToInt32(contactedCmd.ExecuteScalar())

            ' Get the total number of verified jobs completed
            Dim verifiedJobsCmd As New MySqlCommand("SELECT COUNT(*) FROM verified_jobs WHERE employerusername = @username", conn)
            verifiedJobsCmd.Parameters.AddWithValue("@username", Home.LoggedInUsername)
            totalVerifiedJobs = Convert.ToInt32(verifiedJobsCmd.ExecuteScalar())
        End Using

        ' Calculate total progress (customize the weights as needed)
        Dim progressPercentage As Integer = CalculateProgress(totalJobsPosted, totalContactedEmployees, totalVerifiedJobs)

        ' Display the progress in the Guna Circular Progress Bar
        guna2CircleProgressBar1.Value = progressPercentage

        ' Display the statistics in a label (optional)
        ' lblProgress.Text = $"Jobs Posted: {totalJobsPosted}, Contacted Employees: {totalContactedEmployees}, Verified Jobs: {totalVerifiedJobs}"
    End Sub

    Private Function CalculateProgress(jobsPosted As Integer, contactedEmployees As Integer, verifiedJobs As Integer) As Integer
        ' Simple example: total jobs posted contributes 50%, contacted employees 30%, and verified jobs 20%
        Dim totalWeight As Integer = 100 ' Total weight
        Dim progress As Double = 0

        If jobsPosted > 0 Then
            progress += (jobsPosted / totalWeight) * 50 ' 50% weight
        End If
        If contactedEmployees > 0 Then
            progress += (contactedEmployees / totalWeight) * 30 ' 30% weight
        End If
        If verifiedJobs > 0 Then
            progress += (verifiedJobs / totalWeight) * 20 ' 20% weight
        End If

        ' Ensure the value does not exceed 100
        Return Math.Min(100, CInt(progress))
    End Function

End Class
