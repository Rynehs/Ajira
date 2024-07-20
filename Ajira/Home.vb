Imports MySql.Data.MySqlClient
Public Class home
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        pn_registration.Visible = True
        Guna2Transition1.HideSync(pn_registration)
    End Sub
    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        pn_registration.Visible = True
        Guna2Transition1.ShowSync(pn_registration)
    End Sub


    Private Sub BtncreateaccButton_Click(sender As Object, e As EventArgs) Handles btncreateaccButton.Click
        ' Check if any of the textboxes are blank
        If String.IsNullOrWhiteSpace(txtfirstname.Text) OrElse
       String.IsNullOrWhiteSpace(txtsecondname.Text) OrElse
       String.IsNullOrWhiteSpace(txtuname.Text) OrElse
       String.IsNullOrWhiteSpace(txtpass.Text) Then

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

        ' If all fields are filled and password is valid, proceed with registration
        Try
            Using connection As MySqlConnection = Database.GetConnection()
                ' Check if the username already exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM registration WHERE username = @username"
                Using checkCmd As New MySqlCommand(checkQuery, connection)
                    checkCmd.Parameters.AddWithValue("@username", txtuname.Text)

                    connection.Open()
                    Dim userCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    connection.Close()

                    If userCount > 0 Then
                        MessageBox.Show("This username is taken. Please try another one.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End Using

                ' Insert the new registration record
                Dim query As String = "INSERT INTO registration (firstname, secondname, username, password) VALUES (@firstname, @secondname, @username, @password)"
                Using cm As New MySqlCommand(query, connection)
                    cm.Parameters.AddWithValue("@firstname", txtfirstname.Text)
                    cm.Parameters.AddWithValue("@secondname", txtsecondname.Text)
                    cm.Parameters.AddWithValue("@username", txtuname.Text)
                    cm.Parameters.AddWithValue("@password", txtpass.Text)

                    connection.Open()
                    cm.ExecuteNonQuery()

                    MessageBox.Show("Save Successful, Proceed to LogIn", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Clear the textboxes after successful registration
                    txtfirstname.Clear()
                    txtsecondname.Clear()
                    txtuname.Clear()
                    txtpass.Clear()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        ' Check if any textbox is empty
        If String.IsNullOrWhiteSpace(txtunamelogin.Text) Then
            MessageBox.Show("Username cannot be empty.", "Login Error")
            Return
        End If
        If String.IsNullOrWhiteSpace(txtpasslogin.Text) Then
            MessageBox.Show("Password cannot be empty.", "Login Error")
            Return
        End If

        ' Define the connection string
        Using Mysqlcon As New MySqlConnection("Server=localhost;Database=ajira;Uid=root;Pwd=;")
            Dim reader As MySqlDataReader

            Try
                ' Open the connection
                Mysqlcon.Open()

                ' Use parameterized query to prevent SQL injection
                Dim query As String = "SELECT * FROM registration WHERE username = @username AND password = @password"
                Using command As New MySqlCommand(query, Mysqlcon)
                    command.Parameters.AddWithValue("@username", txtunamelogin.Text)
                    command.Parameters.AddWithValue("@password", txtpasslogin.Text)

                    ' Execute the query
                    reader = command.ExecuteReader()

                    Dim count As Integer = 0
                    While reader.Read()
                        count += 1
                    End While

                    ' Check the result
                    If count = 1 Then
                        MessageBox.Show("Login successful!", "Welcome")
                        ' Clear the textboxes after successful login
                        txtunamelogin.Clear()
                        txtpasslogin.Clear()

                        Dim dashboard As New Dashboard
                        dashboard.Show()
                        Me.Hide() ' Hide the login form

                    ElseIf count > 1 Then
                        MessageBox.Show("Duplicate usernames found, please contact administrator.", "Login Error")
                    Else
                        MessageBox.Show("Invalid username or password.", "Login Error")
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Database Error")
            Finally
                Mysqlcon.Close()
            End Try
        End Using
    End Sub

End Class
