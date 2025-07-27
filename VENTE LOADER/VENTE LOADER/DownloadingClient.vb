Imports System.Net

Module DownloadingClient
    Public SharedPath As String =
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\vente\"
    Dim URL As String
    Public Async Sub GetReleaseURL()
        Dim Results As String = Await New WebClient().DownloadStringTaskAsync("https://edditdev.com/vente/loader/release/release")
        URL = Results
        Download()
    End Sub
    Public Sub Download()
        ' Delete first file if exists
        Try
            If IO.File.Exists(SharedPath & "vtempver.exe") Then
                IO.File.Delete(SharedPath & "vtempver.exe")
            End If
        Catch ex As Exception

        End Try


        Try
            Dim savePath As String = "vtempver.exe"

            Dim webClient As New WebClient()
            AddHandler webClient.DownloadFileCompleted, AddressOf DownloadCompleted
            webClient.DownloadFileAsync(New Uri(URL), SharedPath & "vtempver.exe")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DownloadCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs)
        Try
            Diagnostics.Process.Start(SharedPath & "vtempver.exe")
            'Startowanie loadera
            Try
                Main.Close()
            Catch ex As Exception

            End Try
        Catch ex As Exception
            MsgBox("Error #11: Can't run loader. - Try run as admin & disable windows defender.")
            Main.Close()
        End Try
    End Sub
End Module
