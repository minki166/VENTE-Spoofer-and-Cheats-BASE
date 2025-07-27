Imports vente.VenteData
Module Download_AllLicenses
    Public DownloadedLicenses As String
    Public Async Sub StartDwonloading()
        '# Get all licenses attempt
        Try


            '# Get all licenses from server
            Dim GetAllLicenses As String = Await New System.Net.WebClient().DownloadStringTaskAsync("https://edditdev.com/vente/license/licenses.ini")

            GetAllLicenses = GetAllLicenses.Replace("!", "H")
            GetAllLicenses = GetAllLicenses.Replace("@", "F")

            DownloadedLicenses = GetAllLicenses
            RemoveAndAddLicense.LicRichBox.Text = DownloadedLicenses
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Module
