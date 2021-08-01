Imports MySql.Data.MySqlClient
Public Class SchoolYearFrm
    Dim stat As Boolean
    Dim stat2 As String
    Sub clearall()
        School_Year.Clear()
        ID_label.ResetText()
        AddNewBtn.Enabled = True
        UpdateBtn.Enabled = False
    End Sub
    Sub validation()
        cm = New MySqlCommand("SELECT SCHOOL_YEAR FROM school_year WHERE SCHOOL_YEAR = '" & School_Year.Text & "' ", connect)
        dr = cm.ExecuteReader
        If dr.HasRows Then
            MessageBox.Show("Record Already in Database!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            SaveSYdata()
        End If
    End Sub
    Sub LoadSYData()
        SY_Grid.Rows.Clear()
        cm = New MySqlCommand("SELECT * FROM school_year", connect)
        dr = cm.ExecuteReader

        While dr.Read
            stat = dr.Item("ACTIVE").ToString
            If stat = True Then
                stat2 = "Active"
            Else
                stat2 = "Not Active"
            End If

            SY_Grid.Rows.Add("Edit", "Activate", "Deactivate", dr.Item("SCHOOL_YEAR_ID").ToString, dr.Item("SCHOOL_YEAR").ToString, stat2)
        End While
        dr.Close()
    End Sub
    Sub SaveSYdata()
        cm = New MySqlCommand("INSERT INTO school_year (SCHOOL_YEAR) VALUES ('" & School_Year.Text & "')", connect)
        cm.ExecuteNonQuery()
        MessageBox.Show("Record Save!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearall()
        LoadSYData()
    End Sub
    Sub UpdateSyData()
        cm = New MySqlCommand("UPDATE school_year SET SCHOOL_YEAR = '" & School_Year.Text & "' WHERE SCHOOL_YEAR_ID = '" & ID_label.Text & "' ", connect)
        cm.ExecuteNonQuery()
        MessageBox.Show("Record Save!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearall()
        LoadSYData()
        AddNewBtn.Enabled = True
        UpdateBtn.Enabled = False
    End Sub
    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Dispose()
        viewdash()
    End Sub
    Private Sub SchoolYearFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadSYData()
        SY_Grid.Columns(3).Visible = False
        UpdateBtn.Enabled = False
    End Sub

    Private Sub AddNewBtn_Click(sender As Object, e As EventArgs) Handles AddNewBtn.Click
        If School_Year.Text = Nothing Then
            MessageBox.Show("Input School Year!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If MessageBox.Show("Save this record? Click yes to confirm", "notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                validation()
            End If
        End If
    End Sub

    Private Sub SY_Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SY_Grid.CellContentClick
        Dim colname As String = SY_Grid.Columns(e.ColumnIndex).Name
        If colname = "Edit" Then
            UpdateBtn.Enabled = True
            ID_label.Text = SY_Grid.Rows(e.RowIndex).Cells(3).Value.ToString()
            School_Year.Text = SY_Grid.Rows(e.RowIndex).Cells(4).Value.ToString()
            AddNewBtn.Enabled = False
        ElseIf colname = "deact" Then
            cm = New MySqlCommand("UPDATE school_year SET ACTIVE = '0' WHERE SCHOOL_YEAR_ID = '" & SY_Grid.Rows(e.RowIndex).Cells(3).Value.ToString() & "'  ", connect)
            cm.ExecuteNonQuery()
            MessageBox.Show("School Year Deactivate!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadSYData()
            clearall()
        ElseIf colname = "act" Then
            cm = New MySqlCommand("UPDATE school_year SET ACTIVE = '1' WHERE SCHOOL_YEAR_ID = '" & SY_Grid.Rows(e.RowIndex).Cells(3).Value.ToString() & "'  ", connect)
            cm.ExecuteNonQuery()
            MessageBox.Show("School Year Activate!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cm = New MySqlCommand("UPDATE school_year SET ACTIVE = '0' WHERE SCHOOL_YEAR_ID != '" & SY_Grid.Rows(e.RowIndex).Cells(3).Value.ToString() & "'  ", connect)
            cm.ExecuteNonQuery()
            LoadSYData()
            clearall()
        End If
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If MessageBox.Show("Save this record? Click yes to confirm", "notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            UpdateSyData()
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        clearall()
    End Sub
End Class