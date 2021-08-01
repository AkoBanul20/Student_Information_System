Imports MySql.Data.MySqlClient

Public Class TeacherFrm
    Dim timeFormat As String = "MM/dd/yyyy"
    Sub searchTeacher()
        Teacher_Grid.Rows.Clear()
        cm = New MySqlCommand("SELECT * FROM teacher_record WHERE TEACHER_NO LIKE '" & SearchBar.Text & "'", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Teacher_Grid.Rows.Add("Edit", "Move to Archive", dr.Item("TEACHER_ID").ToString, dr.Item("TEACHER_NO").ToString, dr.Item("TEACHER_LASTNAME").ToString, dr.Item("TEACHER_FIRSTNAME").ToString, dr.Item("TEACHER_MIDDLENAME").ToString, Format(dr.Item("BIRTH_DATE"), timeFormat), dr.Item("GENDER").ToString, dr.Item("BIRTH_PLACE"), dr.Item("CONTACT_NO").ToString, dr.Item("NATIONALITY").ToString, dr.Item("RELIGION").ToString, dr.Item("EMAIL_ADDRESS").ToString, dr.Item("ADDRESS").ToString, dr.Item("MOTHER_NAME").ToString, dr.Item("MOTHER_OCCUPATION").ToString, dr.Item("FATHER_NAME").ToString, dr.Item("FATHER_OCCUPATION").ToString)
        End While
        dr.Close()
    End Sub
    Sub load_data_teacher()
        Teacher_Grid.Rows.Clear()
        cm = New MySqlCommand("SELECT * FROM teacher_record", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Teacher_Grid.Rows.Add("Edit", "Move to Archive", dr.Item("TEACHER_ID").ToString, dr.Item("TEACHER_NO").ToString, dr.Item("TEACHER_LASTNAME").ToString, dr.Item("TEACHER_FIRSTNAME").ToString, dr.Item("TEACHER_MIDDLENAME").ToString, Format(dr.Item("BIRTH_DATE"), timeFormat), dr.Item("GENDER").ToString, dr.Item("BIRTH_PLACE"), dr.Item("CONTACT_NO").ToString, dr.Item("NATIONALITY").ToString, dr.Item("RELIGION").ToString, dr.Item("EMAIL_ADDRESS").ToString, dr.Item("ADDRESS").ToString, dr.Item("MOTHER_NAME").ToString, dr.Item("MOTHER_OCCUPATION").ToString, dr.Item("FATHER_NAME").ToString, dr.Item("FATHER_OCCUPATION").ToString)
        End While
        dr.Close()
    End Sub
    Private Sub Close_btn_Click_1(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Dispose()
        viewdash()
    End Sub

    Private Sub AddNewBtn_Click(sender As Object, e As EventArgs) Handles AddNewBtn.Click
        update_status_teacher = 0
        AddNewTeacherFrm.ShowDialog()
    End Sub

    Private Sub TeacherFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_data_teacher()
        Teacher_Grid.Columns(2).Visible = False
    End Sub

    Private Sub Teacher_Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Teacher_Grid.CellContentClick
        Dim colname As String = Teacher_Grid.Columns(e.ColumnIndex).Name
        If colname = "Edit" Then
            With AddNewTeacherFrm
                update_status_teacher = 1
                .ID_label.Text = Teacher_Grid.Rows(e.RowIndex).Cells(2).Value.ToString()
                .UpdateBtn.BringToFront()
                .AddNewBtn.SendToBack()
                .Teacher_No_Text.Enabled = False
                .ShowDialog()
            End With
        End If

    End Sub

    Private Sub SearchBar_ClearClicked() Handles SearchBar.ClearClicked
        load_data_teacher()
    End Sub
    Private Sub SearchBar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchBar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            searchTeacher()
        End If
    End Sub
End Class