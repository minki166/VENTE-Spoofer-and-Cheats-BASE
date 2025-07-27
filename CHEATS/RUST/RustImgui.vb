Public Class RustImgui

    Public activKey As String
    Private WithEvents keyboardHook As New KeyboardHook()
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



    Private Sub keyboardHook_KeyDown(sender As Object, e As KeyEventArgs) Handles keyboardHook.KeyDown
        ' Dodawanie naciśniętego klawisza do TextBox
        AppendTextToTextBox(e.KeyCode.ToString())
    End Sub

    ' Metoda do dodawania tekstu do TextBox
    Private Sub AppendTextToTextBox(text As String)
        If InvokeRequired Then
            Invoke(Sub() AppendTextToTextBox(text))
        Else



            If InvokeRequired Then
                Invoke(Sub() AppendTextToTextBox(text))
            Else





                If text = "Insert" Then
                    ec.AppendText(text)
                    If ec.Text = "Insert" Then

                        Shadow.SetShadowForm(Me)

                        Me.Opacity = 100
                        Me.TopMost = True

                    End If

                    If ec.Text.Length > 11 Then
                        ' Me.Hide()
                        Me.Opacity = 0
                        ec.Text = ""
                        Shadow.Clear()
                    End If

                End If












            End If

        End If
    End Sub


    Private Sub RustImgui_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            uSER.Text = VenteData.stored_username.ToString
            ec.Text = "insert"

        Catch ex As Exception
            uSER.Text = "n/a"
        End Try


        Try
            keyboardHook.Start()
        Catch ex As Exception

        End Try

        With rust_Aimbot
            .TopLevel = False
            .Dock = DockStyle.Fill
            Mother.Controls.Add(rust_Aimbot)
            .Show()
            .BringToFront()
        End With
        AimTabBtn.Checked = True

    End Sub

    Private Sub AimTabBtn_Click(sender As Object, e As EventArgs) Handles AimTabBtn.Click
        If AimTabBtn.Checked = True Then
            With rust_Aimbot
                .TopLevel = False
                .Dock = DockStyle.Fill
                Mother.Controls.Add(rust_Aimbot)
                .Show()
                .BringToFront()
            End With
        End If
    End Sub

    Private Sub TopBar_Paint(sender As Object, e As PaintEventArgs) Handles TopBar.Paint

    End Sub

    Private Sub VisaualsBtn_Click(sender As Object, e As EventArgs) Handles VisaualsBtn.Click
        If VisaualsBtn.Checked = True Then
            With rust_esp
                .TopLevel = False
                .Dock = DockStyle.Fill
                Mother.Controls.Add(rust_esp)
                .Show()
                .BringToFront()
            End With
        End If
    End Sub

    Private Sub Miscbtn_Click(sender As Object, e As EventArgs) Handles Miscbtn.Click
        If Miscbtn.Checked = True Then
            With rust_misc
                .TopLevel = False
                .Dock = DockStyle.Fill
                Mother.Controls.Add(rust_misc)
                .Show()
                .BringToFront()
            End With
        End If
    End Sub
End Class