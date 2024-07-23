Imports MySql.Data.MySqlClient
Public Class Frmemployeedetails
    Private ReadOnly connectionString As String = "Server=localhost;Database=address;Uid=root;Pwd=;"
    Private connection As MySqlConnection

    Private Sub Updatedetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection(connectionString)
        LoadCounties()
    End Sub

    Private Sub LoadCounties()
        Try
            connection.Open()
            Dim query As String = "SELECT id, name FROM county"
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim county As New ComboBoxItem(reader("name").ToString(), reader("id"))
                Cbocounty.Items.Add(county)
            End While

            reader.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub CboCounty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbocounty.SelectedIndexChanged
        Dim selectedCounty As ComboBoxItem = CType(Cbocounty.SelectedItem, ComboBoxItem)
        If selectedCounty IsNot Nothing Then
            LoadSubCounties(selectedCounty.Value)
        End If
    End Sub

    Private Sub LoadSubCounties(countyId As Integer)
        cboSubCounty.Items.Clear()
        cboLocation.Items.Clear()
        Try
            connection.Open()
            Dim query As String = "SELECT id, name FROM sub_county WHERE county_id = @countyId"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@countyId", countyId)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim subCounty As New ComboBoxItem(reader("name").ToString(), reader("id"))
                cboSubCounty.Items.Add(subCounty)
            End While

            reader.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub CboSubCounty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubCounty.SelectedIndexChanged
        Dim selectedSubCounty As ComboBoxItem = CType(cboSubCounty.SelectedItem, ComboBoxItem)
        If selectedSubCounty IsNot Nothing Then
            LoadLocations(selectedSubCounty.Value)
        End If
    End Sub

    Private Sub LoadLocations(subCountyId As Integer)
        cboLocation.Items.Clear()
        Try
            connection.Open()
            Dim query As String = "SELECT id, name FROM location WHERE sub_county_id = @subCountyId"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@subCountyId", subCountyId)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim location As New ComboBoxItem(reader("name").ToString(), reader("id"))
                cboLocation.Items.Add(location)
            End While

            reader.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Class ComboBoxItem
        Public Property Text As String
        Public Property Value As Integer

        Public Sub New(text As String, value As Integer)
            Me.Text = text
            Me.Value = value
        End Sub

        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class

End Class