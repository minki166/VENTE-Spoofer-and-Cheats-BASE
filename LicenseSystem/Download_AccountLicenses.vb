Imports vente.VenteData
Module Download_AccountLicense
    Public Async Sub StartDownload()
        '# Get Account licenses
        Try
            Dim GetAccountLicenses As String = Await New System.Net.WebClient().DownloadStringTaskAsync(Web_Database & stored_username.ToString & "/License.ini")
            stored_license = GetAccountLicenses.ToString
            HomeTab.UsernameLbl2.Text = VenteData.stored_username.ToString
            HomeTab.GetLicensesSyntax()
        Catch ex As Exception
            ' Obsługa błędu
        End Try
    End Sub
End Module
