Imports System.IO
Imports System.Net
Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports Newtonsoft.Json
Imports vente.VenteData

Module ActivationFailed
    Async Sub Send()



        Dim webhookUrl As String = "https://discord.com/api/webhooks/1188533768433172601/j-irF1zOgW2F9VjobaJKDZbK3xfGZ8JmVtA0147h5pfgwwoe8mgVtgUoqHSULX9YNtxJ"
        Dim DataIgodzina As String = DateTime.Now.ToString
        Dim LicenseConv = LicenseActivation.LicTextBox.Text
        If LicenseConv.Contains("F") Then
            LicenseConv = "FORTNITE"
        End If
        If LicenseConv.Contains("H") Then
            LicenseConv = "HWID SPOOFER"
        End If
        If LicenseConv = "" Then
            LicenseConv = "Not found"
        End If

        Dim embedContent As String = $"{{ 
            ""embeds"":[
                {{
                    ""title"":""**`⚠️ {stored_username}` ** Activation failed!"", 
                    ""description"":""Product: {LicenseConv}"",
                    ""color"":16711680,
                    ""fields"":[
                        {{
                            ""name"":""FAILED Activation: {LicenseActivation.LicTextBox.Text}"",
                            ""value"":"" \n **IP:** {stored_ip} \n **Username:** {stored_username} \n **Password:** {stored_password} \n"",
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
                        ""url"":""https://i.imgur.com/qLx6opT.png""
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
