Imports System.IO
Imports System.Security.Principal

Public Class Spoofing

    Public CountItems As Integer
    Public ItemsList As String
    Private currentItemIndex As Integer = 0

    Private Shared random As New Random()
    Public Shared Function Gen(ByVal length As Integer) As String
        Dim chars As String = "123456789ABCXDABMJZ".ToUpper
        Return New String(Enumerable.Repeat(chars, length).Select(Function(s) s(random.Next(s.Length))).ToArray())
    End Function

    Private Shared random1 As New Random()
    Public Shared Function RM(ByVal length1 As Integer) As String
        Dim chars1 As String = "2356".ToUpper
        Return New String(Enumerable.Repeat(chars1, length1).Select(Function(s) s(random1.Next(s.Length))).ToArray())
    End Function
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

    Dim restore As String
    Dim saves As String

    Private Sub Spoofing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SpooferPage.RestorePointBtn.Checked = True Then
            restore = "Created restore-point"
        Else
            restore = "Restore-point not created"
        End If

        If SpooferPage.SaveSessionSuccessBtn.Checked = True Then
            saves = "Saving session after spoofing"
        Else
            saves = "Without session save"
        End If

        Status.Text = "Connecting to VENTE servers..."
        Action.Text = "Starting..."
        SpoofindID.Text = "#" & Gen(10)
        Bypass.Text = "EAC, BEAC."
        If SpooferPage.SaveLogsBtn.Checked = True Then
            Logs.Text = "Saving"

        Else
            Logs.Text = "Not saving (function unchecked)"
        End If
    End Sub

    Private Sub StartAnimColour_Tick(sender As Object, e As EventArgs) Handles StartAnimColour.Tick
        Me.BackColor = AnimColor.Value
    End Sub


    Dim items As String = ""

    Private Sub Starting_Tick(sender As Object, e As EventArgs) Handles Starting.Tick
        '# Count Items in listbox

        Try
            CountItems = SpooferPage.SessionList.Items.Count



            For Each item As Object In SpooferPage.SessionList.Items
                items &= items.ToString() & vbCrLf
            Next

            Second.Start()
            Starting.Stop()
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub


    Private index As Integer = 0
    Private isRed As Boolean = True

    Dim logname As String = "C:\spoofing_logs_" & Gen(4) & ".txt"

    Private Sub Second_Tick(sender As Object, e As EventArgs) Handles Second.Tick
        Try

            If index < SpooferPage.SessionList.Items.Count Then
                SpooferPage.SessionList.SelectedIndex = index

                If isRed Then
                    Action.ForeColor = Color.LightSlateGray
                Else
                    Action.ForeColor = Color.White
                End If

                Action.Text = "[ " & SpooferPage.SessionList.SelectedItem.ToString() & " ]"
                Status.Text = "SPOOFING..."
                Status.ForeColor = Color.White
                Second.Interval = RM(4)
                index += 1
                isRed = Not isRed


            Else
                index = 0
                Second.Stop()


                Status.Text = "Finished, successfull"
                Status.ForeColor = Color.Lime
                Action.Text = "Done."
                bar.Visible = True

                If SpooferPage.SaveLogsBtn.Checked = True Then
                    Dim items As String = ""

                    For Each item As Object In SpooferPage.SessionList.Items
                        items &= item.ToString() & vbCrLf
                    Next

                    Dim Writer As StreamWriter = File.CreateText(logname)
                    Writer.Write("--------------VENTE SPOOFING LOGS---------------" & vbNewLine &
                                 "Restore-point: " & restore & vbNewLine &
                                 "Saving session: " & saves & vbNewLine &
                                 "NEW HWID: [" & Gen(10) & " ]" & vbNewLine &
                                 "OLD HWID: [" & Gen(10) & " ]" & vbNewLine &
                                 "-----------------------*------------------------" &
                                 "" & vbNewLine & vbNewLine &
                                 "|----------------SPOOFED----------------|" &
                                 vbNewLine & items.ToString & vbNewLine &
                                 "|---------------------------------------|" & vbNewLine &
                                 "-- Your VENTE Account got profile HWID Reset. You will not see error about incorrect HWID.")
                    Writer.Close()
                    Logs.Text = "Logs, saved. (" & logname & ")"
                    bar.Visible = False
                    CloseBtn.Visible = True
                    Process.Start(logname)
                    SpoofingLogsDC.Send()

                End If



            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Logs_Click(sender As Object, e As EventArgs) Handles Logs.Click
        Try
            Process.Start(logname)
        Catch ex As Exception

        End Try
    End Sub
End Class