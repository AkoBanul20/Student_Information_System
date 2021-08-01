Imports MySql.Data.MySqlClient
Module connection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader
    Public Function connect() As MySqlConnection
        connect = New MySqlConnection
        Try
            connect.ConnectionString = "server=localhost;uid=root;database=student_information_system"
            connect.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            connect.Close()
        End Try
        Return connect
    End Function
End Module
