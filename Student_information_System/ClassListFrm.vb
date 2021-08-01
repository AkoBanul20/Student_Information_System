Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class ClassListFrm
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
    Sub LoadReport()
        Dim SYparam As New ReportParameter("SY_PARAM", Me.School_year_label.Text, True)
        Dim rptDs As ReportDataSource
        Try
            With ReportViewer1.LocalReport
                .ReportPath = "\Student_information_System\Student_information_System\Report2.rdlc"
                .DataSources.Clear()
                .SetParameters(SYparam)
            End With
            Dim da As New MySqlDataAdapter
            Dim ds As New Class_List
            da.SelectCommand = New MySqlCommand("SELECT student_record.LRN, CONCAT(student_record.LASTNAME,', ',student_record.FIRSTNAME) AS NAME,enrollment.GRADE_LEVEL,enrollment.SECTION,section.ADVISER FROM student_record INNER JOIN enrollment ON student_record.LRN = enrollment.STUDENT_LRN INNER JOIN section ON section.SECTION = enrollment.SECTION WHERE enrollment.SY = '" & School_year_label.Text & "' AND enrollment.GRADE_LEVEL = '" & gradelevel_cmb.Text & "' AND enrollment.SECTION = '" & section_cmb.Text & "' AND enrollment.IS_ENROLLED = '1' ORDER BY student_record.LASTNAME ASC  ", connect)
            da.Fill(ds.Tables("DtClassList"))
            rptDs = New ReportDataSource("Class_List", ds.Tables("DtClassList"))
            ReportViewer1.LocalReport.DataSources.Add(rptDs)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub LoadBtn_Click(sender As Object, e As EventArgs) Handles LoadBtn.Click
        If gradelevel_cmb.Text = Nothing Or section_cmb.Text = Nothing Then
            MessageBox.Show("Select Grade level and Section first!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            LoadReport()
        End If

    End Sub

    Private Sub ClassListFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub gradelevel_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gradelevel_cmb.SelectedIndexChanged

        loadSection()
    End Sub

    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Dispose()
        viewdash()
    End Sub
End Class