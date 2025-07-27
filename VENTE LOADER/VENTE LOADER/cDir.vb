Imports System.Environment
Imports System.IO
Module cDir



    Public SharedPath As String =
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)

    Public Async Sub CreatePath()
        '# Create path for our data
        Try
            If Directory.Exists(SharedPath & "\vente") Then
                '# If path is exists, just import Libs.
                ImportingLibs.ImportGuna()
            Else
                '# If path nopt exists, Create one and  import Libs.
                IO.Directory.CreateDirectory(SharedPath & "\vente")
                ImportingLibs.ImportGuna()

            End If
        Catch ex As Exception
            MsgBox("#1 LOADER: No Access for path | RUN AS ADMIN.", MsgBoxStyle.Critical, "VENTE  | Critical ERROR")
        End Try
    End Sub


End Module
