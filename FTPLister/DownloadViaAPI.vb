Imports System.Net
Imports System.Web
Module DownloadViaAPI

    Dim mySelections As List(Of String)
    Dim mySID As String
    Sub DownloadViaAPIToPublic(strDestination As String)

        Dim currentNode As TreeNode
        Dim subNode As TreeNode
        Dim subsubNode As TreeNode

        mySelections = New List(Of String)

        Dim str As String = ""

        For Each currentNode In frmFTPFiles.tvFiles.Nodes   'rutorrent

            For Each subNode In currentNode.Nodes 'the actual files

                If subNode.Checked = True Then

                    If Strings.Right(subNode.Text, 3) = "; d" Then

                        str = Strings.Left(subNode.Text, Len(subNode.Text) - 3) & "/"
                        mySelections.Add(str)

                    Else

                        str = Strings.Left(subNode.Text, Len(subNode.Text) - 3)
                        mySelections.Add(str)

                    End If

                End If

                For Each subsubNode In subNode.Nodes

                    If subsubNode.Checked = True Then

                        If Strings.Right(subsubNode.Text, 3) = "; d" Then

                            str = Strings.Left(subNode.Text, Len(subNode.Text) - 3) & "/" & Strings.Left(subsubNode.Text, Len(subsubNode.Text) - 3) & "/"
                            mySelections.Add(str)

                        Else

                            str = Strings.Left(subNode.Text, Len(subNode.Text) - 3) & "/" & Strings.Left(subsubNode.Text, Len(subsubNode.Text) - 3)
                            mySelections.Add(str)

                        End If

                    End If

                Next subsubNode

            Next subNode

        Next currentNode

        Call PushViaAPIToPublic(strDestination)

        Call FormView.Manage()

    End Sub

    Sub PushViaAPIToPublic(myDestination As String)

        Dim intcount As Integer
        Dim myWebRequest As HttpWebRequest
        Dim mySynologyURL As String = GetConfig("Synology", "SynologyURL")
        Dim myResponseString As String
        Dim myPostURL As String
        Dim myPostURI As Uri
        Dim fName As String, myNewfName As String

        'This is Step 1:
        myWebRequest = HttpWebRequest.Create(fnURL("GetAPIInformation"))
        myWebRequest.Method = "GET"

        'This is Step 2
        myWebRequest = HttpWebRequest.Create(fnURL("SessionLogin"))
        myWebRequest.Method = "GET"
        myResponseString = GetFullTextResponse(myWebRequest)
        mySID = GetResponseFromText(myResponseString, "data.sid")

        'This is Step 3.3 - this demonstrates the creation of the download task
        For intcount = 0 To mySelections.Count - 1

            fName = mySelections(intcount)
            myNewfName = RemoveIllegalCharacters(fName) '****NOTE THIS

            'https://www.browserling.com/tools/url-encode

            myPostURL = mySynologyURL & "/webapi/DownloadStation/task.cgi?api=SYNO.DownloadStation.Task&version=1&method=create&uri=ftp://brains48:idkwywbicgia@ftp.lime.seedhost.eu/downloads/" & myNewfName & "&destination=" & myDestination & "&_sid=" & mySID

            myWebRequest = HttpWebRequest.Create(myPostURL)
            myWebRequest.Method = "GET" 'yes, it is GET rather than POST
            myResponseString = GetFullTextResponse(myWebRequest)

            If GetResponseFromText(myResponseString, "success") = "False" Then
                MessageBox.Show(myResponseString + vbCrLf + vbCrLf + myPostURL)
            End If

        Next

    End Sub
    Public Function URLEncode(StringToEncode As String, Optional _
   UsePlusRatherThanHexForSpace As Boolean = False) As String

        Dim TempAns As String
        Dim CurChr As Integer
        CurChr = 1
        Do Until CurChr - 1 = Len(StringToEncode)
            Select Case Asc(Mid(StringToEncode, CurChr, 1))
                Case 48 To 57, 65 To 90, 97 To 122
                    TempAns = TempAns & Mid(StringToEncode, CurChr, 1)
                Case 32
                    If UsePlusRatherThanHexForSpace = True Then
                        TempAns = TempAns & "+"
                    Else
                        TempAns = TempAns & "%" & Hex(32)
                    End If
                Case Else
                    TempAns = TempAns & "%" &
              Format(Hex(Asc(Mid(StringToEncode,
              CurChr, 1))), "00")
            End Select

            CurChr = CurChr + 1
        Loop

        URLEncode = TempAns
    End Function
    Public Function encode(ByVal str As String) As String
        'supply True as the construction parameter to indicate
        'that you wanted the class to emit BOM (Byte Order Mark)
        'NOTE: this BOM value is the indicator of a UTF-8 string
        Dim utf8Encoding As New System.Text.UTF8Encoding(True)
        Dim encodedString() As Byte

        encodedString = utf8Encoding.GetBytes(str)

        Return utf8Encoding.GetString(encodedString)
    End Function

End Module
