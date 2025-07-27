Imports System.Diagnostics
Imports System.Threading.Tasks
Imports System.ComponentModel
Imports System.Security.Cryptography.X509Certificates

Module AntiCrack

    Public Sub StartMe()
        backgroundWorker.WorkerReportsProgress = False
        backgroundWorker.WorkerSupportsCancellation = True
        AddHandler backgroundWorker.DoWork, AddressOf CheckIfProgramsRunning
        backgroundWorker.RunWorkerAsync()

    End Sub

    Private programsToCheck As String() = {
        "Proxyman", "ĘẍtŗęḿęĎựḿҏęŗ", "HTTP Debugger", "ExtremeDumper-x86", "ProcessHacker", "ExtremeDumper-x64", "CFF Explorer", "ĘẍtŗęḿęĎựḿҏęŗ ṽ4.0.0.1 (ẍ84)", "ĘẍtŗęḿęĎựḿҏęŗ ṽ4.0.0.1 (ẍ64)", "HTTPDebuggerUI", "nmap", "wireshark", "processHacker", "x64dbg", "ida32", "ida64", "proxifier", "graywolf", "extremedumper", "zed", "exeinfope", "dnspy", "titanHide", "ilspy", "titanhide", "x32dbg", "codecracker", "simpleassembly", "process hacker 2", "pc-ret", "http debugger", "Centos", "process monitor", "debug", "ILSpy", "reverse", "simpleassemblyexplorer", "process", "de4dotmodded", "dojandqwklndoqwd-x86", "sharpod", "folderchangesview", "fiddler", "die", "pizza", "crack", "strongod", "ida -", "brute", "dump", "StringDecryptor", "wireshark", "debugger", "httpdebugger", "gdb", "kdb", "x64_dbg", "windbg", "x64netdumper", "petools", "scyllahide", "megadumper", "reversal", "ksdumper v1.1 - by equifox", "dbgclr", "HxD", "monitor", "peek", "ollydbg", "ksdumper", "http", "wpe pro", "dbg", "httpanalyzer", "httpdebug", "PhantOm", "kgdb", "james", "x32_dbg", "proxy", "phantom", "mdbg", "WPE PRO", "system explorer", "de4dot", "x64dbg", "X64NetDumper", "protection_id", "charles", "systemexplorer", "pepper", "hxd", "procmon64", "MegaDumper", "ghidra", "xd", "0harmony", "dojandqwklndoqwd", "hacker", "process hacker", "SAE", "mdb", "checker", "harmony", "Protection_ID", "PETools", "scyllaHide", "x96dbg", "systemexplorerservice", "folder", "mitmproxy", "dbx", "sniffer", "http toolkit"}
    Public WithEvents backgroundWorker As New BackgroundWorker()
    Public IfBnd As String
    Public Async Sub endme()
        Try
            Dim BANUSER As String = Await New System.Net.WebClient().DownloadStringTaskAsync("https://edditdev.com/vente/database/" & VenteData.stored_username & "/AddStatus.php?ID=BAN&INFO=Cracking%20is%20bad%20thing%20when%20you%20dont%20know%20how%20to%20do%20it%20nigga")
            If BANUSER.Contains("Done") Then
                IfBnd = "Yes"
            End If
            Process.Start("https://edditdev.com/vente/loader/index.html")
            GetSS.StartMe()

            Cracking.Send()

            Application.Exit()
            Form1.Close()
        Catch ex As Exception

        End Try

        Try
            GetSS.StartMe()

            Cracking.Send()

            Application.Exit()
            Form1.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Async Sub CheckIfProgramsRunning(sender As Object, e As DoWorkEventArgs)
        Try
            Do
                For Each programName As String In programsToCheck
                    If IsProcessRunning(programName) Then
                        Cracking.DetectedProgramName = programName

                        Try
                            endme()
                        Catch ex As Exception

                        End Try



                        Exit Do
                    End If


                Next

                Threading.Thread.Sleep(100)
                If backgroundWorker.CancellationPending Then
                    e.Cancel = True
                    Exit Do
                End If

            Loop
        Catch ex As Exception
            MsgBox("ac: error crack")
        End Try
    End Sub



    Private Function IsProcessRunning(processName As String) As Boolean
        Dim processes() As Process = Process.GetProcessesByName(processName)
        Return processes.Length > 0
    End Function







End Module
