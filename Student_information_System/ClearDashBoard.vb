Module ClearDashBoard
    Public update_status As Integer = 0
    Public update_status_teacher As Integer = 0
    Public login_type As Integer = 0
    Public Sub Alert(msg As String, type As frmAlert.alertTypeEnum)
        Dim f As frmAlert = New frmAlert
        f.setAlert(msg, type)
    End Sub
    Sub viewdash()
        If login_type = 1 Then
            With DashboardFrm
                .TopLevel = False
                MainFrm.FormPanel.Controls.Add(DashboardFrm)
                .BringToFront()
                .Show()
            End With
        ElseIf login_type = 2 Then
            With DashBoard_GuidanceFrm
                .TopLevel = False
                GuidanceFrm.FormPanel.Controls.Add(DashBoard_GuidanceFrm)
                .BringToFront()
                .Show()
            End With
        ElseIf login_type = 3 Then
            With DashBoard_GuidanceFrm
                .TopLevel = False
                TeacherMainFrm.FormPanel.Controls.Add(DashBoard_GuidanceFrm)
                .BringToFront()
                .Show()
            End With
        End If
    End Sub
End Module
