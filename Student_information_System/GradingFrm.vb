Imports MySql.Data.MySqlClient
Public Class GradingFrm
    Private WithEvents editingTextBox As TextBox
    Dim average_grade As Double = 0
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
    Sub UpdateRemarks()

    End Sub

    Sub UpdategradeViaDGV()
        For i As Integer = 0 To Grade_list_Grid.Rows.Count - 1

            If Grade_list_Grid.Rows(i).Cells(5).Value = 0 Or Grade_list_Grid.Rows(i).Cells(6).Value = 0 Or Grade_list_Grid.Rows(i).Cells(7).Value = 0 Or Grade_list_Grid.Rows(i).Cells(8).Value = 0 Then
                average_grade = (CDbl(Grade_list_Grid.Rows(i).Cells(5).Value) + CDbl(Grade_list_Grid.Rows(i).Cells(6).Value) + CDbl(Grade_list_Grid.Rows(i).Cells(7).Value) + CDbl(Grade_list_Grid.Rows(i).Cells(8).Value)) / 4
                Grade_list_Grid.Rows(i).Cells(9).Value = average_grade
                cm = New MySqlCommand("UPDATE `grades` SET `G1` = '" & Grade_list_Grid.Rows(i).Cells(5).Value & "', `G2` = '" & Grade_list_Grid.Rows(i).Cells(6).Value & "', `G3` = '" & Grade_list_Grid.Rows(i).Cells(7).Value & "', `G4` = '" & Grade_list_Grid.Rows(i).Cells(8).Value & "', AVERAGE_GRADE ='" & average_grade & "' WHERE `grades`.`ID` = '" & Grade_list_Grid.Rows(i).Cells(0).Value & "';", connect)
                Grade_list_Grid.Rows(i).Cells(10).Value = "----"
                cm.ExecuteNonQuery()
            Else
                average_grade = (CDbl(Grade_list_Grid.Rows(i).Cells(5).Value) + CDbl(Grade_list_Grid.Rows(i).Cells(6).Value) + CDbl(Grade_list_Grid.Rows(i).Cells(7).Value) + CDbl(Grade_list_Grid.Rows(i).Cells(8).Value)) / 4
                Grade_list_Grid.Rows(i).Cells(9).Value = average_grade
                cm = New MySqlCommand("UPDATE `grades` SET `G1` = '" & Grade_list_Grid.Rows(i).Cells(5).Value & "', `G2` = '" & Grade_list_Grid.Rows(i).Cells(6).Value & "', `G3` = '" & Grade_list_Grid.Rows(i).Cells(7).Value & "', `G4` = '" & Grade_list_Grid.Rows(i).Cells(8).Value & "', AVERAGE_GRADE ='" & average_grade & "' WHERE `grades`.`ID` = '" & Grade_list_Grid.Rows(i).Cells(0).Value & "';", connect)
                cm.ExecuteNonQuery()
                If Grade_list_Grid.Rows(i).Cells(9).Value >= 75 Then
                    Grade_list_Grid.Rows(i).Cells(10).Value = "PASSED"
                    cm = New MySqlCommand("UPDATE `grades` SET `REMARKS` = 'PASSED' WHERE `grades`.`ID` = '" & Grade_list_Grid.Rows(i).Cells(0).Value & "';", connect)
                    cm.ExecuteNonQuery()
                Else
                    cm = New MySqlCommand("UPDATE `grades` SET `REMARKS` = 'FAILED' WHERE `grades`.`ID` = '" & Grade_list_Grid.Rows(i).Cells(0).Value & "';", connect)
                    cm.ExecuteNonQuery()
                    Grade_list_Grid.Rows(i).Cells(10).Value = "FAILED"
                End If
            End If
            Grade_list_Grid.RefreshEdit()
        Next
    End Sub
    Sub loadReadOnlyColumnsDGV()
        If login_type = 3 Then
            cm = New MySqlCommand("SELECT PERIOD FROM GRADING_PERIOD WHERE STATUS = 1", connect)
            dr = cm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    If dr.Item("PERIOD").ToString = 1 Then
                        Grade_list_Grid.Columns("Average").ReadOnly = True
                        Grade_list_Grid.Columns("Remarks").ReadOnly = True
                        Grade_list_Grid.Columns(0).Visible = False
                        Grade_list_Grid.Columns(6).ReadOnly = True
                        Grade_list_Grid.Columns(7).ReadOnly = True
                        Grade_list_Grid.Columns(8).ReadOnly = True
                        Grade_list_Grid.Columns(9).ReadOnly = True
                        Grade_list_Grid.Columns(10).ReadOnly = True
                        Grade_list_Grid.Columns(1).ReadOnly = True
                        Grade_list_Grid.Columns(2).ReadOnly = True
                        Grade_list_Grid.Columns(3).ReadOnly = True
                        Grade_list_Grid.Columns(4).ReadOnly = True
                    ElseIf dr.Item("PERIOD").ToString = 2 Then
                        Grade_list_Grid.Columns("Average").ReadOnly = True
                        Grade_list_Grid.Columns("Remarks").ReadOnly = True
                        Grade_list_Grid.Columns(0).Visible = False
                        Grade_list_Grid.Columns(5).ReadOnly = True
                        Grade_list_Grid.Columns(7).ReadOnly = True
                        Grade_list_Grid.Columns(8).ReadOnly = True
                        Grade_list_Grid.Columns(9).ReadOnly = True
                        Grade_list_Grid.Columns(10).ReadOnly = True
                        Grade_list_Grid.Columns(1).ReadOnly = True
                        Grade_list_Grid.Columns(2).ReadOnly = True
                        Grade_list_Grid.Columns(3).ReadOnly = True
                        Grade_list_Grid.Columns(4).ReadOnly = True
                    ElseIf dr.Item("PERIOD").ToString = 3 Then
                        Grade_list_Grid.Columns("Average").ReadOnly = True
                        Grade_list_Grid.Columns("Remarks").ReadOnly = True
                        Grade_list_Grid.Columns(0).Visible = False
                        Grade_list_Grid.Columns(5).ReadOnly = True
                        Grade_list_Grid.Columns(6).ReadOnly = True
                        Grade_list_Grid.Columns(8).ReadOnly = True
                        Grade_list_Grid.Columns(9).Visible = False
                        Grade_list_Grid.Columns(10).Visible = False
                        Grade_list_Grid.Columns(1).ReadOnly = True
                        Grade_list_Grid.Columns(2).ReadOnly = True
                        Grade_list_Grid.Columns(3).ReadOnly = True
                        Grade_list_Grid.Columns(4).ReadOnly = True
                    ElseIf dr.Item("PERIOD").ToString = 4 Then
                        Grade_list_Grid.Columns("Average").ReadOnly = True
                        Grade_list_Grid.Columns("Remarks").ReadOnly = True
                        Grade_list_Grid.Columns(0).Visible = False
                        Grade_list_Grid.Columns(5).ReadOnly = True
                        Grade_list_Grid.Columns(6).ReadOnly = True
                        Grade_list_Grid.Columns(7).ReadOnly = True
                        Grade_list_Grid.Columns(9).ReadOnly = True
                        Grade_list_Grid.Columns(10).ReadOnly = True
                        Grade_list_Grid.Columns(1).ReadOnly = True
                        Grade_list_Grid.Columns(2).ReadOnly = True
                        Grade_list_Grid.Columns(3).ReadOnly = True
                        Grade_list_Grid.Columns(4).ReadOnly = True
                    End If
                End While
            End If
        Else
            Grade_list_Grid.Columns("Average").ReadOnly = True
            Grade_list_Grid.Columns("Remarks").ReadOnly = True
            Grade_list_Grid.Columns(0).Visible = False
            Grade_list_Grid.Columns(1).ReadOnly = True
            Grade_list_Grid.Columns(2).ReadOnly = True
            Grade_list_Grid.Columns(3).ReadOnly = True
            Grade_list_Grid.Columns(4).ReadOnly = True
        End If
    End Sub

    Sub loadGradeList()
        Grade_list_Grid.Rows.Clear()
        cm = New MySqlCommand("SELECT grades.ID, student_record.LRN, CONCAT(student_record.LASTNAME,', ', student_record.FIRSTNAME) AS NAME, enrollment.GRADE_LEVEL, enrollment.SECTION,class_subjects.SUBJECTCODE,class_subjects.SUBJECTNAME,grades.G1,grades.G2,grades.G3,grades.G4,grades.AVERAGE_GRADE,grades.REMARKS FROM enrollment INNER JOIN student_record ON student_record.LRN =  enrollment.STUDENT_LRN INNER JOIN grades on grades.ENROLLMENT_ID = enrollment.ENROLLMENT_ID INNER JOIN class_subjects on class_subjects.ID = grades.CLASS_SUBJECT_ID WHERE class_subjects.SUBJECTCODE = '" & subjectcmb.Text & "' AND enrollment.GRADE_LEVEL = '" & gradelevel_cmb.Text & "' AND enrollment.SECTION = '" & section_cmb.Text & "' AND enrollment.SY = '" & School_year_label.Text & "' AND enrollment.IS_ENROLLED = 1 ", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Grade_list_Grid.Rows.Add(dr.Item("ID").ToString, dr.Item("LRN").ToString, dr.Item("NAME").ToString, dr.Item("SUBJECTCODE").ToString, dr.Item("SUBJECTNAME").ToString, dr.Item("G1").ToString, dr.Item("G2").ToString, dr.Item("G3").ToString, dr.Item("G4").ToString, dr.Item("AVERAGE_GRADE").ToString, dr.Item("REMARKS").ToString)
        End While
    End Sub
    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Dispose()
        viewdash()
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
    Private Sub Grade_list_Grid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Grade_list_Grid.CellEndEdit
        editingTextBox = Nothing
        UpdategradeViaDGV()
    End Sub
    Private Sub GradingFrm_Load(sender As Object, e As EventArgs) Handles Me.load
        LoadActiveSY()
        loadGradeList()
        loadReadOnlyColumnsDGV()
    End Sub
    Private Sub Grade_list_Grid_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Grade_list_Grid.EditingControlShowing
        editingTextBox = TryCast(e.Control, TextBox)
    End Sub
    Private Sub editingTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles editingTextBox.KeyPress
        If Not (Char.IsNumber(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub gradelevel_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gradelevel_cmb.SelectedIndexChanged
        loadSection()
        LoadSubjects()
    End Sub

    Private Sub LoadBtn_Click(sender As Object, e As EventArgs) Handles LoadBtn.Click
        If gradelevel_cmb.Text = Nothing Or section_cmb.Text = Nothing Or subjectcmb.Text = Nothing Then
            MessageBox.Show("Select grade level, section and subject!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            loadGradeList()
            loadReadOnlyColumnsDGV()
        End If
    End Sub
End Class