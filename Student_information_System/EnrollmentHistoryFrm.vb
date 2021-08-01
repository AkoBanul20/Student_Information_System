Imports MySql.Data.MySqlClient
Public Class EnrollmentHistoryFrm
    Dim timeFormat As String = "MMM/dd/yyyy"
    Dim stat As String

    Sub clearall()
        SYcmb.ResetText()
        GradeLevelcmb.ResetText()
    End Sub
    Sub loadSY()
        SYcmb.Items.Clear()
        cm = New MySqlCommand("SELECT SCHOOL_YEAR FROM school_year", connect)
        dr = cm.ExecuteReader
        While dr.Read
            SYcmb.Items.Add(dr.Item("SCHOOL_YEAR").ToString)
        End While
    End Sub
    Sub loadEnrollmentList()
        Enrolled_List_Grid.Columns(0).Visible = False
        Enrolled_List_Grid.Rows.Clear()
        cm = New MySqlCommand("SELECT enrollment.ENROLLMENT_ID, enrollment.STUDENT_LRN, CONCAT(student_record.LASTNAME, ', ',student_record.FIRSTNAME) AS NAME, enrollment.GRADE_LEVEL,enrollment.SECTION,enrollment.DATE_ENROLLED,enrollment.IS_ENROLLED FROM enrollment LEFT JOIN  student_record on enrollment.STUDENT_LRN = student_record.LRN ", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Dim is_enrolled = dr.Item("IS_ENROLLED")

            If is_enrolled = True Then
                stat = "Enrolled"
            Else
                stat = "Drop"
            End If
            Enrolled_List_Grid.Rows.Add(dr.Item("ENROLLMENT_ID").ToString, dr.Item("STUDENT_LRN").ToString, dr.Item("NAME").ToString, dr.Item("GRADE_LEVEL").ToString, dr.Item("SECTION").ToString, Format(dr.Item("DATE_ENROLLED"), timeFormat), stat)
        End While
        dr.Close()
        'Format(datedata, timeFormat)
    End Sub
    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Dispose()
        viewdash()
    End Sub

    Private Sub EnrollmentHistoryFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSY()
        loadEnrollmentList()
    End Sub
    Private Sub SYcmb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SYcmb.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub GradeLevelcmb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GradeLevelcmb.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        clearall()
    End Sub

    Private Sub Enrolled_List_Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Enrolled_List_Grid.CellContentClick

    End Sub

    Private Sub Enrolled_List_Grid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Enrolled_List_Grid.CellFormatting
        Dim row As DataGridViewRow = Enrolled_List_Grid.Rows(e.RowIndex)
        Dim obj As Object = row.Cells(6).Value
        If Not IsDBNull(row.Cells(6).Value) Then
            If row.Cells(6).Value = "Drop" Then
                row.DefaultCellStyle.BackColor = Color.Red
                row.DefaultCellStyle.ForeColor = Color.White
            End If
        End If

        Return
    End Sub

    Private Sub Print_Preview_btn_Click(sender As Object, e As EventArgs) Handles Print_Preview_btn.Click
        If SYcmb.Text = Nothing Or GradeLevelcmb.Text = Nothing Then
            MessageBox.Show("Select School year and Grade Level", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            With EnrollmentHistoryReportFrm
                .TopLevel = False
                MainFrm.FormPanel.Controls.Add(EnrollmentHistoryReportFrm)
                .BringToFront()
                .Show()
            End With
        End If
    End Sub
End Class