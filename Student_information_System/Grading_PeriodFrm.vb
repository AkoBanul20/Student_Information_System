Imports MySql.Data.MySqlClient
Public Class Grading_PeriodFrm
    Dim stat As String
    Dim stat_open As String
    Sub Load_GradingPeriod()
        Grading_Period_Grid.Columns(2).Visible = False
        Grading_Period_Grid.Rows.Clear()
        cm = New MySqlCommand("SELECT * FROM `grading_period`", connect)
        dr = cm.ExecuteReader
        While dr.Read

            If dr.Item("PERIOD").ToString = 1 Then
                stat = "1st Grading"
            ElseIf dr.Item("PERIOD").ToString = 2 Then
                stat = "2nd Grading"
            ElseIf dr.Item("PERIOD").ToString = 3 Then
                stat = "3rd Grading"
            ElseIf dr.Item("PERIOD").ToString = 4 Then
                stat = "4th Grading"
            End If

            If dr.Item("STATUS").ToString = True Then
                stat_open = "Active"
            Else
                stat_open = "Not Active"
            End If

            Grading_Period_Grid.Rows.Add("Activate", "Deactivate", dr.Item("ID").ToString, stat, stat_open)
        End While
        dr.Dispose()
    End Sub

    Private Sub Grading_PeriodFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Load_GradingPeriod()
    End Sub

    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Dispose()
        viewdash()
    End Sub

    Private Sub Grading_Period_Grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grading_Period_Grid.CellContentClick
        Dim colname As String = Grading_Period_Grid.Columns(e.ColumnIndex).Name
        If colname = "act" Then
            cm = New MySqlCommand("UPDATE `grading_period` SET `STATUS` = '1' WHERE `grading_period`.`ID` = '" & Grading_Period_Grid.Rows(e.RowIndex).Cells(2).Value.ToString() & "' ;", connect)
            cm.ExecuteNonQuery()
            MessageBox.Show("Grading Period is now Active!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cm = New MySqlCommand("UPDATE `grading_period` SET `STATUS` = '0' WHERE `grading_period`.`ID` != '" & Grading_Period_Grid.Rows(e.RowIndex).Cells(2).Value.ToString() & "' ;", connect)
            cm.ExecuteNonQuery()
            Load_GradingPeriod()
        ElseIf colname = "deact" Then
            cm = New MySqlCommand("UPDATE `grading_period` SET `STATUS` = '0' WHERE `grading_period`.`ID` = '" & Grading_Period_Grid.Rows(e.RowIndex).Cells(2).Value.ToString() & "' ;", connect)
            cm.ExecuteNonQuery()
            MessageBox.Show("Grading Period is been deactivated!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Load_GradingPeriod()
        End If
    End Sub
End Class