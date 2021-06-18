
Imports System.IO
Imports System.Net
Imports System.Text
Public Class NAS

    Shared Sub NASGET(strURL As String)

        Dim blnTest As Boolean
        blnTest = False
        If blnTest = True Then MessageBox.Show("hello")
        If blnTest = True Then MessageBox.Show("First commit to development branch")

        ' Create a request for the URL.   
        Dim request As WebRequest = WebRequest.Create(strURL)
        ' If required by the server, set the credentials.  
        request.Credentials = CredentialCache.DefaultCredentials

        ' Get the response.  
        Dim response As WebResponse = request.GetResponse()
        ' Display the status.  
        Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)

        ' Get the stream containing content returned by the server. 
        ' The using block ensures the stream is automatically closed.
        Using dataStream As Stream = response.GetResponseStream()
            ' Open the stream using a StreamReader for easy access.  
            Dim reader As New StreamReader(dataStream)
            ' Read the content.  
            Dim responseFromServer As String = reader.ReadToEnd()
            ' Display the content.  
            'Console.WriteLine(responseFromServer)
            MessageBox.Show(responseFromServer)
        End Using

        ' Clean up the response.
        response.Close()
    End Sub



    Public Shared Sub NASPOST(strURL As String)
        ' Create a request using a URL that can receive a post.   
        Dim request As WebRequest = WebRequest.Create(strURL)
        ' Set the Method property of the request to POST.  
        request.Method = "POST"
        Dim response As WebResponse = request.GetResponse()
        'Create POST data And convert it to a byte array.  
        'Dim postData As String = "This is a test that posts this string to a Web server."
        'Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)

        '' Set the ContentType property of the WebRequest.  
        'request.ContentType = "application/x-www-form-urlencoded"
        '' Set the ContentLength property of the WebRequest.  
        'request.ContentLength = byteArray.Length

        '' Get the request stream.  
        'Dim dataStream As Stream = request.GetRequestStream()
        '' Write th' data to the request stream.  
        'dataStream.Write(byteArray, 0, byteArray.Length)
        '' Close the Stream object.  
        'dataStream.Close()

        ''Get the response.  
        'Dim response As WebResponse = request.GetResponse()
        ''Display the status.  
        'Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)

        '' Get the stream containing content returned by the server.  
        ''The using block ensures the stream Is automatically closed.
        'Using dataStream1 As Stream = response.GetResponseStream()
        '    ' Open the stream using a StreamReader for easy access.  
        '    Dim reader As New StreamReader(dataStream1)
        '    ' Read the content.  
        '    Dim responseFromServer As String = reader.ReadToEnd()
        '    ' Display the content.  
        '    Console.WriteLine(responseFromServer)
        'End Using

        'Clean up the response.  
        response.Close()
    End Sub


    Public Shared Sub NASPOST2(strURL As String)
        ' Create a request using a URL that can receive a post.   
        Dim request As WebRequest = WebRequest.Create(strURL)
        ' Set the Method property of the request to POST.  
        request.Method = "POST"

        ' Create POST data and convert it to a byte array.  
        Dim postData As String = "This is a test that posts this string to a Web server."
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(strURL)

        '' Set the ContentType property of the WebRequest.  
        'request.ContentType = "application/x-www-form-urlencoded"
        '' Set the ContentLength property of the WebRequest.  
        request.ContentLength = byteArray.Length

        ' Get the request stream.  
        Dim dataStream As Stream = request.GetRequestStream()
        '' Write the data to the request stream.  
        dataStream.Write(byteArray, 0, byteArray.Length)
        '' Close the Stream object.  
        dataStream.Close()

        ' Get the response.  
        Dim response As WebResponse = request.GetResponse()
        ' Display the status.  
        Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)

        ' Get the stream containing content returned by the server.  
        ' The using block ensures the stream is automatically closed.
        Using dataStream1 As Stream = response.GetResponseStream()
            ' Open the stream using a StreamReader for easy access.  
            Dim reader As New StreamReader(dataStream1)
            ' Read the content.  
            Dim responseFromServer As String = reader.ReadToEnd()
            ' Display the content.  
            Console.WriteLine(responseFromServer)

            MessageBox.Show(responseFromServer)
        End Using

        ' Clean up the response.  
        response.Close()
    End Sub

    Public Shared Sub NASPOST3(myFTPURL As String)

        Dim s As HttpWebRequest
        Dim enc As UTF8Encoding
        Dim postdata As String
        Dim postdatabytes As Byte()
        s = HttpWebRequest.Create("http://192.168.0.9:5000/webapi/DownloadStation/task.cgi")
        enc = New System.Text.UTF8Encoding()
        postdata = "api=SYNO.DownloadStation.Task&version=1&method=create&uri=" & myFTPURL  ' ftp://brains48:idkwywbicgia@ftp.mint.seedhost.eu/downloads/Borg/"
        postdatabytes = enc.GetBytes(postdata)
        s.Method = "POST"
        s.ContentType = "application/x-www-form-urlencoded"
        s.ContentLength = postdatabytes.Length

        Using stream = s.GetRequestStream()
            stream.Write(postdatabytes, 0, postdatabytes.Length)
        End Using
        Dim result = s.GetResponse()

    End Sub


    'Shared Sub naspost4()
    '    Dim myurl As String
    '    myurl = "http://192.168.0.9:5000/webapi/DownloadStation/task.cgi?api=SYNO.DownloadStation.Task&version=1&method=create&uri=ftp://brains48:idkwywbicgia@ftp.mint.seedhost.eu/downloads/Borg/"


    '    Dim client = Await New HttpClient().GetAsync(myURl)
    '    Dim bytes As Byte() = Await client.Content.ReadAsByteArrayAsync()
    '    Dim result As String

    '    result = System.Text.Encoding.UTF8.GetString(bytes, 0, bytes.Length - 1)
    '    MessageBox.Show(result)

    'End Sub

    Private Sub TESTRUN()
        Dim s As HttpWebRequest
        Dim enc As UTF8Encoding
        Dim postdata As String
        Dim postdatabytes As Byte()
        s = HttpWebRequest.Create("http://www.textmarketer.biz/gateway/")
        enc = New System.Text.UTF8Encoding()
        postdata = "username=*****&password=*****&message=test+message&orig=test&number=447712345678"
        postdatabytes = enc.GetBytes(postdata)
        s.Method = "POST"
        s.ContentType = "application/x-www-form-urlencoded"
        s.ContentLength = postdatabytes.Length

        Using stream = s.GetRequestStream()
            stream.Write(postdatabytes, 0, postdatabytes.Length)
        End Using
        Dim result = s.GetResponse()
    End Sub

    Public Shared Sub NASGET2(strURL As String)


        Dim myRequest As HttpWebRequest
        '    Dim username = "username=" + HttpUtility.UrlEncode("yourusername")
        '    Dim password = "password=" + HttpUtility.UrlEncode("yourp@assword)!==&@(*#)!@#(_")
        '    Dim message = "message=" + HttpUtility.UrlEncode("yourmessage")
        '    Dim orig = "orig=" + HttpUtility.UrlEncode("dunno what this is")
        '    Dim num = "number=" + HttpUtility.UrlEncode("123456")
        '    Dim sep = "&"
        '    Dim sb As New StringBuilder()
        'sb.Append(username).Append(sep).Append(password).Append(sep)
        'sb.Append(message).Append(sep).Append(orig).Append(sep).Append(num)

        myRequest = HttpWebRequest.Create(strURL)
        myRequest.Method = "GET"
        'Dim result = myRequest.GetResponse()

        ' Get the response.  
        Dim response As WebResponse = myRequest.GetResponse()
        ' Display the status.  
        Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
        MessageBox.Show(myRequest.GetResponse.ToString)
        '' Get the stream containing content returned by the server.  
        '' The using block ensures the stream is automatically closed.
        'Using dataStream1 As Stream = myRequest.GetResponse.ToString.GetResponseStream()
        '    ' Open the stream using a StreamReader for easy access.  
        '    Dim reader As New StreamReader(dataStream1)
        '    ' Read the content.  
        '    Dim responseFromServer As String = reader.ReadToEnd()
        '    ' Display the content.  
        '    Console.WriteLine(responseFromServer)

        '    MessageBox.Show(responseFromServer)

        'End Using
    End Sub



    Public Shared Sub multiget(strurl As String)


        Dim s As HttpWebRequest
        'Dim username = "username=" + HttpUtility.UrlEncode("yourusername")
        'Dim password = "password=" + HttpUtility.UrlEncode("yourp@assword)!==&@(*#)!@#(_")
        'Dim message = "message=" + HttpUtility.UrlEncode("yourmessage")
        'Dim orig = "orig=" + HttpUtility.UrlEncode("dunno what this is")
        'Dim num = "number=" + HttpUtility.UrlEncode("123456")
        'Dim sep = "&"
        'Dim sb As New StringBuilder()
        'sb.Append(username).Append(sep).Append(password).Append(sep)
        'sb.Append(message).Append(sep).Append(orig).Append(sep).Append(num)

        Dim myurl As String
        myurl = "http://192.168.0.17:5000/webapi/auth.cgi?api=SYNO.API.Auth&version=2&method=login&account=admin&passwd=1dkwywb1cg1a&session=DownloadStation&format=cookie"

        s = HttpWebRequest.Create(myurl)
        s.Method = "GET"

        Dim result1 = s.GetResponse()
        s = HttpWebRequest.Create(strurl)
        s.Method = "GET"
        Dim result2 = s.GetResponse()

    End Sub
End Class
