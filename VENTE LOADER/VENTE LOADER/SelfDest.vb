Imports System.Diagnostics
Module SelfDest


    Public Sub SelfDestruct()
        Try
            Dim batchContent As String = "@echo off" & vbCrLf &
                                 "cd /d " & Application.StartupPath & vbCrLf &
                                 "timeout /t 5 /nobreak > nul" & vbCrLf &
                                 "del /f /q ""VENTE_LOADER.exe""" & vbCrLf &
                                 "pause"
            Dim batchFilePath As String = Application.StartupPath & "\SD.bat"
            IO.File.WriteAllText(batchFilePath, batchContent)
            Dim psi As New ProcessStartInfo()
            psi.FileName = batchFilePath
            psi.WindowStyle = ProcessWindowStyle.Hidden
            psi.UseShellExecute = True
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show($"Error {ex.Message}")
        End Try
    End Sub



End Module
