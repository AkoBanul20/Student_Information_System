Public Class GuidanceFrm
    Sub DisposeForm()
        DashBoard_GuidanceFrm.Dispose()
        StudentFrm.Dispose()
        GradingFrm.Dispose()
        EnrollmentListFrm.Dispose()
    End Sub
    Private Sub GuidanceFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Dim ask As String = MessageBox.Show("Do you want to exit application?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ask = vbYes Then
            MessageBox.Show("System Terminated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        End If
    End Sub

    Private Sub DashboardBtn_Click(sender As Object, e As EventArgs) Handles DashboardBtn.Click
        DisposeForm()
        With DashboardFrm
            .TopLevel = False
            FormPanel.Controls.Add(DashboardFrm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub StudentBtn_Click(sender As Object, e As EventArgs) Handles StudentBtn.Click
        DisposeForm()
        With StudentFrm
            .TopLevel = False
            FormPanel.Controls.Add(StudentFrm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub GradesBtn_Click(sender As Object, e As EventArgs) Handles GradesBtn.Click
        DisposeForm()
        With GradingFrm
            .TopLevel = False
            FormPanel.Controls.Add(GradingFrm)
            .BringToFront()
            .Show()
        End With
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

    Private Sub EnrollmentBtn_Click(sender As Object, e As EventArgs) Handles EnrollmentBtn.Click
        DisposeForm()
        With EnrollmentListFrm
            .TopLevel = False
            FormPanel.Controls.Add(EnrollmentListFrm)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class