Public Class MainFrm
    Dim isCollapsed As Integer = 1
    Dim isCollapsed2 As Integer = 1
    Dim isCollapsed3 As Integer = 1
    Dim isCollapsed4 As Integer = 1
    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Dim ask As String = MessageBox.Show("Do you want to exit application?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ask = vbYes Then
            MessageBox.Show("System Terminated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        End If
    End Sub
    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = intX
        Me.Height = intY - 40
        Me.Left = 0
        Me.Top = 0
        MaintenancePanel.Size = MaintenancePanel.MinimumSize
        InputDataPanel.Size = InputDataPanel.MinimumSize
        RecordsPanel.Size = RecordsPanel.MinimumSize
        With DashboardFrm
            .TopLevel = False
            FormPanel.Controls.Add(DashboardFrm)
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
    Sub disable_drop()
        isCollapsed = 0
        Timer1.Start()
        isCollapsed2 = 0
        Timer2.Start()
        isCollapsed3 = 0
        Timer3.Start()
        isCollapsed4 = 0
        Timer4.Start()
    End Sub
    Sub DisposeForm()
        DashboardFrm.Dispose()
        TeacherFrm.Dispose()
        StudentFrm.Dispose()
        SchoolYearFrm.Dispose()
        StudentFrm.Dispose()
        TeacherFrm.Dispose()
        SubjectFrm.Dispose()
        TeacherSubjectFrm.Dispose()
        SectionFrm.Dispose()
        EnrollmentFrm.Dispose()
        EnrollmentListFrm.Dispose()
        GradingFrm.Dispose()
        ClassListFrm.Dispose()
        ArchiveFrm.Dispose()
        EnrollmentHistoryFrm.Dispose()
        Grading_PeriodFrm.Dispose()
        SMSFrm.Dispose()
        UserAccountsFrm.Dispose()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isCollapsed = 1 Then
            Panel11.Height += 10
            If Panel11.Size = Panel11.MaximumSize Then
                MaintenancePanel.Height += 10
                If MaintenancePanel.Size = MaintenancePanel.MaximumSize Then
                    isCollapsed = 0
                    Timer1.Stop()
                End If
            End If

        ElseIf isCollapsed = 0 Then
            Panel11.Height -= 10
            If Panel11.Size = Panel11.MinimumSize Then
                MaintenancePanel.Height -= 10
                If MaintenancePanel.Size = MaintenancePanel.MinimumSize Then
                    isCollapsed = 1
                    Timer1.Stop()
                End If
            End If
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If isCollapsed2 = 1 Then
            Panel9.Height += 10
            If Panel9.Size = Panel9.MaximumSize Then
                InputDataPanel.Height += 10
                If InputDataPanel.Size = InputDataPanel.MaximumSize Then
                    isCollapsed2 = 0
                    Timer2.Stop()
                End If
            End If
        Else
            Panel9.Height -= 10
            If Panel9.Size = Panel9.MinimumSize Then
                InputDataPanel.Height -= 10
                If InputDataPanel.Size = InputDataPanel.MinimumSize Then
                    isCollapsed2 = 1
                    Timer2.Stop()
                End If
            End If
        End If
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If isCollapsed3 = 1 Then
            Panel10.Height += 10
            If Panel10.Size = Panel10.MaximumSize Then
                RecordsPanel.Height += 10
                If RecordsPanel.Size = RecordsPanel.MaximumSize Then
                    isCollapsed3 = 0
                    Timer3.Stop()
                End If
            End If
        Else
            Panel10.Height -= 10
            If Panel10.Size = Panel10.MinimumSize Then
                RecordsPanel.Height -= 10
                If RecordsPanel.Size = RecordsPanel.MinimumSize Then
                    isCollapsed3 = 1
                    Timer3.Stop()
                End If
            End If
        End If
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If isCollapsed4 = 1 Then
            Panel6.Height += 10
            If Panel6.Size = Panel6.MaximumSize Then
                TransactionPanel.Height += 10
                If TransactionPanel.Size = TransactionPanel.MaximumSize Then
                    isCollapsed4 = 0
                    Timer4.Stop()
                End If
            End If
        Else
            Panel6.Height -= 10
            If Panel6.Size = Panel6.MinimumSize Then
                TransactionPanel.Height -= 10
                If TransactionPanel.Size = TransactionPanel.MinimumSize Then
                    isCollapsed4 = 1
                    Timer4.Stop()
                End If
            End If
        End If
    End Sub

    Private Sub Maintenancebtn_Click(sender As Object, e As EventArgs) Handles Maintenancebtn.Click
        Timer1.Start()
        isCollapsed2 = 0
        Timer2.Start()
        isCollapsed3 = 0
        Timer3.Start()
        isCollapsed4 = 0
        Timer4.Start()

    End Sub

    Private Sub InputDatabtn_Click(sender As Object, e As EventArgs) Handles InputDatabtn.Click
        Timer2.Start()
        isCollapsed = 0
        Timer1.Start()
        isCollapsed3 = 0
        Timer3.Start()
        isCollapsed4 = 0
        Timer4.Start()

    End Sub

    Private Sub RecordsBtn_Click(sender As Object, e As EventArgs) Handles RecordsBtn.Click
        Timer3.Start()
        isCollapsed = 0
        Timer1.Start()
        isCollapsed2 = 0
        Timer2.Start()
        isCollapsed4 = 0
        Timer4.Start()
    End Sub
    Private Sub TransactionBtn_Click(sender As Object, e As EventArgs) Handles TransactionBtn.Click
        Timer4.Start()
        isCollapsed = 0
        Timer1.Start()
        isCollapsed2 = 0
        Timer2.Start()
        isCollapsed3 = 0
        Timer3.Start()
    End Sub

    Private Sub DashboardBtn_Click(sender As Object, e As EventArgs) Handles DashboardBtn.Click
        disable_drop()
        DisposeForm()
        With DashboardFrm
            .TopLevel = False
            FormPanel.Controls.Add(DashboardFrm)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub AddStudentBtn_Click(sender As Object, e As EventArgs) Handles AddStudentBtn.Click
        DisposeForm()
        With StudentFrm
            .TopLevel = False
            FormPanel.Controls.Add(StudentFrm)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub AddTeacherBtn_Click(sender As Object, e As EventArgs) Handles AddTeacherBtn.Click
        DisposeForm()
        With TeacherFrm
            .TopLevel = False
            FormPanel.Controls.Add(TeacherFrm)
            .BringToFront()
            .Show()
        End With
    End Sub


    Private Sub SectionBtn_Click(sender As Object, e As EventArgs) Handles SectionBtn.Click
        DisposeForm()
        With SectionFrm
            .TopLevel = False
            FormPanel.Controls.Add(SectionFrm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub SchoolyearBtn_Click(sender As Object, e As EventArgs) Handles SchoolyearBtn.Click
        DisposeForm()
        With SchoolYearFrm
            .TopLevel = False
            FormPanel.Controls.Add(SchoolYearFrm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub SubjectBtn_Click(sender As Object, e As EventArgs) Handles SubjectBtn.Click
        DisposeForm()
        With SubjectFrm
            .TopLevel = False
            FormPanel.Controls.Add(SubjectFrm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub TeacherSubjectBtn_Click(sender As Object, e As EventArgs) Handles TeacherSubjectBtn.Click
        DisposeForm()
        With TeacherSubjectFrm
            .TopLevel = False
            FormPanel.Controls.Add(TeacherSubjectFrm)
            .BringToFront()
            .Show()
        End With
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

    Private Sub GradingBtn_Click(sender As Object, e As EventArgs) Handles GradingBtn.Click
        DisposeForm()
        With GradingFrm
            .TopLevel = False
            FormPanel.Controls.Add(GradingFrm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ClassListBtn_Click(sender As Object, e As EventArgs) Handles ClassListBtn.Click
        DisposeForm()
        With ClassListFrm
            .TopLevel = False
            FormPanel.Controls.Add(ClassListFrm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ArchiveBtn_Click(sender As Object, e As EventArgs) Handles ArchiveBtn.Click
        DisposeForm()
        With ArchiveFrm
            .TopLevel = False
            FormPanel.Controls.Add(ArchiveFrm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub EnrollmentRecordBtn_Click(sender As Object, e As EventArgs) Handles EnrollmentRecordBtn.Click
        DisposeForm()
        With EnrollmentHistoryFrm
            .TopLevel = False
            FormPanel.Controls.Add(EnrollmentHistoryFrm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Grading_PeriodBtn_Click(sender As Object, e As EventArgs) Handles Grading_PeriodBtn.Click
        DisposeForm()
        With Grading_PeriodFrm
            .TopLevel = False
            FormPanel.Controls.Add(Grading_PeriodFrm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub SMSbtn_Click(sender As Object, e As EventArgs) Handles SMSbtn.Click
        DisposeForm()
        With SMSFrm
            .TopLevel = False
            FormPanel.Controls.Add(SMSFrm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub UserBtn_Click(sender As Object, e As EventArgs) Handles UserBtn.Click
        DisposeForm()
        With UserAccountsFrm
            .TopLevel = False
            FormPanel.Controls.Add(UserAccountsFrm)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
