Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Public Class TeacherViewGradesFrm
    Sub LoadGradeReport()
        Dim rptDs As ReportDataSource
        Dim SYparam As New ReportParameter("SY_Param", School_year_label.Text, True)
        Try
            With GradeReportViewer.LocalReport
                .ReportPath = "\Student_information_System\Student_information_System\GradesViewReport.rdlc"
                .DataSources.Clear()
                .SetParameters(SYparam)
            End With
            Dim da As New MySqlDataAdapter
            Dim ds As New Class_List
            da.SelectCommand = New MySqlCommand("SELECT student_record.LRN, CONCAT(student_record.LASTNAME,', ', student_record.FIRSTNAME) AS NAME, enrollment.GRADE_LEVEL, enrollment.SECTION,class_subjects.SUBJECTCODE,class_subjects.SUBJECTNAME,grades.G1,grades.G2,grades.G3,grades.G4,grades.AVERAGE_GRADE,grades.REMARKS,class_subjects.TEACHER FROM enrollment INNER JOIN student_record ON student_record.LRN =  enrollment.STUDENT_LRN INNER JOIN grades on grades.ENROLLMENT_ID = enrollment.ENROLLMENT_ID INNER JOIN class_subjects on class_subjects.ID = grades.CLASS_SUBJECT_ID WHERE class_subjects.SUBJECTCODE = '" & subjectcmb.Text & "' AND enrollment.GRADE_LEVEL = '" & gradelevel_cmb.Text & "' AND enrollment.SECTION = '" & section_cmb.Text & "' AND enrollment.SY = '" & School_year_label.Text & "' AND enrollment.IS_ENROLLED = 1 ", connect)
            da.Fill(ds.Tables("DTGradesReports"))
            If ds.Tables("DTGradesReports").Rows.Count > 0 Then
                rptDs = New ReportDataSource("Class_List", ds.Tables("DTGradesReports"))
                GradeReportViewer.LocalReport.DataSources.Add(rptDs)
                GradeReportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                GradeReportViewer.ZoomMode = ZoomMode.Percent
                GradeReportViewer.ZoomPercent = 100
                Me.GradeReportViewer.RefreshReport()
                PdfBtn.Visible = True
            Else
                MessageBox.Show("No Found Data!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                GradeReportViewer.Clear()
                PdfBtn.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub LoadActiveSY()
        cm = New MySqlCommand("SELECT * FROM school_year WHERE ACTIVE = 1", connect)
        dr = cm.ExecuteReader
        While dr.Read
            School_year_label.Text = dr.Item("SCHOOL_YEAR").ToString
        End While
    End Sub
    Sub loadSection()
        section_cmb.ResetText()
        section_cmb.Items.Clear()
        cm = New MySqlCommand("SELECT SECTION, GRADE_LEVEL FROM section WHERE GRADE_LEVEL = '" & gradelevel_cmb.Text & "' ", connect)
        dr = cm.ExecuteReader
        While dr.Read
            section_cmb.Items.Add(dr.Item("SECTION").ToString)
        End While
        dr.Close()
    End Sub
    Sub LoadSubjects()
        subjectcmb.ResetText()
        subjectcmb.Items.Clear()
        cm = New MySqlCommand("SELECT SUBJECT_CODE FROM subjects WHERE GRADE_LEVEL = '" & gradelevel_cmb.Text & "'", connect)
        dr = cm.ExecuteReader
        While dr.Read
            subjectcmb.Items.Add(dr.Item("SUBJECT_CODE").ToString)
        End While
        dr.Close()
    End Sub
    Private Sub TeacherViewGradesFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadActiveSY()
    End Sub
    Private Sub gradelevel_cmb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gradelevel_cmb.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub section_cmb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles section_cmb.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub subjectcmb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles subjectcmb.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Dispose()
        viewdash()
    End Sub

    Private Sub gradelevel_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gradelevel_cmb.SelectedIndexChanged
        loadSection()
        LoadSubjects()
    End Sub

    Private Sub LoadBtn_Click(sender As Object, e As EventArgs) Handles LoadBtn.Click
        If gradelevel_cmb.Text = Nothing Or section_cmb.Text = Nothing Or subjectcmb.Text = Nothing Then
            MessageBox.Show("Select grade level, section and subject!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            LoadGradeReport()

        End If
    End Sub
    Sub ExportPDF()
        Dim filename As String
        Dim savepdf As New SaveFileDialog()
        savepdf.Filter = "pdf files (*.pdf)|*.pdf"
        savepdf.FilterIndex = 2
        savepdf.RestoreDirectory = True
        filename = gradelevel_cmb.Text & "-" & section_cmb.Text & "-" & subjectcmb.Text & ".pdf"
        savepdf.FileName = filename
        If savepdf.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim savelocation = Path.GetDirectoryName(savepdf.FileName)
                Dim savepdf2 = Path.Combine(savelocation, filename)
                Dim byteViewer As Byte() = GradeReportViewer.LocalReport.Render("PDF")
                Dim newFile As New FileStream(savepdf2, FileMode.Create)
                newFile.Write(byteViewer, 0, byteViewer.Length)
                newFile.Close()
                MessageBox.Show("Succesfully Exported go to " & savelocation, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub PdfBtn_Click(sender As Object, e As EventArgs) Handles PdfBtn.Click
        If gradelevel_cmb.Text = Nothing Or section_cmb.Text = Nothing Or subjectcmb.Text = Nothing Then
            MessageBox.Show("Select grade level, section and subject!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ExportPDF()
        End If
    End Sub
End Class