Imports MySql.Data.MySqlClient
Public Class TeacherMainFrm
    Sub DisposeForm()
        DashBoard_GuidanceFrm.Dispose()
        TeacherViewGradesFrm.Dispose()
        GradingFrm.Dispose()
    End Sub
    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Dim ask As String = MessageBox.Show("Do you want to exit application?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ask = vbYes Then
            MessageBox.Show("System Terminated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        End If
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim ask As String = MessageBox.Show("Do you want to logout?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ask = vbYes Then
            MessageBox.Show("User logout!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Dim newlogin As New LoginFrm
            newlogin.Show()
            login_type = 0
        End If
    End Sub

    Private Sub TeacherMainFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = intX
        Me.Height = intY - 40
        Me.Left = 0
        Me.Top = 0
        With DashBoard_GuidanceFrm
            .TopLevel = False
            FormPanel.Controls.Add(DashBoard_GuidanceFrm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub DashboardBtn_Click(sender As Object, e As EventArgs) Handles DashboardBtn.Click
        DisposeForm()
        With DashBoard_GuidanceFrm
            .TopLevel = False
            FormPanel.Controls.Add(DashBoard_GuidanceFrm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub StudentBtn_Click(sender As Object, e As EventArgs) Handles StudentBtn.Click
        DisposeForm()
        With TeacherViewGradesFrm
            .TopLevel = False
            FormPanel.Controls.Add(TeacherViewGradesFrm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub GradesBtn_Click(sender As Object, e As EventArgs) Handles GradesBtn.Click
        cm = New MySqlCommand("SELECT PERIOD FROM GRADING_PERIOD WHERE STATUS = 1", connect)
        dr = cm.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                If dr.Item("PERIOD").ToString = 1 Then
                    MessageBox.Show("You can only input grade by 1st Grading", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf dr.Item("PERIOD").ToString = 2 Then
                    MessageBox.Show("You can only input grade by 2nd Grading", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf dr.Item("PERIOD").ToString = 3 Then
                    MessageBox.Show("You can only input grade by 3rd Grading", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf dr.Item("PERIOD").ToString = 4 Then
                    MessageBox.Show("You can only input grade by 4th Grading", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End While
            DisposeForm()
            With GradingFrm
                .TopLevel = False
                FormPanel.Controls.Add(GradingFrm)
                .BringToFront()
                .Show()
            End With
        Else
            MessageBox.Show("Sorry but this module is been disabled. Contact the Administration to activate this Module", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class