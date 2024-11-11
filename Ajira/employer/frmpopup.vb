Imports MySql.Data.MySqlClient
Imports System.IO

' FrmEmployeeProfile Form
Public Class Frmpopup
    Private ReadOnly Username As String

    Public Sub New(selectedUsername As String)
        InitializeComponent()
        Me.Username = selectedUsername
        LoadEmployeeProfile()
        LoadEmployeeReviews()
    End Sub

    Private Sub LoadEmployeeProfile()
        ' Update query to include all required fields
        Dim query As String = "SELECT username, firstname, secondname, email, phoneNumber, county, subcounty, location, availability, skills, experience, profilePicture, bgimage FROM employee WHERE username = @Username"
        Dim connectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"

        Try
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", Username)
                    conn.Open()

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then


                            FirstName.Text = reader("firstname").ToString()
                            LastName.Text = reader("secondname").ToString()
                            Email.Text = reader("email").ToString()
                            PhoneNumber.Text = reader("phoneNumber").ToString()
                            County.Text = reader("county").ToString()
                            SubCounty.Text = reader("subcounty").ToString()
                            Location.Text = reader("location").ToString()


                            ' Load profile picture
                            If Not IsDBNull(reader("profilePicture")) Then
                                Dim imageBytes() As Byte = CType(reader("profilePicture"), Byte())
                                Using ms As New MemoryStream(imageBytes)
                                    PictureBoxProfile.Image = Image.FromStream(ms)
                                End Using
                            End If

                            ' Load background image
                            If Not IsDBNull(reader("bgimage")) Then
                                Dim bgImageBytes() As Byte = CType(reader("bgimage"), Byte())
                                If bgImageBytes?.Length > 0 Then
                                    Using ms As New MemoryStream(bgImageBytes)
                                        PictureBoxBg.Image = Image.FromStream(ms)
                                    End Using
                                End If
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading profile: " & ex.Message)
        End Try
    End Sub


    Private Sub LoadEmployeeReviews()
        Try
            ' SQL query to fetch reviews from the reviews table
            Dim query As String = "SELECT employerusername, review, rating " &
                              "FROM reviews " &
                              "WHERE employeeusername = @Username " &
                              "ORDER BY rating DESC"

            Dim connectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"

            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", Username)
                    conn.Open()

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        ' Clear existing rows before adding new ones
                        ReviewsDataGridView.Rows.Clear()

                        ' Check if columns exist, add them if not
                        If ReviewsDataGridView.Columns.Count = 0 Then
                            ' Adding columns with headers
                            ReviewsDataGridView.Columns.Add("EmployerUsername", "Employer Username")
                            ReviewsDataGridView.Columns.Add("ReviewText", "Review Text")
                            ReviewsDataGridView.Columns.Add("Rating", "Rating")
                        End If

                        ' Check if there are any rows returned
                        If reader.HasRows Then
                            While reader.Read()
                                ' Handle DBNull values for employerusername, review, and rating
                                Dim employerUsername As String = If(IsDBNull(reader("employerusername")), "Unknown", reader("employerusername").ToString())
                                Dim reviewText As String = If(IsDBNull(reader("review")), String.Empty, reader("review").ToString())
                                Dim rating As Integer = If(IsDBNull(reader("rating")), 0, Convert.ToInt32(reader("rating")))

                                ' Add data to the DataGridView
                                ReviewsDataGridView.Rows.Add(employerUsername, reviewText, rating)
                            End While
                        Else
                            ' Display a message when no reviews are found
                            MessageBox.Show("No reviews found for the selected employee.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Display an error message in case something goes wrong
            MessageBox.Show("An error occurred while loading reviews: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
