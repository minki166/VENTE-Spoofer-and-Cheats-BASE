Imports vente.VenteData

Module GetUserDetails
    Public Async Sub Download()
        Try

            Dim RegdateDLL As String = Await New System.Net.WebClient().DownloadStringTaskAsync(Web_Database & stored_username.ToString & "/Regdate.ini")
            HomeTab.JoinedLbl.Text = "Joined, " & RegdateDLL & "."
            stored_regdate = "Joined, " & RegdateDLL & "."
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Module
