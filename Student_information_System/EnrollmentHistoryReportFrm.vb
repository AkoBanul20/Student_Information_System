Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class EnrollmentHistoryReportFrm

    Private Sub EnrollmentHistoryReportFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SYparam As New ReportParameter("SYParam", EnrollmentHistoryFrm.SYcmb.Text, True)
        Dim rptDs As ReportDataSource
        Try
            With EnrollmentReportViewer.LocalReport
                .ReportPath = "\Student_information_System\Student_information_System\EnrollmentReport.rdlc"
                .DataSources.Clear()
                .SetParameters(SYparam)
            End With
            Dim da As New MySqlDataAdapter
            Dim ds As New Class_List
            da.SelectCommand = New MySqlCommand("SELECT enrollment.ENROLLMENT_ID, enrollment.STUDENT_LRN, CONCAT(student_record.LASTNAME, ', ',student_record.FIRSTNAME) AS NAME, enrollment.GRADE_LEVEL,enrollment.SECTION FROM enrollment LEFT JOIN  student_record on enrollment.STUDENT_LRN = student_record.LRN  WHERE enrollment.SY = '" & EnrollmentHistoryFrm.SYcmb.Text & "' AND enrollment.GRADE_LEVEL = '" & EnrollmentHistoryFrm.GradeLevelcmb.Text & "' ", connect)
            da.Fill(ds.Tables("DTEnrollmentReport"))
            rptDs = New ReportDataSource("Class_List", ds.Tables("DTEnrollmentReport"))
            EnrollmentReportViewer.LocalReport.DataSources.Add(rptDs)
            EnrollmentReportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            EnrollmentReportViewer.ZoomMode = ZoomMode.Percent
            EnrollmentReportViewer.ZoomPercent = 100
            Me.EnrollmentReportViewer.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Dispose()
    End Sub
End Class