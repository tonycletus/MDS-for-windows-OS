Module Module1
    Public NumberOfPatient As Integer

    Structure PatientType
        Dim FirstName As String
        Dim SurName As String
        Dim BloodGroup As String
        Dim GenoType As String
        Dim Age As String
        Dim Sex As String
        Dim LabTech As String
    End Structure

    Public Registration(10) As PatientType
End Module
