Imports System.IO
Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class Employerdash
    Private ReadOnly ConnectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"

    ' Boolean flag to track the collapsed state of gunaPanel2 (side panel)
    Private isCollapsed As Boolean = False

    ' Width for the collapsed and expanded states of gunaPanel2
    Private Const CollapsedWidth As Integer = 50
    Private Const ExpandedWidth As Integer = 200

    ' Speed for the smooth collapsing/expanding
    Private Const SlideSpeed As Integer = 10

    ' Timer for smooth collapsing/expanding
    Private WithEvents collapseTimer As New Timer()

    ' Constructor or Load event to set up the timer
    Private Sub Employerdash_Load(sender As Object, e As EventArgs) Handles Me.Load
        collapseTimer.Interval = 10 ' Set the timer interval (adjust for smoother or faster animation)
        Childform(Homeemployer)
    End Sub

    ' Method to toggle the gunaPanel2 collapse state
    Private Sub TogglePanel_Click(sender As Object, e As EventArgs) Handles toggleButton.Click
        collapseTimer.Start() ' Start the timer for smooth animation
    End Sub

    ' Timer Tick event to gradually collapse/expand the panel
    Private Sub collapseTimer_Tick(sender As Object, e As EventArgs) Handles collapseTimer.Tick
        If isCollapsed Then
            ' Expand the panel gradually
            If gunaPanel2.Width < ExpandedWidth Then
                gunaPanel2.Width += SlideSpeed
            Else
                ' Stop expanding once full width is reached
                gunaPanel2.Width = ExpandedWidth
                collapseTimer.Stop()
                isCollapsed = False
            End If
        Else
            ' Collapse the panel gradually
            If gunaPanel2.Width > CollapsedWidth Then
                gunaPanel2.Width -= SlideSpeed
            Else
                ' Stop collapsing once collapsed width is reached
                gunaPanel2.Width = CollapsedWidth
                collapseTimer.Stop()
                isCollapsed = True
            End If
        End If

        ' Adjust the panelemployer size during the animation
        ResizePanelEmployer()
    End Sub

    ' Method to resize panelemployer based on the state of gunaPanel2
    Private Sub ResizePanelEmployer()
        Dim rightPadding As Integer = 5 ' Padding between gunaPanel2 and panelemployer

        ' Calculate the new width for panelemployer based on the form's width and gunaPanel2's width
        panelemployer.Left = gunaPanel2.Right + rightPadding
        panelemployer.Width = Me.ClientSize.Width - panelemployer.Left - rightPadding

        ' Ensure the controls inside panelemployer resize or fit within panelemployer
        For Each ctrl As Control In panelemployer.Controls
            ctrl.Width = panelemployer.ClientSize.Width
            ctrl.Height = panelemployer.ClientSize.Height
        Next
    End Sub

    ' Handle form resize event to adapt panel sizes when the form is resized
    Private Sub Employerdash_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ResizePanelEmployer()
    End Sub

    ' Method to load child forms into the panel
    Sub Childform(ByVal panel As Form)
        panelemployer.Controls.Clear()
        panel.TopLevel = False
        panelemployer.Controls.Add(panel)
        panel.Show()
    End Sub

    ' Event handler for home button
    Private Sub Home_Click_1(sender As Object, e As EventArgs) Handles home.Click
        Childform(Homeemployer)
    End Sub

    ' Event handler for profile button
    Private Sub Profile_Click_1(sender As Object, e As EventArgs) Handles profile.Click
        Childform(employerdetailsupdate)
    End Sub

    ' Event handler for workers button
    Private Sub Workers_Click_1(sender As Object, e As EventArgs) Handles Workers.Click
        Childform(Frmworkers)
    End Sub

    ' Common method to execute SQL commands (insert, update, delete)
    Private Sub ExecuteQuery(query As String, parameters As Dictionary(Of String, Object))
        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters to the command
                For Each param In parameters
                    cmd.Parameters.AddWithValue(param.Key, param.Value)
                Next
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Method to submit a rating and update the employee's average rating
    Private Sub SubmitRating(employerId As Integer, employeeId As Integer, rating As Integer, comment As String)
        Dim query As String = "INSERT INTO ratings (employer_id, employee_id, rating, comment) VALUES (@employerId, @employeeId, @rating, @comment); 
                               UPDATE employee SET average_rating = (SELECT AVG(rating) FROM ratings WHERE employee_id = @employeeId) WHERE id = @employeeId;"

        ' Create parameters
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@employerId", employerId},
            {"@employeeId", employeeId},
            {"@rating", rating},
            {"@comment", comment}
        }

        ' Execute the query with parameters
        ExecuteQuery(query, parameters)
    End Sub

    ' Event handler for job posting button
    Private Sub Btnjobspost1_Click(sender As Object, e As EventArgs) Handles Btnjobspost1.Click
        Childform(jobspost)
    End Sub

    Private Sub btnmsg_Click(sender As Object, e As EventArgs) Handles btnmsg.Click
        Childform(Messaging)
    End Sub

    Private Sub Buttonsettings_Click(sender As Object, e As EventArgs) Handles Buttonsettings.Click
        Childform(EmployerSettingForm)
    End Sub
End Class