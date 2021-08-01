Imports MySql.Data.MySqlClient
Public Class AddNewUserFrm
    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Close()
    End Sub
    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub
    Private Sub Password_txt_TextChanged(sender As Object, e As EventArgs) Handles Password_txt.TextChanged
        Password_txt.UseSystemPasswordChar = True
    End Sub

    Private Sub Confirm_txt_TextChanged(sender As Object, e As EventArgs) Handles Confirm_txt.TextChanged
        Confirm_txt.UseSystemPasswordChar = True
    End Sub
    Private Sub AddNewBtn_Click(sender As Object, e As EventArgs) Handles AddNewBtn.Click
        If Lastname_txt.Text = Nothing Or Firstname_txt.Text = Nothing Or Username_txt.Text = Nothing Or Password_txt.Text = Nothing Or Confirm_txt.Text = Nothing Then
            MessageBox.Show("Complete all Required Fields!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If Password_txt.Text = Confirm_txt.Text Then
                cm = New MySqlCommand("INSERT INTO `accounts` (`ACCOUNT_FIRSTNAME`, `ACCOUNT_MIDDLENAME`, `ACCOUNT_LASTNAME`, `ACOUNT_NICKNAME`, `ACCOUNT_CONTACT`, `ACCOUNT_ADDRESS`, `ACCOUNT_EMAIL`, `ACCOUNT_TYPE`, `ACCOUNT_USERNAME`, `ACCOUNT_PASSWORD`, `ACCOUNT_CREATED`) VALUES ('" & Firstname_txt.Text & "', '" & Middlename_txt.Text & "', '" & Lastname_txt.Text & "', '', '', '', '', '1', '" & Username_txt.Text & "', '" & Password_txt.Text & "', CURRENT_TIMESTAMP);", connect)
                cm.ExecuteNonQuery()
                MessageBox.Show("Record Save!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                With UserAccountsFrm
                    .LoadUsers()
                    .loadTotalAdmin()
                    .loadTotalGuidance()
                    .loadTotalTeacher()
                End With
                Me.Close()
            Else
                MessageBox.Show("Password Not Match!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class