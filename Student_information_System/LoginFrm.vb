Imports MySql.Data.MySqlClient
Public Class LoginFrm
    Sub cleartext()
        Passwordtxt.ResetText()
        Usernametxt.ResetText()
    End Sub
    Sub loginprocess()
        cm = New MySqlCommand("SELECT CONCAT(ACCOUNT_LASTNAME,', ',ACCOUNT_FIRSTNAME) AS NAME, ACCOUNT_USERNAME, ACCOUNT_PASSWORD, ACCOUNT_TYPE FROM accounts WHERE ACCOUNT_USERNAME = '" & Usernametxt.Text & "' AND ACCOUNT_PASSWORD= '" & Passwordtxt.Text & "' ", connect)
        dr = cm.ExecuteReader
        Dim count As Integer
        count = 0
        While dr.Read
            count = count + 1
        End While
        If count = 1 Then
            Dim account_type = dr.GetString("ACCOUNT_TYPE")
            Dim name = dr.GetString("NAME")
            If account_type = 1 Then
                login_type = 1
                MessageBox.Show("Welcome Admin! " & name, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Passwordtxt.ResetText()
                MainFrm.Show()
                MainFrm.Label1.Text = name
            ElseIf account_type = 2 Then
                login_type = 2
                MessageBox.Show("Welcome Guidance Staff User! " & name, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Passwordtxt.ResetText()
                GuidanceFrm.Show()
                GuidanceFrm.Label2.Text = name
            ElseIf account_type = 3 Then
                login_type = 3
                MessageBox.Show("Welcome Teacher User! " & name, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Passwordtxt.ResetText()
                TeacherMainFrm.Show()
                TeacherMainFrm.Label2.Text = name
            End If
        Else
            MessageBox.Show("Invalid Account!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Passwordtxt.ResetText
        End If
    End Sub
    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Dim ask As String = MessageBox.Show("Do you want to exit application?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ask = vbYes Then
            MessageBox.Show("System Terminated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        End If
    End Sub

    Private Sub Passwordtxt_OnValueChanged(sender As Object, e As EventArgs) Handles Passwordtxt.OnValueChanged
        Passwordtxt.isPassword = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        RegistrationFrm.ShowDialog()
    End Sub

    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles Loginbtn.Click
        If Usernametxt.Text = Nothing And Passwordtxt.Text = Nothing Then
            MessageBox.Show("Input Your Account!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Usernametxt.Text = Nothing Then
            MessageBox.Show("Username Required!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Passwordtxt.Text = Nothing Then
            MessageBox.Show("Password Required!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            loginprocess()
        End If
    End Sub
    Private Sub LoginFrm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = intX
        Me.Height = intY - 40
        Me.Left = 0
        Me.Top = 0
        Panel2.Left = (Me.Width - Panel2.Width) / 2
    End Sub
End Class
