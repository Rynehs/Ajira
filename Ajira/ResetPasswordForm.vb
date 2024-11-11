Imports MySql.Data.MySqlClient

Public Class ResetPasswordForm
    Private userID As String

    Public Sub New(userID As String)
        InitializeComponent()
        Me.userID = userID
    End Sub

    Private Sub BtnResetPassword_Click(sender As Object, e As EventArgs) Handles BtnResetPassword.Click
        Dim newPassword As String = txtNewPassword.Text
        Dim confirmPassword As String = txtConfirmPassword.Text

        ' Validate if passwords match
        If newPassword <> confirmPassword Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate password strength
        Dim passwordPattern As String = "^(?=.*[a-zA-Z])(?=.*\d)(?=.*[\W_]).{6,12}$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(newPassword, passwordPattern) Then
            MessageBox.Show("Password must be 6-12 characters long and include at least one letter, one number, and one special character.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Hash the new password
        Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(newPassword)

        ' Update the password in the database
        Try
            Using connection As MySqlConnection = Database.GetConnection()
                Dim updateQuery As String = "UPDATE registration SET password = @Password WHERE UserID = @UserID"
                Using cmd As New MySqlCommand(updateQuery, connection)
                    cmd.Parameters.AddWithValue("@Password", hashedPassword)
                    cmd.Parameters.AddWithValue("@UserID", userID)
                    connection.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Password has been successfully reset.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
