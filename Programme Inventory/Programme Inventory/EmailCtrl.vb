
Imports System.Net.Mail

Public Class EmailCtrl
    Dim mail As New MailMessage
    Dim smtp As New SmtpClient

    Public Sub ConfigMail()

        smtp.Host = "smtp-mail.outlook.com"
        smtp.Port = "587"
        smtp.EnableSsl = True
        smtp.Credentials = New Net.NetworkCredential("garg_gaurav2510@outlook.com", "pswd@outlook")
        mail.From = New MailAddress("garg_gaurav2510@outlook.com", "E-mail Heading")
        mail.To.Add("garg_gaurav25@rocketmail.com")

    End Sub
    Public Sub SendEmail(ByVal Subject As String, ByVal Body As String, ByVal BodyHTMLType As Boolean)

        Dim s As String = "dd"
        ConfigMail()
        mail.Subject = Subject
        mail.Body = Body
        mail.IsBodyHtml = BodyHTMLType
        Try
            '           smtp.SendAsync(mail)
            smtp.SendAsync(mail, s)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class

