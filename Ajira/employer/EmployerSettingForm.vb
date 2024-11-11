Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class EmployerSettingForm

    ' Example: ComboBox for selecting profile update interval
    Private cmbUpdateInterval As ComboBox
    Private btnSaveSettings As Button
    Private lblTitle As Label
    Private lblInstructions As Label

    ' Assuming these variables for database connection
    Private connectionString As String = "Server=localhost;Database=ajira;Uid=root;Pwd=;"
    Private currentUseriD As Integer ' This will be set dynamically

    ' Form Load Event
    Private Sub EmployerSettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the form controls
        InitializeControls()

        ' Populate the ComboBox with predefined intervals (in days)
        cmbUpdateInterval.Items.Add("30 days")
        cmbUpdateInterval.Items.Add("60 days")
        cmbUpdateInterval.Items.Add("90 days")
        cmbUpdateInterval.Items.Add("180 days")
        cmbUpdateInterval.SelectedIndex = 0 ' Set default to 30 days

        ' Get the employer's ID using the logged-in username from Home
        GetEmployerIdFromUsername(Home.LoggedInUsername)
    End Sub

    ' Method to Initialize Controls
    Private Sub InitializeControls()
        ' Create and configure the ComboBox
        cmbUpdateInterval = New ComboBox()
        cmbUpdateInterval.Size = New Size(200, 30)
        cmbUpdateInterval.Location = New Point(100, 60)
        Me.Controls.Add(cmbUpdateInterval)

        ' Create and configure the Save Settings button
        btnSaveSettings = New Button()
        btnSaveSettings.Size = New Size(100, 40)
        btnSaveSettings.Location = New Point(100, 110)
        btnSaveSettings.Text = "Save Settings"
        AddHandler btnSaveSettings.Click, AddressOf btnSaveSettings_Click
        Me.Controls.Add(btnSaveSettings)

        ' Create and configure the Title label
        lblTitle = New Label()
        lblTitle.Size = New Size(200, 30)
        lblTitle.Location = New Point(100, 20)
        lblTitle.Text = "Employer Settings"
        lblTitle.Font = New Font("Arial", 16, FontStyle.Bold)
        Me.Controls.Add(lblTitle)

        ' Create and configure the Instructions label
        lblInstructions = New Label()
        lblInstructions.Size = New Size(300, 30)
        lblInstructions.Location = New Point(50, 150)
        lblInstructions.Text = "Select the frequency for profile update notifications."
        lblInstructions.Font = New Font("Arial", 10)
        Me.Controls.Add(lblInstructions)
    End Sub

    ' Get the employer's ID using the logged-in username
    Private Sub GetEmployerIdFromUsername(username As String)
        ' Updated query: Retrieve employer ID from the registration or relevant table based on username
        Dim query As String = "SELECT UseriD FROM registration WHERE username = @username"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)

                conn.Open()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        currentUseriD = reader.GetString("UseriD")
                    End If
                End Using
            End Using
        End Using
    End Sub

    ' Save the selected interval when the employer submits
    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs)
        ' Save the selected interval to the database (in the employer settings)
        Dim selectedInterval As String = cmbUpdateInterval.SelectedItem.ToString()

        ' Assuming a method SaveEmployerSettings to update the settings in the database
        SaveEmployerSettings(selectedInterval)

        MessageBox.Show("Profile update frequency saved successfully.")
    End Sub

    ' Method to save employer settings to the database
    Private Sub SaveEmployerSettings(interval As String)
        ' Example SQL update query to save the profile update interval
        Dim query As String = "UPDATE employer_settings SET update_interval = @interval WHERE UseriD = @UseriD"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@interval", interval)
                cmd.Parameters.AddWithValue("@UseriD", currentUseriD) ' The current logged-in employer's ID

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
