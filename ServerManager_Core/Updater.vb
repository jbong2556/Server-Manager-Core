Imports System.Net
Imports System.IO

Public Class Updater

    'This has been re-worked a little!
    Private Sub Updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.BringToFront()

        WiglegUpdater_Console.Text = WiglegUpdater_Console.Text + "[UPDATE] Checking files on system" + Environment.NewLine
        WiglegUpdater_Console.Text = WiglegUpdater_Console.Text + "[UPDATE] System version is " + Application.ProductVersion + Environment.NewLine
        Progressbar.Value = 10



        If Not WebsiteFunction().Contains(Application.ProductVersion) Then
            Download.Enabled = True
            WiglegUpdater_Console.Text = WiglegUpdater_Console.Text + "[UPDATE] Update Detected, Download?" + Environment.NewLine

        Else
            Loading.Loading_Console.Items.Add("[UPDATES] Files are up to date!")
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

        WiglegUpdater_Console.Text = WiglegUpdater_Console.Text + "[UPDATE] Please select a place to save the file" + Environment.NewLine

        FolderBrowser.ShowDialog()

        If FolderBrowser.SelectedPath = "" Then
            MsgBox("Path needs to be selected", MsgBoxStyle.Critical, "Error")
            FolderBrowser.ShowDialog()
        End If

        Progressbar.Value = 50
        WiglegUpdater_Console.Text = WiglegUpdater_Console.Text + "[UPDATE] Location set to " + FolderBrowser.SelectedPath + Environment.NewLine
        My.Computer.Network.DownloadFile("http://servermanager.miixit.org/downloads/" + WebsiteFunction() + ".zip", FolderBrowser.SelectedPath.ToString + "\" + WebsiteFunction() + ".zip")
        MsgBox("The file has been downloaded! Please extract the zip and run the new application", MsgBoxStyle.Information, "File Downloaded")

        Progressbar.Value = 100
        Application.Exit()

    End Sub
End Class