
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Hello World!!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Hello Earth!!")
    End Sub

    Private Function GetIPAddress() As String
        GetIPAddress = System.Net.Dns.GetHostEntry(GetHostName).AddressList(0).ToString()
    End Function
    Private Function GetHostName() As String
        GetHostName = System.Net.Dns.GetHostName()
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Host name: " & GetHostName() & vbCrLf & "IP Address: " & GetIPAddress())
        ' MsgBox("This does nothing.")
    End Sub
End Class
