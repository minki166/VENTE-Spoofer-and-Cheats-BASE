Imports System.Runtime.InteropServices

Public Class FortniteIMGUI
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



    Private Sub FortniteIMGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ec.Text = "insert"

        Shadow.SetShadowForm(Me)
        Try
            uSER.Text = VenteData.stored_username.ToUpper
            AimTabBtn.Checked = True

            If AimTabBtn.Checked = True Then
                With AimbotTab
                    .TopLevel = False
                    .Dock = DockStyle.Fill
                    Mother.Controls.Add(AimbotTab)
                    .Show()
                    .BringToFront()
                End With
            Else

                With HomeTab
                    .Hide()
                End With

            End If


            VenteMain.Hide()
            Form1.Hide()
        Catch ex As Exception

        End Try


        Try
            keyboardHook.Start()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub AimTabBtn_Click(sender As Object, e As EventArgs) Handles AimTabBtn.Click
        If AimTabBtn.Checked = True Then
            With AimbotTab
                .TopLevel = False
                .Dock = DockStyle.Fill
                Mother.Controls.Add(AimbotTab)
                .Show()
                .BringToFront()
            End With
        Else

            With HomeTab
                .Hide()
            End With

        End If
    End Sub

    Private Sub TopBar_Paint(sender As Object, e As PaintEventArgs) Handles TopBar.Paint

    End Sub

    Private Sub VisaualsBtn_Click(sender As Object, e As EventArgs) Handles VisaualsBtn.Click
        If VisaualsBtn.Checked = True Then
            With VisualsTab
                .TopLevel = False
                .Dock = DockStyle.Fill
                Mother.Controls.Add(VisualsTab)
                .Show()
                AimbotTab.Hide()
                .BringToFront()
            End With
        Else

            With HomeTab
                .Hide()
            End With

        End If
    End Sub

    Private Sub Miscbtn_Click(sender As Object, e As EventArgs) Handles Miscbtn.Click
        If Miscbtn.Checked = True Then
            With MIscTab
                .TopLevel = False
                .Dock = DockStyle.Fill
                Mother.Controls.Add(MIscTab)
                .Show()
                VisualsTab.Hide()
                AimbotTab.Hide()
                .BringToFront()
            End With
        Else

            With HomeTab
                .Hide()
            End With

        End If
    End Sub




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

    Private Sub mcheck_Tick(sender As Object, e As EventArgs) Handles mcheck.Tick



    End Sub
    Private form2Visible As Boolean = False

    Private Sub ec_TextChanged(sender As Object, e As EventArgs) Handles ec.TextChanged



    End Sub
End Class

' Klasa do przechwytywania zdarzeń klawiatury
Public Class KeyboardHook

    Private Const WM_KEYDOWN As Integer = &H100
    Private Const WH_KEYBOARD_LL As Integer = 13

    ' Deklaracje funkcji związanych z hookiem klawiatury
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SetWindowsHookEx(ByVal idHook As Integer, ByVal lpfn As LowLevelKeyboardProc, ByVal hMod As IntPtr, ByVal dwThreadId As UInteger) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function UnhookWindowsHookEx(ByVal hhk As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function CallNextHookEx(ByVal hhk As IntPtr, ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function GetModuleHandle(ByVal lpModuleName As String) As IntPtr
    End Function

    ' Delegat do procedury obsługi niskopoziomowego hooka klawiatury
    Private Delegate Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    ' Zdarzenie klawiatury
    Public Event KeyDown As KeyEventHandler

    ' Uchwyt hooka klawiatury
    Private hookId As IntPtr = IntPtr.Zero
    ' Delegat procedury obsługi hooka klawiatury
    Private keyboardProc As LowLevelKeyboardProc

    ' Konstruktor klasy
    Public Sub New()
        keyboardProc = New LowLevelKeyboardProc(AddressOf HookCallback)
    End Sub

    ' Metoda do rozpoczęcia przechwytywania zdarzeń klawiatury
    Public Sub Start()
        hookId = SetHook(keyboardProc)
    End Sub

    ' Metoda do zatrzymania przechwytywania zdarzeń klawiatury
    Public Sub Stopz()
        UnhookWindowsHookEx(hookId)
    End Sub

    ' Procedura obsługi hooka klawiatury
    Private Function HookCallback(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
        If nCode >= 0 AndAlso wParam = New IntPtr(WM_KEYDOWN) Then
            Dim vkCode As Integer = Marshal.ReadInt32(lParam)
            ' Wywołanie zdarzenia KeyDown
            RaiseEvent KeyDown(Me, New KeyEventArgs(CType(vkCode, Keys)))
        End If
        ' Przekazanie zdarzenia do kolejnego hooka w łańcuchu
        Return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam)
    End Function

    ' Ustawienie hooka klawiatury
    Private Function SetHook(ByVal proc As LowLevelKeyboardProc) As IntPtr
        Dim moduleHandle As IntPtr = GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName)
        Return SetWindowsHookEx(WH_KEYBOARD_LL, proc, moduleHandle, 0)
    End Function
End Class
