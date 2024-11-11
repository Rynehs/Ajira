Imports MySql.Data.MySqlClient

Public Class jobspost
    ' Define the MySQL connection string
    Dim connectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"
    ' Store the employer's Username
    Public LoggedInUsername As String

    Private Sub Jobspost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if the logged-in username is set (i.e., not Nothing or an empty string)
        If String.IsNullOrEmpty(Home.LoggedInUsername) Then
            MessageBox.Show("Username is not set. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close() ' Close the form if Username is not set
        Else
            LoggedInUsername = Home.LoggedInUsername ' Set the logged-in username
        End If
    End Sub

    Private Sub btnPostJob_Click(sender As Object, e As EventArgs) Handles btnPostJob.Click
        ' Set the MinDate for the date pickers to prevent selecting past dates
        dtpStartDate.MinDate = DateTime.Now
        dtpEndDate.MinDate = DateTime.Now

        ' Get the job details from the form fields
        Dim jobTitle As String = txtJobTitle.Text
        Dim jobDescription As String = txtJobDescription.Text
        Dim location As String = txtLocation.Text
        Dim startDate As DateTime = dtpStartDate.Value
        Dim endDate As DateTime = dtpEndDate.Value
        Dim proposedPayment As Decimal

        ' Check if all required fields are filled
        If jobTitle = "" Or jobDescription = "" Or location = "" Then
            MessageBox.Show("Please fill all the fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Validate proposed payment input
        If Not Decimal.TryParse(txtProposedPayment.Text.Replace("Ksh", "").Replace(",", "").Trim(), proposedPayment) Then
            MessageBox.Show("Please enter a valid proposed payment amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ' Insert the job into the MySQL database using the employer's logged-in Username
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim query As String = "INSERT INTO job_posts (username, jobtitle, jobdescription, location, start_date, end_date, proposedpayment) " &
                                      "VALUES (@Username, @jobTitle, @jobDescription, @location, @startDate, @endDate, @proposedPayment)"

                Using cmd As New MySqlCommand(query, conn)
                    ' Use the employer Username stored during login
                    cmd.Parameters.AddWithValue("@Username", LoggedInUsername)
                    cmd.Parameters.AddWithValue("@jobTitle", jobTitle)
                    cmd.Parameters.AddWithValue("@jobDescription", jobDescription)
                    cmd.Parameters.AddWithValue("@location", location)
                    cmd.Parameters.AddWithValue("@startDate", startDate)
                    cmd.Parameters.AddWithValue("@endDate", endDate)
                    cmd.Parameters.AddWithValue("@proposedPayment", proposedPayment)

                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Job posted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Catch ex As MySqlException
                MessageBox.Show("An error occurred while posting the job: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub txtProposedPayment_TextChanged(sender As Object, e As EventArgs) Handles txtProposedPayment.TextChanged
        Dim input As String = txtProposedPayment.Text.Replace("Ksh", "").Replace(",", "").Trim()

        ' If input is numeric, format it as currency with Ksh prefix
        If IsNumeric(input) Then
            Dim parsedAmount As Decimal = Convert.ToDecimal(input)
            txtProposedPayment.Text = "Ksh " & parsedAmount.ToString("N0") ' Format as currency (no decimal places)
            txtProposedPayment.SelectionStart = txtProposedPayment.Text.Length ' Move the cursor to the end
        Else
            ' Remove invalid non-numeric characters, except the "Ksh" prefix
            If txtProposedPayment.Text.Length > 3 Then
                txtProposedPayment.Text = "Ksh "
                txtProposedPayment.SelectionStart = txtProposedPayment.Text.Length ' Keep cursor at the end
            End If
        End If
    End Sub

    Private Sub Guna2ShadowPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2ShadowPanel1.Paint

    End Sub
End Class
