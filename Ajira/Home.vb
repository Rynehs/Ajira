Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Threading.Tasks
Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text

Public Class Home
    Private usertype As String
    Private WithEvents PasswordTimer As New Timer()
    Private otp As String ' Variable to store generated OTP

    ' Shared variables to store logged-in username and user type
    Public Shared LoggedInUsername As String
    Public Shared LoggedInUserType As String

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBoxotp.Visible = False ' Keep OTP group hidden initially
        txtpasslogin.UseSystemPasswordChar = True
        ' Display the current date and time in Label1
        Label2.Text = DateTime.Now.ToString("F")
        guna2ProgressIndicator1.Visible = False
        ' Set the timer interval to 5 seconds (5000 milliseconds)
        PasswordTimer.Interval = 5000

        ' Load saved username and password if Remember Me was checked
        If My.Settings.RememberMe Then
            txtunamelogin.Text = My.Settings.SavedUsername
            txtpasslogin.Text = My.Settings.SavedPassword
            toggleRememberMe.Checked = True
        End If
    End Sub

    ' This method validates email and sends OTP for verification
    Private Sub TxtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        Dim email As String = txtEmail.Text

        If ValidateEmail(email) Then
            ' Check if email is already registered
            If IsEmailRegistered(email) Then
                MessageBox.Show("This email is already registered.", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim dialogResult As DialogResult = MessageBox.Show("Do you want to send an OTP to this email?", "Send OTP", MessageBoxButtons.YesNo)
            If dialogResult = DialogResult.Yes Then
                GroupBoxotp.Visible = True ' Show OTP GroupBox
                otp = GenerateOTP() ' Generate OTP
                SendOTPEmail(email, otp) ' Send OTP via email
                StoreOTPInDatabase(email, otp) ' Store OTP in the database
                MessageBox.Show("OTP has been sent to your email.")
            End If
        Else
            MessageBox.Show("Invalid email format. Please enter a valid email.")
        End If
    End Sub


    Private Function ValidateEmail(email As String) As Boolean
        Return email.Contains("@") AndAlso email.EndsWith(".com")
    End Function


    Private Function IsEmailRegistered(email As String) As Boolean
        Using connection As MySqlConnection = Database.GetConnection()
            Dim query As String = "SELECT COUNT(*) FROM registration WHERE Email = @Email"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Email", email)
                connection.Open()
                Dim emailCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                connection.Close()
                Return emailCount > 0
            End Using
        End Using
    End Function

    Private Function GenerateOTP() As String
        Const chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Const length As Integer = 8

        Using rng As RandomNumberGenerator = RandomNumberGenerator.Create()
            Dim result As New StringBuilder(length)
            Dim bytes(4) As Byte

            For i As Integer = 0 To length - 1
                rng.GetBytes(bytes)
                Dim rnd As Integer = Math.Abs(BitConverter.ToInt32(bytes, 0)) ' Ensure positive random number
                result.Append(chars(rnd Mod chars.Length))
            Next

            Return result.ToString()
        End Using
    End Function


    ' Send OTP via email with HTML body
    Private Sub SendOTPEmail(email As String, otp As String)
        Try
            Dim mail As New MailMessage With {
                .From = New MailAddress("ajiraassistance@gmail.com")
            }
            mail.To.Add(email)
            mail.Subject = "Your OTP Code"

            ' HTML email content with header, footer, and a logo
            Dim htmlBody As String = "
       <html>
<head>
    <style>
        body {
            font-family: 'Segoe UI', Arial, sans-serif;
            background-color: #f4f4f4;
            color: #333;
            margin: 0;
            padding: 0;
            line-height: 1.6;
        }
        .container {
            width: 100%;
            max-width: 600px;
            margin: 0 auto;
            background-color: white;
            border-radius: 8px;
            box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
            overflow: hidden;
        }
        .header {
            background-color: rgb(0, 148, 186);
            padding: 20px;
            text-align: center;
        }
        .header img {
            width: 120px;
            margin-bottom: 10px;
        }
        .header h1 {
            color: white;
            font-size: 26px;
            margin: 0;
            letter-spacing: 1px;
        }
        .content {
            padding: 30px;
            font-size: 16px;
            color: #333;
        }
        .content p {
            margin-bottom: 20px;
        }
        .content .otp-code {
            background-color: #eee;
            border: 1px dashed rgb(0, 148, 186);
            color: rgb(0, 148, 186);
            padding: 10px 15px;
            font-size: 20px;
            font-weight: bold;
            text-align: center;
            display: inline-block;
            margin-top: 10px;
        }
        .footer {
            background-color: #333;
            color: white;
            padding: 20px;
            text-align: center;
            font-size: 14px;
        }
        .footer a {
            color: white;
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <div class='container'>
        <div class='header'>
            <img src='cid:logo' alt='Ajira Assistance Logo'/>
            <h1>Ajira Assistance</h1>
        </div>
        <div class='content'>
            <p>Dear Valued User,</p>
            <p>Your OTP code for verification is:</p>
            <div class='otp-code'>" & otp & "</div>
            <p>Please enter this code to complete your registration. The code will expire in 10 minutes.</p>
            <p>If you did not request this, please ignore this email or contact our support team.</p>
        </div>
        <div class='footer'>
            <p>&copy; 2024 Ajira Assistance. All rights reserved.</p>
            <p><a href='https://ajira-assistance.com'>Visit our website</a></p>
        </div>
    </div>
</body>
</html>"

            ' Set the email body to HTML format
            mail.IsBodyHtml = True

            ' Attach the logo (use the actual path to your logo image)
            Dim logoPath As String = "E:\School Work\Ajira\Ajira\Resources\logo\logo.png"
            Dim logo As New LinkedResource(logoPath) With {
                .ContentId = "logo"
            }

            ' Create alternate view to embed the logo in the email
            Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(htmlBody, Nothing, "text/html")
            htmlView.LinkedResources.Add(logo)
            mail.AlternateViews.Add(htmlView)

            ' SMTP server settings
            Dim smtpServer As New SmtpClient("smtp.gmail.com") With {
                .Port = 587,
                .Credentials = New Net.NetworkCredential("ajiraassistance@gmail.com", "muvb nxhd ydex qatv"),
                .EnableSsl = True
            }

            ' Send the email
            smtpServer.Send(mail)

        Catch ex As Exception
            MessageBox.Show("Error sending OTP: " & ex.Message)
        End Try
    End Sub



    ' Store OTP in the database
    Private Sub StoreOTPInDatabase(email As String, otp As String)
        Try
            Using connection As New MySqlConnection("Server=localhost;Database=ajira;Uid=root;Pwd=;")
                connection.Open()

                ' Remove previous OTP for the same email
                Dim deleteQuery As String = "DELETE FROM otp WHERE Email = @Email"
                Using deleteCmd As New MySqlCommand(deleteQuery, connection)
                    deleteCmd.Parameters.AddWithValue("@Email", email)
                    deleteCmd.ExecuteNonQuery()
                End Using

                ' Insert the new OTP with expiration time
                Dim query As String = "INSERT INTO otp (Email, OTP, GeneratedAt, ExpiresAt) VALUES (@Email, @OTP, @GeneratedAt, @ExpiresAt)"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@OTP", otp)
                    cmd.Parameters.AddWithValue("@GeneratedAt", DateTime.Now)
                    cmd.Parameters.AddWithValue("@ExpiresAt", DateTime.Now.AddMinutes(5)) ' OTP expires after 10 minutes
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("An error occurred while storing OTP: " & ex.Message)
        End Try
    End Sub

    ' Verify OTP during registration
    Private Sub BtnVerifyOTP_Click(sender As Object, e As EventArgs) Handles btnVerifyOTP.Click
        Dim enteredOtp As String = txtotp.Text
        Dim email As String = txtEmail.Text

        If VerifyOTPInDatabase(email, enteredOtp) Then
            MessageBox.Show("OTP verified successfully! Your email has been validated.")
            GroupBoxotp.Visible = False ' Hide the GroupBoxotp
        Else
            MessageBox.Show("Invalid OTP. Please try again.")
        End If
    End Sub


    Private Sub InsertEmailInEmployeeTable(email As String)
        Using connection As MySqlConnection = Database.GetConnection()
            Dim query As String = "INSERT INTO employee (email) VALUES (@email)"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@email", email)
                connection.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub InsertEmailInEmployerTable(email As String)
        Using connection As MySqlConnection = Database.GetConnection()
            Dim query As String = "INSERT INTO employer (email) VALUES (@email)"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@email", email)
                connection.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub InsertEmailInUsersTable(email As String)
        Using connection As MySqlConnection = Database.GetConnection()
            Dim query As String = "INSERT INTO registration (email) VALUES (@email)"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@email", email)
                connection.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Verify OTP from the database
    Private Function VerifyOTPInDatabase(email As String, enteredOtp As String) As Boolean
        Try
            Using connection As New MySqlConnection("Server=localhost;Database=ajira;Uid=root;Pwd=;")
                connection.Open()

                Dim query As String = "SELECT OTP, ExpiresAt FROM otp WHERE Email = @Email AND OTP = @OTP AND ExpiresAt > @CurrentTime"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@OTP", enteredOtp)
                    cmd.Parameters.AddWithValue("@CurrentTime", DateTime.Now)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' OTP is valid and not expired
                            Return True
                        End If
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("An error occurred during OTP verification: " & ex.Message)
        End Try

        Return False
    End Function
    Private Function CanGenerateOTP(email As String) As Boolean
        Using connection As New MySqlConnection("Server=localhost;Database=ajira;Uid=root;Pwd=;")
            connection.Open()
            Dim query As String = "SELECT COUNT(*) FROM otp_attempts WHERE Email = @Email AND AttemptTime > @CooldownTime"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@CooldownTime", DateTime.Now.AddMinutes(-5)) ' 5-minute cooldown
                Dim attempts As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return attempts < 3 ' Allow up to 3 attempts within 5 minutes
            End Using
        End Using
    End Function

    Private Sub RecordOTPAttempt(email As String)
        Using connection As New MySqlConnection("Server=localhost;Database=ajira;Uid=root;Pwd=;")
            connection.Open()
            Dim query As String = "INSERT INTO otp_attempts (Email, AttemptTime) VALUES (@Email, @AttemptTime)"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@AttemptTime", DateTime.Now)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Private Sub BtnUploadPicture_Click(sender As Object, e As EventArgs) Handles btnUploadPicture.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Set PictureBox size mode to StretchImage to make the image fit the PictureBox
                PictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage
                ' Display the selected image in the PictureBox
                PictureBoxProfile.Image = Image.FromFile(openFileDialog.FileName)
            End If
        End Using
    End Sub


    ' Function to convert the image to byte array
    Private Function ImageToByteArray(image As Image) As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, image.RawFormat)
            Return ms.ToArray()
        End Using
    End Function

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        pn_login.Visible = True
        Guna2Transition1.ShowSync(pn_login)
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        pn_login.Visible = True
        Guna2Transition1.HideSync(pn_login)
    End Sub

    Private Sub BtncreateaccButton_Click(sender As Object, e As EventArgs) Handles btncreateaccButton.Click
        ' Determine the selected user type
        If rdoEmployee.Checked Then
            usertype = "employee"
        ElseIf rdoEmployer.Checked Then
            usertype = "employer"
        Else
            MessageBox.Show("Please select a user type.")
            Exit Sub
        End If

        ' Check if any of the textboxes are blank
        If String.IsNullOrWhiteSpace(txtfirstname.Text) OrElse
       String.IsNullOrWhiteSpace(txtsecondname.Text) OrElse
       String.IsNullOrWhiteSpace(txtuname.Text) OrElse
       String.IsNullOrWhiteSpace(txtpass.Text) OrElse
       String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate password
        Dim password As String = txtpass.Text
        Dim passwordPattern As String = "^(?=.*[a-zA-Z])(?=.*\d)(?=.*[\W_]).{6,12}$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(password, passwordPattern) Then
            MessageBox.Show("Password must be 6-12 characters long and include at least one letter, one number, and one special character.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Hash the password before storing it
        Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(password)

        ' Check if a profile picture is selected
        Dim profilePictureData As Byte()
        If PictureBoxProfile.Image IsNot Nothing Then
            profilePictureData = ImageToByteArray(PictureBoxProfile.Image)
        Else
            MessageBox.Show("Please select a profile picture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Generate a unique ID for the user
        Dim userID As String = Guid.NewGuid().ToString()

        ' Proceed with registration if all validations pass
        Try
            Using connection As MySqlConnection = Database.GetConnection()
                connection.Open()

                ' Check if the username already exists
                Dim checkUsernameQuery As String = "SELECT COUNT(*) FROM registration WHERE username = @username"
                Using checkUsernameCmd As New MySqlCommand(checkUsernameQuery, connection)
                    checkUsernameCmd.Parameters.AddWithValue("@username", txtuname.Text)
                    Dim usernameCount As Integer = Convert.ToInt32(checkUsernameCmd.ExecuteScalar())
                    If usernameCount > 0 Then
                        MessageBox.Show("This username is taken. Please try another one.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using

                ' Check if the email already exists
                Dim checkEmailQuery As String = "SELECT COUNT(*) FROM registration WHERE email = @Email"
                Using checkEmailCmd As New MySqlCommand(checkEmailQuery, connection)
                    checkEmailCmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                    Dim emailCount As Integer = Convert.ToInt32(checkEmailCmd.ExecuteScalar())
                    If emailCount > 0 Then
                        MessageBox.Show("This email is already registered. Please try another one.", "Email Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using

                ' Insert the new registration record with the profile picture and generated UserID
                Dim regQuery As String = "INSERT INTO registration (UserID, firstname, secondname, username, password, email, user_type, profilepicture) VALUES (@UserID, @firstname, @secondname, @username, @password, @email, @user_type, @profilepicture)"
                Using regCmd As New MySqlCommand(regQuery, connection)
                    regCmd.Parameters.AddWithValue("@UserID", userID)
                    regCmd.Parameters.AddWithValue("@firstname", txtfirstname.Text)
                    regCmd.Parameters.AddWithValue("@secondname", txtsecondname.Text)
                    regCmd.Parameters.AddWithValue("@username", txtuname.Text)
                    regCmd.Parameters.AddWithValue("@password", hashedPassword)
                    regCmd.Parameters.AddWithValue("@email", txtEmail.Text) ' Add the email
                    regCmd.Parameters.AddWithValue("@user_type", usertype)
                    regCmd.Parameters.AddWithValue("@profilepicture", profilePictureData)
                    regCmd.ExecuteNonQuery()
                End Using

                ' Insert into the corresponding table based on the user type
                Dim userTableQuery As String
                If usertype = "employee" Then
                    userTableQuery = "INSERT INTO employee (UserID, firstname, secondname, username, profilepicture, email) VALUES (@UserID, @firstname, @secondname, @username, @profilepicture, @Email)"
                Else
                    userTableQuery = "INSERT INTO employer (UserID, firstname, secondname, username, profilepicture, email) VALUES (@UserID, @firstname, @secondname, @username, @profilepicture, @Email)"
                End If

                Using userTableCmd As New MySqlCommand(userTableQuery, connection)
                    userTableCmd.Parameters.AddWithValue("@UserID", userID)
                    userTableCmd.Parameters.AddWithValue("@firstname", txtfirstname.Text)
                    userTableCmd.Parameters.AddWithValue("@secondname", txtsecondname.Text)
                    userTableCmd.Parameters.AddWithValue("@username", txtuname.Text)
                    userTableCmd.Parameters.AddWithValue("@profilepicture", profilePictureData)
                    userTableCmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                    userTableCmd.ExecuteNonQuery()
                End Using

                ' Insert into the mailuser table
                Dim mailUserQuery As String = "INSERT INTO mailuser (email, username) VALUES (@Email, @Username)"
                Using mailUserCmd As New MySqlCommand(mailUserQuery, connection)
                    mailUserCmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                    mailUserCmd.Parameters.AddWithValue("@Username", txtuname.Text)
                    mailUserCmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Registration Successful, Proceed to LogIn", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Clear the textboxes and PictureBox after successful registration
                txtfirstname.Clear()
                txtsecondname.Clear()
                txtuname.Clear()
                txtpass.Clear()
                txtEmail.Clear()
                PictureBoxProfile.Image = Nothing
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    ' Login Page
    Private Async Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        ' Checking if any textbox is empty
        If String.IsNullOrWhiteSpace(txtunamelogin.Text) Then
            MessageBox.Show("Username cannot be empty.", "Login Error")
            ClearLoginFields()
            Return
        End If
        If String.IsNullOrWhiteSpace(txtpasslogin.Text) Then
            MessageBox.Show("Password cannot be empty.", "Login Error")
            ClearLoginFields()
            Return
        End If

        ' Checking if any radio button is selected
        If Not radioEmployee.Checked And Not radioEmployer.Checked Then
            MessageBox.Show("Please select either Employee or Employer.", "Login Error")
            ClearLoginFields()
            Return
        End If

        ' Determine the selected user type
        Dim selectedUserType As String = If(radioEmployee.Checked, "employee", "employer")

        ' Show the loading animation
        guna2ProgressIndicator1.Visible = True
        guna2ProgressIndicator1.Start()

        ' Run the query asynchronously to avoid blocking the UI
        Dim loginSuccessful As Boolean = Await Task.Run(Function() PerformLogin(selectedUserType))

        ' Hide the loading animation
        guna2ProgressIndicator1.Stop()
        guna2ProgressIndicator1.Visible = False

        ' Handle login result
        If loginSuccessful Then
            MessageBox.Show("Login successful!", "Welcome")
            ' Navigate to the appropriate dashboard
            If selectedUserType = "employee" Then
                EmployeeDash.Show()
            ElseIf selectedUserType = "employer" Then
                Employerdash.Show()
            End If
            Me.Hide()
        End If
    End Sub

    Private Function PerformLogin(selectedUserType As String) As Boolean
        Dim loginSuccessful As Boolean = False

        ' Define the connection string
        Using Mysqlcon As New MySqlConnection("Server=localhost;Database=ajira;Uid=root;Pwd=;")
            Try
                Mysqlcon.Open()

                ' Parameterized query to prevent SQL injection
                Dim checkQuery As String = "SELECT password, user_type FROM registration WHERE username = @username"
                Using command As New MySqlCommand(checkQuery, Mysqlcon)
                    command.Parameters.AddWithValue("@username", txtunamelogin.Text)

                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim storedHash As String = reader("password").ToString()
                            Dim userType As String = reader("user_type").ToString()

                            ' Verify the password
                            If BCrypt.Net.BCrypt.Verify(txtpasslogin.Text, storedHash) Then
                                ' Check user type and selection
                                If selectedUserType = userType Then
                                    UpdateLoginCount()
                                    LoggedInUsername = txtunamelogin.Text
                                    LoggedInUserType = userType
                                    loginSuccessful = True
                                Else
                                    ' Invoke on UI thread to avoid cross-thread error
                                    Me.Invoke(Sub()
                                                  MessageBox.Show("Invalid login details. Please check your credentials and user type.", "Login Error")
                                                  ClearLoginFields()
                                              End Sub)
                                End If
                            Else
                                ' Invoke on UI thread to avoid cross-thread error
                                Me.Invoke(Sub()
                                              MessageBox.Show("Invalid password.", "Login Error")
                                              ClearLoginFields()
                                          End Sub)
                            End If
                        Else
                            ' Invoke on UI thread to avoid cross-thread error
                            Me.Invoke(Sub()
                                          MessageBox.Show("Invalid username.", "Login Error")
                                          ClearLoginFields()
                                      End Sub)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                ' Invoke on UI thread to avoid cross-thread error
                Me.Invoke(Sub()
                              MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                          End Sub)
            Finally
                Mysqlcon.Close()
            End Try
        End Using

        Return loginSuccessful
    End Function

    ' Function to update login count
    Private Sub UpdateLoginCount()
        Using Mysqlcon As New MySqlConnection("Server=localhost;Database=ajira;Uid=root;Pwd=;")
            Try
                Mysqlcon.Open()

                Dim query As String = "UPDATE registration SET loginCount = loginCount + 1 WHERE username = @username"
                Using command As New MySqlCommand(query, Mysqlcon)
                    command.Parameters.AddWithValue("@username", LoggedInUsername)
                    command.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show("Failed to update login count: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Mysqlcon.Close()
            End Try
        End Using
    End Sub

    ' Clear login fields after login attempt
    Private Sub ClearLoginFields()
        txtunamelogin.Clear()
        txtpasslogin.Clear()
        radioEmployee.Checked = False
        radioEmployer.Checked = False
    End Sub



    ' Remember Me toggle switch
    Private Sub ToggleRememberMe_CheckedChanged(sender As Object, e As EventArgs) Handles toggleRememberMe.CheckedChanged
        My.Settings.RememberMe = toggleRememberMe.Checked
        If toggleRememberMe.Checked Then
            My.Settings.SavedUsername = txtunamelogin.Text
            My.Settings.SavedPassword = txtpasslogin.Text
        Else
            My.Settings.SavedUsername = ""
            My.Settings.SavedPassword = ""
        End If
        My.Settings.Save()
    End Sub

    Private Sub Showpass_Click(sender As Object, e As EventArgs) Handles showpass.Click
        ' Toggle password visibility
        If txtpasslogin.UseSystemPasswordChar Then
            ' Show password
            txtpasslogin.UseSystemPasswordChar = False
            showpass.Text = "Hide"
        Else
            ' Hide password
            txtpasslogin.UseSystemPasswordChar = True
            showpass.Text = "Show"
        End If
    End Sub


    Private Sub FindAccount_Click(sender As Object, e As EventArgs) Handles FindAccount.Click
        OTPRequestAndVerificationForm.Show()
    End Sub


End Class
