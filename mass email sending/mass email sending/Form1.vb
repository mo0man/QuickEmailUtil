Imports System.Net.Mail
Public Class Form1
    Public emailcount As Integer = 5
    Public greetings() As String
    Public face As String = "(´･ω･`)"
    Public SmtpServer As New SmtpClient()
    Public bye() As String
    Public body() As String


    Sub Start() Handles Me.Load
        greetings = Split("hi,hello,hey,how are you", ",")
        bye = Split("bye,farewell,see ya,love,what,kay", ",")
        body = Split("styff, more stuff a shole, a whole sentence, you know, I don't even know what I'm saying", ",")


        SmtpServer.Credentials = New  _
Net.NetworkCredential("wushu.dude@gmail.com", "B7jahaDR")
        SmtpServer.Port = 587
        SmtpServer.Host = "smtp.gmail.com"
        SmtpServer.EnableSsl = True
        Randomize()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer = 0
        Do While i < emailcount
            Try
                Dim mail As New MailMessage()
                mail = New MailMessage()
                mail.From = New MailAddress("myemail@gmail.com")
                mail.To.Add("sansin@live.ca")
                mail.To.Add("wushu.dude@gmail.com")
                mail.Subject = greetings(Int(greetings.Length * Rnd()))
                mail.Body = bye(Int(bye.Length * Rnd())) + vbCrLf + face
                SmtpServer.Send(mail)
                i += 1
                System.Threading.Thread.Sleep(1000 * 7.2 * 60)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Loop
    End Sub

    Sub createemail()


    End Sub

End Class
