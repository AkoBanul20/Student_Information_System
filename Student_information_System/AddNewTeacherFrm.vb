Imports MySql.Data.MySqlClient
Public Class AddNewTeacherFrm
    Dim result As String
    Sub clearall()
        ID_label.ResetText()
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
        Teacher_No_Text.Clear()
    End Sub
    Sub save_data()
        cm = New MySqlCommand("INSERT INTO `teacher_record` (`TEACHER_NO`,`TEACHER_FIRSTNAME`, `TEACHER_MIDDLENAME`, `TEACHER_LASTNAME`,  `GENDER`, `BIRTH_PLACE`, `BIRTH_DATE`, `CONTACT_NO`, `NATIONALITY`, `RELIGION`,`EMAIL_ADDRESS`, `ADDRESS`, `MOTHER_NAME`, `MOTHER_OCCUPATION`, `FATHER_NAME`, `FATHER_OCCUPATION`) VALUES ('" & Teacher_No_Text.Text & "','" & Firstname_Text.Text & "', '" & Middlename_Text.Text & "', '" & Lastname_Text.Text & "', '" & Gender_Combox.Text & "', '" & Birthplace_Text.Text & "',  '" & Birthdate_Picker.Value.ToString("yyyy/MM/dd") & "',  '" & Contact_Text.Text & "', '" & Nationality_Text.Text & "', '" & Religion_Text.Text & "', '" & Email_Text.Text & "' , '" & Address_Text.Text & "', '" & Mother_name_text.Text & "', '" & mother_occupation_text.Text & "', '" & Father_name_text.Text & "', '" & Father_occupation_text.Text & "');", connect)
        cm.ExecuteNonQuery()
        MessageBox.Show("Record Save!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearall()
        TeacherFrm.load_data_teacher()
        check_last_teacher_no()

    End Sub
    Sub check_last_teacher_no()
        cm = New MySqlCommand("SELECT MAX(TEACHER_NO) FROM teacher_record", connect)
        result = cm.ExecuteScalar().ToString()

        If String.IsNullOrEmpty(result) Then
            result = "20190001"
            Teacher_No_Text.Text = result
        Else
            result = result + 1
            Teacher_No_Text.Text = result
        End If
    End Sub
    Sub check_update()
        If update_status_teacher = 0 Then
            check_last_teacher_no()
        Else
            cm = New MySqlCommand("SELECT * FROM teacher_record WHERE TEACHER_ID = '" & ID_label.Text & "' ", connect)
            dr = cm.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    ID_label.Text = dr.Item("TEACHER_ID").ToString
                    Teacher_No_Text.Text = dr.Item("TEACHER_NO").ToString
                    Firstname_Text.Text = dr.Item("TEACHER_FIRSTNAME").ToString
                    Middlename_Text.Text = dr.Item("TEACHER_MIDDLENAME").ToString
                    Lastname_Text.Text = dr.Item("TEACHER_LASTNAME").ToString
                    Gender_Combox.Text = dr.Item("GENDER").ToString
                    Birthplace_Text.Text = dr.Item("BIRTH_PLACE").ToString
                    Birthdate_Picker.Value = dr.Item("BIRTH_DATE").ToString
                    Contact_Text.Text = dr.Item("CONTACT_NO").ToString
                    Nationality_Text.Text = dr.Item("NATIONALITY").ToString
                    Religion_Text.Text = dr.Item("RELIGION").ToString
                    Email_Text.Text = dr.Item("EMAIL_ADDRESS").ToString
                    Address_Text.Text = dr.Item("ADDRESS").ToString
                    Mother_name_text.Text = dr.Item("MOTHER_NAME").ToString
                    mother_occupation_text.Text = dr.Item("MOTHER_OCCUPATION").ToString
                    Father_name_text.Text = dr.Item("FATHER_NAME").ToString
                    Father_occupation_text.Text = dr.Item("FATHER_OCCUPATION").ToString
                End While
                dr.Close()
            End If
        End If
        'dito update function
       
    End Sub
    Sub Update_teacher_data()
        cm = New MySqlCommand(" UPDATE teacher_record SET " _
                               & "TEACHER_FIRSTNAME = '" & Firstname_Text.Text & "', " _
                               & "TEACHER_MIDDLENAME = '" & Middlename_Text.Text & "'," _
                               & "TEACHER_LASTNAME = '" & Lastname_Text.Text & "'," _
                               & "GENDER = '" & Gender_Combox.Text & "'," _
                               & "BIRTH_PLACE = '" & Birthplace_Text.Text & "'," _
                               & "BIRTH_DATE = '" & Birthdate_Picker.Value.ToString("yyyy-MM-dd") & "'," _
                               & "CONTACT_NO = '" & Contact_Text.Text & "'," _
                               & "NATIONALITY = '" & Nationality_Text.Text & "'," _
                               & "RELIGION = '" & Religion_Text.Text & "'," _
                               & "EMAIL_ADDRESS = '" & Email_Text.Text & "'," _
                               & "ADDRESS = '" & Address_Text.Text & "'," _
                               & "MOTHER_NAME = '" & Mother_name_text.Text & "'," _
                               & "MOTHER_OCCUPATION = '" & mother_occupation_text.Text & "'," _
                               & "FATHER_NAME = '" & Father_name_text.Text & "'," _
                               & "FATHER_OCCUPATION = '" & Father_occupation_text.Text & "'" _
                                & "WHERE TEACHER_ID = '" & ID_label.Text & "'", connect)
        cm.ExecuteNonQuery()
        MessageBox.Show("Record Save!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearall()
        TeacherFrm.load_data_teacher()

    End Sub
    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Close()
    End Sub

    Private Sub AddNewBtn_Click(sender As Object, e As EventArgs) Handles AddNewBtn.Click
        If Teacher_No_Text.Text = Nothing Or Firstname_Text.Text = Nothing Or Lastname_Text.Text = Nothing Or Gender_Combox.Text = Nothing Or Birthplace_Text.Text = Nothing Or Contact_Text.Text = Nothing Or Nationality_Text.Text = Nothing Or Nationality_Text.Text = Nothing Or Religion_Text.Text = Nothing Or Email_Text.Text = Nothing Or Address_Text.Text = Nothing Or Mother_name_text.Text = Nothing Or Father_name_text.Text = Nothing Then
            MessageBox.Show("Fill out required fields!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Birthdate_Picker.Value = Date.Today Then
            MessageBox.Show("Select proper date in birthdate!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If MessageBox.Show("Save this record? Click yes to confirm", "notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                save_data()
            End If
        End If
        
    End Sub

    Private Sub AddNewTeacherFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        clearall()
        AddNewBtn.BringToFront()
        UpdateBtn.SendToBack()
        Teacher_No_Text.Enabled = True
    End Sub
    Private Sub AddNewTeacherFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        check_update()
        Birthdate_Picker.FormatCustom = "MM/dd/yyyy"
        Birthdate_Picker.Format = DateTimePickerFormat.Custom
        Birthdate_Picker.Value = DateTime.Today
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        clearall()
        Me.Close()
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If MessageBox.Show("Save this record? Click yes to confirm", "notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Update_teacher_data()
            Me.Close()
        End If
    End Sub
End Class