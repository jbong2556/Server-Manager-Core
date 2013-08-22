Imports System.Net
Imports System.IO

Public Class Updater

    'This has been re-worked a little!
    Private Sub Updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.BringToFront()

        WiglegUpdater_Console.Text = WiglegUpdater_Console.Text + "[Обновление] Проверка файлов" + Environment.NewLine
        WiglegUpdater_Console.Text = WiglegUpdater_Console.Text + "[Обновление] Версия программы " + Application.ProductVersion + Environment.NewLine
        Progressbar.Value = 10



        If Not WebsiteFunction().Contains(Application.ProductVersion) Then
            Download.Enabled = True
            WiglegUpdater_Console.Text = WiglegUpdater_Console.Text + "[Обновление] Обновление было обнаружено! Скачать?" + Environment.NewLine

        Else
            Loading.Loading_Console.Items.Add("[Обновление] Файлы не нуждается обновления! ")
            Me.Close()
            Loading.FinishUp()

        End If



    End Sub

    Public Function WebsiteFunction() As String
        Dim req As HttpWebRequest = WebRequest.Create("http://servermanager.miixit.org/")
        Dim res As HttpWebResponse = req.GetResponse()
        Dim Stream As Stream = res.GetResponseStream()
        Dim sr As StreamReader = New StreamReader(Stream)
        WebsiteFunction = sr.ReadToEnd
    End Function



    Public Function GetFileSize() As String

        Dim webReq As Net.WebRequest = Net.WebRequest.Create("http://servermanager.miixit.org/")
        Dim webResp As Net.WebResponse = webReq.GetResponse()
        GetFileSize = webResp.ContentLength()

    End Function

    Private Sub Download_Click(sender As Object, e As EventArgs) Handles Download.Click
        DownloadFile()
    End Sub

    Private Sub DownloadFile()

        WiglegUpdater_Console.Text = WiglegUpdater_Console.Text + "[Обновление] Пожалуйста выберите куда сохранить файлы" + Environment.NewLine

        FolderBrowser.ShowDialog()

        If FolderBrowser.SelectedPath = "" Then
            MsgBox("Локация должна быть выбрана!", MsgBoxStyle.Critical, "Ошибка")
            FolderBrowser.ShowDialog()
        End If

        Progressbar.Value = 50
        WiglegUpdater_Console.Text = WiglegUpdater_Console.Text + "[Обновление] Локация выбрана" + FolderBrowser.SelectedPath + Environment.NewLine
        My.Computer.Network.DownloadFile("http://servermanager.miixit.org/downloads/" + WebsiteFunction() + ".zip", FolderBrowser.SelectedPath.ToString + "\" + WebsiteFunction() + ".zip")
        MsgBox("Файл был скачан! Пожалуйста распакуйте .Zip и запустите новую программу", MsgBoxStyle.Information, "Файл был скачан")

        Progressbar.Value = 100
        Application.Exit()

    End Sub
End Class