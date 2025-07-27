Imports vente.VenteData
Imports System.Diagnostics
Imports System.Threading

Module LoadCheatScript






    Public Sub IfCheatsRunning(ByVal CheatID As String, ByVal ProcessName As String)
        '# CheatID = GameName / ProcessID
        '# Load for fortnite


        If CheatsTab.Cheat.Text = CheatID Then
            Dim ProcessID As String = ProcessName.Trim
            Dim Checker() As Process = Process.GetProcessesByName(ProcessID)

            If Checker.Length > 0 Then
                '# is active

                CheatsTab.timerLeft.Start()

                CheatsTab.LoginBtn.Visible = False
                CheatsTab.Bar.Visible = True
                CheatsTab.TimeLeft.Visible = True
                CheatsTab.WARN.Visible = False

            Else
                '# Is not active
                CheatsTab.WARN.Visible = True
            End If
        End If

    End Sub




    Public Sub StartLoading()

    End Sub

End Module
