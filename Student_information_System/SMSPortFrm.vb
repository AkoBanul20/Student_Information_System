Public Class SMSPortFrm

    Private Sub SMSPortFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        For Each sp As String In My.Computer.Ports.SerialPortNames
            Port_List.Items.Add(sp)
        Next
        Dim portstring = My.Settings.SmsPortSettings
        Port_List.Text = portstring
    End Sub
    Private Sub Close_btn_Click(sender As Object, e As EventArgs) Handles Close_btn.Click
        Me.Close()
    End Sub

    Private Sub SaveSmsPort_Click(sender As Object, e As EventArgs) Handles SaveSmsPort.Click
        If Port_List.Text = Nothing Then
            MsgBox("Select a port first before Save", MsgBoxStyle.Critical, "Invalid Attempt")
        End If
        My.Settings.SmsPortSettings = Port_List.Text
        MessageBox.Show("Port set up successfully to " & Port_List.Text, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        SMSFrm.checkport()
    End Sub

   
End Class