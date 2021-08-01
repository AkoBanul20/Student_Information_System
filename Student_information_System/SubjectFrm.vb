Imports MySql.Data.MySqlClient
Public Class SubjectFrm
    Sub clearall()
        SubjectCode.Clear()
        SubjectName.Clear()
        GradeCmb.ResetText()
        UpdateBtn.Enabled = False
        AddNewBtn.Enabled = True
        ID_label.ResetText()
    End Sub
    Sub validation()
        cm = New MySqlCommand("SELECT GRADE_LEVEL, SUBJECT_CODE FROM subjects WHERE SUBJECT_CODE  = '" & SubjectCode.Text & "' AND GRADE_LEVEL = '" & GradeCmb.Text & "'", connect)
        dr = cm.ExecuteReader
        If dr.HasRows Then
            MessageBox.Show("Record already in Database!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            cm = New MySqlCommand("SELECT SUBJECT_CODE FROM subjects WHERE SUBJECT_CODE  = '" & SubjectCode.Text & "' ", connect)
            dr = cm.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("Record has already used in other Grade Level!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                saveSubjectData()
            End If
        End If
        dr.Close()
    End Sub
    Sub deleteSubjectData()
        If MessageBox.Show("Delete  this record?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            cm = New MySqlCommand("DELETE FROM subjects WHERE ID = '" & ID_label.Text & "' ", connect)
            cm.ExecuteNonQuery()
            MessageBox.Show("Record deleted!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSubjectList()
        End If
    End Sub
    Sub updateSubjectData()
        cm = New MySqlCommand("UPDATE subjects SET SUBJECT_CODE = '" & SubjectCode.Text & "', SUBJECT_NAME = '" & SubjectName.Text & "', GRADE_LEVEL = '" & GradeCmb.Text & "' WHERE ID = '" & ID_label.Text & "' ", connect)
        cm.ExecuteNonQuery()
        MessageBox.Show("Record Save!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearall()
        LoadSubjectList()
    End Sub
    Sub saveSubjectData()
        cm = New MySqlCommand("INSERT INTO subjects (SUBJECT_CODE,SUBJECT_NAME,GRADE_LEVEL) VALUES ('" & SubjectCode.Text & "','" & SubjectName.Text & "','" & GradeCmb.Text & "')", connect)
        cm.ExecuteNonQuery()
        MessageBox.Show("Record Save!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearall()
        LoadSubjectList()
    End Sub
    Sub LoadSubjectList()
        Subject_Grid.Rows.Clear()
        cm = New MySqlCommand("SELECT * FROM subjects ORDER BY GRADE_LEVEL ASC", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Subject_Grid.Rows.Add("Edit", "Delete", dr.Item("ID").ToString, dr.Item("SUBJECT_CODE").ToString, dr.Item("SUBJECT_NAME").ToString, dr.Item("GRADE_LEVEL").ToString)
        End While
        dr.Close()
    End Sub
    Sub SearchSubjectList()
        Subject_Grid.Rows.Clear()
        cm = New MySqlCommand("SELECT * FROM subjects WHERE SUBJECT_CODE = '" & SearchBar.Text & "' ", connect)
        dr = cm.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                Subject_Grid.Rows.Add("Edit", "Delete", dr.Item("ID").ToString, dr.Item("SUBJECT_CODE").ToString, dr.Item("SUBJECT_NAME").ToString, dr.Item("GRADE_LEVEL").ToString)
            End While
            dr.Close()
        Else
            MessageBox.Show("Record does not exist!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        
    End Sub
    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Dispose()
        viewdash()
    End Sub

    Private Sub AddNewBtn_Click(sender As Object, e As EventArgs) Handles AddNewBtn.Click
        If GradeCmb.Text = Nothing Or SubjectCode.Text = Nothing Or SubjectName.Text = Nothing Then
            MessageBox.Show("Complete all fields!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If MessageBox.Show("Save this record?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                validation()
            End If
        End If
        
    End Sub
    Private Sub SubjectFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadSubjectList()
        UpdateBtn.Enabled = False
        Subject_Grid.Columns("ID").Visible = False
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        clearall()
    End Sub

    Private Sub Subject_Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Subject_Grid.CellContentClick
        Dim colname As String = Subject_Grid.Columns(e.ColumnIndex).Name
        If colname = "Edit" Then
            UpdateBtn.Enabled = True
            ID_label.Text = Subject_Grid.Rows(e.RowIndex).Cells(2).Value.ToString()
            GradeCmb.Text = Subject_Grid.Rows(e.RowIndex).Cells(5).Value.ToString()
            SubjectCode.Text = Subject_Grid.Rows(e.RowIndex).Cells(3).Value.ToString()
            SubjectName.Text = Subject_Grid.Rows(e.RowIndex).Cells(4).Value.ToString()
            AddNewBtn.Enabled = False
        ElseIf colname = "Delete" Then
            ID_label.Text = Subject_Grid.Rows(e.RowIndex).Cells(2).Value.ToString()
            deleteSubjectData()
        End If
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If MessageBox.Show("Save this record?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            updateSubjectData()
        End If
    End Sub

    Private Sub SearchBar_ClearClicked() Handles SearchBar.ClearClicked
        LoadSubjectList()
    End Sub

  

    Private Sub SearchBar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchBar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SearchSubjectList()
        End If
    End Sub
End Class