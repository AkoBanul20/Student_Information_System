Imports MySql.Data.MySqlClient
Public Class EnrollmentFrm
    Dim EID As String
    Dim check_null As String
    Dim startID As String
    Dim insertIDNull As String
    Sub validation()
        cm = New MySqlCommand("SELECT STUDENT_LRN, SY FROM enrollment WHERE SY = '" & SY_text.Text & "' AND STUDENT_LRN = '" & LRN_Text.Text & "' ", connect)
        dr = cm.ExecuteReader
        If dr.HasRows Then
            MessageBox.Show("Student Already Enrolled for this School Year!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            check_is_db_null()
        End If
    End Sub
    Sub saveSubjectsForGradeTable()
        cm = New MySqlCommand("INSERT INTO grades (grades.ENROLLMENT_ID,.grades.CLASS_SUBJECT_ID) SELECT enrollment.ENROLLMENT_ID, class_subjects.ID FROM enrollment, class_subjects WHERE enrollment.ENROLLMENT_ID = '" & EID_text.Text & "' AND class_subjects.GRADE_LEVEL = enrollment.GRADE_LEVEL AND class_subjects.SECTION = enrollment.SECTION ;", connect)
        cm.ExecuteNonQuery()
    End Sub
    Sub enrollstudent2()
        Dim yearnow As Integer = Date.Now.Year
        insertIDNull = yearnow & "00001"
        cm = New MySqlCommand("INSERT INTO enrollment(ID,ENROLLMENT_ID,STUDENT_LRN,GRADE_LEVEL,SECTION,SY) VALUES ('" & insertIDNull & "','" & EID_text.Text & "', '" & LRN_Text.Text & "', '" & Gradelvl_cmb.Text & "','" & Section_cmb.Text & "', '" & SY_text.Text & "')", connect)
        cm.ExecuteNonQuery()
        saveSubjectsForGradeTable()
        EnrollmentListFrm.loadEnrollmentList()
        MessageBox.Show("Student " & Name_txt.Text & "is Successfully Enrolled!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearall()
        EID_text.Clear()
        Check_EID()
    End Sub
    Sub enrollStudent()
        cm = New MySqlCommand("INSERT INTO enrollment(ENROLLMENT_ID,STUDENT_LRN,GRADE_LEVEL,SECTION,SY) VALUES ('" & EID_text.Text & "', '" & LRN_Text.Text & "', '" & Gradelvl_cmb.Text & "','" & Section_cmb.Text & "', '" & SY_text.Text & "')", connect)
        cm.ExecuteNonQuery()
        saveSubjectsForGradeTable()
        EnrollmentListFrm.loadEnrollmentList()
        MessageBox.Show("Student " & Name_txt.Text & "is Successfully Enrolled!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearall()
        EID_text.Clear()
        Check_EID()
    End Sub
    Sub LoadSections()
        Section_cmb.ResetText()
        Section_cmb.Items.Clear()
        cm = New MySqlCommand("SELECT SECTION, GRADE_LEVEL FROM section WHERE GRADE_LEVEL = '" & Gradelvl_cmb.Text & "' ", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Section_cmb.Items.Add(dr.Item("SECTION").ToString)
        End While
        dr.Close()
    End Sub
    Sub LoadClassSubject()
        Subject_List_Grid.Rows.Clear()
        cm = New MySqlCommand("SELECT * FROM class_subjects WHERE GRADE_LEVEL = '" & Gradelvl_cmb.Text & "' AND SECTION = '" & Section_cmb.Text & "' ", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Subject_List_Grid.Rows.Add(dr.Item("SUBJECTCODE").ToString, dr.Item("SUBJECTNAME").ToString, dr.Item("TEACHER").ToString)
        End While
        dr.Close()
    End Sub
    Sub clearall()
        LRN_Text.Clear()
        Name_txt.Clear()
        Gradelvl_cmb.ResetText()
        Section_cmb.ResetText()
        Subject_List_Grid.Rows.Clear()
        SearchBar.Clear()
    End Sub
    Sub SearchStudent()
        cm = New MySqlCommand("SELECT LRN, CONCAT(LASTNAME,', ',FIRSTNAME) AS NAME FROM student_record  WHERE LRN = '" & SearchBar.Text & "' AND ARCHIVE = 0", connect)
        dr = cm.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                LRN_Text.Text = dr.Item("LRN").ToString
                Name_txt.Text = dr.Item("NAME").ToString
            End While
        Else
            MessageBox.Show("Data does not Exist in Records", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            clearall()
        End If
        dr.Close()
    End Sub
    Sub LoadSy()
        cm = New MySqlCommand("SELECT SCHOOL_YEAR, ACTIVE FROM school_year WHERE  ACTIVE = '1'  LIMIT 1 ", connect)
        dr = cm.ExecuteReader
        While dr.Read
            SY_text.Text = dr.Item("SCHOOL_YEAR").ToString
        End While
        dr.Close()
    End Sub
    Sub check_is_db_null()
        cm = New MySqlCommand("SELECT MAX(ID) FROM enrollment", connect)
        startID = cm.ExecuteScalar().ToString()

        If String.IsNullOrEmpty(startID) Then
            enrollstudent2()
        Else
            enrollStudent()
        End If

    End Sub

    Sub Check_EID()
        Dim yearnow As Integer = Date.Now.Year
        cm = New MySqlCommand("SELECT ID,EIDSTR  FROM enrollment WHERE SY = '" & SY_text.Text & "' ORDER BY ID DESC LIMIT 1", connect)
        dr = cm.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                EID = dr.Item("ID").ToString + 1
                EID_text.Text = dr.Item("EIDSTR").ToString & EID
            End While
        Else
            EID_text.Text = "EID" & yearnow & "00001"
        End If
        
    End Sub

    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Dispose()
    End Sub

    Private Sub EnrollmentFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSy()
        Check_EID()
    End Sub

    Private Sub SearchBar_ClearClicked() Handles SearchBar.ClearClicked
        clearall()
    End Sub

    

    Private Sub SearchBar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchBar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SearchStudent()
        End If
    End Sub

    Private Sub Section_cmb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Section_cmb.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Section_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Section_cmb.SelectedIndexChanged
        LoadClassSubject()
    End Sub

    Private Sub Gradelvl_cmb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Gradelvl_cmb.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Gradelvl_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Gradelvl_cmb.SelectedIndexChanged
        LoadSections()
    End Sub

    Private Sub EnrollBtn_Click(sender As Object, e As EventArgs) Handles EnrollBtn.Click
        If SearchBar.Text = Nothing Then
            MessageBox.Show("Enter Student LRN First!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf Gradelvl_cmb.Text = Nothing Or Section_cmb.Text = Nothing Then
            MessageBox.Show("Select Grade Level and Section first!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If MessageBox.Show("Do you want to add this record to Grade " + Gradelvl_cmb.Text + " " & Section_cmb.Text + "?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                'check_is_db_null()
                validation()
            End If
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        clearall()
    End Sub
End Class