Imports MySql.Data.MySqlClient
Module Database
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection("Server=localhost;Database=ajira;Uid=root;Pwd=;")
    End Function
End Module
