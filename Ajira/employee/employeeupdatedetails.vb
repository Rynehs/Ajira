Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Frmemployeedetails
    Private ReadOnly ajiraConnectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"
    Private ReadOnly addressConnectionString As String = "Server=localhost;Database=address;Uid=root;Pwd=;"
    Private ReadOnly ajiraConnection As MySqlConnection
    Private ReadOnly addressConnection As MySqlConnection

    Private Sub Frmemployeedetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(Home.LoggedInUsername) Then
            MessageBox.Show("No user is currently logged in.")
            Me.Close()
            Return
        End If

        LoadUserDetails()
        DisplayUserProfilePicture()
        PopulateCountyComboBox()

        dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-18)
        dtpDateOfBirth.Value = DateTime.Today.AddYears(-18) ' Set the default value to the max date
    End Sub

    Private Sub UpdateLoginCount()
        Try
            Using ajiraConnection As New MySqlConnection(ajiraConnectionString)
                ajiraConnection.Open()

                Dim query As String = "SELECT LoginCount, LastLoginDate FROM registration WHERE Username = @Username"
                Dim loginCount As Integer
                Dim lastLoginDate As DateTime

                Using cmd As New MySqlCommand(query, ajiraConnection)
                    cmd.Parameters.AddWithValue("@Username", Home.LoggedInUsername)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            loginCount = Convert.ToInt32(reader("LoginCount"))
                            lastLoginDate = Convert.ToDateTime(reader("LastLoginDate"))
                        Else
                            MessageBox.Show("User not found.")
                            Exit Sub
                        End If
                    End Using
                End Using

                loginCount += 1

                query = "UPDATE registration SET LoginCount = @LoginCount, LastLoginDate = @LastLoginDate WHERE Username = @Username"
                Using cmd As New MySqlCommand(query, ajiraConnection)
                    cmd.Parameters.AddWithValue("@LoginCount", loginCount)
                    cmd.Parameters.AddWithValue("@LastLoginDate", DateTime.Now)
                    cmd.Parameters.AddWithValue("@Username", Home.LoggedInUsername)
                    cmd.ExecuteNonQuery()
                End Using

                If loginCount = 1 OrElse (DateTime.Now - lastLoginDate).TotalDays <= 15 Then
                    EnableDetailUpdate()
                Else
                    SetfieldsReadOnly()
                End If
            End Using
        Catch ex As MySqlException
            MessageBox.Show("An error occurred while updating login count: " & ex.Message)
        End Try
    End Sub

    Private Sub EnableDetailUpdate()
        txtPhoneNumber.ReadOnly = False
        txtEmail.ReadOnly = False
        ExperienceTextBox.ReadOnly = False
        skillsTextBox.ReadOnly = False
        Guna2TextBox6.ReadOnly = False
        Availability.Enabled = True
        dtpDateOfBirth.Enabled = True
        Cbocounty.Enabled = True
        cboSubCounty.Enabled = True
        cboLocation.Enabled = True
        RadioButtonmale.Enabled = True
        RadioButtonfemale.Enabled = True
    End Sub

    Private Sub SetfieldsReadOnly()
        txtPhoneNumber.ReadOnly = True
        txtEmail.ReadOnly = True
        ExperienceTextBox.ReadOnly = True
        skillsTextBox.ReadOnly = True
        Guna2TextBox6.ReadOnly = True
        Availability.Enabled = False
        dtpDateOfBirth.Enabled = False
        Cbocounty.Enabled = False
        cboSubCounty.Enabled = False
        cboLocation.Enabled = False
        RadioButtonmale.Enabled = False
        RadioButtonfemale.Enabled = False
    End Sub

    Private Sub LoadUserDetails()
        Try
            Using ajiraConnection As New MySqlConnection(ajiraConnectionString)
                ajiraConnection.Open()

                Dim query As String = "SELECT r.UserID, r.firstname, r.secondname, r.username, r.LoginCount, r.FirstLoginDate, e.PhoneNumber, e.Email, e.Experience, e.Skills, e.County, e.SubCounty, e.Location, e.IDNumber, e.Availability, e.DateOfBirth, e.Gender " &
                                  "FROM registration r " &
                                  "LEFT JOIN employee e ON r.UserID = e.UserID " &
                                  "WHERE r.username = @Username"

                Using cmd As New MySqlCommand(query, ajiraConnection)
                    cmd.Parameters.AddWithValue("@Username", Home.LoggedInUsername)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        ' Load the details into the text boxes and combo boxes
                        txtfirstname.Text = If(IsDBNull(reader("firstname")), String.Empty, reader("firstname").ToString())
                        txtsecondname.Text = If(IsDBNull(reader("secondname")), String.Empty, reader("secondname").ToString())
                        txtuname.Text = If(IsDBNull(reader("username")), String.Empty, reader("username").ToString())
                        txtPhoneNumber.Text = If(IsDBNull(reader("PhoneNumber")), String.Empty, reader("PhoneNumber").ToString())
                        txtEmail.Text = If(IsDBNull(reader("Email")), String.Empty, reader("Email").ToString())
                        ExperienceTextBox.Text = If(IsDBNull(reader("Experience")), String.Empty, reader("Experience").ToString())
                        skillsTextBox.Text = If(IsDBNull(reader("Skills")), String.Empty, reader("Skills").ToString())
                        Guna2TextBox6.Text = If(IsDBNull(reader("IDNumber")), String.Empty, reader("IDNumber").ToString())
                        Availability.Text = If(IsDBNull(reader("Availability")), String.Empty, reader("Availability").ToString())

                        ' Set radio buttons for gender
                        Dim gender As String = If(IsDBNull(reader("Gender")), String.Empty, reader("Gender").ToString())
                        Select Case gender.ToLower()
                            Case "male"
                                RadioButtonmale.Checked = True
                            Case "female"
                                RadioButtonfemale.Checked = True
                            Case Else
                                ' Handle cases where gender might be unknown or empty
                                RadioButtonmale.Checked = False
                                RadioButtonfemale.Checked = False
                        End Select

                        ' Set county, subcounty, and location
                        Dim county As String = If(IsDBNull(reader("County")), String.Empty, reader("County").ToString())
                        Dim subCounty As String = If(IsDBNull(reader("SubCounty")), String.Empty, reader("SubCounty").ToString())
                        Dim location As String = If(IsDBNull(reader("Location")), String.Empty, reader("Location").ToString())

                        If Not String.IsNullOrEmpty(county) Then
                            Cbocounty.SelectedIndex = Cbocounty.FindStringExact(county)
                        End If
                        If Not String.IsNullOrEmpty(subCounty) Then
                            cboSubCounty.SelectedIndex = cboSubCounty.FindStringExact(subCounty)
                        End If
                        If Not String.IsNullOrEmpty(location) Then
                            cboLocation.SelectedIndex = cboLocation.FindStringExact(location)
                        End If

                        ' Handle FirstLoginDate safely
                        Dim firstLoginDate As DateTime
                        If IsDBNull(reader("FirstLoginDate")) Then
                            firstLoginDate = DateTime.MinValue ' Set a default value if the field is null
                        Else
                            firstLoginDate = Convert.ToDateTime(reader("FirstLoginDate"))
                        End If

                        Dim loginCount As Integer = If(IsDBNull(reader("LoginCount")), 0, Convert.ToInt32(reader("LoginCount")))

                        If loginCount = 0 Then
                            ' First login, allow user to update details
                            MessageBox.Show("Welcome! Please update your details.")
                            UpdateButton.Enabled = True
                        ElseIf DateTime.Now.Subtract(firstLoginDate).TotalDays <= 15 Then
                            ' Not the first login, but within 15 days, make fields read-only
                            SetfieldsReadOnly()
                            MessageBox.Show("You cannot update details until 15 days have passed since your first login.")
                        Else
                            ' Not the first login and more than 15 days have passed, allow updates
                            SetfieldsReadOnly()
                        End If
                    End If
                    reader.Close()
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("An error occurred while loading user details: " & ex.Message)
        End Try
    End Sub


    Private Sub DisplayUserProfilePicture()
        Try
            Using connection As New MySqlConnection(ajiraConnectionString)
                connection.Open()

                Dim query As String = "SELECT ProfilePicture FROM registration WHERE Username = @Username"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", Home.LoggedInUsername)
                    Dim imageData As Byte() = CType(command.ExecuteScalar(), Byte())

                    If imageData IsNot Nothing AndAlso imageData.Length > 0 Then
                        Using ms As New MemoryStream(imageData)
                            PictureBoxProfile.Image = Image.FromStream(ms)
                            PictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom
                        End Using
                    Else
                        MessageBox.Show("No profile picture found for the logged-in user.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving profile picture: " & ex.Message)
        End Try
    End Sub

    Private Sub PopulateCountyComboBox()
        Try
            Using addressConnection As New MySqlConnection(addressConnectionString)
                addressConnection.Open()

                Dim query As String = "SELECT county_id AS ID, county_name AS Name FROM county ORDER BY Name"
                Using cmd As New MySqlCommand(query, addressConnection)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Cbocounty.Items.Clear()
                        While reader.Read()
                            Cbocounty.Items.Add(New ComboBoxItem(reader("Name").ToString(), CInt(reader("ID"))))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("An error occurred while loading counties: " & ex.Message)
        End Try
    End Sub

    Private Sub Cbocounty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbocounty.SelectedIndexChanged
        If Cbocounty.SelectedItem IsNot Nothing Then
            Dim selectedCounty As ComboBoxItem = CType(Cbocounty.SelectedItem, ComboBoxItem)
            PopulateSubCountyComboBox(selectedCounty.Value)
        End If
    End Sub

    Private Sub PopulateSubCountyComboBox(countyId As Integer)
        Try
            Using addressConnection As New MySqlConnection(addressConnectionString)
                addressConnection.Open()

                Dim query As String = "SELECT sub_county_id AS ID, sub_county_name AS Name FROM sub_county WHERE county_id = @county_id ORDER BY Name"
                Using cmd As New MySqlCommand(query, addressConnection)
                    cmd.Parameters.AddWithValue("@county_id", countyId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cboSubCounty.Items.Clear()
                        While reader.Read()
                            cboSubCounty.Items.Add(New ComboBoxItem(reader("Name").ToString(), CInt(reader("ID"))))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("An error occurred while loading sub-counties: " & ex.Message)
        End Try
    End Sub

    Private Sub CboSubCounty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubCounty.SelectedIndexChanged
        If cboSubCounty.SelectedItem IsNot Nothing Then
            Dim selectedSubCounty As ComboBoxItem = CType(cboSubCounty.SelectedItem, ComboBoxItem)
            PopulateLocationComboBox(selectedSubCounty.Value)
        End If
    End Sub

    Private Sub PopulateLocationComboBox(subCountyId As Integer)
        Try
            Using addressConnection As New MySqlConnection(addressConnectionString)
                addressConnection.Open()

                ' Only selecting location_name since sub_county_id is used for filtering
                Dim query As String = "SELECT location_name AS Name FROM location WHERE sub_county_id = @sub_county_id ORDER BY Name"
                Using cmd As New MySqlCommand(query, addressConnection)
                    cmd.Parameters.AddWithValue("@sub_county_id", subCountyId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cboLocation.Items.Clear()
                        While reader.Read()
                            ' Adding only location_name to the ComboBox
                            cboLocation.Items.Add(reader("Name").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("An error occurred while loading locations: " & ex.Message)
        End Try
    End Sub


    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            Using ajiraConnection As New MySqlConnection(ajiraConnectionString)
                ajiraConnection.Open()

                Dim query As String = "UPDATE employee SET PhoneNumber = @PhoneNumber, Email = @Email, Experience = @Experience, Skills = @Skills, IDNumber = @IDNumber, Availability = @Availability, County = @County, SubCounty = @SubCounty, Location = @Location, DateOfBirth = @DateOfBirth, Gender = @Gender WHERE UserID = @UserID"

                Using cmd As New MySqlCommand(query, ajiraConnection)
                    ' Add parameters for the query
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text.Trim())
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@Experience", ExperienceTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@Skills", skillsTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@IDNumber", Guna2TextBox6.Text.Trim())
                    cmd.Parameters.AddWithValue("@Availability", Availability.Text.Trim())

                    ' Assuming ComboBoxItem has a Text property for county and sub-county
                    Dim selectedCounty As ComboBoxItem = CType(Cbocounty.SelectedItem, ComboBoxItem)
                    Dim selectedSubCounty As ComboBoxItem = CType(cboSubCounty.SelectedItem, ComboBoxItem)

                    cmd.Parameters.AddWithValue("@County", selectedCounty?.Text.Trim())
                    cmd.Parameters.AddWithValue("@SubCounty", selectedSubCounty?.Text.Trim())
                    cmd.Parameters.AddWithValue("@Location", cboLocation.Text.Trim())
                    cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value)

                    ' Gender handling
                    cmd.Parameters.AddWithValue("@Gender", If(RadioButtonmale.Checked, "male", "female"))

                    ' Using the logged-in user's username to fetch UserID
                    cmd.Parameters.AddWithValue("@UserID", GetUserIdByUsername(Home.LoggedInUsername)) ' A method to fetch UserID based on username

                    ' Execute the command
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Details updated successfully!")
            End Using
        Catch ex As MySqlException
            MessageBox.Show("An error occurred while updating details: " & ex.Message)
        End Try
    End Sub

    Private Function GetUserIdByUsername(username As String) As String
        ' This function retrieves the UserID based on the username
        Dim userId As String = String.Empty
        Using ajiraConnection As New MySqlConnection(ajiraConnectionString)
            ajiraConnection.Open()
            Dim query As String = "SELECT UserID FROM employee WHERE Username = @Username"
            Using cmd As New MySqlCommand(query, ajiraConnection)
                cmd.Parameters.AddWithValue("@Username", username)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    userId = result.ToString()
                End If
            End Using
        End Using
        Return userId
    End Function

    Private Sub guna2TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox6.KeyPress
        ' Allow only digits
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        ' Limit to 8 characters
        If Guna2TextBox6.TextLength >= 8 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNumber.KeyPress
        ' Allow only digits or control keys
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        ' Prepend +254 if not already present
        If txtPhoneNumber.Text.Length = 0 AndAlso e.KeyChar <> ControlChars.Back Then
            txtPhoneNumber.Text = "+254"
            txtPhoneNumber.SelectionStart = txtPhoneNumber.Text.Length ' Move cursor to the end
            e.Handled = True
        End If

        ' Limit to a maximum of 13 characters
        If txtPhoneNumber.Text.Length >= 13 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Function IsValidInput(input As String) As Boolean
        If input Is Nothing Then
            Throw New ArgumentNullException(NameOf(input))
        End If
        ' Implement input validation and sanitization logic here
        Return True
    End Function

    ' Class to hold ComboBox item data
    Private Class ComboBoxItem
        Public Property Name As String
        Public Property Value As Integer
        Public Property Text As Object

        Public Sub New(name As String, value As Integer)
            Me.Name = name
            Me.Value = value
        End Sub

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class




    Private Sub btnBg_Click(sender As Object, e As EventArgs) Handles btnBg.Click
        ' Allow the user to select an image file
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If ofd.ShowDialog() = DialogResult.OK Then
            ' Get the file path of the selected image
            Dim filePath As String = ofd.FileName

            ' Convert the selected image to a byte array
            Dim imgBytes() As Byte = File.ReadAllBytes(filePath)

            ' Get the logged-in user's username (assuming you're using loggedinusername)
            Dim loggedInUserID As String = Home.LoggedInUsername ' Change this to your actual user ID source

            ' Define the query to update the background image
            Dim query As String = "UPDATE employee SET bgimage = @Image WHERE username = @UserID"

            ' Using the provided connection string to connect to the database
            Dim connStr As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"

            ' Update the database with the image
            Using conn As New MySqlConnection(connStr),
              cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Image", imgBytes)
                cmd.Parameters.AddWithValue("@UserID", loggedInUserID)

                ' Open the connection and execute the query
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using

            ' Notify the user of success
            MessageBox.Show("Background image updated successfully!")
        End If
    End Sub

End Class
