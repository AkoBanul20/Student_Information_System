Imports MySql.Data.MySqlClient
Public Class RegistrationFrm
    Dim account_type As Integer = 0
    Sub RegisterData()
        cm = New MySqlCommand("INSERT INTO `accounts` (`ACCOUNT_FIRSTNAME`, `ACCOUNT_MIDDLENAME`, `ACCOUNT_LASTNAME`, `ACOUNT_NICKNAME`, `ACCOUNT_CONTACT`, `ACCOUNT_ADDRESS`, `ACCOUNT_EMAIL`, `ACCOUNT_TYPE`, `ACCOUNT_USERNAME`, `ACCOUNT_PASSWORD`) VALUES" _
                              & " ('" & Firstname.Text & "', '" & Middlename.Text & "', '" & Lastname.Text & "', '" & Nickname.Text & "', '" & Contact_no.Text & "','" & Address.Text & "','" & EmailAddress.Text & "','" & account_type & "', '" & Username.Text & "','" & Password.Text & "')", connect)
        cm.ExecuteNonQuery()
        cleardata()
        MessageBox.Show("Successfully Registered!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Sub cleardata()
        Firstname.ResetText()
        Middlename.ResetText()
        Lastname.ResetText()
        Nickname.ResetText()
        Contact_no.ResetText()
        Address.ResetText()
        EmailAddress.ResetText()
        Username.ResetText()
        Password.ResetText()
        account_type = 0
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub


    Private Sub RegPasswordtxt_OnValueChanged(sender As Object, e As EventArgs) Handles Password.OnValueChanged
        Password.isPassword = True
    End Sub

    Private Sub registerbtn_Click(sender As Object, e As EventArgs) Handles registerbtn.Click
        If Lastname.Text = Nothing Or Firstname.Text = Nothing Or Contact_no.Text = Nothing Or Address.Text = Nothing Or EmailAddress.Text = Nothing Or Username.Text = Nothing Or Password.Text = Nothing Then
            MessageBox.Show("Complete All Fields", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf account_type = 0 Then
            MessageBox.Show("Select Account type!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            RegisterData()
        End If
    End Sub

    Private Sub AccountType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AccountType.SelectedIndexChanged
        If AccountType.SelectedItem = "GUIDANCE" Then
            account_type = 2
        ElseIf AccountType.SelectedItem = "TEACHER" Then
            account_type = 3
        Else
            account_type = 0
        End If
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        cleardata()
    End Sub
End Class