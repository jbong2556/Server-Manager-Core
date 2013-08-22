Public Class Reports

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Namebox.Text = "" Then
            MsgBox("Пожалуйста напишите ваше имя", MsgBoxStyle.Critical, "Ошибка")
            Exit Sub
        End If

        If DataMessage.Text = "" Then
            MsgBox("Пожалуйста напишите сообщение", MsgBoxStyle.Critical, "Ошибка")
            Exit Sub
        End If
        ReportSender.Navigate("http://servermanager.miixit.org/report/reporter_index.php?name=" + Namebox.Text + " " + "&report=" + DataMessage.Text)
        MsgBox("Сообщение было отправлено!", MsgBoxStyle.Information, "Ошибка")
        Me.Close()
    End Sub
End Class