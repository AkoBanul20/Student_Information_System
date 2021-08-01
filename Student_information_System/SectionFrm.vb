Imports MySql.Data.MySqlClient
Public Class SectionFrm
    Sub clearall()
        Gradelvl_cmb.ResetText()
        Section_txt.Clear()
        Adviser_text.Clear()
        ID_label.ResetText()
        AddNewBtn.Enabled = True
        UpdateBtn.Enabled = False
    End Sub
    Sub Validation()
        cm = New MySqlCommand("SELECT GRADE_LEVEL, SECTION FROM section WHERE SECTION  = '" & Section_txt.Text & "' AND GRADE_LEVEL = '" & Gradelvl_cmb.Text & "'", connect)
        dr = cm.ExecuteReader
        If dr.HasRows Then
            MessageBox.Show("Record already in Database!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            cm = New MySqlCommand("SELECT SECTION FROM section WHERE SECTION  = '" & Section_txt.Text & "' ", connect)
            dr = cm.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("Record has already used in other Grade Level!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                SaveSectionData()
            End If
        End If
        dr.Close()
    End Sub
    Sub LoadSectionData()
        Section_Grid.Rows.Clear()
        cm = New MySqlCommand("SELECT * FROM section ORDER BY GRADE_LEVEL ASC", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Section_Grid.Rows.Add("Edit", dr.Item("ID").ToString, dr.Item("SECTION").ToString, dr.Item("GRADE_LEVEL"), dr.Item("ADVISER").ToString)
        End While
        dr.Close()
    End Sub
    Sub SaveSectionData()
        cm = New MySqlCommand("INSERT INTO section (GRADE_LEVEL,SECTION,ADVISER) VALUES ('" & Gradelvl_cmb.Text & "','" & Section_txt.Text & "','" & Adviser_text.Text & "')", connect)
        cm.ExecuteNonQuery()
        MessageBox.Show("Record Save!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearall()
        LoadSectionData()
    End Sub
    Sub UpdateSectionData()
        cm = New MySqlCommand("UPDATE section SET GRADE_LEVEL = '" & Gradelvl_cmb.Text & "', SECTION ='" & Section_txt.Text & "', ADVISER= '" & Adviser_text.Text & "' WHERE ID = '" & ID_label.Text & "' ", connect)
        cm.ExecuteNonQuery()
        MessageBox.Show("Record Save!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearall()
        LoadSectionData()
        AddNewBtn.Enabled = True
        UpdateBtn.Enabled = False
    End Sub
    Sub AutoSearchTeacher()
        cm = New MySqlCommand("SELECT * FROM teacher_record WHERE TEACHER_LASTNAME LIKE '" & Adviser_text.Text & "%' ", connect)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "teacher_record")
        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("TEACHER_LASTNAME").ToString & ", " & ds.Tables(0).Rows(i)("TEACHER_FIRSTNAME").ToString)
        Next
        Adviser_text.AutoCompleteSource = AutoCompleteSource.CustomSource
        Adviser_text.AutoCompleteCustomSource = col
        Adviser_text.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub
    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Dispose()
        viewdash()
    End Sub
    Private Sub SectionFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadSectionData()
        UpdateBtn.Enabled = False
        AutoSearchTeacher()
        Section_Grid.Columns("ID").Visible = False
    End Sub

    Private Sub AddNewBtn_Click(sender As Object, e As EventArgs) Handles AddNewBtn.Click

        If Gradelvl_cmb.Text = Nothing Or Adviser_text.Text = Nothing Or Section_txt.Text = Nothing Then
            MessageBox.Show("Complete all Fields!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("Do you want to save this record?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                Validation()
            End If
        End If
        
    End Sub

    Private Sub Section_Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Section_Grid.CellContentClick
        Dim colname As String = Section_Grid.Columns(e.ColumnIndex).Name
        If colname = "Edit" Then
            UpdateBtn.Enabled = True
            ID_label.Text = Section_Grid.Rows(e.RowIndex).Cells("ID").Value.ToString()
            Gradelvl_cmb.Text = Section_Grid.Rows(e.RowIndex).Cells(3).Value.ToString()
            Section_txt.Text = Section_Grid.Rows(e.RowIndex).Cells(2).Value.ToString()
            Adviser_text.Text = Section_Grid.Rows(e.RowIndex).Cells(4).Value.ToString()
            AddNewBtn.Enabled = False
        End If

    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        clearall()
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If Gradelvl_cmb.Text = Nothing Or Adviser_text.Text = Nothing Or Section_txt.Text = Nothing Then
            MessageBox.Show("Complete all Fields!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("Do you want to save this record?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                UpdateSectionData()
            End If
        End If
    End Sub

    Private Sub Adviser_text_TextChanged(sender As Object, e As EventArgs) Handles Adviser_text.TextChanged

    End Sub
End Class