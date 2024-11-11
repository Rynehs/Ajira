Imports System.Net
Imports System.Net.Mail
Imports MySql.Data.MySqlClient

Public Class OTPRequestAndVerificationForm
    ' Declare the userID variable at the form level
    Private userID As String
    Private otpRequestCount As Integer = 0 ' Keep track of OTP requests
    Private otpExpirationTime As DateTime ' For OTP countdown timer
    Private otpTimer As New Timer() ' Timer for OTP validity countdown
    Private otpExpired As Boolean = False ' To track if OTP has expired

    ' OTP generation function
    Private Function GenerateOTP() As String
        Dim rng As New Random()
        Return rng.Next(100000, 999999).ToString()
    End Function

    ' Form Load Event - hide the OTP GroupBox and Guna2ProgressIndicator initially
    Private Sub OTPRequestAndVerificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBoxotp.Visible = False ' Hide the OTP GroupBox on load
        guna2ProgressIndicator1.Visible = False ' Hide the progress indicator on load
    End Sub

    Private Sub SendOtpEmail(ByVal recipientEmail As String, ByVal otpCode As String)
        Try
            ' Create a new mail message
            Dim mail As New MailMessage()

            ' Set the sender's email address
            mail.From = New MailAddress("ajiraassistance@gmail.com")

            ' Set the recipient email address
            mail.To.Add(recipientEmail)

            ' Set the subject of the email
            mail.Subject = "Your OTP Code"

            ' HTML content for the email body
            Dim htmlBody As String = "
            <html>
            <head>
                <style>
                    body {
                        font-family: Arial, sans-serif;
                        background-color: white;
                        color: #333333;
                        padding: 0;
                        margin: 0;
                    }
                    .header {
                        background-color: rgb(255,255,255);
                        padding: 20px;
                        text-align: center;
                    }
                    .header img {
                        width: 150px; /* Set logo size */
                    }
                    .header h1 {
                        color: white;
                        font-size: 24px;
                        margin: 0;
                    }
                    .content {
                        padding: 20px;
                        font-size: 18px;
                    }
                    .footer {
                        background-color: rgb(0, 148, 186);
                        color: white;
                        text-align: center;
                        padding: 10px;
                        font-size: 14px;
                    }
                    .footer a {
                        color: white;
                        text-decoration: none;
                    }
                </style>
            </head>
            <body>
                <div class='header'>
                    <img src='cid:logo' alt='Your Logo'/>
                    <h1>Ajira</h1>
                </div>
                <div class='content'>
                    <p>Hello,</p>
                    <p>Your OTP code is: <strong>" & otpCode & "</strong></p>
                    <p>Please use this code to complete your password reset process.</p>
                </div>
                <div class='footer'>
                    <p>&copy; 2024 Your Company. All rights reserved.</p>
                    <p><a href='https://yourcompany.com'>Visit our website</a></p>
                </div>
            </body>
            </html>"

            ' Set the body of the email with the HTML content
            mail.Body = htmlBody
            mail.IsBodyHtml = True

            ' Attach the logo (assuming it's in the project directory)
            Dim logoPath As String = "E:\School Work\Ajira\Ajira\Resources\logo\logo.png"
            Dim logo As New LinkedResource(logoPath)
            logo.ContentId = "logo"

            ' Alternate view to include the logo inline
            Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(htmlBody, Nothing, "text/html")
            htmlView.LinkedResources.Add(logo)
            mail.AlternateViews.Add(htmlView)

            ' Create a new SMTP client and configure it
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New NetworkCredential("ajiraassistance@gmail.com", "muvb nxhd ydex qatv")

            ' Send the email
            smtp.Send(mail)

        Catch ex As Exception
            MessageBox.Show("Failed to send OTP: " & ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Request OTP method with loading indicator
    Private Sub RequestNewOtp()
        Dim emailOrUsername As String = txtEmailOrUsername.Text

        ' Show the progress indicator and disable the button
        guna2ProgressIndicator1.Visible = True
        guna2ProgressIndicator1.Start() ' Start the progress animation
        BtnRequestOtp.Enabled = False

        ' Validate if the user exists in the registration table
        Try
            Using connection As MySqlConnection = Database.GetConnection()
                Dim query As String = "SELECT UserID, email FROM registration WHERE email = @EmailOrUsername OR username = @EmailOrUsername"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@EmailOrUsername", emailOrUsername)
                    connection.Open()
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        userID = reader("UserID").ToString()  ' Auto-fill userID from the registration table
                    Else
                        MessageBox.Show("No account found with this email or username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using
            End Using

            ' Generate OTP and set expiration time
            Dim otpCode As String = GenerateOTP()
            otpExpirationTime = DateTime.Now.AddMinutes(1)

            ' Insert or Update OTP in the users table
            Using connection As MySqlConnection = Database.GetConnection()
                Dim upsertOtpQuery As String = "
                INSERT INTO users (user_id, email, reset_token, reset_token_expiration) 
                VALUES (@UserID, @Email, @OTP, @ExpiresAt) 
                ON DUPLICATE KEY UPDATE reset_token = @OTP, reset_token_expiration = @ExpiresAt"
                Using cmd As New MySqlCommand(upsertOtpQuery, connection)
                    cmd.Parameters.AddWithValue("@UserID", userID)
                    cmd.Parameters.AddWithValue("@Email", emailOrUsername)
                    cmd.Parameters.AddWithValue("@OTP", otpCode)
                    cmd.Parameters.AddWithValue("@ExpiresAt", otpExpirationTime)
                    connection.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Send OTP to user via email
            SendOtpEmail(emailOrUsername, otpCode)

            ' Make the GroupBox for OTP visible and set the email/username text box as read-only
            GroupBoxotp.Visible = True
            txtEmailOrUsername.ReadOnly = True
            otpRequestCount += 1
            otpExpired = False ' Reset expiration flag

            ' Check if this is the third OTP request
            If otpRequestCount = 3 Then
                Dim result = MessageBox.Show("You've requested OTP 3 times. Do you want to change your email?", "Change Email?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    txtEmailOrUsername.ReadOnly = False ' Allow email change
                    otpRequestCount = 0 ' Reset the request count
                    GroupBoxotp.Visible = False ' Hide OTP GroupBox for new email
                End If
            End If

            ' Start the OTP countdown timer
            otpTimer.Interval = 1000 ' 1 second intervals
            AddHandler otpTimer.Tick, AddressOf UpdateTimerLabel
            otpTimer.Start()

            MessageBox.Show("An OTP has been sent to your email. Please enter it below to verify.", "OTP Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Hide the progress indicator and enable the button after the process is complete
            guna2ProgressIndicator1.Visible = False
            guna2ProgressIndicator1.Stop() ' Stop the progress animation
            BtnRequestOtp.Enabled = True
        End Try
    End Sub

    ' Timer Tick event for updating countdown
    Private Sub UpdateTimerLabel(sender As Object, e As EventArgs)
        Dim remaining As TimeSpan = otpExpirationTime - DateTime.Now
        If remaining.TotalSeconds > 0 Then
            lblTimer.Text = "Time left: " & remaining.ToString("mm\:ss")
        Else
            otpExpired = True
            lblTimer.Text = "OTP Expired."
            otpTimer.Stop() ' Stop the timer once OTP expires
        End If
    End Sub

    ' OTP verification method
    Private Sub VerifyOtp()
        Dim enteredOtp As String = txtOtp.Text.Trim()  ' Trim any extra spaces

        If otpExpired Then
            MessageBox.Show("The OTP has expired. Please request a new one.", "OTP Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if the entered OTP matches the one stored in the database
        Try
            Using connection As MySqlConnection = Database.GetConnection()
                Dim query As String = "SELECT reset_token, reset_token_expiration FROM users WHERE user_id = @UserID"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@UserID", userID)
                    connection.Open()

                    ' Fetch the stored OTP and expiration time from the database
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim storedOtp As String = reader("reset_token").ToString().Trim()
                            Dim expirationTime As DateTime = Convert.ToDateTime(reader("reset_token_expiration"))

                            ' Check if the OTP has expired in the database
                            If DateTime.Now > expirationTime Then
                                MessageBox.Show("The OTP has expired. Please request a new one.", "OTP Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return
                            End If

                            ' Compare entered and stored OTP
                            If String.Equals(storedOtp, enteredOtp, StringComparison.Ordinal) Then
                                MessageBox.Show("OTP verified successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                ' Proceed to password reset or other actions
                            Else
                                MessageBox.Show("Invalid OTP. Please try again.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("OTP not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' OTP Request button click event
    Private Sub BtnRequestOtp_Click(sender As Object, e As EventArgs) Handles BtnRequestOtp.Click
        RequestNewOtp() ' Call the OTP request method
    End Sub

    ' OTP Verify button click event
    Private Sub BtnVerifyOtp_Click(sender As Object, e As EventArgs) Handles BtnVerifyOtp.Click
        VerifyOtp() ' Call the OTP verification method
    End Sub
End Class
