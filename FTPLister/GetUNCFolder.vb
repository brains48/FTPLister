Imports System.IO

Module Module1

    Public Declare Function WNetGetConnection Lib "mpr.dll" Alias "WNetGetConnectionA" (ByVal lpszLocalName As String,
             ByVal lpszRemoteName As String, ByRef cbRemoteName As Integer) As Integer

    Function GetUNCFolder(strDriveLetter As String) As String

        Dim ret As Integer
        Dim out As String = New String(" ", 260)
        Dim len As Integer = 260

        GetUNCFolder = ""

        ret = WNetGetConnection(strDriveLetter, out, len)
        If out.Count > 0 Then
            GetUNCFolder = out.Trim
        End If
        'Console.ReadLine()

    End Function

End Module