Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class EmployeeDash
    ' Boolean flags to track panel animation and state
    Private isCollapsed As Boolean = False
    Private isAnimating As Boolean = False
    Private isExpanding As Boolean = False

    ' Width for the collapsed and expanded states of gunaPanel2
    Private Const CollapsedWidth As Integer = 50
    Private Const ExpandedWidth As Integer = 200

    ' The step size for animation (how much the panel width changes per tick)
    Private Const AnimationStep As Integer = 10

    ' Add a Timer control in the designer or dynamically
    Private WithEvents PanelAnimationTimer As New Timer With {.Interval = 10}

    ' This is the shared variable for the logged-in username
    Public Shared LoggedInUsername As String

    ' Method to toggle the gunaPanel2 collapse/expand state
    Private Sub TogglePanel_Click(sender As Object, e As EventArgs) Handles toggleButton.Click
        If Not isAnimating Then
            ' Start the animation process
            isAnimating = True
            isExpanding = isCollapsed
            PanelAnimationTimer.Start()
        End If
    End Sub

    ' Timer tick event to handle panel expansion/collapse animation
    Private Sub PanelAnimationTimer_Tick(sender As Object, e As EventArgs) Handles PanelAnimationTimer.Tick
        If isExpanding Then
            ' Expanding the panel
            If gunaPanel2.Width < ExpandedWidth Then
                gunaPanel2.Width += AnimationStep
                If gunaPanel2.Width >= ExpandedWidth Then
                    gunaPanel2.Width = ExpandedWidth
                    FinishAnimation()
                End If
            End If
        Else
            ' Collapsing the panel
            If gunaPanel2.Width > CollapsedWidth Then
                gunaPanel2.Width -= AnimationStep
                If gunaPanel2.Width <= CollapsedWidth Then
                    gunaPanel2.Width = CollapsedWidth
                    FinishAnimation()
                End If
            End If
        End If

        ' Adjust the panelhome size during animation
        ResizePanelHome()
    End Sub

    ' Method to finish animation and reset flags
    Private Sub FinishAnimation()
        isAnimating = False
        PanelAnimationTimer.Stop()
        isCollapsed = Not isCollapsed
    End Sub

    ' Method to resize panelhome based on the state of gunaPanel2
    Private Sub ResizePanelHome()
        Dim rightPadding As Integer = 5 ' Padding between gunaPanel2 and panelhome

        ' Calculate the new width for panelhome based on the form's width and gunaPanel2's width
        panelhome.Left = gunaPanel2.Right + rightPadding
        panelhome.Width = Me.ClientSize.Width - panelhome.Left - rightPadding

        ' Ensure the controls inside panelhome resize or fit within panelhome
        For Each ctrl As Control In panelhome.Controls
            ctrl.Dock = DockStyle.Fill
        Next
    End Sub

    ' Handle form resize event to adapt panel sizes when the form is resized
    Private Sub EmployeeDash_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ResizePanelHome()
    End Sub

    ' Loading child form inside panelhome
    Private Sub LoadChildForm(ByVal childForm As Form)
        panelhome.Controls.Clear()
        childForm.TopLevel = False
        panelhome.Controls.Add(childForm)
        childForm.Show()
    End Sub

    ' Event handler for clicking the profile button
    Private Sub Profile_Click(sender As Object, e As EventArgs) Handles profile.Click
        LoadChildForm(Frmemployeedetails)
    End Sub

    ' Event handler for loading the dashboard
    Private Sub EmployeeDash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initial panel setup
        gunaPanel2.Width = ExpandedWidth
        ResizePanelHome()

        ' Other existing load logic
        LoadChildForm(employeehome)
        ' Access the shared LoggedInUsername


    End Sub

    ' Event handler for clicking the Logout button
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles logoutButton.Click
        ' Clear the logged-in user information
        LoggedInUsername = Nothing

        ' Show the login form or perform other logout actions
        home.Show()
        Me.Close()
    End Sub

    ' Event handler for clicking the Home button
    Private Sub Home_Click(sender As Object, e As EventArgs) Handles home.Click
        LoadChildForm(employeehome)
    End Sub

    Private Sub BtnMessageCount_Click(sender As Object, e As EventArgs) Handles btnMessageCount.Click
        LoadChildForm(frmMessages)
    End Sub

    Private Sub Btnjobs_Click(sender As Object, e As EventArgs) Handles Btnjobs.Click
        frmJobs.Show()
    End Sub

    Private Sub Buttonsettings_Click(sender As Object, e As EventArgs) Handles Buttonsettings.Click
        LoadChildForm(frmsettings)
    End Sub
End Class
