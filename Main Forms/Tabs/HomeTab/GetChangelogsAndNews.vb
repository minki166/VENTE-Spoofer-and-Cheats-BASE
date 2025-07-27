Imports System.Text
Imports vente.VenteData
Module GetChangelogsAndNews


    Public Async Sub Dll_Changelog()
        Try
            Dim downloaded_reults As String = Await New System.Net.WebClient().DownloadStringTaskAsync("https://edditdev.com/vente/loader/changelog")
            downloaded_reults = downloaded_reults.Replace("*", "•")
            stored_changelog = downloaded_reults
            HomeTab.Changelogstxt.Text = stored_changelog.ToString
        Catch ex As Exception

        End Try
    End Sub

    Public Async Sub Dll_News()
        Try
            Dim downloaded_reults As String = Await New System.Net.WebClient().DownloadStringTaskAsync("https://edditdev.com/vente/loader/news")
            downloaded_reults = downloaded_reults.Replace("*", "[#]")
            stored_news = downloaded_reults
            HomeTab.NewsTxt.Text = stored_news.ToString
        Catch ex As Exception

        End Try
    End Sub


End Module
