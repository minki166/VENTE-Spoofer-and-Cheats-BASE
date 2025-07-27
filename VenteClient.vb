Imports System.ComponentModel
Imports System.Net
Imports System.Threading
Imports vente.VenteData
Public Class Form1
    Public isLogin As String = "L"

    Async Sub Installize_Vente()

        '# Get IP in await.
        Await DownloadIP()

        With LoginPage
            .TopLevel = False
            .BringToFront()
            .Dock = DockStyle.Fill
            '.StartPosition = FormStartPosition.CenterScreen
            '.Location = New Point(0, 0)
            MotherPages.Controls.Add(LoginPage.Panel1)
            .Show()
        End With

    End Sub

    Private Async Function DownloadIP() As Task(Of String)
        Dim WebClient_1 As New System.Net.WebClient()
        Dim result As String = Await WebClient_1.DownloadStringTaskAsync("https://api.ipify.org")
        stored_ip = result.ToString
        Return result
    End Function






#Region "Animacje"


    '# Default Size: 327; 225
    '# Zmniejszanie: 
    ' Group.Size = New Size(Group.Width, Group.Height - 4)
    '# Powiększanie:
    ' Group.Size = New Size(Group.Width, Group.Height + 4)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Animacja_Powiększania.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Animacja_Zmniejszania.Start()
    End Sub


    Private Sub SprawdzanieAnimacji_Tick(sender As Object, e As EventArgs) Handles SprawdzanieAnimacji.Tick
        If isLogin = "R" Then
            With RegisterPage
                .TopLevel = False
                .BringToFront()
                .Dock = DockStyle.Fill
                .StartPosition = FormStartPosition.CenterScreen
                .Location = New Point(0, 0)
                MotherPages.Controls.Add(RegisterPage.Panel1)
                .Show()
            End With
        Else
            With LoginPage
                .TopLevel = False
                .BringToFront()
                .Dock = DockStyle.Fill
                .StartPosition = FormStartPosition.CenterScreen
                .Location = New Point(0, 0)
                MotherPages.Controls.Add(LoginPage.Panel1)
                .Show()
            End With
        End If


        Animacja_Powiększania.Start()
        SprawdzanieAnimacji.Stop()
    End Sub

    Private Sub Animacja_Powiększania_Tick(sender As Object, e As EventArgs) Handles Animacja_Powiększania.Tick
        If Group.Size.Height > 225 Then
            Animacja_Zmniejszania.Stop()
            Animacja_Powiększania.Stop()
        Else
            Group.Size = New Size(Group.Width, Group.Height + 5)
        End If
    End Sub

    Private Sub Animacja_Zmniejszania_Tick(sender As Object, e As EventArgs) Handles Animacja_Zmniejszania.Tick
        If Group.Size.Height < 10 Then
            Animacja_Powiększania.Stop()
            Animacja_Zmniejszania.Stop()
        Else
            Group.Size = New Size(Group.Width, Group.Height - 8)
        End If
    End Sub




#End Region


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Installize_Vente()
        'Group.Size = New Size(327, 10)
        Button1.PerformClick()

        With LoginPage
            .TopLevel = False
            .BringToFront()
            .Dock = DockStyle.Fill
            .StartPosition = FormStartPosition.CenterScreen
            .Location = New Point(0, 0)
            MotherPages.Controls.Add(LoginPage.Panel1)
            .Show()
        End With




        '  AntiCrack.StartMe()

    End Sub

    Private Sub Mother_Paint(sender As Object, e As PaintEventArgs) Handles Mother.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'DiscordSend.Send()
        ' DiscordRegLog.Send()

    End Sub

    Private Sub AppRestart_Tick(sender As Object, e As EventArgs) Handles AppRestart.Tick
        Application.Restart()

    End Sub

    Private Async Sub AntiCrackTimer_Tick(sender As Object, e As EventArgs) Handles AntiCrackTimer.Tick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        FortniteIMGUI.Show()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'AntiCrack.backgroundWorker.CancelAsync()

    End Sub
End Class
