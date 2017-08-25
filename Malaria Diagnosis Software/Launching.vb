Public Class Launching
    Dim Index As String
    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            RectangleShape2.Width += 1
            If (RectangleShape2.Width >= 1) Then
                Timer1.Stop()
                ExpertSystem.Show()
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Launching_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Sapi
        Sapi = CreateObject("Sapi.Spvoice")
        Sapi.Speak("Preparing Diagnosis and symptom's package")
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class

