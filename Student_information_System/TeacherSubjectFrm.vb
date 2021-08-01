Imports MySql.Data.MySqlClient
Public Class TeacherSubjectFrm
    Sub clearall()

        Sectioncmb.ResetText()
        GradeLevelcmb.ResetText()
        SubjectCodetcmb.ResetText()
        SubjectNametxt.Clear()
        SearchTeacher.Clear()
        AdviserTxt.Clear()
        ID_label.ResetText()
        AddNewBtn.Enabled = True
        UpdateBtn.Enabled = False
    End Sub
    Sub Validation()
        cm = New MySqlCommand("SELECT SUBJECTCODE, SECTION FROM class_subjects WHERE SECTION = '" & Sectioncmb.Text & "' AND SUBJECTCODE = '" & SubjectCodetcmb.Text & "' ", connect)
        dr = cm.ExecuteReader
        If dr.HasRows Then
            MessageBox.Show("Record Has Already in Database", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            saveSubjectTeacher()
        End If
    End Sub
    Sub LoadSubjectTeacher_list()
        Teacher_Subject_Grid.Rows.Clear()
        cm = New MySqlCommand("SELECT * FROM `class_subjects`", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Teacher_Subject_Grid.Rows.Add("Edit", "Delete", dr.Item("ID").ToString, dr.Item("SUBJECTCODE").ToString, dr.Item("SUBJECTNAME").ToString, dr.Item("GRADE_LEVEL").ToString, dr.Item("SECTION").ToString, dr.Item("TEACHER").ToString)
        End While
        dr.Close()
    End Sub
    Sub Concat_First_and_Last()
        cm = New MySqlCommand("SELECT TEACHER_NO, CONCAT(TEACHER_LASTNAME,' ',TEACHER_FIRSTNAME) AS Fullname FROM teacher_record WHERE TEACHER_LASTNAME LIKE '" & SearchTeacher.Text & "%'", connect)
        dr = cm.ExecuteReader
        While dr.Read
            ID_label.Text = dr.Item("TEACHER_NO").ToString
        End While
    End Sub
    Sub LoadSy()
        cm = New MySqlCommand("SELECT SCHOOL_YEAR, ACTIVE FROM school_year WHERE  ACTIVE = '1'", connect)
        dr = cm.ExecuteReader
        While dr.Read
            SchoolYearcmb.Text = dr.Item("SCHOOL_YEAR").ToString
        End While
        dr.Close()
    End Sub
    Sub LoadSections()
        Sectioncmb.ResetText()
        Sectioncmb.Items.Clear()
        AdviserTxt.Clear()
        cm = New MySqlCommand("SELECT SECTION, GRADE_LEVEL FROM section WHERE GRADE_LEVEL = '" & GradeLevelcmb.Text & "' ", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Sectioncmb.Items.Add(dr.Item("SECTION").ToString)
        End While
        dr.Close()
    End Sub
    Sub LoadAdviserSection()
        AdviserTxt.Clear()
        cm = New MySqlCommand("SELECT ADVISER, SECTION FROM section WHERE SECTION = '" & Sectioncmb.Text & "' ", connect)
        dr = cm.ExecuteReader
        While dr.Read
            AdviserTxt.Text = dr.Item("ADVISER").ToString
        End While
        dr.Close()
    End Sub
    Sub LoadSubjects()
        SubjectCodetcmb.ResetText()
        SubjectCodetcmb.Items.Clear()
        SubjectNametxt.Clear()
        cm = New MySqlCommand("SELECT SUBJECT_CODE, GRADE_LEVEL FROM subjects WHERE GRADE_LEVEL = '" & GradeLevelcmb.Text & "' ", connect)
        dr = cm.ExecuteReader
        While dr.Read
            SubjectCodetcmb.Items.Add(dr.Item("SUBJECT_CODE").ToString)
        End While
        dr.Close()
    End Sub
    Sub LoadSubjectName()
        cm = New MySqlCommand("SELECT SUBJECT_NAME, SUBJECT_CODE FROM subjects WHERE SUBJECT_CODE = '" & SubjectCodetcmb.Text & "' ", connect)
        dr = cm.ExecuteReader
        While dr.Read
            SubjectNametxt.Text = dr.Item("SUBJECT_NAME").ToString
        End While
        dr.Close()
    End Sub
    Sub AutoSearchTeacher()
        cm = New MySqlCommand("SELECT CONCAT(TEACHER_LASTNAME, ' ' ,TEACHER_FIRSTNAME) AS Fullname FROM teacher_record WHERE TEACHER_LASTNAME LIKE '" & SearchTeacher.Text & "%' ", connect)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "teacher_record")
        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("Fullname").ToString)
        Next i
        SearchTeacher.AutoCompleteSource = AutoCompleteSource.CustomSource
        SearchTeacher.AutoCompleteCustomSource = col
        SearchTeacher.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub
    Sub saveSubjectTeacher()
        cm = New MySqlCommand("INSERT INTO class_subjects (GRADE_LEVEL,SECTION,SUBJECTCODE,SUBJECTNAME,TEACHER,SCHOOL_YEAR) VALUES ('" & GradeLevelcmb.Text & "','" & Sectioncmb.Text & "','" & SubjectCodetcmb.Text & "', '" & SubjectNametxt.Text & "', '" & SearchTeacher.Text & "', '" & SchoolYearcmb.Text & "') ", connect)
        cm.ExecuteNonQuery()
        MessageBox.Show("Record Save!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearall()
        LoadSubjectTeacher_list()
    End Sub
    Sub updateSubjectTeacher()
        cm = New MySqlCommand("UPDATE class_subjects SET  GRADE_LEVEL = '" & GradeLevelcmb.Text & "', SECTION = '" & Sectioncmb.Text & "', SUBJECTCODE = '" & SubjectCodetcmb.Text & "', SUBJECTNAME = '" & SubjectNametxt.Text & "', TEACHER = '" & SearchTeacher.Text & "' WHERE ID = '" & ID_label.Text & "'  ", connect)
        cm.ExecuteNonQuery()
        MessageBox.Show("Record Save!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearall()
        LoadSubjectTeacher_list()
    End Sub
    Sub DeleteSubjectTeacher()
        cm = New MySqlCommand("DELETE FROM class_subjects WHERE ID = '" & ID_label.Text & "' ", connect)
        cm.ExecuteNonQuery()
        MessageBox.Show("Record Deleted!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearall()
        LoadSubjectTeacher_list()
    End Sub
    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Close()
        viewdash()
    End Sub

    Private Sub GradeLevelcmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GradeLevelcmb.SelectedIndexChanged
        LoadSubjects()
        LoadSections()
    End Sub

    Private Sub Sectioncmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Sectioncmb.SelectedIndexChanged
        LoadAdviserSection()
    End Sub

    Private Sub SubjectCodetcmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubjectCodetcmb.SelectedIndexChanged
        LoadSubjectName()
    End Sub

    Private Sub TeacherSubjectFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        AutoSearchTeacher()
        LoadSy()
        LoadSubjectTeacher_list()
        Teacher_Subject_Grid.Columns("ID").Visible = False
    End Sub


    Private Sub SearchTeacher_TextChanged(sender As Object, e As EventArgs) Handles SearchTeacher.TextChanged
        ' Concat_First_and_Last()
    End Sub

    Private Sub AddNewBtn_Click(sender As Object, e As EventArgs) Handles AddNewBtn.Click
        If SchoolYearcmb.Text = Nothing Or GradeLevelcmb.Text = Nothing Or Sectioncmb.Text = Nothing Or SubjectCodetcmb.Text = Nothing Or SubjectNametxt.Text = Nothing Or SearchTeacher.Text = Nothing Then
            MessageBox.Show("Fill Out All Fields!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("Do you want to save this record?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                Validation()
            End If
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        clearall()
    End Sub

    Private Sub Teacher_Subject_Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Teacher_Subject_Grid.CellContentClick
        Dim colname As String = Teacher_Subject_Grid.Columns(e.ColumnIndex).Name
        If colname = "Edit" Then
            UpdateBtn.Enabled = True
            ID_label.Text = Teacher_Subject_Grid.Rows(e.RowIndex).Cells(2).Value.ToString()
            GradeLevelcmb.Text = Teacher_Subject_Grid.Rows(e.RowIndex).Cells(5).Value.ToString()
            Sectioncmb.Text = Teacher_Subject_Grid.Rows(e.RowIndex).Cells(6).Value.ToString()
            SubjectCodetcmb.Text = Teacher_Subject_Grid.Rows(e.RowIndex).Cells(3).Value.ToString()
            SearchTeacher.Text = Teacher_Subject_Grid.Rows(e.RowIndex).Cells(7).Value.ToString()
            AddNewBtn.Enabled = False
        ElseIf colname = "Delete" Then
            If MessageBox.Show("Do you want to delete this record?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                ID_label.Text = Teacher_Subject_Grid.Rows(e.RowIndex).Cells(2).Value.ToString()
                DeleteSubjectTeacher()
            End If

        End If
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If MessageBox.Show("Do you want to save this record?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            updateSubjectTeacher()
        End If
    End Sub
End Class