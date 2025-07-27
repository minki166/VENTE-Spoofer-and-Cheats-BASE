Imports vente.VenteData
Imports System.IO
Imports System.ComponentModel

Module RemoveAndAddLicense
    Public LicRichBox As New RichTextBox
    Public logSticker As String

    Public Async Sub GetLicense()

        Download_AllLicenses.StartDwonloading()
        ' LicRichBox.Text = Download_AllLicenses.DownloadedLicenses

    End Sub

    Public Async Sub CheckIfThisLicenseExists()
        Download_AllLicenses.StartDwonloading()

        Dim found As Boolean = False

        For Each line As String In LicRichBox.Lines
            If String.Equals(line.Trim(), LicenseActivation.LicTextBox.Text.Trim(), StringComparison.OrdinalIgnoreCase) Then
                found = True
                Exit For
            End If
        Next

        If found Then

            '# Add license to WEB account.
            Dim AddLicenseToAccount As String = Await New System.Net.WebClient().DownloadStringTaskAsync("https://edditdev.com/vente/database/" & stored_username.ToString & "/NewLicense.php?ID=" & LicenseActivation.LicTextBox.Text)
            If AddLicenseToAccount.Contains("Done") Then
                '# If license is added, remove it from web server.
                Dim EncryptLicenseToRemoveFromServer As String = LicenseActivation.LicTextBox.Text
                EncryptLicenseToRemoveFromServer = EncryptLicenseToRemoveFromServer.Replace("!", "H")
                EncryptLicenseToRemoveFromServer = EncryptLicenseToRemoveFromServer.Replace("@", "F")

                Dim RemoveLicenseFromWebServer As String = Await New System.Net.WebClient().DownloadStringTaskAsync("https://edditdev.com/vente/license/rLicense.php?ID=" & EncryptLicenseToRemoveFromServer.ToString)
                If RemoveLicenseFromWebServer.Contains("Done") Then
                    LicenseActivation.StatusLbl.Text = "Successfully activated license!"
                    LicenseActivation.StatusLbl.ForeColor = Color.Lime
                    LicenseActivation.StatusLbl.Visible = True
                    LicenseActivation.ActivateBtn.Enabled = False
                    LicenseActivation.ActivateBtn.Visible = False
                    LicenseActivation.ActivateBtn.Text = "License activated"
                    LicenseActivation.ActivateBtn.Size = New Size(149, 27)
                    LicenseActivation.ActivateBtn.Location = New Point(342, 174)
                    '# Refresh user in VENTE Imgui.
                    Download_AllLicenses.StartDwonloading()
                    Download_AccountLicense.StartDownload()
                    HomeTab.DownloadUserDetails()
                    HomeTab.GetLicensesSyntax()
                    ActivatedLicense.Send()
                End If
            End If

        Else
            LicenseActivation.StatusLbl.Text = "Activation failed!"
            LicenseActivation.StatusLbl.ForeColor = Color.Crimson
            LicenseActivation.StatusLbl.Visible = True
            ActivationFailed.Send()
        End If

    End Sub


End Module
