Imports System.IO
Imports System.Management
Imports System.Net
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports Newtonsoft.Json
Imports vente.VenteData

Module Cracking
    Public SessionID As String
    Public CreatedSSLink As String
    Public DetectedProgramName As String



    Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem")
    Dim os As ManagementObject = searcher.Get().Cast(Of ManagementObject).First()

    Dim searcher2 As New ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem")
    Dim computerInfo As ManagementObject = searcher2.Get().Cast(Of ManagementObject).First()


    Dim version As String = os("Version").ToString()

    Dim manufacturer As String = computerInfo("Manufacturer").ToString()
    Dim model As String = computerInfo("Model").ToString()





    Async Sub Send()



        Dim usernameeddited
        If stored_username = "" Then
            stored_username = "N/A"
            usernameeddited = "GUEST (Without account)"
        End If
        If stored_password = "" Then
            stored_password = "N/A"
        End If
        If stored_username = "eddit" Then
            stored_ip = "HIDDEN | ADMIN"
        End If

        Dim BanOutput As String
        Dim IsBanned As String = AntiCrack.IfBnd
        If IsBanned = "Yes" Then
            BanOutput = " Account has been banned!"
        Else
            BanOutput = " Not banned - Guest"
        End If


        If stored_ip = "" Then
            stored_ip = "N/A"
        End If
        '    MsgBox("\n > **Computer-Name:** {Environment.UserName & " | " & Environment.UserDomainName & " | " & Environment.MachineName} \n > **IP-Adress**: {stored_ip} \ > **Manufacturer:** {manufacturer} \n > **Model:** {model} \n > **Version:** {version} \n \n > **USER:** {usernameeddited} \n \n **Account has been banned:** {BanOutput}")
        Dim webhookUrl As String = "https://discord.com/api/webhooks/1197694456154030151/9NxCsIfp2JB8U82zJDaFca_8yD88yQwzlU6g3fkM09LKT7pbmnwd_kFOHUq0-QGA0PI1"
        Dim DataIgodzina As String = DateTime.Now.ToString
        '**Cracking Alert** \n PC-NAME: {Environment.UserName} \n IP: {stored_ip} \n \n USER: {stored_username} \n
        Dim embedContent As String = $"{{ 
            ""embeds"":[
                {{
                    ""title"":""CRACKING ALERT"", 
                    ""description"":""`{stored_ip} | {Environment.UserName & " | " & Environment.UserDomainName & " | " & Environment.MachineName }`"",
                    ""color"":16722944,
                    ""fields"":[
                        {{
                            ""name"":""**Session informations**"",
                            ""value"":""\n > **USER:** {usernameeddited} \n > **Session-ID:** {SessionID} \n > **Detected program:** {DetectedProgramName}  \n > **Operations: ** {BanOutput} \n \n **Computer Informations** \n > **Computer-Name:** {Environment.UserName} \n > **IP-Adress**: {stored_ip} > \n > **Manufacturer:** {manufacturer.Trim.ToString} \n > **Model:** {model} \n > **Version:** {version}"",
                            ""inline"":""true""
                        }}
                    ],
                    ""image"": {{
                        ""url"":""{CreatedSSLink}""
                    }},
                    ""thumbnail"": {{
                        ""url"":""""
                    }},
                    ""footer"": {{
                        ""text"":""{DataIgodzina}"",
                        ""icon_url"":""""
                    }}
                }}
            ]
        }}" ' Tutaj dostosuj zawartość embeda


        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(webhookUrl), HttpWebRequest)
        request.Method = "POST"
        request.ContentType = "application/json"

        Using streamWriter As New StreamWriter(request.GetRequestStream())
            streamWriter.Write(embedContent)
            streamWriter.Flush()
            streamWriter.Close()
        End Using

        Try
            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)

        Catch ex As WebException
            MsgBox($"Wystąpił błąd: {ex.Message}")
        End Try

    End Sub
End Module
