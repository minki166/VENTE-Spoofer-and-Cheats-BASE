Public Class CheatsTab
    Private Sub VisaualsBtn_Click(sender As Object, e As EventArgs) Handles FortniteBtn.Click
        If FortniteBtn.Checked = True Then
            Cheat.Text = "Fortnie | 1.3.1"
            Type.Text = "Internal"
            Release.Text = "1.3.1"
            LUpdate.Text = "02.05.2024"
            StatusT.Text = "Undetected, safe to use."

            If Unlocklicenses.Contains("F") Then
                access.ForeColor = Color.Lime
                access.Text = "Yes, ready to use."
            Else
                access.ForeColor = Color.Crimson
                access.Text = "No, buy license! (click)"

            End If

            If access.Text.Contains("Yes") Then
                LoginBtn.Enabled = True
            Else
                LoginBtn.Enabled = False

            End If

        End If
    End Sub

    Public Unlocklicenses As String = VenteData.stored_license

    Private Sub CheatsTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginBtn.Enabled = False

    End Sub

    Private Sub Guna2GroupBox3_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox3.Click

    End Sub

    Private Sub access_Click(sender As Object, e As EventArgs) Handles access.Click
        If access.Text = "No, buy license! (click)" Then
            Process.Start("https://ventecheat.shop/")
        End If
    End Sub

    Private Sub FortniteBetaBtn_Click(sender As Object, e As EventArgs) Handles FortniteBetaBtn.Click
        If FortniteBetaBtn.Checked = True Then
            Cheat.Text = "Fortnite cheat BETA | 1.3.3"
            Type.Text = "Internal"
            Release.Text = "1.3.3"
            LUpdate.Text = "Today"
            StatusT.Text = "Use at own risk!"

            If Unlocklicenses.Contains("B") Then
                access.ForeColor = Color.Lime
                access.Text = "Yes, ready to use."
            Else
                access.ForeColor = Color.Crimson
                access.Text = "No, this is only for beta members!"

            End If
            If access.Text.Contains("Yes") Then
                LoginBtn.Enabled = True
            Else
                LoginBtn.Enabled = True

            End If
        Else

        End If
    End Sub

    Private Sub RustBtn_Click(sender As Object, e As EventArgs) Handles RustBtn.Click
        If RustBtn.Checked = True Then
            Cheat.Text = "Rust | 2.1.1"
            Type.Text = "Internal"
            Release.Text = "2.1.1"
            LUpdate.Text = "01.05.2024"
            StatusT.Text = "Undetected, safe to use."

            If Unlocklicenses.Contains("B") Then
                access.ForeColor = Color.Lime
                access.Text = "Yes, ready to use."
            Else
                access.ForeColor = Color.RoyalBlue
                access.Text = "No, buy license! (click)"

            End If
            If access.Text.Contains("Yes") Then
                LoginBtn.Enabled = True
            Else
                LoginBtn.Enabled = True

            End If
        Else

        End If
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If FortniteBtn.Checked = True Then
            IfCheatsRunning("Fortnie | 1.3.1", "FortniteClient-Win64-Shipping.exe")
        End If


        If FortniteBetaBtn.Checked = True Then
            IfCheatsRunning("Fortnite cheat BETA | 1.3.3", "notepad")

        End If
        If RustBtn.Checked = True Then
            IfCheatsRunning("Rust| 2.1.1", "notepad")

        End If


    End Sub

    Private Sub timerLeft_Tick(sender As Object, e As EventArgs) Handles timerLeft.Tick

        Bar.Increment(-1)
    End Sub

    Private Sub Guna2GroupBox4_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox4.Click

    End Sub

    Private Sub Bar_ValueChanged(sender As Object, e As EventArgs) Handles Bar.ValueChanged
        TimeLeft.Text = "" & timerLeft.Interval
        If Bar.Value > 50 Then
            TimeLeft.Text = "Run game now, you got 2 mninutes to do it. "

        Else
            TimeLeft.Text = "Run game now, you got 1 mninute to do it. "
        End If
        If Bar.Value = 0 Then

            timerLeft.Stop()



            FortniteIMGUI.Show()
        End If
    End Sub
End Class