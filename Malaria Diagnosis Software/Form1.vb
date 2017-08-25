Imports System.Text.RegularExpressions  'Regular Expression Namespace

Public Class frmPatientInfo
    Private FirstNameValid As Boolean ' Is First Name Valid?
    Private SurnameValid As Boolean ' Is Surname Valid?
    Private AddressValid As Boolean ' Is Address Valid?
    Private SexValid As Boolean ' Is Sex (Gender) Valide?
    Private AgeValid As Boolean ' Is Age Valid?

    Dim Index As String
    Private Sub frmPatientInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub frmPatientInfo_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown


    End Sub
    Private Sub frmPatientInfo_Closed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        Dim Sapi
        Sapi = CreateObject("Sapi.Spvoice")
        Sapi.Speak("Thank You for using MDS, Remember, Health is wealth, Protect Yourself from mosquitoes")

    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button11.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
        Registration(Index).FirstName = txtFirstName.Text
        Registration(Index).SurName = txtLastName.Text
        Registration(Index).Age = txtAge.Text
        Registration(Index).Sex = cboSex.Text
        Registration(Index).BloodGroup = cboBloodGroup.Text
        Registration(Index).GenoType = cboGenotype.Text
        Registration(Index).LabTech = txtClinician.Text

        'Index = Index = 1
        'txtFirstName.Text = ""
        'txtLastName.Text = ""
        'txtAge.Text = ""
        'txtSex.Text = ""
        'txtLastName.Text = ""
        'cboGenotype.Text = ""
        '.Text = ""
        'txtFirstName.Focus()

    End Sub

    Private Sub btnPushMe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPushMe.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button8.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
        Launching.Show()
    End Sub

    Private Sub Green_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Green.Tick
        Try
            rectGreen.Height += 1
            If (rectGreen.Height >= 50) Then
                Green.Stop()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Red_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Red.Tick
        Try
            rectRed.Height += 1
            Label8.Text = "Completed: 100%"
            If (rectRed.Height >= 49) Then
                Red.Stop()
            Else
                Label8.Text = "Updating: 0%"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Blue_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blue.Tick

        Try
            rectBlue.Height += 1
            If (rectBlue.Height >= 50) Then

                Blue.Stop()
                Dim Sapi
                Sapi = CreateObject("Sapi.Spvoice")
                Sapi.Speak("Welcome to The Malariah Diagnosing System, Please fill the form below...")
                Sapi.Stop()
                Dim first As New frmPatientInfo
                first.computer.Image = My.Resources.background2

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtFirstName_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstName.Leave
        'Create A Pattern For First 
        Dim strFirstName As String = "^[a-zA-Z\s]+$"
        Dim reFirstName As New Regex(strFirstName) 'Attach Pattern To FirstName TextBox

        'Not Match 
        If Not reFirstName.IsMatch(txtFirstName.Text) Then
            MessageBox.Show("Please Enter Alphabetic Characters Only!")

            txtFirstName.Focus()
            txtFirstName.Clear()

            FirstNameValid = False

        Else

            FirstNameValid = True
        End If

    End Sub

    Private Sub txtLastName_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLastName.Leave
        'Create A Pattern For Surname 
        Dim strSurname As String = "^[a-zA-Z\s]+$"
        Dim reSurname As New Regex(strSurname) 'Attach Pattern To Surname TextBox

        'Not Match 
        If Not reSurname.IsMatch(txtLastName.Text) Then
            MessageBox.Show("Please Enter Alphabetic Characters Only!")

            txtLastName.Focus()
            txtLastName.Clear()

            SurnameValid = False

        Else

            SurnameValid = True
        End If
    End Sub
End Class
