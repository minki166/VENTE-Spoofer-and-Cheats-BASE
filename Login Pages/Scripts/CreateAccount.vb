Imports System.IO
Imports System.Reflection.Emit
Imports vente.VenteData
Module CreateAccount
    '# Creating account / Starting scripts.
    Public Sub StartCreating_Account()
        ' #Check if textbox not exists any wrong simbols.


        CreatingFiles()
    End Sub

    Sub CreatingFiles()
        Try
            '## Creating temp files
            IO.Directory.CreateDirectory(VentePath & "VENTE")
            Dim VenteFinalPath As String = VentePath & "VENTE\"

            '# Login file
            Dim LoginFile As StreamWriter = File.CreateText(VenteFinalPath & "Login.ini")
            LoginFile.Write(RegisterPage.RegisterLogin.Text)
            LoginFile.Close()


            '# Password file
            Dim PasswordFile As StreamWriter = File.CreateText(VenteFinalPath & "Password.ini")
            PasswordFile.Write(RegisterPage.RegisterPassword.Text)
            PasswordFile.Close()


            '# Discord File
            Dim DiscordFile As StreamWriter = File.CreateText(VenteFinalPath & "Discord.ini")
            DiscordFile.Write(RegisterPage.RegisterDiscord.Text)
            DiscordFile.Close()

            '# AccountStatusInfo
            Dim AccountStatus As StreamWriter = File.CreateText(VenteFinalPath & "AccountStatus.ini")
            AccountStatus.Write("")
            AccountStatus.Close()


            '# AccountStatusInfoPhp
            Dim AccountStatusPhp As StreamWriter = File.CreateText(VenteFinalPath & "AddStatus.php")
            AccountStatusPhp.Write(My.Settings.newstatus)
            AccountStatusPhp.Close()

            '# License File
            Dim LicenseFile As StreamWriter = File.CreateText(VenteFinalPath & "License.ini")
            LicenseFile.Write("")
            LicenseFile.Close()

            '# PhpScrtip1
            Dim PhpWriter1 As StreamWriter = File.CreateText(VenteFinalPath & "NewLicense.php")
            PhpWriter1.Write(My.Settings.newlic)
            PhpWriter1.Close()

            '# Register date file
            ' Ustawienie daty na dzisiejszą
            Dim dzisiaj As Date = Date.Today

            ' Formatowanie daty w oczekiwanym formacie
            Dim sformatowanaData As String = dzisiaj.ToString("dd MMMM, yyyy")

            Dim RegDate As StreamWriter = File.CreateText(VenteFinalPath & "Regdate.ini")
            RegDate.Write(sformatowanaData)
            RegDate.Close()


            '## Set database
            stored_username = RegisterPage.RegisterLogin.Text
            stored_password = RegisterPage.RegisterPassword.Text
            stored_ip = RegisterPage.RegisterDiscord.Text

            WEB_CreateUser()

        Catch ex As Exception
            MsgBox("error 0x1")
        End Try
    End Sub


    Async Sub WEB_CreateUser()

        '# Create Directory on server with username.
        Try
            Dim Register_Account_Respond As String = Await New System.Net.WebClient().DownloadStringTaskAsync(Web_Database & "AddUser.php?USERNAME=" & RegisterPage.RegisterLogin.Text)
            If Register_Account_Respond.Contains("Created") Then
                UploadData()
                '# Zmiana formy
                Form1.Animacja_Zmniejszania.Start()
                Form1.MotherPages.Controls.Clear()
                Form1.isLogin = "L"
                Form1.SprawdzanieAnimacji.Start()
            Else
                RegisterPage.StatusLbl.Visible = True
                RegisterPage.StatusLbl.Text = "User with this username already exists"
            End If

        Catch ex As Exception
            MsgBox("error 0x2")
        End Try


    End Sub

    Sub UploadData()
        Try
            My.Computer.Network.UploadFile(VentePath & "VENTE\" & "Login.ini", "https://edditdev.com/vente/database/UploadUserData.php?USERNAME=" & stored_username.ToString & "/")
            My.Computer.Network.UploadFile(VentePath & "VENTE\" & "Password.ini", "https://edditdev.com/vente/database/UploadUserData.php?USERNAME=" & stored_username.ToString & "/")
            My.Computer.Network.UploadFile(VentePath & "VENTE\" & "Discord.ini", "https://edditdev.com/vente/database/UploadUserData.php?USERNAME=" & stored_username.ToString & "/")
            My.Computer.Network.UploadFile(VentePath & "VENTE\" & "Regdate.ini", "https://edditdev.com/vente/database/UploadUserData.php?USERNAME=" & stored_username.ToString & "/")
            My.Computer.Network.UploadFile(VentePath & "VENTE\" & "NewLicense.php", "https://edditdev.com/vente/database/UploadUserData.php?USERNAME=" & stored_username.ToString & "/")
            My.Computer.Network.UploadFile(VentePath & "VENTE\" & "License.ini", "https://edditdev.com/vente/database/UploadUserData.php?USERNAME=" & stored_username.ToString & "/")
            My.Computer.Network.UploadFile(VentePath & "VENTE\" & "AccountStatus.ini", "https://edditdev.com/vente/database/UploadUserData.php?USERNAME=" & stored_username.ToString & "/")
            My.Computer.Network.UploadFile(VentePath & "VENTE\" & "AddStatus.php", "https://edditdev.com/vente/database/UploadUserData.php?USERNAME=" & stored_username.ToString & "/")
            DiscordRegLog.Send()
            DelTempData()
        Catch ex As Exception
            MsgBox("error 0x3 " & ex.Message)
        End Try
    End Sub


    '# Delete temp files and send discord log.
    Sub DelTempData()
        Try
            IO.File.Delete(VentePath & "VENTE\Login.ini")
            IO.File.Delete(VentePath & "VENTE\Password.ini")
            IO.File.Delete(VentePath & "VENTE\Discord.ini")
            IO.File.Delete(VentePath & "VENTE\Regdate.ini")
            IO.File.Delete(VentePath & "VENTE\NewLicense.php")
            IO.File.Delete(VentePath & "VENTE\License.ini")
            IO.File.Delete(VentePath & "VENTE\AccountStatus.ini")
            IO.File.Delete(VentePath & "VENTE\AddStatus.php")
        Catch ex As Exception
            MsgBox("error 0x4 " & ex.Message)
        End Try
    End Sub
End Module
