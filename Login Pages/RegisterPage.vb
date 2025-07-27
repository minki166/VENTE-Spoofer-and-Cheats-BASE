
Public Class RegisterPage
    Private Sub DirToReg_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DirToReg.LinkClicked
        '# Zmiana formy
        Form1.Animacja_Zmniejszania.Start()
        Form1.MotherPages.Controls.Clear()
        Form1.isLogin = "L"
        Form1.SprawdzanieAnimacji.Start()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        CreateAccount.StartCreating_Account()
    End Sub
End Class