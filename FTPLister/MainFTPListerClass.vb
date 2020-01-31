Imports System.IO
Imports System.Net

Public Class MainFTPListerClass

    Shared dctFileNames As New Dictionary(Of String, Integer)

    Shared Sub FTPLister()
        Dim Rows As New List(Of ListViewItem)
        Call MainFTPListerClass.CreateDictionary()

        frmFTPFiles.lstFTPFiles.Items.Clear()

        Dim Dirlist As New List(Of String) 'I prefer List() instead of an array
        Dim request As FtpWebRequest = DirectCast(WebRequest.Create("ftp://ftp.mint.seedhost.eu/downloads/"), FtpWebRequest)

        request.Method = WebRequestMethods.Ftp.ListDirectory
        request.Credentials = New NetworkCredential("brains48", "idkwywbicgia")

        Dim response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
        Dim responseStream As Stream = response.GetResponseStream
        'Dim items() As String
        'Dim str As String

        Using reader As New StreamReader(responseStream)

            Do While reader.Peek <> -1

                'str = reader.ReadLine
                'items = str.Split("  ")

                Dirlist.Add(reader.ReadLine)

            Loop

        End Using

        response.Close()

        'Dirlist.Sort()

        Dim intcount As Integer : intcount = 1
        Dim strFound As String

        For Each item In Dirlist
            Debug.Print(item)
            strFound = "not found"

            For Each pair As KeyValuePair(Of String, Integer) In dctFileNames

                If InStr(pair.Key, item) > 0 Then

                    strFound = Left(pair.Key, 1) '"Found"
                    Exit For

                End If

            Next

            frmFTPFiles.lstFTPFiles.Items.Add(New ListViewItem(New String() {item, strFound}))
            intcount = intcount + 1
        Next


        frmFTPFiles.lblCount.Text = "Items: " & intcount.ToString


    End Sub

    Shared Sub CreateDictionary()

        Dim Dirlist As New List(Of String) 'I prefer List() instead of an array
        Dim request As FtpWebRequest = DirectCast(WebRequest.Create("ftp://ftp.mint.seedhost.eu/downloads/"), FtpWebRequest)

        request.Method = WebRequestMethods.Ftp.ListDirectoryDetails
        request.Credentials = New NetworkCredential("brains48", "idkwywbicgia")

        Dim response As FtpWebResponse = DirectCast(request.GetResponse(), FtpWebResponse)
        Dim responseStream As Stream = response.GetResponseStream

        Dim intcount As Integer : intcount = 1
        Using reader As New StreamReader(responseStream)
            dctFileNames = New Dictionary(Of String, Integer)

            Do While reader.Peek <> -1

                'Debug.Print(reader.ReadLine)
                dctFileNames.Add(reader.ReadLine, intcount)
                intcount = intcount + 1

            Loop

        End Using

        response.Close()

    End Sub

End Class
