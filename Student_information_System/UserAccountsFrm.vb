Imports MySql.Data.MySqlClient
Public Class UserAccountsFrm
    Dim ss As String

    Sub loadTotalAdmin()
        cm = New MySqlCommand("SELECT COUNT(ID) AS ADMIN FROM accounts WHERE ACCOUNT_TYPE = 1 ", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Total_Admin_Label.Text = dr.Item("ADMIN").ToString
        End While
        dr.Dispose()
    End Sub

    Sub loadTotalGuidance()
        cm = New MySqlCommand("SELECT COUNT(ID) AS GUIDANCE FROM accounts WHERE ACCOUNT_TYPE = 2 ", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Total_Guidance_Label.Text = dr.Item("GUIDANCE").ToString
        End While
        dr.Dispose()
    End Sub

    Sub loadTotalTeacher()
        cm = New MySqlCommand("SELECT COUNT(ID) AS TEACHER FROM accounts WHERE ACCOUNT_TYPE = 3 ", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Total_Teacher_Label.Text = dr.Item("TEACHER").ToString
        End While
        dr.Dispose()
    End Sub
    Sub LoadUsers()
        User_Grid.Rows.Clear()
        cm = New MySqlCommand("SELECT CONCAT(ACCOUNT_LASTNAME,', ',ACCOUNT_FIRSTNAME) AS NAME FROM `accounts` WHERE ACCOUNT_TYPE = '" & ss & "'", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Dim i As Integer
            i = i + 1
            User_Grid.Rows.Add(i, dr.Item("NAME").ToString)
        End While
        dr.Dispose()
    End Sub


    Private Sub user_type_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles user_type_cmb.SelectedIndexChanged
        ss = user_type_cmb.SelectedIndex + 1
        'MessageBox.Show(ss)
    End Sub

    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Dispose()
        viewdash()
    End Sub

    Private Sub LoadBtn_Click(sender As Object, e As EventArgs) Handles LoadBtn.Click
        LoadUsers()
    End Sub

    Private Sub UserAccountsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTotalAdmin()
        loadTotalGuidance()
        loadTotalTeacher()
    End Sub

    Private Sub AddNewBtn_Click(sender As Object, e As EventArgs) Handles AddNewBtn.Click
        AddNewUserFrm.ShowDialog()
    End Sub
End Class