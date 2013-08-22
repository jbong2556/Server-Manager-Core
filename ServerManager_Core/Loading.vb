Public Class Loading

    Dim Firstlaunch As Boolean = My.Settings.Firstlaunch
    Dim Timer As Integer
    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Loading_Console.Items.Add("[SERVER MANAGER] Launching load objectives... ")
        Section_Timer.Enabled = True
        Check_FirstLaunch()

    End Sub

    Private Sub Check_FirstLaunch()

        Loading_Console.Items.Add("[SERVER MANAGER] Checking if this is first launch...  ")

        If Firstlaunch = True Then
            Loading_Console.Items.Add("[SERVER MANAGER] First launch detected..")

            MsgBox("We've detected this is your first launch, can you tell us where your game is?", MsgBoxStyle.Information, "Welcome")
            FolderBrowser.ShowDialog()

            My.Settings.Directory = FolderBrowser.SelectedPath.ToString
            My.Settings.Save()

            Loading_Console.Items.Add("[GAME FILES] Directory set to " + My.Settings.Directory)

            'Show the changelog
            Changelog.Show()

            'Then check directory
            CheckDirectory()

            My.Settings.Firstlaunch = False

            Exit Sub
        End If

        If Firstlaunch = False Then
            Loading_Console.Items.Add("[SERVER MANAGER] Not first launch..")

            'Then check directory
            CheckDirectory()
        End If

    End Sub

    Private Sub CheckDirectory()

        If My.Settings.Directory = "" Then

            MsgBox("Your directory is non existant, please replace it.", MsgBoxStyle.Exclamation, "Error")
            Loading_Console.Items.Add("[DIRECTORY] Your directory has been changed to " + My.Settings.Directory.ToString)

            FolderBrowser.ShowDialog()

            My.Settings.Directory = FolderBrowser.SelectedPath
            My.Settings.Firstlaunch = False
            My.Settings.Save()



        End If


        If Not My.Computer.FileSystem.DirectoryExists(My.Settings.Directory.ToString) Then

            MsgBox("Your directory has not been found!", MsgBoxStyle.Exclamation, "Error")
            Loading_Console.Items.Add("[DIRECTORY] Your directory has been changed to " + My.Settings.Directory.ToString)

            FolderBrowser.ShowDialog()

            My.Settings.Directory = FolderBrowser.SelectedPath
            My.Settings.Firstlaunch = False
            My.Settings.Save()




        End If

        CheckUpdates()


    End Sub


    Private Sub CheckUpdates()

        If System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() = True Then

            Loading_Console.Items.Add("[UPDATES] Checking updates..")
            IsURLValid()
        Else

            Loading_Console.Items.Add("[UPDATES] No internet connection aborting!")
        End If
    End Sub

    Public Sub FinishUp()
        Section_Timer.Enabled = False
        Loading_Console.Items.Add("[FINISH] Launching startup, took " + Timer.ToString + " seconds")
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
            Loading_Console.Items.Add("[UPDATES] Wigleg nexus is online..")
            Updater.Show()
        Catch ex As Exception
            req = Nothing
            Return
            Loading_Console.Items.Add("[UPDATES] Wigleg nexus is offline cannot update..")
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
