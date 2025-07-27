Public Class LicenseActivation
    Private Sub AnimScale_Tick(sender As Object, e As EventArgs) Handles AnimScale.Tick
        Me.Size = New Size(Me.Width, Me.Height + 5)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.CenterToScreen()
        If Me.Size.Height > 350 Then
            AnimScale.Stop()
        End If



    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Process.Start("https://ventecheat.shop/")
    End Sub
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const CS_DROPSHADOW As Integer = &H20000
            Const CS_DROPSHADOW_COLOR As Integer = &H80 ' Kolor cienia (0x80 = COLORREF dla royalblue)

            Dim cp As CreateParams = MyBase.CreateParams
            cp.ClassStyle = cp.ClassStyle Or CS_DROPSHADOW
            cp.ExStyle = cp.ExStyle Or CS_DROPSHADOW_COLOR

            Return cp
        End Get
    End Property

    Private Sub LicenseActivation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Download_AllLicenses.StartDwonloading()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles ActivateBtn.Click
        GetLicense()
        CheckIfThisLicenseExists()



    End Sub
End Class