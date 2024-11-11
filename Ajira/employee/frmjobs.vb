Imports MySql.Data.MySqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmJobs
    ' Define the MySQL connection string
    Dim connectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"

    Private Sub frmJobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadJobPosts()
    End Sub

    ' Method to load jobs into the DataGridView
    Private Sub LoadJobPosts(Optional ByVal filter As String = "")
        Dim query As String = "SELECT jobtitle AS 'Job Title', jobdescription AS 'Description', location AS 'Location', start_date AS 'Start Date', end_date AS 'End Date', username AS 'Employer' FROM job_posts"

        ' Add filter to query if provided
        If Not String.IsNullOrWhiteSpace(filter) Then
            query &= " WHERE jobtitle LIKE @filter OR location LIKE @filter"
        End If

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim adapter As New MySqlDataAdapter(query, conn)

                ' Set parameter for filtering
                If Not String.IsNullOrWhiteSpace(filter) Then
                    adapter.SelectCommand.Parameters.AddWithValue("@filter", "%" & filter & "%")
                End If

                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Bind the DataTable to the DataGridView
                dgvJobs.DataSource = dt

                ' Auto-fit the columns
                dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                ' Add the "Contact Employer" button column
                If dgvJobs.Columns("ContactEmployer") Is Nothing Then
                    Dim contactButton As New DataGridViewButtonColumn()
                    contactButton.HeaderText = "Contact"
                    contactButton.Text = "Contact Employer"
                    contactButton.UseColumnTextForButtonValue = True
                    contactButton.Name = "ContactEmployer"
                    dgvJobs.Columns.Add(contactButton)
                End If

                ' Add the "Send Interest" button column
                If dgvJobs.Columns("SendInterest") Is Nothing Then
                    Dim interestButton As New DataGridViewButtonColumn()
                    interestButton.HeaderText = "Interest"
                    interestButton.Text = "Send Interest"
                    interestButton.UseColumnTextForButtonValue = True
                    interestButton.Name = "SendInterest"
                    dgvJobs.Columns.Add(interestButton)
                End If

            Catch ex As MySqlException
                MessageBox.Show("An error occurred while loading the jobs: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    ' Handle the DataGridView button click event
    Private Sub dgvJobs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJobs.CellContentClick
        ' Check if the user clicked on the "Contact Employer" button
        If e.ColumnIndex = dgvJobs.Columns("ContactEmployer").Index AndAlso e.RowIndex >= 0 Then
            ' Retrieve the employer username from the selected row
            Dim employerUsername As String = dgvJobs.Rows(e.RowIndex).Cells("Employer").Value.ToString()

            ' Open the jobmessage form and pass the employer username
            Dim messageForm As New jobmessage(employerUsername)
            messageForm.Show()
        End If

        ' Check if the user clicked on the "Send Interest" button
        If e.ColumnIndex = dgvJobs.Columns("SendInterest").Index AndAlso e.RowIndex >= 0 Then
            ' Retrieve the employer username and job title from the selected row
            Dim employerUsername As String = dgvJobs.Rows(e.RowIndex).Cells("Employer").Value.ToString()
            Dim jobTitle As String = dgvJobs.Rows(e.RowIndex).Cells("Job Title").Value.ToString()

            ' Send the interest notification
            SendInterestNotification(employerUsername, jobTitle)
        End If
    End Sub

    ' Method to send an interest notification to the employer
    Private Sub SendInterestNotification(employerUsername As String, jobTitle As String)
        ' Assume that the logged-in employee's username is stored in Home.LoggedInUsername
        Dim employeeUsername As String = Home.LoggedInUsername

        ' Insert the notification into the notifications table with correct column names
        Dim query As String = "INSERT INTO notifications (Message, DateSent, IsRead, EmployeeUsername, EmployerUsername) " &
                          "VALUES (@Message, @DateSent, @IsRead, @EmployeeUsername, @EmployerUsername)"

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    ' Add parameters for the query
                    cmd.Parameters.AddWithValue("@Message", "I am interested in your job posting: " & jobTitle)
                    cmd.Parameters.AddWithValue("@DateSent", DateTime.Now)
                    cmd.Parameters.AddWithValue("@IsRead", False)  ' Set the IsRead field to False initially
                    cmd.Parameters.AddWithValue("@EmployeeUsername", employeeUsername)
                    cmd.Parameters.AddWithValue("@EmployerUsername", employerUsername)

                    ' Execute the query
                    cmd.ExecuteNonQuery()
                End Using

                ' Show success message
                MessageBox.Show("Interest notification sent successfully!", "Notification Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As MySqlException
                ' Show error message in case of exception
                MessageBox.Show("An error occurred while sending the notification: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    ' Handle the export functionality
    Private Sub btnexport_Click(sender As Object, e As EventArgs) Handles btnexport.Click
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "Excel Files|*.xlsx|PDF Files|*.pdf"
        saveFileDialog.Title = "Export Jobs Data"

        If saveFileDialog.ShowDialog = DialogResult.OK Then
            If Path.GetExtension(saveFileDialog.FileName).ToLower() = ".xlsx" Then
                ExportToExcel(saveFileDialog.FileName)
            ElseIf Path.GetExtension(saveFileDialog.FileName).ToLower() = ".pdf" Then
                ExportToPDF(saveFileDialog.FileName)
            End If
        End If
    End Sub

    ' Method to export data to Excel
    Private Sub ExportToExcel(ByVal filePath As String)
        Dim excelApp As New Excel.Application
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add
        Dim worksheet As Excel.Worksheet = workbook.Sheets(1)

        ' Export the column headers
        For i As Integer = 1 To dgvJobs.Columns.Count
            worksheet.Cells(1, i).Value = dgvJobs.Columns(i - 1).HeaderText
        Next

        ' Export the data rows
        For i As Integer = 0 To dgvJobs.Rows.Count - 1
            For j As Integer = 0 To dgvJobs.Columns.Count - 1
                worksheet.Cells(i + 2, j + 1).Value = dgvJobs.Rows(i).Cells(j).Value
            Next
        Next

        workbook.SaveAs(filePath)
        workbook.Close()
        excelApp.Quit()

        ' Release COM objects to avoid Excel process hanging
        System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)

        MessageBox.Show("Data exported to Excel successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Method to export data to PDF
    Private Sub ExportToPDF(ByVal filePath As String)
        Dim pdfDoc As New Document(PageSize.A4, 10, 10, 10, 10)
        PdfWriter.GetInstance(pdfDoc, New FileStream(filePath, FileMode.Create))
        pdfDoc.Open()

        ' Create a table with the same number of columns as the DataGridView
        Dim pdfTable As New PdfPTable(dgvJobs.ColumnCount)

        ' Set custom widths for columns
        pdfTable.SetWidths(New Single() {2.0F, 3.0F, 3.0F, 2.0F, 2.0F, 2.0F})

        ' Add the headers
        For Each column As DataGridViewColumn In dgvJobs.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            pdfTable.AddCell(cell)
        Next

        ' Add the rows
        For Each row As DataGridViewRow In dgvJobs.Rows
            For Each cell As DataGridViewCell In row.Cells
                pdfTable.AddCell(If(cell.Value IsNot Nothing, cell.Value.ToString(), ""))
            Next
        Next

        pdfDoc.Add(pdfTable)
        pdfDoc.Close()

        MessageBox.Show("Data exported to PDF successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Method to filter jobs by title or location
    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        Dim filter As String = txtFilter.Text.Trim()
        ' Only filter with meaningful input
        If filter.Length >= 2 Then
            LoadJobPosts(filter)
        End If
    End Sub

    ' Confirm close form
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub
End Class
