Public Class Loading

    Dim Firstlaunch As Boolean = My.Settings.Firstlaunch
    Dim Timer As Integer
    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Loading_Console.Items.Add("[Сервер Манагер] Программа запускается... ")
        Section_Timer.Enabled = True
        Check_FirstLaunch()

    End Sub

    Private Sub Check_FirstLaunch()

        Loading_Console.Items.Add("[Сервер Манагер] Проверка...  ")

        If Firstlaunch = True Then
            Loading_Console.Items.Add("[Сервер Манагер] Сервер Манагер был запущен первый раз...")

            MsgBox("Сервер Манагер был запущен первый раз, откройте корень игры!", MsgBoxStyle.Information, "Welcome")
            FolderBrowser.ShowDialog()

            My.Settings.Directory = FolderBrowser.SelectedPath.ToString
            My.Settings.Save()

            Loading_Console.Items.Add("[Корень] Корень игры:" + My.Settings.Directory)

            'Show the changelog
            Changelog.Show()

            'Then check directory
            CheckDirectory()

            My.Settings.Firstlaunch = False

            Exit Sub
        End If

        If Firstlaunch = False Then
            Loading_Console.Items.Add("[Сервер Манагер] Не первый рас запускаетса..")

            'Then check directory
            CheckDirectory()
        End If

    End Sub

    Private Sub CheckDirectory()

        If My.Settings.Directory = "" Then

            MsgBox("Корень игры не был найден! обновите его.", MsgBoxStyle.Exclamation, "Ошыбка")
            Loading_Console.Items.Add("[Корень] Ваш корень был изменен на " + My.Settings.Directory.ToString)

            FolderBrowser.ShowDialog()

            My.Settings.Directory = FolderBrowser.SelectedPath
            My.Settings.Firstlaunch = False
            My.Settings.Save()



        End If


        If Not My.Computer.FileSystem.DirectoryExists(My.Settings.Directory.ToString) Then

            MsgBox("Корень игры не был найден!", MsgBoxStyle.Exclamation, "Ошыбка")
            Loading_Console.Items.Add("[Корень] Ваш корень игры был изменен на " + My.Settings.Directory.ToString)

            FolderBrowser.ShowDialog()

            My.Settings.Directory = FolderBrowser.SelectedPath
            My.Settings.Firstlaunch = False
            My.Settings.Save()




        End If

        CheckUpdates()


    End Sub


    Private Sub CheckUpdates()

        If System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() = True Then

            Loading_Console.Items.Add("[Обновление] Проверка обновление..")
            IsURLValid()
        Else

            Loading_Console.Items.Add("[Обновление] No internet connection aborting!")
        End If
    End Sub

    Public Sub FinishUp()
        Section_Timer.Enabled = False
        Loading_Console.Items.Add("[Завершено] Программа была запущена за " + Timer.ToString + " Секунд")
        Closebutton.Visible = True
    End Sub
    Private Sub IsURLValid()
        Dim url As New System.Uri("http://servermanager.miixit.org/")
        Dim req As System.Net.WebRequest
        req = System.Net.WebRequest.Create(url)
        Dim resp As System.Net.WebResponse
        Try
            resp = req.GetResponse()
            resp.Close()
            req = Nothing
            Loading_Console.Items.Add("[Обновление] Wigleg nexus в сети..")
            Updater.Show()
        Catch ex As Exception
            req = Nothing
            Return
            Loading_Console.Items.Add("[Обновление] Wigleg nexus не в сети..")
        End Try
    End Sub

    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click

        ServerSetup.Show()
        Me.Close()

    End Sub

    Private Sub Section_Timer_Tick(sender As Object, e As EventArgs)
        Timer = Timer + 1
    End Sub
End Class
