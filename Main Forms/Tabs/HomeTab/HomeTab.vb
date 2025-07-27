Imports vente.VenteData
Public Class HomeTab
    Private Sub HomeTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DownloadUserDetails()
            GetLicensesSyntax()
            If LicenseText.Text = "" Then
                LicenseText.Text = "Not found any license"
            End If
            If LicenseText.Text = " " Then
                LicenseText.Text = "Not found any license"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub GetLicensesSyntax()
        UsernameLbl2.Text = VenteData.stored_username.ToString


        '# Read licenses for programs/games.
        LicenseText.Text = ""
        If stored_license.Contains("F") Then
            LicenseText.Text = LicenseText.Text & "| FORTNITE "
            RankLbl.Text = "VIP"
            RankLbl.ForeColor = Color.Gold
        End If

        If stored_license.Contains("H") Then
            LicenseText.Text = LicenseText.Text & "| HWID SPOOFER "
            RankLbl.Text = "VIP"
            RankLbl.ForeColor = Color.Gold
        End If

        If LicenseText.Text.StartsWith("|") Then
            LicenseText.Text = LicenseText.Text.Substring(2)
        End If



    End Sub

    Public Sub DownloadUserDetails()
        GetUserDetails.Download()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles RankLbl.Click
        LicenseActivation.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LicenseActivation.Show()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class