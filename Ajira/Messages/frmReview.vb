Imports MySql.Data.MySqlClient

Public Class frmReview
    Private employeeUsername As String
    Private employerUsername As String

    ' Constructor accepting employee and employer usernames
    Public Sub New(empUsername As String, empUser As String)
        InitializeComponent()
        employeeUsername = empUsername
        employerUsername = empUser
        LoadReviewDetails()
    End Sub

    ' Load any initial details or past reviews here if necessary
    Private Sub LoadReviewDetails()
        ' For example, display employee's username in a label
        lblEmployeeUsername.Text = employeeUsername
    End Sub

    ' Submit review when the button is clicked
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim reviewText As String = txtReview.Text ' Assuming you have a TextBox named txtReview
        Dim rating As Integer = CInt(nudRating.Value) ' Assuming you have a NumericUpDown named nudRating for rating

        ' Validate input
        If String.IsNullOrWhiteSpace(reviewText) Then
            MessageBox.Show("Please enter a review.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Save the review to the database
        SaveReview(employeeUsername, employerUsername, reviewText, rating)
    End Sub

    Private Sub SaveReview(empUsername As String, empUser As String, reviewText As String, rating As Integer)
        Dim connectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;" ' Update this with your actual connection string

        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "INSERT INTO reviews (employeeusername, employerusername, review, Rating) VALUES (@empUsername, @empUser, @reviewText, @rating)"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@empUsername", empUsername)
                cmd.Parameters.AddWithValue("@empUser", empUser)
                cmd.Parameters.AddWithValue("@reviewText", reviewText)
                cmd.Parameters.AddWithValue("@rating", rating)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Review submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close() ' Close the review form after submission
                Catch ex As MySqlException
                    MessageBox.Show("An error occurred while submitting the review: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class

