'import mail namespace
Imports System.Net.Mail

Public Class report
    Dim Index As String

    Public Sub RegistrationDetails(ByVal Index As String)
        With Registration(Index)
            txtName.Text = " " & .FirstName & " " & .SurName
        End With
    End Sub


    Private Sub show_Result_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call RegistrationDetails(0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button11.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()

        Try
            Dim smtp_server As New SmtpClient
            Dim email As New MailMessage()
            smtp_server.UseDefaultCredentials = False

            'MDS Reciever Email Username and passoword
            smtp_server.Credentials = New Net.NetworkCredential("Tonycletus@hotmail.com", "Anthoniokleitos")

            smtp_server.Port = 587
            smtp_server.EnableSsl = True

            ''Settings For Gmail Client Progression
            smtp_server.Host = "smtp.live.com"
            email = New MailMessage()
            email.From = New MailAddress(txtClient.Text)
            email.To.Add(txtReciever.Text)
            email.Subject = txtName.Text
            email.IsBodyHtml = False
            email.Body = txtMessageBody.Text
            smtp_server.Send(email)
            lblReportSent.Text = "Report Sent Successfully..."
        Catch ex As Exception
            lblReportSent.Text = "Error!!! Please Check Your Network Connection."
        End Try
    End Sub

    Private Sub Resultlbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtResult_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button9.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()

        txtMessageBody.Text = ""

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button13.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button14.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()

        MessageBox.Show("Your report and credentials are highly confidential and treated as private informations. MDS will automatically redirect your report and infomations to the hospital's Email address and a doctor will attend to your report as soon as possible. Note: Make sure you fill the form correctly as possible means to get back to you will be made through the Email you provided.",
               "Tips Alert!")
    End Sub
End Class