Imports System.Net.Mail
Public Class Emailsend
    Public emailcount As Integer = 5
    Public greetings() As String
    Public face As String = "(´･ω･`)"
    Public SmtpServer As New SmtpClient()
    Public bye() As String
    Public body() As String


    Sub Start() Handles Me.Load
        SmtpServer.Credentials = New  _
Net.NetworkCredential("wushu.dude@gmail.com", "B7jahaDR")
        SmtpServer.Port = 587
        SmtpServer.Host = "smtp.gmail.com"
        SmtpServer.EnableSsl = True
    End Sub


    Private Sub sendoffitem(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.FormClosed
        Dim i As Integer = 0
        Try
            Dim mail As New MailMessage()
            mail = New MailMessage()
            mail.From = New MailAddress("myemail@gmail.com")
            mail.To.Add("wushu.dude@gmail.com")
            mail.Subject = "Subject"
            mail.Body = TextBox1.Text
            SmtpServer.Send(mail)
            i += 1
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
