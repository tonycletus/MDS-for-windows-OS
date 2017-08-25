Public Class result

    Private Sub result_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblshowResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtResult.Click

    End Sub

    Private Sub btnTips_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTips.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button14.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
        Tips.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button13.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button14.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
        report.Show()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button14.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
        MsgBox("THIS SERVICE IS NOT AVALIABLE TO FREE TRIAL VERSION.")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("https://www.google.com.ng/maps")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("https://www.cdc.gov/malaria/diagnosis_treatment/treatment.html")
    End Sub

End Class