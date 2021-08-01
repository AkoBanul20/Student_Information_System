Imports MySql.Data.MySqlClient
Imports System.Threading.Thread
Imports System.IO.Ports

Public Class SMSFrm
    Dim studname As String
    Dim rowData As String
    Dim message As String
    Dim queryGrade As String
    Dim GP, Grading_Period As String
    Dim average_Text As Double
    Dim contactnum As String
    Dim asd As String
    Sub checkport()
        Dim availableSerialPorts As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Computer.Ports.SerialPortNames
        If availableSerialPorts.Contains(My.Settings.SmsPortSettings) Then
            MessageBox.Show(My.Settings.SmsPortSettings & " Port is available you can now send messages!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(My.Settings.SmsPortSettings & " Port is not available you can't send messages! check if modem stick is connected!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Sub SendSmsGrades()
            Try
                With SendSMS
                    .PortName = My.Settings.SmsPortSettings
                    .BaudRate = 9600
                    .Parity = Parity.None
                    .StopBits = StopBits.One
                    .DataBits = 8
                .Handshake = Handshake.None
                    .DtrEnable = True
                    .RtsEnable = True
                    .NewLine = vbCrLf
                    .Open()
                    .Write("AT" & vbCrLf)
                    .Write("AT+CMGF=1" & vbCrLf)
                    .Write("AT+CMGS=" & Chr(34) & (contactnum) & Chr(34) & vbCrLf)
                    Sleep(2000)
                    .Write(message & Chr(26))
                    Sleep(3000)
                End With
                asd = SendSMS.ReadExisting
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
    End Sub

    Sub LoadStudentGrades()
        Try
            If Student_List_View.Items.Count > 0 Then
                For i = Student_List_View.Items.Count - 1 To 0 Step -1

                    If Student_List_View.Items(i).Checked = True Then
                        Dim tmpColor As New System.Drawing.Color
                        tmpColor = Color.GreenYellow
                        Student_List_View.Items(i).BackColor = tmpColor
                        sendingstat_label.ForeColor = Color.GreenYellow
                        sendingstat_label.Text = "Sending......"
                        If Grading_txt.Text = 1 Then
                            GP = "G1"
                            Grading_Period = "1st Grading"
                        ElseIf Grading_txt.Text = 2 Then
                            GP = "G2"
                            Grading_Period = "2nd Grading"
                        ElseIf Grading_txt.Text = 3 Then
                            GP = "G3"
                            Grading_Period = "3rd Grading"
                        ElseIf Grading_txt.Text = 4 Then
                            GP = "G4"
                            Grading_Period = "4th Grading"
                        End If
                        queryGrade = "SELECT   class_subjects.SUBJECTCODE AS SUBJ,grades." & GP & " AS GRADE FROM enrollment INNER JOIN student_record ON student_record.LRN =  enrollment.STUDENT_LRN  JOIN grades on grades.ENROLLMENT_ID = enrollment.ENROLLMENT_ID  JOIN class_subjects on class_subjects.ID = grades.CLASS_SUBJECT_ID  WHERE grades.ENROLLMENT_ID  = '" & Student_List_View.Items(i).Text & "' ORDER BY grades.ENROLLMENT_ID"
                        Dim dt As New DataTable
                        Using adpt As New MySqlDataAdapter(queryGrade, connect)
                            adpt.Fill(dt)
                        End Using

                        cm = New MySqlCommand("SELECT AVG(" & GP & ") AS AVERAGE FROM grades WHERE ENROLLMENT_ID = '" & Student_List_View.Items(i).Text & "';", connect)
                        dr = cm.ExecuteReader

                        While dr.Read
                            average_Text = dr.Item("AVERAGE").ToString
                        End While
                        dr.Dispose()

                        'dito yung pag extract ng data ng grades ng student
                        rowData = ""
                        For Each row As DataRow In dt.Rows
                            For Each column As DataColumn In dt.Columns
                                rowData = rowData & row(column) & " "
                            Next
                            rowData = rowData & vbNewLine
                        Next

                        studname = Student_List_View.Items(i).SubItems(1).Text
                        contactnum = Student_List_View.Items(i).SubItems(2).Text
                        message = "STUDENT:" & Student_List_View.Items(i).SubItems(1).Text & vbCrLf &
                             "GRADE:" & Student_List_View.Items(i).SubItems(3).Text & "-" & Student_List_View.Items(i).SubItems(4).Text & vbCrLf &
                            Grading_Period & vbCrLf &
                            rowData & vbCrLf &
                            "AVERAGE:" & Math.Round(average_Text, 2)

                        ''DIto yung sending
                        SendSmsGrades()

                        If InStr(asd, "OK") Then
                            Sleep(500)
                            sendingstat_label.ForeColor = Color.Magenta
                            sendingstat_label.Text = "Messages Sent"
                            Student_List_View.Items(i).BackColor = Color.White
                            Student_List_View.Items(i).Checked = False
                            SendSMS.Close()
                        Else
                            Sleep(500)
                            SendSMS.Close()
                            Student_List_View.Items(i).BackColor = Color.Crimson
                            sendingstat_label.ForeColor = Color.Red
                            sendingstat_label.Text = "There's Messages not sent"
                            SendSMS.RtsEnable = False
                            SendSMS.DtrEnable = False
                        End If
                    End If
                Next


            Else
                MessageBox.Show("There is No record Shown int the list", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & " Contact the Technical Support!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Sub LoadGrading()
        cm = New MySqlCommand("SELECT PERIOD FROM `grading_period` WHERE STATUS = 1", connect)
        dr = cm.ExecuteReader
        While dr.Read
            Grading_txt.Text = dr.Item("PERIOD").ToString
            If Grading_txt.Text = 1 Then
                grading_label_txt.Text = "1st Grading"
            ElseIf Grading_txt.Text = 2 Then
                grading_label_txt.Text = "2nd Grading"
            ElseIf Grading_txt.Text = 3 Then
                grading_label_txt.Text = "3rd Grading"
            ElseIf Grading_txt.Text = 4 Then
                grading_label_txt.Text = "4th Grading"
            End If
        End While
    End Sub
    Sub LoadActiveSY()
        cm = New MySqlCommand("SELECT * FROM school_year WHERE ACTIVE = 1", connect)
        dr = cm.ExecuteReader
        While dr.Read
            School_year_label.Text = dr.Item("SCHOOL_YEAR").ToString
        End While
    End Sub
    Sub LoadListview()

        If grading_label_txt.Text = Nothing Then
            MessageBox.Show("There are no active grading period, activate first grading period from maintenance module", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            cm = New MySqlCommand("SELECT enrollment.ENROLLMENT_ID, CONCAT(student_record.LASTNAME,', ',student_record.FIRSTNAME) AS NAME,student_record.GUARDIAN_CONTACT, enrollment.GRADE_LEVEL, enrollment.SECTION FROM enrollment INNER JOIN student_record  ON student_record.LRN = enrollment.STUDENT_LRN WHERE student_record.ARCHIVE = 0 AND enrollment.SY ='" & School_year_label.Text & "' AND enrollment.GRADE_LEVEL = '" & gradelevel_cmb.Text & "' AND enrollment.SECTION = '" & section_cmb.Text & "' AND  enrollment.IS_ENROLLED = 1  ORDER BY enrollment.ENROLLMENT_ID", connect)
            dr = cm.ExecuteReader
            Student_List_View.Items.Clear()
            While dr.Read
                Dim a, b, c, d, e As String
                a = (dr.Item("ENROLLMENT_ID").ToString)
                b = (dr.Item("NAME").ToString)
                c = (dr.Item("GUARDIAN_CONTACT").ToString)
                d = (dr.Item("GRADE_LEVEL").ToString)
                e = (dr.Item("SECTION").ToString)
                Dim lv As ListViewItem = Student_List_View.Items.Add(a)
                lv.SubItems.Add(b)
                lv.SubItems.Add(c)
                lv.SubItems.Add(d)
                lv.SubItems.Add(e)


                For i = Student_List_View.Items.Count - 1 To 0 Step -1
                    Student_List_View.Items(i).Checked = True
                    SendBtn.Enabled = True
                Next
            End While
        End If
    End Sub
    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Dispose()
        viewdash()
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

    Private Sub SMSFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadActiveSY()
        LoadGrading()
        checkport()
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

    Private Sub gradelevel_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gradelevel_cmb.SelectedIndexChanged
        loadSection()
    End Sub

    Private Sub EnrollBtn_Click(sender As Object, e As EventArgs) Handles EnrollBtn.Click
        LoadListview()
    End Sub

    Private Sub SendBtn_Click(sender As Object, e As EventArgs) Handles SendBtn.Click
        LoadStudentGrades()
    End Sub

    Private Sub PortBtn_Click(sender As Object, e As EventArgs) Handles PortBtn.Click
        SMSPortFrm.ShowDialog()
    End Sub
End Class