Public Class Reports

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Namebox.Text = "" Then
            MsgBox("Please enter a name for your self", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If DataMessage.Text = "" Then
            MsgBox("Please enter a message", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        ReportSender.Navigate("http://servermanager.miixit.org/report/reporter_index.php?name=" + Namebox.Text + " " + "&report=" + DataMessage.Text)
        MsgBox("Message has been sent to server!", MsgBoxStyle.Information, "Sent")
        Me.Close()
    End Sub
End Class