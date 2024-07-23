Imports MySql.Data.MySqlClient
Imports System.IO
Public Class employeeDash
    Sub Childform(ByVal panel As Form)
        panelhome.Controls.Clear()
        panel.TopLevel = False
        panelhome.Controls.Add(panel)
        panel.Show()

    End Sub
    Private Sub BtnUpload_Click(sender As Object, e As EventArgs)
        Dim openFileDialog As New OpenFileDialog With {
            .Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        }

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = openFileDialog.FileName
            Dim imageBytes As Byte() = File.ReadAllBytes(imagePath)

            Using connection As New MySqlConnection("Server=localhost;Database=ajira;Uid=root;Pwd=;")
                Dim query As String = "INSERT INTO images (image_data) VALUES (@image_data)"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@image_data", imageBytes)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Image uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadImageFromDatabase()
    End Sub

    Private Sub LoadImageFromDatabase()
        Using connection As New MySqlConnection("Server=localhost;Database=ajira;Uid=root;Pwd=;")
            Dim query As String = "SELECT image_data FROM images ORDER BY id DESC LIMIT 1"
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        Dim imageBytes As Byte() = CType(reader("image_data"), Byte())
                        Using ms As New MemoryStream(imageBytes)
                            Guna2CirclePictureBox1.Image = Image.FromStream(ms)
                        End Using
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles profile.Click
        Childform(Frmemployeedetails)
    End Sub



    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        Dim pop As New OpenFileDialog
        If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Guna2CirclePictureBox1.Image = Image.FromFile(pop.FileName)
        End If
    End Sub
End Class
