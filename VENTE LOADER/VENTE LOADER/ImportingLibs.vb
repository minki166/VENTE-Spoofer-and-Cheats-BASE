Module ImportingLibs

    Public SharedPath As String =
      Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\vente\"

    Public Sub ImportGuna()
        '# Import Guna.DLL
        Try
            System.IO.File.WriteAllBytes(SharedPath & "Guna.UI2.dll", My.Resources.Guna_UI2)
            '# If GUNA is in Path, do a Next step. (DLL)
            DownloadingClient.GetReleaseURL()
        Catch ex As Exception
            MsgBox("#2 LOADER: Problem with Importing Librares for Loader or VENTE is already open in another process.", MsgBoxStyle.Critical, "VENTE | Critical ERROR")
        End Try




    End Sub
End Module
