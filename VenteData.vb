'##############################
'#       VENTE CHEATS         #
'#    HARDCODED BY EDDIT      #
'#         [v4.12.1]          #
'##############################

'# DATABASE: EDDITDEV.COM
'# PROXY: EDDITDEV.COM/ProxyServer/AccessPass:316613111598?access=server=allow

'# # VENTE USER-SAVED DATA

Imports System.IO

Public Class VenteData

    '# Vente Url's
    Public Shared VentePath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\"
    Public Shared Web_VENTE As String = "https://edditdev.com/vente/"
    Public Shared Web_Database As String = "https://edditdev.com/vente/database/"
    Public Shared Web_Licenses As String = "https://edditdev.com/vente/license/"
    Public Shared Web_LicensesPath As String = "https://edditdev.com/vente/license/"
    Public Shared AllLicenses As String

    '# Vente  database
    Public Shared stored_username As String
    Public Shared stored_password As String
    Public Shared stored_license As String
    Public Shared stored_ip As String
    Public Shared stored_discord As String
    Public Shared stored_regdate As String
    Public Shared stored_changelog As String
    Public Shared stored_news As String



End Class
