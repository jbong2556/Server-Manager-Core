Imports System.Net
Imports System.IO
Imports System.Net.Sockets
Imports System.Threading
Imports System.Text

Public Class Mainframe


    Private Sub Mainframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console_Display.Items.Add("[Сервер] Сервер был запущен под этим IP " + GetIP() + ":" + ServerSetup.Portbox.Text)


    End Sub

    Private Sub Commands()
        Dim Console As Object = Console_Display.Items
        Dim Command As String = Me.ConsoleEntry.Text
        Dim host As String = System.Net.Dns.GetHostName()
        Dim LocalHostaddress As String = System.Net.Dns.GetHostEntry(host).AddressList(2).ToString()

        If Command = "shutdown application" Then
            KillApplication()
        End If

        If Command = "shutdown" Then

            Console.Add("[Ошибка] Используйте 'shutdown game' или 'shutdown application' ")
        End If

        If Command = "shutdown server" Then
            Killserver()

            Console.Add("[Сервер] Сервер был убит! ")
            Console.Add("[Консоль] Закрыть Программу? напиши'shutdown application''")
        End If

        If Command = "help" Then
            Console.Add("[Сервер] Команды консоля")
            Console.Add("shutdown server")
            Console.Add("shutdown application")
            Console.Add("port")
            Console.Add("ip local")
            Console.Add("ip global")
        End If

        If Command = "port" Then
            Console.Add("[Сервер] Ваш порт " + ServerSetup.Portbox.Text)
        End If



        If Command = "daftpunk" Then
            Console.Add("[DAFTPUNK] Нельзя закрыть программу!")

        End If

        If Command = ("ip local") Then
            Console.Add("[Хост] Ваш локальный IP " + LocalHostaddress.ToString)
        End If

        If Command = ("ip global") Then
            Console.Add("[Хост] Ваш глобальный IP " + GetIP())
        End If



        Me.ConsoleEntry.Text = ""

    End Sub
    Private Sub RestartServer()
        KillServer()

        ServerSetup.Show()
        Me.Close()


    End Sub
    Public Function GetIP() As String
        Dim req As HttpWebRequest = WebRequest.Create("http://checkip.dyndns.org/")
        Dim res As HttpWebResponse = req.GetResponse()
        Dim Stream As Stream = res.GetResponseStream()
        Dim sr As StreamReader = New StreamReader(Stream)
        GetIP = sr.ReadToEnd
        Dim first As Integer = GetIP.IndexOf("Address: ") + 9
        Dim last As Integer = GetIP.LastIndexOf("</body>")
        GetIP = GetIP.Substring(first, last - first)
    End Function
    Private Sub KillServer()
        Dim Game() As Process = Process.GetProcessesByName("7DaysToDie")

        For Each Process As Process In Game
            Process.Kill()
        Next
    End Sub

    Private Sub KillApplication()
        Me.Close()
    End Sub


    Private Sub CloseServer_Click(sender As Object, e As EventArgs) Handles CloseServer.Click
        Dim Console As Object = Console_Display.Items


        Killserver()


        Console.Add("[Сервер] Сервер был убит! ")
        Console.Add("[Консоль] Закрыть Программу? напиши'shutdown application'")
    End Sub

    Private Sub ConsoleEntry_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ConsoleEntry.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Commands()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RestartServer()
    End Sub


    Private Sub CloseServer_Click_1(sender As Object, e As EventArgs) Handles CloseServer.Click
        KillServer()
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        Commands()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Reports.Show()
    End Sub
End Class