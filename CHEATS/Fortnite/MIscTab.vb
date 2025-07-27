Public Class MIscTab
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        FortniteIMGUI.Close()
        Form1.Close()
    End Sub

    Private Sub op_Scroll(sender As Object, e As ScrollEventArgs) Handles op.Scroll
        FortniteIMGUI.Opacity = op.Value
        Me.Opacity = op.Value
        L1.Text = op.Value & "%"
    End Sub

    Private Sub MIscTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        L1.Text = op.Value & "%"
        FortniteIMGUI.Opacity = op.Value
        Me.Opacity = op.Value

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Process.Start("https://ventecheat.shop/
")
    End Sub
End Class