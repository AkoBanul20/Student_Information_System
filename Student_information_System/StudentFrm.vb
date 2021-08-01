Imports MySql.Data.MySqlClient
Public Class StudentFrm
    Dim stat As String
    Dim stat2 As String
    Dim stat3 As String
    Dim timeFormat As String = "MMM/dd/yyyy"

    Sub searchStudent()

        Student_Grid.Rows.Clear()
        cm = New MySqlCommand("SELECT * FROM student_record WHERE LRN LIKE  '" & SearchBar.Text & "%' AND ARCHIVE = 0 ", connect)
        dr = cm.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                Dim BC = dr.GetString("BIRTH_CERTIFICATE")
                Dim GM = dr.GetString("GOOD_MORAL")
                Dim FRM = dr.GetString("FORM_137")
                Dim datedata = dr.Item("BIRTH_DATE")
                'dito yung condition para sa requirments
                If BC = True Then
                    stat = "Submitted"
                Else
                    stat = "Not Submitted"
                End If

                If GM = True Then
                    stat2 = "Submitted"
                Else
                    stat2 = "Not Submitted"
                End If

                If FRM = True Then
                    stat3 = "Submitted"
                Else
                    stat3 = "Not Submitted"
                End If

                Student_Grid.Rows.Add("Edit", "Move to Archive", dr.Item("ID").ToString, dr.Item(4).ToString, dr.Item(3).ToString, dr.Item(1).ToString, dr.Item(2).ToString, Format(datedata, timeFormat), dr.GetString(6).ToString, dr.GetString(7).ToString, dr.GetString(8).ToString, dr.GetString(9).ToString, dr.GetString(10).ToString, dr.GetString(11).ToString, dr.GetString(12).ToString, dr.GetString(13).ToString, dr.GetString(14).ToString, dr.GetString(15).ToString, dr.GetString(16).ToString, dr.GetString(17).ToString, dr.GetString(18).ToString, stat, stat2, stat3, Format(dr.Item("DATE_OF_ADMISSION"), timeFormat))
            End While
            dr.Dispose()
        Else
            MessageBox.Show("Data does not exist in database Do you want to add this data?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If
    End Sub
    Sub LoadStudentList()
        'Dim i As Integer
        Student_Grid.Rows.Clear()
        cm = New MySqlCommand("SELECT * FROM student_record WHERE ARCHIVE = 0 ", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Dim BC = dr.GetString("BIRTH_CERTIFICATE")
            Dim GM = dr.GetString("GOOD_MORAL")
            Dim FRM = dr.GetString("FORM_137")
            Dim datedata = dr.Item("BIRTH_DATE")
            'dito yung condition para sa requirments
            If BC = True Then
                stat = "Submitted"
            Else
                stat = "Not Submitted"
            End If

            If GM = True Then
                stat2 = "Submitted"
            Else
                stat2 = "Not Submitted"
            End If

            If FRM = True Then
                stat3 = "Submitted"
            Else
                stat3 = "Not Submitted"
            End If
            'i = i + 1
            Student_Grid.Rows.Add("Edit", "Move to Archive", dr.Item("ID").ToString, dr.Item(4).ToString, dr.Item(3).ToString, dr.Item(1).ToString, dr.Item(2).ToString, Format(datedata, timeFormat), dr.GetString(6).ToString, dr.GetString(7).ToString, dr.GetString(8).ToString, dr.GetString(9).ToString, dr.GetString(10).ToString, dr.GetString(11).ToString, dr.GetString(12).ToString, dr.GetString(13).ToString, dr.GetString(14).ToString, dr.GetString(15).ToString, dr.GetString(16).ToString, dr.GetString(17).ToString, dr.GetString(18).ToString, stat, stat2, stat3, Format(dr.Item(22), timeFormat))
        End While
        dr.Dispose()
    End Sub
    Private Sub Close_btn_Click_1(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Dispose()
        viewdash()
    End Sub

    Private Sub AddNewBtn_Click(sender As Object, e As EventArgs) Handles AddNewBtn.Click
        update_status = 0
        AddNewStudentFrm.ShowDialog()
    End Sub

    Private Sub StudentFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadStudentList()
        Student_Grid.Columns(2).Visible = False
    End Sub

    Private Sub Student_Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Student_Grid.CellContentClick
        Dim colname As String = Student_Grid.Columns(e.ColumnIndex).Name
        If colname = "Edit" Then
            With AddNewStudentFrm
                update_status = 1
                .ID_label.Text = Student_Grid.Rows(e.RowIndex).Cells(2).Value.ToString()
                .UpdateBtn.BringToFront()
                .AddNewBtn.SendToBack()
                .ShowDialog()
            End With

        ElseIf colname = "Delete" Then
            cm = New MySqlCommand("UPDATE student_record SET ARCHIVE = 1 WHERE ID = '" & Student_Grid.Rows(e.RowIndex).Cells(2).Value.ToString() & "' ", connect)
            cm.ExecuteNonQuery()
            MessageBox.Show("Student Record moved to Archive list", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadStudentList()
        End If
    End Sub

    Private Sub SearchBar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchBar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            searchStudent()
        End If
    End Sub
    Private Sub SearchBar_ClearClicked() Handles SearchBar.ClearClicked
        LoadStudentList()
    End Sub
End Class