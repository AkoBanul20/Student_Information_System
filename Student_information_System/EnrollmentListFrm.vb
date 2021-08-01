Imports MySql.Data.MySqlClient
Public Class EnrollmentListFrm
    Dim timeFormat As String = "MMM/dd/yyyy"
    Dim stat As String
    Sub loadEnrollmentList()
        Enrolled_List_Grid.Columns(1).Visible = False
        Enrolled_List_Grid.Rows.Clear()


        cm = New MySqlCommand("SELECT enrollment.ENROLLMENT_ID, enrollment.STUDENT_LRN, CONCAT(student_record.LASTNAME, ', ',student_record.FIRSTNAME) AS NAME, enrollment.GRADE_LEVEL,enrollment.SECTION,enrollment.DATE_ENROLLED,enrollment.IS_ENROLLED FROM enrollment LEFT JOIN  student_record on enrollment.STUDENT_LRN = student_record.LRN WHERE enrollment.SY = '" & School_year_label.Text & "' ", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Dim is_enrolled = dr.Item("IS_ENROLLED")

            If is_enrolled = True Then
                stat = "Enrolled"
            Else
                stat = "Drop"
            End If
            Enrolled_List_Grid.Rows.Add("Drop", dr.Item("ENROLLMENT_ID").ToString, dr.Item("STUDENT_LRN").ToString, dr.Item("NAME").ToString, dr.Item("GRADE_LEVEL").ToString, dr.Item("SECTION").ToString, Format(dr.Item("DATE_ENROLLED"), timeFormat), stat)
        End While
        dr.Close()
        'Format(datedata, timeFormat)
    End Sub
    Sub SearchEnrolledStudent()
        Enrolled_List_Grid.Columns(1).Visible = False
        Enrolled_List_Grid.Rows.Clear()
        cm = New MySqlCommand("SELECT enrollment.ENROLLMENT_ID, enrollment.STUDENT_LRN, CONCAT(student_record.LASTNAME, ', ',student_record.FIRSTNAME) AS NAME, enrollment.GRADE_LEVEL,enrollment.SECTION,enrollment.DATE_ENROLLED,enrollment.IS_ENROLLED FROM enrollment LEFT JOIN  student_record on enrollment.STUDENT_LRN = student_record.LRN WHERE enrollment.STUDENT_LRN = '" & SearchBar.Text & "' and enrollment.SY = '" & School_year_label.Text & "' ", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Dim is_enrolled = dr.Item("IS_ENROLLED")

            If is_enrolled = True Then
                stat = "Enrolled"
            Else
                stat = "Drop"
            End If
            Enrolled_List_Grid.Rows.Add("Drop", dr.Item("ENROLLMENT_ID").ToString, dr.Item("STUDENT_LRN").ToString, dr.Item("NAME").ToString, dr.Item("GRADE_LEVEL").ToString, dr.Item("SECTION").ToString, Format(dr.Item("DATE_ENROLLED"), timeFormat), stat)
        End While
        dr.Close()
    End Sub
    Sub LoadActiveSY()
        cm = New MySqlCommand("SELECT * FROM school_year WHERE ACTIVE = 1", connect)
        dr = cm.ExecuteReader
        While dr.Read
            School_year_label.Text = dr.Item("SCHOOL_YEAR").ToString
        End While
    End Sub

    Private Sub EnrollmentListFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadActiveSY()
        loadEnrollmentList()
    End Sub

    Private Sub EnrollBtn_Click(sender As Object, e As EventArgs) Handles EnrollBtn.Click
        If login_type = 1 Then
            With EnrollmentFrm
                .TopLevel = False
                MainFrm.FormPanel.Controls.Add(EnrollmentFrm)
                .BringToFront()
                .Show()
            End With
        ElseIf login_type = 2 Then
            With EnrollmentFrm
                .TopLevel = False
                GuidanceFrm.FormPanel.Controls.Add(EnrollmentFrm)
                .BringToFront()
                .Show()
            End With
        End If
      
    End Sub

    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Dispose()
        viewdash()
    End Sub

    Private Sub SearchBar_ClearClicked() Handles SearchBar.ClearClicked
        loadEnrollmentList()
    End Sub

   

    Private Sub SearchBar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchBar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If SearchBar.Text = Nothing Then
                MessageBox.Show("Enter Student Lrn No.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                SearchEnrolledStudent()
            End If
        End If
    End Sub

    Private Sub Enrolled_List_Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Enrolled_List_Grid.CellContentClick
        Dim colname As String = Enrolled_List_Grid.Columns(e.ColumnIndex).Name
        If colname = "Drop" Then

            If MessageBox.Show("Are you sure want to Drop " & Enrolled_List_Grid.Rows(e.RowIndex).Cells(3).Value.ToString() & " ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                cm = New MySqlCommand("UPDATE enrollment SET IS_ENROLLED = '0' WHERE ENROLLMENT_ID = '" & Enrolled_List_Grid.Rows(e.RowIndex).Cells(1).Value.ToString() & "'  ", connect)
                cm.ExecuteNonQuery()
                MessageBox.Show("Student has been Dropped", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadEnrollmentList()
            Else
                'wala
            End If
            
        End If
    End Sub

    Private Sub Enrolled_List_Grid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Enrolled_List_Grid.CellFormatting
        Dim row As DataGridViewRow = Enrolled_List_Grid.Rows(e.RowIndex)
        Dim obj As Object = row.Cells(7).Value
        If Not IsDBNull(row.Cells(7).Value) Then
            If row.Cells(7).Value = "Drop" Then
                row.DefaultCellStyle.BackColor = Color.Red
                row.DefaultCellStyle.ForeColor = Color.White
            End If
        End If

        Return
    End Sub
End Class