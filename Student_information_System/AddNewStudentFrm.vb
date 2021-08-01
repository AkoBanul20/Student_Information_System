Imports MySql.Data.MySqlClient
Imports Tulpep.NotificationWindow

Public Class AddNewStudentFrm
    Dim BC As Integer
    Dim GM As Integer
    Dim Form137 As Integer
    Dim updateBC, updateGM, updateForm As Boolean

    Sub CheckcmbStatus()
        If BC_cmb.Checked = True Then
            BC = 1
        ElseIf GM_cmb.Checked = True Then
            GM = 1
        ElseIf FRM137_cmb.Checked = True Then
            Form137 = 1
        Else
            BC = 0
            GM = 0
            Form137 = 0
        End If
    End Sub
    Sub clearall()
        ID_label.ResetText()
        LRN_Text.ResetText()
        Firstname_Text.Clear()
        Middlename_Text.Clear()
        Lastname_Text.Clear()
        Gender_Combox.SelectedItem = Nothing
        Birthplace_Text.Clear()
        Birthdate_Picker.Value = Date.Today
        Contact_Text.Clear()
        Nationality_Text.Clear()
        Religion_Text.Clear()
        Email_Text.Clear()
        Address_Text.Clear()
        Mother_name_text.Clear()
        mother_occupation_text.Clear()
        Father_name_text.Clear()
        Father_occupation_text.Clear()
        Guardian_text.Clear()
        Guardian_contact_text.Clear()
        BC_cmb.Checked = False
        GM_cmb.Checked = False
        FRM137_cmb.Checked = False
        BC = 0
        GM = 0
        Form137 = 0
        

    End Sub
    Sub check_update()
        If update_status = 1 Then
            cm = New MySqlCommand("SELECT * FROM student_record WHERE ID = '" & ID_label.Text & "'", connect)
            dr = cm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    LRN_Text.Text = dr.Item("LRN").ToString
                    updateBC = dr.Item("BIRTH_CERTIFICATE").ToString
                    updateGM = dr.Item("GOOD_MORAL").ToString
                    updateForm = dr.Item("FORM_137").ToString
                    Firstname_Text.Text = dr.Item("FIRSTNAME").ToString
                    Middlename_Text.Text = dr.Item("MIDDLENAME").ToString
                    Lastname_Text.Text = dr.Item("LASTNAME").ToString
                    Birthdate_Picker.Value = dr.Item("BIRTH_DATE").ToString
                    Gender_Combox.Text = dr.Item("GENDER").ToString
                    Birthplace_Text.Text = dr.Item("BIRTHPLACE").ToString
                    Contact_Text.Text = dr.Item("CONTACT").ToString
                    Nationality_Text.Text = dr.Item("NATIONALITY").ToString
                    Religion_Text.Text = dr.Item("RELIGION").ToString
                    Email_Text.Text = dr.Item("EMAIL_ADDRESS").ToString
                    Address_Text.Text = dr.Item("ADDRESS").ToString
                    Mother_name_text.Text = dr.Item("MOTHERS_NAME").ToString
                    mother_occupation_text.Text = dr.Item("MOTHER_OCCUPATION").ToString
                    Father_name_text.Text = dr.Item("FATHERS_NAME").ToString
                    Father_occupation_text.Text = dr.Item("FATHER_OCCUPATION").ToString
                    Guardian_text.Text = dr.Item("GUARDIAN").ToString
                    Guardian_contact_text.Text = dr.Item("GUARDIAN_CONTACT").ToString
                    'MessageBox.Show(updateBC)
                    If updateBC = True Then
                        BC_cmb.Checked = True
                    End If

                    If updateGM = True Then
                        GM_cmb.Checked = True
                    End If

                    If updateForm = True Then
                        FRM137_cmb.Checked = True
                    End If

                End While
            End If
        End If
    End Sub
    Sub update_data()
        cm = New MySqlCommand("UPDATE student_record SET " _
                              & "LRN = '" & LRN_Text.Text & "'," _
                              & "BIRTH_CERTIFICATE = '" & BC & "'," _
                              & "GOOD_MORAL = '" & GM & "'," _
                              & "FORM_137 = '" & Form137 & "'," _
                              & "FIRSTNAME = '" & Firstname_Text.Text & "'," _
                              & "MIDDLENAME = '" & Middlename_Text.Text & "'," _
                              & "LASTNAME = '" & Lastname_Text.Text & "'," _
                              & "BIRTH_DATE = '" & Birthdate_Picker.Value.ToString("yyyy-MM-dd") & "'," _
                              & "GENDER = '" & Gender_Combox.Text & "'," _
                              & "BIRTHPLACE = '" & Birthplace_Text.Text & "'," _
                              & "CONTACT = '" & Contact_Text.Text & "', " _
                              & "NATIONALITY = '" & Nationality_Text.Text & "'," _
                              & "RELIGION = '" & Religion_Text.Text & "'," _
                              & "EMAIL_ADDRESS = '" & Email_Text.Text & "'," _
                              & "ADDRESS = '" & Address_Text.Text & "'," _
                              & "MOTHERS_NAME= '" & Mother_name_text.Text & "'," _
                              & "MOTHER_OCCUPATION = '" & mother_occupation_text.Text & "'," _
                              & "FATHERS_NAME = '" & Father_name_text.Text & "'," _
                              & "FATHER_OCCUPATION = '" & Father_occupation_text.Text & "'," _
                              & "GUARDIAN = '" & Guardian_text.Text & "'," _
                              & "GUARDIAN_CONTACT = '" & Guardian_contact_text.Text & "'" _
                             & " WHERE ID = '" & ID_label.Text & "' ", connect)
        cm.ExecuteNonQuery()
        StudentFrm.LoadStudentList()
        MessageBox.Show("Record has been save!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)

        clearall()
        Me.Close()
    End Sub
    Sub saverecord()
        cm = New MySqlCommand("INSERT INTO `student_record` (`FIRSTNAME`, `MIDDLENAME`, `LASTNAME`, `LRN`, `BIRTH_DATE`, `GENDER`, `BIRTHPLACE`, `CONTACT`, `NATIONALITY`, `RELIGION`,`EMAIL_ADDRESS`, `ADDRESS`, `MOTHERS_NAME`, `MOTHER_OCCUPATION`, `FATHERS_NAME`, `FATHER_OCCUPATION`, `GUARDIAN`, `GUARDIAN_CONTACT`, `BIRTH_CERTIFICATE`, `GOOD_MORAL`, `FORM_137`) VALUES " _
                                  & "('" & Firstname_Text.Text & "', '" & Middlename_Text.Text & "', '" & Lastname_Text.Text & "', '" & LRN_Text.Text & "', '" & Birthdate_Picker.Value.ToString("yyyy/MM/dd") & "', '" & Gender_Combox.Text & "', '" & Birthplace_Text.Text & "', '" & Contact_Text.Text & "', '" & Nationality_Text.Text & "', '" & Religion_Text.Text & "', '" & Email_Text.Text & "' ,'" & Address_Text.Text & "', '" & Mother_name_text.Text & "', '" & mother_occupation_text.Text & "', '" & Father_name_text.Text & "', '" & Father_occupation_text.Text & "', '" & Guardian_text.Text & "', '" & Guardian_contact_text.Text & "', '" & BC & "', '" & GM & "', '" & Form137 & "');", connect)
        cm.ExecuteNonQuery()
        MessageBox.Show("Record has been save!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)

        clearall()
        StudentFrm.LoadStudentList()

    End Sub
    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Close()
    End Sub
    Private Sub BC_cmb_CheckedChanged(sender As Object, e As EventArgs) Handles BC_cmb.CheckedChanged
        If BC_cmb.Checked = True Then
            BC = 1
        Else
            BC = 0
        End If
    End Sub

    Private Sub GM_cmb_CheckedChanged(sender As Object, e As EventArgs) Handles GM_cmb.CheckedChanged
        If GM_cmb.Checked = True Then
            GM = 1
        Else
            GM = 0
        End If
    End Sub

    Private Sub FRM137_cmb_CheckedChanged(sender As Object, e As EventArgs) Handles FRM137_cmb.CheckedChanged
        If FRM137_cmb.Checked = True Then
            Form137 = 1
        Else
            Form137 = 0
        End If
    End Sub
    Private Sub AddNewBtn_Click(sender As Object, e As EventArgs) Handles AddNewBtn.Click
        If LRN_Text.Text = Nothing Or Firstname_Text.Text = Nothing Or Lastname_Text.Text = Nothing Or Gender_Combox.Text = Nothing Or Birthplace_Text.Text = Nothing Or Contact_Text.Text = Nothing Or Nationality_Text.Text = Nothing Or Nationality_Text.Text = Nothing Or Religion_Text.Text = Nothing Or Email_Text.Text = Nothing Or Address_Text.Text = Nothing Or Mother_name_text.Text = Nothing Or Father_name_text.Text = Nothing Or Guardian_text.Text = Nothing Or Guardian_contact_text.Text = Nothing Then
            MessageBox.Show("Fill out required fields!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Birthdate_Picker.Value = Date.Today Then
            MessageBox.Show("Select proper date in birthdate!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If MessageBox.Show("Do you want to save this record?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                saverecord()
            End If
        End If
    End Sub

    Private Sub AddNewStudentFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        clearall()
        AddNewBtn.BringToFront()
        UpdateBtn.SendToBack()
    End Sub
    Private Sub AddNewStudentFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        check_update()
        CheckcmbStatus()
        Birthdate_Picker.FormatCustom = "MM/dd/yyyy"
        Birthdate_Picker.Format = DateTimePickerFormat.Custom
        Birthdate_Picker.Value = DateTime.Today

    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        clearall()
        Me.Close()
    End Sub
    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        update_data()
    End Sub
End Class