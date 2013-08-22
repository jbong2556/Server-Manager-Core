Public Class Changelog

    Private Sub DonationButton_Click(sender As Object, e As EventArgs) Handles DonationButton.Click
        Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=CJU3DBQXBUQPC")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Navigator.Navigate("http://servermanager.miixit.org/hits/hit_index.php?k=" + System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString() + " has updated to version " + Application.ProductVersion + "[RUSSIAN]")
        Me.Close()
    End Sub

    Private Sub Changelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class