Imports System.IO

Public Class ServerSetup

    Dim GameDirectory As String = My.Settings.Directory
    Private Sub ServerSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(My.Settings.Directory)


        GrabSaves()
        GrabWorlds()


        World.SelectedIndex = 0
        SaveLocation.SelectedIndex = 0

        
    End Sub


    Private Sub GrabSaves()

        For Each Dir As String In Directory.GetDirectories(My.Settings.Directory.ToString + "\Data\Worlds\Navezgane\Saves")

            Dim NewDir = Replace(Dir, My.Settings.Directory + "\Data\Worlds\Navezgane\Saves\", "")
            SaveLocation.Items.Add(NewDir)
        Next
    End Sub

    Private Sub GrabWorlds()

        For Each SecondDir As String In Directory.GetDirectories(My.Settings.Directory.ToString + "\Data\Worlds")

            Dim NewDir = Replace(SecondDir, My.Settings.Directory + "\Data\Worlds\", "")
            World.Items.Add(NewDir)
        Next

    End Sub

    Private Sub StartServer_Click(sender As Object, e As EventArgs) Handles StartServer.Click

        If PortBox.TextLength > 6 Then
            MsgBox("Port is impossible", MsgBoxStyle.Critical, "Critical Error")
            PortBox.Text = "25000"
            Exit Sub
        End If

        Dim Port As String = PortBox.Text
        Dim ServerWorld As Object = World.SelectedItem
        Dim SaveFile As Object = SaveLocation.SelectedItem
        Dim GameLocation As String

        If ServerWorld.ToString = "Please Select a value" Then
            MsgBox("Please pick a Server World!", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If SaveFile.ToString = "Please Select a value" Then
            MsgBox("Please pick a Server Save!", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If Port = "" Then
            MsgBox("Please pick a Server Port!", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        FindGame.InitialDirectory = My.Settings.Directory.ToString
        FindGame.Filter = "Game Executables | *.exe"
        FindGame.ShowDialog()


        GameLocation = FindGame.FileName

        If GameLocation = "" Then
            Exit Sub
        End If

        'This is infact the main process which starts the game
        If Advanced.Text = "" Then
            Process.Start(GameLocation, "-port " + Port + " -dedicated " + ServerWorld.ToString + " " + SaveFile.ToString)
        Else
            Process.Start(GameLocation, "-port " + Port + " -dedicated " + ServerWorld.ToString + " " + SaveFile.ToString + " " + Advanced.Text)
        End If
    End Sub

    Private Sub PortBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Portbox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class