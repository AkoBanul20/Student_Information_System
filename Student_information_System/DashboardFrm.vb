Imports MySql.Data.MySqlClient
Public Class DashboardFrm
    Sub TotalStudents()
        cm = New MySqlCommand("SELECT COUNT(ID) AS TOTAL FROM student_record WHERE ARCHIVE = 0", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Total_students_label.Text = dr.Item("TOTAL").ToString
        End While
    End Sub
    Sub LoadUserTotal()
        cm = New MySqlCommand("SELECT COUNT(ID) AS TOTAL FROM accounts", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Total_User_Accounts.Text = dr.Item("TOTAL").ToString
        End While
    End Sub
    Sub LoadEnrollednumbers()
        cm = New MySqlCommand("SELECT COUNT(ID) AS TOTAL FROM enrollment WHERE SY = '" & School_year_label.Text & "' ", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Total_enrolled.Text = dr.Item("TOTAL").ToString
        End While
    End Sub
    Sub LoadActiveSY()
        cm = New MySqlCommand("SELECT * FROM school_year WHERE ACTIVE = 1", connect)
        dr = cm.ExecuteReader
        While dr.Read
            School_year_label.Text = dr.Item("SCHOOL_YEAR").ToString
        End While
    End Sub
    Private Sub DashboardFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        LoadActiveSY()
        LoadEnrollednumbers()
        LoadUserTotal()
        TotalStudents()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text = DateTime.Now.ToString("hh:mm:ss tt")
        Label7.Text = DateTime.Now.ToString("MMMM d, yyyy")
    End Sub
End Class