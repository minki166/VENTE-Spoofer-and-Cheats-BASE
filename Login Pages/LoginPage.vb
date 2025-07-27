Imports vente.VenteData
Imports System.Threading
Imports System.IO

Public Class LoginPage

    Private Sub DirToReg_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DirToReg.LinkClicked
        '# Zmiana formy

        Form1.Animacja_Zmniejszania.Start()
        Form1.MotherPages.Controls.Clear()
        Form1.isLogin = "R"
        Form1.SprawdzanieAnimacji.Start()

    End Sub

    Private Async Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        '# Check if user exists in database


        VenteMain.Show()



#Region "Check if user exists"

        Try
            Dim LoginAttept As String = Await New System.Net.WebClient().DownloadStringTaskAsync(Web_Database & LoginTextBox.Text & "/Login.ini")
            If LoginAttept.Contains(LoginTextBox.Text.Trim) Then
                '# If exists - check password match
                Dim PasswordAttept As String = Await New System.Net.WebClient().DownloadStringTaskAsync(Web_Database & LoginTextBox.Text & "/Password.ini")
                If PasswordAttept = PasswordTextbox.Text.Trim Then
                    StatusLbl.Text = ""

                    '# Zapis login details
                    stored_username = LoginTextBox.Text.ToString
                    stored_password = PasswordTextbox.Text.ToString
                    'remember me save
                    If RmBtn.Checked = True Then

                        My.Settings.rmUser = LoginTextBox.Text.ToString
                        My.Settings.rmPass = PasswordTextbox.Text.ToString
                        My.Settings.Save()
                    End If


                    '# Licensing
                    Download_AllLicenses.StartDwonloading()
                    Download_AccountLicense.StartDownload()

                    '# Check if user is not banned.
                    Dim GetAccountStatus As String = Await New System.Net.WebClient().DownloadStringTaskAsync(Web_Database & stored_username.ToString & "/AccountStatus.ini")
                    If GetAccountStatus.Contains("BAN") Then
                        Me.Opacity = 0
                        GetAccountStatus = GetAccountStatus.Replace("BAN", "")
                        MsgBox("ACCOUNT BANNED!" & vbNewLine & "You can't use vente client." & vbNewLine & vbNewLine & "Reason: " & GetAccountStatus)
                        Form1.Close()
                    End If


                    '# Download user discord
                    Dim GetDiscordName As String = Await New System.Net.WebClient().DownloadStringTaskAsync(Web_Database & LoginTextBox.Text & "/Discord.ini")
                    stored_discord = GetDiscordName.ToString



                    Me.Hide()
                    Form1.Hide()
                    VenteMain.Show()



                Else
                    StatusLbl.Text = "Wrong password!"
                End If
            End If
        Catch ex As Exception
            StatusLbl.Text = "User is not registred"
        End Try


#End Region


    End Sub

    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load







        RmBtn.Checked = My.Settings.RM
        If My.Settings.RM = True Then
            LoginTextBox.Text = My.Settings.rmUser
            PasswordTextbox.Text = My.Settings.rmPass
        End If
        getip()
    End Sub

    Public Async Sub getip()
        Dim IP As String = Await New System.Net.WebClient().DownloadStringTaskAsync("https://api.ipify.org")
        stored_ip = IP.ToString
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RmBtn_CheckedChanged(sender As Object, e As EventArgs) Handles RmBtn.CheckedChanged

        My.Settings.RM = RmBtn.Checked
        My.Settings.Save()

    End Sub
End Class