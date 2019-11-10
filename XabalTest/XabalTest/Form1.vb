Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Web

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s As HttpWebRequest
        Dim enc As UTF8Encoding
        Dim postdata As String
        Dim postdatabytes As Byte()
        s = HttpWebRequest.Create("https://loremitalia.altervista.org/xabal.php")
        enc = New System.Text.UTF8Encoding()
        postdata = "function=test"
        postdatabytes = enc.GetBytes(postdata)
        s.Method = "POST"
        s.ContentType = "application/x-www-form-urlencoded"
        s.ContentLength = postdatabytes.Length

        Using stream = s.GetRequestStream()
            stream.Write(postdatabytes, 0, postdatabytes.Length)
        End Using
        Dim result = s.GetResponse()
        Dim reader As New StreamReader(result.GetResponseStream())
        Dim streamText As String = reader.ReadToEnd()
        MsgBox(streamText)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim s As HttpWebRequest
        Dim enc As UTF8Encoding
        Dim postdata As String
        Dim postdatabytes As Byte()
        s = HttpWebRequest.Create("https://loremitalia.altervista.org/xabal.php")
        enc = New System.Text.UTF8Encoding()
        postdata = "function=string&string=" & TextBox1.Text
        postdatabytes = enc.GetBytes(postdata)
        s.Method = "POST"
        s.ContentType = "application/x-www-form-urlencoded"
        s.ContentLength = postdatabytes.Length

        Using stream = s.GetRequestStream()
            stream.Write(postdatabytes, 0, postdatabytes.Length)
        End Using
        Dim result = s.GetResponse()
        Dim reader As New StreamReader(result.GetResponseStream())
        Dim streamText As String = reader.ReadToEnd()
        MsgBox(streamText)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim s As HttpWebRequest
        Dim enc As UTF8Encoding
        Dim postdata As String
        Dim postdatabytes As Byte()
        s = HttpWebRequest.Create("https://loremitalia.altervista.org/xabal.php")
        enc = New System.Text.UTF8Encoding()
        postdata = "function=operations&operation=" & System.Web.HttpUtility.UrlEncode(TextBox2.Text)
        postdatabytes = enc.GetBytes(postdata)
        s.Method = "POST"
        s.ContentType = "application/x-www-form-urlencoded"
        s.ContentLength = postdatabytes.Length

        Using stream = s.GetRequestStream()
            stream.Write(postdatabytes, 0, postdatabytes.Length)
        End Using
        Dim result = s.GetResponse()
        Dim reader As New StreamReader(result.GetResponseStream())
        Dim streamText As String = reader.ReadToEnd()
        MsgBox(streamText)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim s As HttpWebRequest
        Dim enc As UTF8Encoding
        Dim postdata As String
        Dim postdatabytes As Byte()
        s = HttpWebRequest.Create("https://loremitalia.altervista.org/xabal.php")
        enc = New System.Text.UTF8Encoding()
        postdata = "function=encrypt&testo=" & TextBox3.Text & "&chiave=" & TextBox4.Text
        postdatabytes = enc.GetBytes(postdata)
        s.Method = "POST"
        s.ContentType = "application/x-www-form-urlencoded"
        s.ContentLength = postdatabytes.Length

        Using stream = s.GetRequestStream()
            stream.Write(postdatabytes, 0, postdatabytes.Length)
        End Using
        Dim result = s.GetResponse()
        Dim reader As New StreamReader(result.GetResponseStream())
        Dim streamText As String = reader.ReadToEnd()
        My.Computer.Clipboard.SetText(streamText)
        MsgBox(streamText)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim s As HttpWebRequest
        Dim enc As UTF8Encoding
        Dim postdata As String
        Dim postdatabytes As Byte()
        s = HttpWebRequest.Create("https://loremitalia.altervista.org/xabal.php")
        enc = New System.Text.UTF8Encoding()
        postdata = "function=decrypt&testo=" & TextBox3.Text & "&chiave=" & TextBox4.Text
        postdatabytes = enc.GetBytes(postdata)
        s.Method = "POST"
        s.ContentType = "application/x-www-form-urlencoded"
        s.ContentLength = postdatabytes.Length

        Using stream = s.GetRequestStream()
            stream.Write(postdatabytes, 0, postdatabytes.Length)
        End Using
        Dim result = s.GetResponse()
        Dim reader As New StreamReader(result.GetResponseStream())
        Dim streamText As String = reader.ReadToEnd()
        My.Computer.Clipboard.SetText(streamText)
        MsgBox(streamText)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim s As HttpWebRequest
        Dim enc As UTF8Encoding
        Dim postdata As String
        Dim postdatabytes As Byte()
        s = HttpWebRequest.Create("https://loremitalia.altervista.org/xabal.php")
        enc = New System.Text.UTF8Encoding()
        postdata = "function=code&code=" & System.Web.HttpUtility.UrlEncode(TextBox5.Text)
        postdatabytes = enc.GetBytes(postdata)
        s.Method = "POST"
        s.ContentType = "application/x-www-form-urlencoded"
        s.ContentLength = postdatabytes.Length

        Using stream = s.GetRequestStream()
            stream.Write(postdatabytes, 0, postdatabytes.Length)
        End Using
        Dim result = s.GetResponse()
        Dim reader As New StreamReader(result.GetResponseStream())
        Dim streamText As String = reader.ReadToEnd()
        MsgBox(streamText)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim s As HttpWebRequest
        Dim enc As UTF8Encoding
        Dim postdata As String
        Dim postdatabytes As Byte()
        s = HttpWebRequest.Create("https://loremitalia.altervista.org/xabal.php")
        enc = New System.Text.UTF8Encoding()
        postdata = "function=sanitize&string=" & TextBox6.Text
        postdatabytes = enc.GetBytes(postdata)
        s.Method = "POST"
        s.ContentType = "application/x-www-form-urlencoded"
        s.ContentLength = postdatabytes.Length

        Using stream = s.GetRequestStream()
            stream.Write(postdatabytes, 0, postdatabytes.Length)
        End Using
        Dim result = s.GetResponse()
        Dim reader As New StreamReader(result.GetResponseStream())
        Dim streamText As String = reader.ReadToEnd()
        MsgBox(streamText)
    End Sub
End Class
