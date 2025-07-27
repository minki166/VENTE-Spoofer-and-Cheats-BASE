Public Class VisualsTab
    Private Sub t1_Scroll(sender As Object, e As ScrollEventArgs) Handles t1.Scroll
        L1.Text = t1.Value & "m"
    End Sub

    Private Sub VisualsTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        L1.Text = t1.Value & "m"

    End Sub

    Private Sub Guna2ShadowPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2ShadowPanel1.Paint

    End Sub

    Private Sub Guna2ShadowPanel1_Click(sender As Object, e As EventArgs) Handles Guna2ShadowPanel1.Click
        ColorDialog1.ShowDialog()
        Guna2ShadowPanel1.FillColor = ColorDialog1.Color
    End Sub
End Class