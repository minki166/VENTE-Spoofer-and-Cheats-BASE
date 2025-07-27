Public Class AimbotTab
    Private Sub t1_Scroll(sender As Object, e As ScrollEventArgs) Handles t1.Scroll
        L1.Text = t1.Value & "%"
    End Sub

    Private Sub t2_Scroll(sender As Object, e As ScrollEventArgs) Handles t2.Scroll
        l2.Text = t2.Value & "%"
    End Sub

    Private Sub t3_Scroll(sender As Object, e As ScrollEventArgs) Handles t3.Scroll
        l3.Text = t3.Value & "%"
    End Sub

    Private Sub AimbotTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        L1.Text = t1.Value & "%"
        l2.Text = t2.Value & "%"
        l3.Text = t3.Value & "%"
        ht2.Text = h2.Value & "%"
        ht.Text = h1.Value & "%"
    End Sub

    Private Sub h1_Scroll(sender As Object, e As ScrollEventArgs) Handles h1.Scroll
        ht.Text = h1.Value & "%"

    End Sub

    Private Sub h2_Scroll(sender As Object, e As ScrollEventArgs) Handles h2.Scroll
        ht2.Text = h2.Value & "%"
    End Sub
End Class