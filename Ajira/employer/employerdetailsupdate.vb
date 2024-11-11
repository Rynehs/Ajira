Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Net.Mail ' For sending OTP via email
Imports System.Security.Cryptography ' For generating OTP

Public Class employerdetailsupdate
    Private ReadOnly addressConnectionString As String = "Server=localhost;Database=address;Uid=root;Pwd=;"
    Private ReadOnly ajiraConnectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"
    Private ReadOnly otp As String

    Private Sub Employerdetailsupdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(Home.LoggedInUsername) Then
            MessageBox.Show("No user is currently logged in.")
            Me.Close()
            Return
        End If

        LoadUserDetails()
        DisplayUserProfilePicture()
        PopulateCountyComboBox()

        dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-18)
        dtpDateOfBirth.Value = DateTime.Today.AddYears(-18)

        ' Call to increment login count
        UpdateLoginCount()
    End Sub

    Private Sub UpdateLoginCount()
        Try
            Using ajiraConnection As New MySqlConnection(ajiraConnectionString)
                ajiraConnection.Open()

                ' Fetch the current login count for the user
                Dim query As String = "SELECT LoginCount FROM registration WHERE Username = @Username"
                Dim loginCount As Integer = 0

                Using cmd As New MySqlCommand(query, ajiraConnection)
                    cmd.Parameters.AddWithValue("@Username", Home.LoggedInUsername)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            If Not IsDBNull(reader("LoginCount")) Then
                                loginCount = Convert.ToInt32(reader("LoginCount"))
                            End If
                        Else
                            MessageBox.Show("User not found.")
                            Exit Sub
                        End If
                    End Using
                End Using

                ' Increment the login count
                loginCount += 1

                ' Update the login count in the database
                query = "UPDATE registration SET LoginCount = @LoginCount WHERE Username = @Username"
                Using cmd As New MySqlCommand(query, ajiraConnection)
                    cmd.Parameters.AddWithValue("@LoginCount", loginCount)
                    cmd.Parameters.AddWithValue("@Username", Home.LoggedInUsername)
                    cmd.ExecuteNonQuery()
                End Using

                ' Check if the user is logging in for the first time or after 15 days
                If loginCount = 1 OrElse ShouldAllowDetailUpdate(loginCount) Then
                    EnableDetailUpdate() ' Enable profile update if applicable
                End If

            End Using
        Catch ex As MySqlException
            MessageBox.Show("An error occurred while updating login count: " & ex.Message)
        End Try
    End Sub

    Private Function ShouldAllowDetailUpdate(loginCount As Integer) As Boolean
        ' Example logic: Allow profile updates on first login and after every 15 days (e.g., 15, 30, 45, etc.)
        Return loginCount Mod 15 = 0
    End Function

    Private Sub EnableDetailUpdate()
        txtPhoneNumber.ReadOnly = False
        txtEmail.ReadOnly = False
        Guna2TextBox6.ReadOnly = False

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
        Guna2TextBox6.ReadOnly = True

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

                Dim query As String = "SELECT r.UserID, r.firstname, r.secondname, r.username, r.LoginCount, r.FirstLoginDate, e.PhoneNumber, e.Email, e.jobs, e.County, e.SubCounty, e.Location, e.IDNumber, e.DateOfBirth, e.Gender " &
                                  "FROM registration r " &
                                  "LEFT JOIN employer e ON r.UserID = e.UserID " &
                                  "WHERE r.username = @Username"

                Using cmd As New MySqlCommand(query, ajiraConnection)
                    cmd.Parameters.AddWithValue("@Username", Home.LoggedInUsername)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        ' Load the details into the text boxes and combo boxes
                        txtfirstname.Text = GetSafeString(reader("firstname"))
                        txtsecondname.Text = GetSafeString(reader("secondname"))
                        txtuname.Text = GetSafeString(reader("username"))
                        txtPhoneNumber.Text = GetSafeString(reader("PhoneNumber"))
                        txtEmail.Text = GetSafeString(reader("Email"))
                        Guna2TextBox6.Text = GetSafeString(reader("IDNumber"))

                        ' Set radio buttons for gender
                        SetGenderRadioButton(reader("Gender"))

                        ' Set county, subcounty, and location
                        SetComboBoxSelection(Cbocounty, reader("County"))
                        SetComboBoxSelection(cboSubCounty, reader("SubCounty"))
                        SetComboBoxSelection(cboLocation, reader("Location"))

                        ' Handle FirstLoginDate safely
                        Dim firstLoginDate As DateTime? = If(IsDBNull(reader("FirstLoginDate")), CType(Nothing, DateTime?), Convert.ToDateTime(reader("FirstLoginDate")))
                        Dim loginCount As Integer = If(IsDBNull(reader("LoginCount")), 0, Convert.ToInt32(reader("LoginCount")))

                        HandleLoginDetails(firstLoginDate, loginCount)
                    End If
                    reader.Close()
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("An error occurred while loading user details: " & ex.Message)
        End Try
    End Sub

    Private Function GetSafeString(value As Object) As String
        Return If(IsDBNull(value), String.Empty, value.ToString())
    End Function

    Private Sub SetGenderRadioButton(genderValue As Object)
        Dim gender As String = If(IsDBNull(genderValue), String.Empty, genderValue.ToString().ToLower())
        Select Case gender
            Case "male"
                RadioButtonmale.Checked = True
            Case "female"
                RadioButtonfemale.Checked = True
            Case Else
                RadioButtonmale.Checked = False
                RadioButtonfemale.Checked = False
        End Select
    End Sub

    Private Sub SetComboBoxSelection(comboBox As ComboBox, value As Object)
        Dim text As String = GetSafeString(value)
        If Not String.IsNullOrEmpty(text) AndAlso comboBox.FindStringExact(text) <> -1 Then
            comboBox.SelectedIndex = comboBox.FindStringExact(text)
        ElseIf Not String.IsNullOrEmpty(text) Then
            MessageBox.Show($"{comboBox.Name} value '{text}' not found in the list. Please select manually.")
        End If
    End Sub

    Private Sub HandleLoginDetails(firstLoginDate As DateTime?, loginCount As Integer)
        If loginCount = 0 Then
            MessageBox.Show("Welcome! Please update your details.")
            BtnUpdate.Enabled = True
        ElseIf firstLoginDate.HasValue AndAlso DateTime.Now.Subtract(firstLoginDate.Value).TotalDays <= 15 Then
            SetfieldsReadOnly()
            MessageBox.Show("You cannot update details until 15 days have passed since your first login.")
        Else
            SetfieldsReadOnly()
        End If
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
        ' Clear the location ComboBox to remove outdated options
        cboLocation.Items.Clear()

        If cboSubCounty.SelectedItem IsNot Nothing Then
            Dim selectedSubCounty As ComboBoxItem = CType(cboSubCounty.SelectedItem, ComboBoxItem)
            PopulateLocationComboBox(selectedSubCounty.Value)
        End If
    End Sub


    Private Sub PopulateLocationComboBox(subCountyId As Integer)
        Try
            Using addressConnection As New MySqlConnection(addressConnectionString)
                addressConnection.Open()

                Dim query As String = "SELECT  location_name AS Name FROM location WHERE sub_county_id = @sub_county_id ORDER BY Name"
                Using cmd As New MySqlCommand(query, addressConnection)
                    cmd.Parameters.AddWithValue("@sub_county_id", subCountyId)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        cboLocation.Items.Clear()
                        While reader.Read()
                            cboLocation.Items.Add(New ComboBoxItem(reader("Name").ToString(), CInt(reader("ID"))))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("An error occurred while loading locations: " & ex.Message)
        End Try
    End Sub

    ' Custom class to handle combo box items with IDs
    Private Class ComboBoxItem
        Public Property Name As String
        Public Property ID As Integer
        Public Property Value As Integer

        Public Sub New(name As String, id As Integer)
            Me.Name = name
            Me.ID = id
        End Sub

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class



    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        ' Validate user input before proceeding
        If String.IsNullOrEmpty(txtPhoneNumber.Text) OrElse Not txtPhoneNumber.Text.StartsWith("+254") OrElse txtPhoneNumber.Text.Length <> 13 Then
            MessageBox.Show("Phone number must start with +254 and be 13 characters long.")
            Return
        End If

        If String.IsNullOrEmpty(txtEmail.Text) OrElse Not txtEmail.Text.Contains("@") Then
            MessageBox.Show("Invalid email address.")
            Return
        End If

        Try
            Using ajiraConnection As New MySqlConnection(ajiraConnectionString)
                ajiraConnection.Open()

                Dim query As String = "UPDATE employer SET PhoneNumber = @PhoneNumber, Email = @Email, County = @County, SubCounty = @SubCounty, Location = @Location, IDNumber = @IDNumber, DateOfBirth = @DateOfBirth, Gender = @Gender WHERE UserID = @UserID"
                Using cmd As New MySqlCommand(query, ajiraConnection)
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@County", Cbocounty.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@SubCounty", cboSubCounty.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Location", cboLocation.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@IDNumber", Guna2TextBox6.Text)
                    cmd.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@Gender", If(RadioButtonmale.Checked, "male", "female"))
                    cmd.Parameters.AddWithValue("@UserID", GetUserID())

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Details updated successfully!")
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("An error occurred while updating details: " & ex.Message)
        End Try
    End Sub

    ' Get the UserID of the logged-in user
    Private Function GetUserID() As Integer
        Dim userId As Integer = 0
        Try
            Using ajiraConnection As New MySqlConnection(ajiraConnectionString)
                ajiraConnection.Open()

                Dim query As String = "SELECT UserID FROM registration WHERE Username = @Username"
                Using cmd As New MySqlCommand(query, ajiraConnection)
                    cmd.Parameters.AddWithValue("@Username", Home.LoggedInUsername)
                    userId = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error fetching user ID: " & ex.Message)
        End Try
        Return userId
    End Function
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
            Dim query As String = "UPDATE employer SET bgimage = @Image WHERE username = @UserID"

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
