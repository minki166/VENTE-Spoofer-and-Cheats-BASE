Imports vente.VenteData
Public Class VenteMain

    Dim ChangelogFinal

    Private Sub AnimColorEngine_Tick(sender As Object, e As EventArgs) Handles AnimColorEngine.Tick
        Label1.ForeColor = ColorAnim.Value
    End Sub


    Public Async Sub DownloadChangelog()
        Dll_Changelog()
        Dll_News()
    End Sub


    Private Async Sub VenteMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        '# Load Form settings
        UsernameLbl.Text = VenteData.stored_username
        MotherAnim.Show(LeftBar)
        MotherAnim.Show(MotherBox)
        HomeBtn.PerformClick()
        '# Send DC .Log File
        DownloadChangelog()
        DiscordSend.Send()
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        If HomeBtn.Checked = True Then
            With HomeTab
                .TopLevel = False
                .Dock = DockStyle.Fill
                MotherPanel.Controls.Add(HomeTab)
                .Show()
                .BringToFront()
            End With
        Else
            With HomeTab
                .Hide()
            End With

            With SpooferPage
                .Hide()
            End With
            With CheatsTab
                .Hide()
            End With
        End If
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Form1.Close()
    End Sub

    Private Sub Mother_Paint(sender As Object, e As PaintEventArgs) Handles Mother.Paint

    End Sub

    Private Sub LicenseRefresher_Tick(sender As Object, e As EventArgs) Handles LicenseRefresher.Tick
        Try
            Download_AllLicenses.StartDwonloading()
            Download_AccountLicense.StartDownload()
            HomeTab.DownloadUserDetails()
            HomeTab.GetLicensesSyntax()
        Catch ex As Exception

        End Try
    End Sub



    Private Sub SpooferBtn_Click(sender As Object, e As EventArgs) Handles SpooferBtn.Click
        If SpooferBtn.Checked = True Then
            With SpooferPage
                .TopLevel = False
                .Dock = DockStyle.Fill
                MotherPanel.Controls.Add(SpooferPage)
                .Show()
                .BringToFront()
                HomeTab.Hide()
            End With
        Else
            With SpooferPage
                .Hide()
            End With
            With CheatsTab
                .Hide()
            End With
        End If
    End Sub

    Private Sub CheatsBtn_Click(sender As Object, e As EventArgs) Handles CheatsBtn.Click
        If CheatsBtn.Checked = True Then
            With CheatsTab
                .TopLevel = False
                .Dock = DockStyle.Fill
                MotherPanel.Controls.Add(CheatsTab)
                .Show()
                .BringToFront()
            End With
        Else
            With HomeTab
                .Hide()
            End With
            With SpooferPage
                .Hide()
            End With
        End If
    End Sub
End Class