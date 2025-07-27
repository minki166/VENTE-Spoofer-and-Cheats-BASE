Imports System.IO
Imports System.Reflection.Emit
Imports System.Security.Principal

Public Class SpooferPage


    Private Shared random As New Random()
    Public Shared Function Gen(ByVal length As Integer) As String
        Dim chars As String = "123456789ABCXDABMJZ".ToUpper
        Return New String(Enumerable.Repeat(chars, length).Select(Function(s) s(random.Next(s.Length))).ToArray())
    End Function

    '# Create listbox for load/save Sessions.
    Public SessionList As New ListBox

    Public logsCounter As String
    Private Sub SpooferPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If HomeTab.LicenseText.Text.Contains("HWID SPOOFER") Then
            spoofingBtn.Enabled = True
            spoofingBtn.Text = "Spoofing"
        Else
            spoofingBtn.Enabled = False
            spoofingBtn.Text = "Buy license"
        End If
    End Sub

    Private Sub Box1_CheckedChanged(sender As Object, e As EventArgs) Handles Box1.CheckedChanged
        If Box1.Checked = True Then
            SessionList.Items.Add("disk id")
        Else
            SessionList.Items.Remove("disk id")
        End If
    End Sub

    Private Sub Box2_CheckedChanged(sender As Object, e As EventArgs) Handles Box2.CheckedChanged
        If Box2.Checked = True Then
            SessionList.Items.Add("disk guild")
        Else
            SessionList.Items.Remove("disk guild")
        End If
    End Sub

    Private Sub Box3_CheckedChanged(sender As Object, e As EventArgs) Handles Box3.CheckedChanged
        If Box3.Checked = True Then
            SessionList.Items.Add("disk info")
        Else
            SessionList.Items.Remove("disk info")
        End If
    End Sub

    Private Sub Box4_CheckedChanged(sender As Object, e As EventArgs) Handles Box4.CheckedChanged
        If Box4.Checked = True Then
            SessionList.Items.Add("disk emulate")
        Else
            SessionList.Items.Remove("disk emulate")
        End If
    End Sub

    Private Sub Box5_CheckedChanged(sender As Object, e As EventArgs) Handles Box5.CheckedChanged
        If Box5.Checked = True Then
            SessionList.Items.Add("disk anti-detection")
        Else
            SessionList.Items.Remove("disk anti-detection")
        End If
    End Sub

    Private Sub Box6_CheckedChanged(sender As Object, e As EventArgs) Handles Box6.CheckedChanged
        If Box6.Checked = True Then
            SessionList.Items.Add("system signature")
        Else
            SessionList.Items.Remove("system signature")
        End If
    End Sub

    Private Sub Box7_CheckedChanged(sender As Object, e As EventArgs) Handles Box7.CheckedChanged
        If Box7.Checked = True Then
            SessionList.Items.Add("hardware identification")
        Else
            SessionList.Items.Remove("hardware identification")
        End If
    End Sub

    Private Sub Box8_CheckedChanged(sender As Object, e As EventArgs) Handles Box8.CheckedChanged
        If Box8.Checked = True Then
            SessionList.Items.Add("drivers")
        Else
            SessionList.Items.Remove("drivers")
        End If
    End Sub

    Private Sub Box9_CheckedChanged(sender As Object, e As EventArgs) Handles Box9.CheckedChanged
        If Box9.Checked = True Then
            SessionList.Items.Add("firmware")
        Else
            SessionList.Items.Remove("fimrware")
        End If
    End Sub

    Private Sub Box10_CheckedChanged(sender As Object, e As EventArgs) Handles Box10.CheckedChanged
        If Box10.Checked = True Then
            SessionList.Items.Add("human interface device")
        Else
            SessionList.Items.Remove("human interface device")
        End If
    End Sub

    Private Sub Box11_CheckedChanged(sender As Object, e As EventArgs) Handles Box11.CheckedChanged
        If Box11.Checked = True Then
            SessionList.Items.Add("sensor data")
        Else
            SessionList.Items.Remove("sensor data")
        End If
    End Sub

    Private Sub Box12_CheckedChanged(sender As Object, e As EventArgs) Handles Box12.CheckedChanged
        If Box12.Checked = True Then
            SessionList.Items.Add("motherboard identification")
        Else
            SessionList.Items.Remove("motherboard identification")
        End If
    End Sub

    Private Sub Box13_CheckedChanged(sender As Object, e As EventArgs) Handles Box13.CheckedChanged
        If Box13.Checked = True Then
            SessionList.Items.Add("mac adress")
        Else
            SessionList.Items.Remove("mac adress")
        End If
    End Sub

    Private Sub Box14_CheckedChanged(sender As Object, e As EventArgs) Handles Box14.CheckedChanged
        If Box14.Checked = True Then
            SessionList.Items.Add("cpu identification")
        Else
            SessionList.Items.Remove("cpu identification")
        End If
    End Sub

    Private Sub Box15_CheckedChanged(sender As Object, e As EventArgs) Handles Box15.CheckedChanged
        If Box15.Checked = True Then
            SessionList.Items.Add("gpu")
        Else
            SessionList.Items.Remove("gpu")
        End If
    End Sub

    Private Sub Box16_CheckedChanged(sender As Object, e As EventArgs) Handles Box16.CheckedChanged
        If Box16.Checked = True Then
            SessionList.Items.Add("smart data")
        Else
            SessionList.Items.Remove("smart data")
        End If
    End Sub

    Private Sub Box17_CheckedChanged(sender As Object, e As EventArgs) Handles Box17.CheckedChanged
        If Box17.Checked = True Then
            SessionList.Items.Add("network adatper")
        Else
            SessionList.Items.Remove("network adapter")
        End If
    End Sub

    Private Sub Box18_CheckedChanged(sender As Object, e As EventArgs) Handles Box18.CheckedChanged
        If Box18.Checked = True Then
            SessionList.Items.Add("user account")
        Else
            SessionList.Items.Remove("user account")
        End If
    End Sub

    Private Sub Box19_CheckedChanged(sender As Object, e As EventArgs) Handles Box19.CheckedChanged
        If Box19.Checked = True Then
            SessionList.Items.Add("system uptime")
        Else
            SessionList.Items.Remove("system uptime")
        End If
    End Sub

    Private Sub Box20_CheckedChanged(sender As Object, e As EventArgs) Handles Box20.CheckedChanged
        If Box20.Checked = True Then
            SessionList.Items.Add("tracers")
        Else
            SessionList.Items.Remove("tracers")
        End If
    End Sub

    Private Sub Box22_CheckedChanged(sender As Object, e As EventArgs) Handles Box22.CheckedChanged
        If Box22.Checked = True Then
            SessionList.Items.Add("ram emu")
        Else
            SessionList.Items.Remove("ram emu")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        '# Zapisywanie itemów session  do lisboxa
        Try
            Dim items As String = ""

            For Each item As Object In SessionList.Items
                items &= item.ToString() & vbCrLf
            Next

            If File.Exists("C:\vente_spoofer_session.cfg") Then
                File.Delete("C:\vente_spoofer_session.cfg")
            Else
                Dim Writer As StreamWriter = File.CreateText("C:\vente_spoofer_session.cfg")
                Writer.Write(items.ToString)
                Writer.Close()
            End If
        Catch ex As Exception
            MsgBox("saving session config error; " & ex.Message & vbNewLine & vbNewLine & "If it's saying that file doesn't exists, save config first.")
        End Try
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            Dim lines As String() = File.ReadAllLines("C:\vente_spoofer_session.cfg")
            For Each line As String In lines
                SessionList.Items.Add(line)
            Next
            If SessionList.Items.Contains("disk id") Then Box1.Checked = True Else Box1.Checked = False
            If SessionList.Items.Contains("disk guild") Then Box2.Checked = True Else Box2.Checked = False
            If SessionList.Items.Contains("disk info") Then Box3.Checked = True Else Box3.Checked = False
            If SessionList.Items.Contains("disk emulate") Then Box4.Checked = True Else Box4.Checked = False
            If SessionList.Items.Contains("disk anti-detection") Then Box5.Checked = True Else Box5.Checked = False
            If SessionList.Items.Contains("system signature") Then Box6.Checked = True Else Box6.Checked = False
            If SessionList.Items.Contains("hardware identification") Then Box7.Checked = True Else Box7.Checked = False
            If SessionList.Items.Contains("drivers") Then Box8.Checked = True Else Box8.Checked = False
            If SessionList.Items.Contains("firmware") Then Box9.Checked = True Else Box9.Checked = False
            If SessionList.Items.Contains("human interface device") Then Box10.Checked = True Else Box10.Checked = False
            If SessionList.Items.Contains("sensor data") Then Box11.Checked = True Else Box11.Checked = False
            If SessionList.Items.Contains("motherboard identification") Then Box12.Checked = True Else Box12.Checked = False
            If SessionList.Items.Contains("mac adress") Then Box13.Checked = True Else Box13.Checked = False
            If SessionList.Items.Contains("cpu identification") Then Box14.Checked = True Else Box14.Checked = False
            If SessionList.Items.Contains("gpu") Then Box15.Checked = True Else Box15.Checked = False
            If SessionList.Items.Contains("smart data") Then Box16.Checked = True Else Box16.Checked = False
            If SessionList.Items.Contains("network adatper") Then Box17.Checked = True Else Box17.Checked = False
            If SessionList.Items.Contains("user account") Then Box18.Checked = True Else Box18.Checked = False
            If SessionList.Items.Contains("system uptime") Then Box19.Checked = True Else Box19.Checked = False
            If SessionList.Items.Contains("tracers") Then Box20.Checked = True Else Box20.Checked = False
            If SessionList.Items.Contains("ram emu") Then Box22.Checked = True

        Catch ex As Exception
            MsgBox("loading session config error;  " & ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles spoofingBtn.Click

        Spoofing.Show()
        Me.Hide()



    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click
        SpoofingLogsDC.Send()
    End Sub
End Class