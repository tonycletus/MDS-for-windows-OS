Public Class ExpertSystem
    Dim Index As String
    Dim Result As New result

    Public Sub RegistrationDetails(ByVal Index As String)
        With Registration(Index)
            txtFirstName.Text = " " & .FirstName & " " & .SurName
            txtBloodGroup.Text = .BloodGroup
            txtGenoType.Text = .GenoType
            txtAge.Text = .Age
            txtSex.Text = .Sex
            txtLabTech.Text = .LabTech
        End With
    End Sub
    Private Sub ExpertSystem_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Dim Sapi
        Sapi = CreateObject("Sapi.Spvoice")
        Sapi.Speak("Optimized For " & txtFirstName.Text)
    End Sub
    Private Sub ExpertSystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call RegistrationDetails(0)
    End Sub
    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button13.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
        Me.Close()
    End Sub
    Private Sub btnDiagnose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDiagnose.Click

        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button8.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()

        '######################################################
        'Declaring Variables for The types of symptoms check-up                                       #
        '######################################################
        Result.lblOwner.Text = "All is well " & txtFirstName.Text
        Dim vomiting As Boolean = chkVomiting.Checked
        Dim abdominalpain As Boolean = chkAbodominal.Checked
        Dim blurredVission As Boolean = chkBlurred.Checked
        Dim bitterThroat As Boolean = chkBitter.Checked
        Dim cold As Boolean = chkCold.Checked
        Dim dizziness As Boolean = chkDizziness.Checked
        Dim fever As Boolean = chkFever.Checked
        Dim headache As Boolean = chkHeadache.Checked
        Dim internalHeat As Boolean = chkInternalHeat.Checked
        Dim lossOfAppetite As Boolean = chkLossOfAppetite.Checked
        Dim rigor As Boolean = chkRigor.Checked
        Dim unconsciousness As Boolean = chkUnconsciousness.Checked
        Dim sweating As Boolean = chkSweating.Checked
        Dim hotbody As Boolean = chkhotbody.Checked
        Dim bodypain As Boolean = chkBodyPain.Checked
        Dim reoccur As Boolean = chkTrue.Checked
        Dim Everything1 As Boolean
        Dim Everything2 As Boolean
        Dim acute, acute1, acute2, acute3, acute4, acute5, acute6, acute7, acute8, acute9, acute10, acute11, acute12, acute13, acute14, acute15, chronic, chronic1, chronic2, celebral, celebral1, celebral2, celebral3, celebral4, celebral5 As Boolean

        '####################################################
        'Allocations of data varibles to a main point variable
        '#####################################################
        'Acute Algorithmic Process 
        acute = cold And vomiting And internalHeat Or abdominalpain And sweating Or headache And bitterThroat Or lossOfAppetite And dizziness Or hotbody And rigor Or blurredVission And dizziness
        acute1 = vomiting And cold And headache Or internalHeat And abdominalpain Or bitterThroat And blurredVission Or bodypain And lossOfAppetite Or sweating And rigor Or hotbody And dizziness
        acute2 = headache And cold And bodypain And hotbody And abdominalpain And bitterThroat And internalHeat And lossOfAppetite And sweating And rigor And vomiting And blurredVission And dizziness
        acute3 = headache And cold And bodypain And hotbody And abdominalpain And bitterThroat And internalHeat And lossOfAppetite And sweating And rigor Or vomiting And blurredVission
        acute4 = headache And cold And bodypain And hotbody And abdominalpain And bitterThroat And internalHeat And lossOfAppetite And sweating Or rigor And vomiting And blurredVission
        acute5 = headache And cold And bodypain And hotbody And abdominalpain And bitterThroat And internalHeat And lossOfAppetite Or sweating And rigor And vomiting And blurredVission
        acute6 = headache And cold And bodypain And hotbody And abdominalpain And bitterThroat And internalHeat Or lossOfAppetite And sweating And rigor And vomiting And blurredVission
        acute7 = headache And cold And bodypain And hotbody And abdominalpain And bitterThroat Or internalHeat And lossOfAppetite And sweating And rigor And vomiting And blurredVission

        'Terrrible conditions
        acute8 = bitterThroat And bodypain Or vomiting And internalHeat Or headache And abdominalpain Or sweating And blurredVission And dizziness Or bitterThroat And lossOfAppetite Or hotbody And dizziness Or cold And rigor
        acute9 = headache And cold And bodypain Or hotbody And abdominalpain And bitterThroat And internalHeat And lossOfAppetite And sweating And rigor And vomiting And blurredVission
        acute10 = headache And cold And bodypain And hotbody Or abdominalpain And bitterThroat And internalHeat And lossOfAppetite And sweating And rigor And vomiting And blurredVission
        acute11 = bitterThroat And internalHeat And lossOfAppetite And sweating And rigor And vomiting And blurredVission Or headache And cold And bodypain And hotbody And abdominalpain And fever Or cold And fever
        acute12 = abdominalpain And bitterThroat Or cold And headache Or internalHeat And lossOfAppetite Or cold And hotbody Or rigor And cold Or vomiting And lossOfAppetite
        acute13 = headache And cold And bodypain And hotbody And abdominalpain And bitterThroat And internalHeat And lossOfAppetite And sweating And rigor And vomiting And blurredVission
        acute14 = headache And cold And bodypain And hotbody And abdominalpain And bitterThroat Or dizziness And internalHeat And lossOfAppetite And sweating And rigor And vomiting And blurredVission

        acute15 = fever And acute Or fever And acute1 Or fever And acute2 Or fever And acute3 Or fever And acute4 Or fever And acute5 Or fever And acute6 Or fever And acute7 Or fever And acute8 Or fever And acute9 Or fever And acute10 Or fever And acute11 Or fever And acute12 Or fever And acute13 Or fever And acute14

        'Chronic Algorithmic Process
        chronic = acute And reoccur Or acute1 And reoccur Or acute10 And reoccur
        chronic1 = acute8 And reoccur Or acute12 And reoccur Or acute9 And reoccur Or acute15 And reoccur
        chronic2 = acute2 And reoccur Or acute3 And reoccur Or acute4 And reoccur Or acute5 And reoccur Or acute6 And reoccur Or acute7 And reoccur Or acute11 And reoccur Or acute13 And reoccur Or acute14 And reoccur

        'Celebral Algorithmic Process

        'Celibral on acute malaria
        celebral = unconsciousness And acute Or acute1 And unconsciousness Or acute10 And unconsciousness
        celebral2 = unconsciousness And acute8 Or unconsciousness And acute12 Or unconsciousness And acute9 Or unconsciousness And acute15
        celebral3 = unconsciousness And acute2 Or unconsciousness And acute3 Or unconsciousness And acute4 Or unconsciousness And acute5 Or unconsciousness And acute6 Or unconsciousness And acute7 Or unconsciousness And acute11 Or unconsciousness And acute13 Or unconsciousness And acute14

        'Reoccurring Celibral Malaria
        celebral1 = unconsciousness And chronic
        celebral4 = unconsciousness And chronic1
        celebral5 = unconsciousness And chronic2

        'E! Algorithmic Process
        Everything1 = abdominalpain And bodypain And hotbody And bitterThroat And blurredVission And cold And dizziness And fever And headache And internalHeat And lossOfAppetite And rigor And vomiting And unconsciousness And sweating
        Everything2 = abdominalpain And bodypain And hotbody And bitterThroat And blurredVission And cold And dizziness And fever And headache And internalHeat And lossOfAppetite And rigor And vomiting And unconsciousness And sweating And reoccur

        '###################################################
        '#                  Launch Assignments and Program flows..............                       #
        '###################################################




        If Everything2 Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " THIS IS BAD... AT THIS STATE YOU MUST HURRY BECAUSE YOUR CONDITION IS WORST. PLEASE PROCEED TO THE NEAREST HOSPITAL AND SEE A DOCTOR,  DO NOT TAKE ANY MEDCINE BEFORE PRESCRIPTION."
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female

        ElseIf Everything1 Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " YOUR MALARIA SYMPTOMS ARE TOO HIGH, AT THIS STATE YOU MUST SEE A DOCTOR IMMEDIATELY FOR YOUR OWN GOOD. PLEASE DO NOT TAKE ANY MEDCINE BEFORE PRESCRIPTION OR TRY TO HANDLE THIS CONDITION YOURSELF."
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female

        ElseIf celebral1 Or celebral4 Or celebral5 Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " YOU HAVE CELIBRAL MALARIA WHICH HAPPENS TO COME UP OFTEN.. FREQUENT OCCURENCE OF MALARIA ACCOMPANIED WITH UNCONSCIOUSNES CAN LEAD TO DEATH IF NOT TREATED PROPERLY. PLEASE DO NOT TRY TO CONTROL THIS YOURSELF, KINDLY RUSH TO THE HOSPITAL FOR PROPER TREATMENT AND ATTENTION. "
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female


        ElseIf celebral Or celebral2 Or celebral3 Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " YOU HAVE HIGH SYMPTOMS OF MALARIA AND AT THIS LEVEL ITS CELIBRAL(very dangerous).  PLEASE SEE A DOCTOR FOR COMFIRMATORY TEST AND TREATMENT IMMEDIATELY."
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female


        ElseIf chronic2 Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " YOU HAVE CHRONIC MALARIA. FREQUENT MALARIA ILLNESS CAN LEAD TO CELIBRAL AND WORST CASES IF NOT TREATED TO THE LATER.  IT IS ADVICEABLE TO BEGIN WITH QUININE INJECTIONS NOW. SEE A DOCTOR IMMEDIATELY."
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female

        ElseIf chronic1 Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " YOUR MALARIA LEVEL IS NOT GOOD, REOCCURENCE OF AN ACUTE MALARIA CAN CAUSE SERIOUS PAIN AND GREATER HARM. DO NOT WAIT... PROCEED TO THE HOSPITAL FOR PROPER CHECK-UP AND TREATMENT."
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female


        ElseIf chronic Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " YOU HAVE LOW SYMPTOMS OF MALARIA BUT SOME SYMPTOMS ALWAYS REOCCUR... THIS IS A CASE THAT MUST BE INVESTIGATED FURTHER. PLEASE PROCEED TO THE HOSPITAL FOR CONFIRMAORY TEST AND TREATMENT. "
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female



            'This is acute A1, A2, A3, A++ malaria...............................................It begins from here. Take Note Master
        ElseIf acute15 Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " YOUR SYMPTOMS SHOWS SIGNS OF MALARIA INFECTION COUPLED WITH ITS FEVER SYMPTOMS. BEST CASE-PRESCRIPTION IS TO TAKE: *Coatem (100mg daily, obeserve this for 2days) Diclofenac Sodium (100mg daily)  ibuprofen (400mg) And PCM (2 ^ 2 ^ 2) "
            Result.lblOwner.Text = "All is well " & txtFirstName.Text

        ElseIf acute2 Or acute4 Or acute5 Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " THIS IS A SEVERE ACUTE MALARIA AND NEEDS A SERIOUS ATTENTION. IF A HOSPITAL IS OUT OF YOUR REACH YOU CAN CONSIDER THE FOLLOWING PRESCRIPTIONS AS A FIRST AID TREATMENT BEFORE REACHING OUT FOR THE HOSPITAL: TABS: *Diclofenac Sodium (100mg daily)  ibuprofen (400mg) And PCM (2 ^ 2 ^ 2). However, after taking this drugs you should observe for 8hours to check if there's any improvement of your health"
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female


        ElseIf acute7 Or acute14 Or acute13 Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " YOUR SYMPTOMS SHOWS SIGNS OF SEVERE MALARIA INFECTION AND PROPER TREATMENT IS REQUIRED AT ONCE. IF THE HOSPITAL IS OUT OF YOUR REACH YOU CAN CONSIDER THE FOLLOWING PRESCRIPTIONS TO SUPPRESS THE DISEASE: TABS: *Diclofenac (100mg daily)  ibuprofen (400mg) And PCM (2 ^ 2 ^ 2) "
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female

        ElseIf acute2 Or acute3 Or acute4 Or acute10 Or acute11 Or acute9 Or acute6 Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " MALARIA PARASITE SUSPECTED AND SERIOUS ANTI PYRETIC DRUGS NEEDS TO BE ADMINISTERED FOR A START. TABS: *Diclofenac (100mg daily), ibuprofen (400mg) And p.c.m (2 ~ 2 ~ 2*) THIS WILL STOP ANY FURTHER DEVELOPMENT OF THE INFECTION. "
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female

        ElseIf acute Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " THESE ARE SYMPTOMS OF MALARIA AND CAN TREATED. THIS IS PROBABLY ACUTE 1 TYPE OF MALARIA AND YOU'LL BE FINE. IF THE HOSPITAL IS OUT OF YOUR REACH RIGHT NOW THEN YOU CAN CONSIDER GOING FOR THESE PRESCRIPTIONS TO SUBSIDE THE PAIN BEFORE HOSPITAL.  TABS: *Diclofenac Sodium (100mg daily) And panadol (2 ~ 2 ~ 2)* However, after taking this drugs you should observe for 8hours to check if there's any improvement of your health."
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female


        ElseIf acute12 Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " YOUR SYMPTOMS INDICATES THAT YOU HAVE THE MALARIA PARASITE IN YOUR BODY. THIS SITUATION CAN BE CONTROLLED BY SUPRESSING AND TERMINATING THIS PARASITE. IF THE HOSPITAL IS OUT OF YOUR REACH YOU CAN CONSIDER THE FOLLOWING PRESCRIPTIONS AS A FIRST AID MEASURE BEFORE MAKING PLANS FOR THE HOSPITAL: TABS: *Diclofenac Sodium (100mg daily)  ibuprofen (400mg) And PCM (2 ^ 2 ^ 2)* However, after taking this drugs you should observe for 8hours to check if there's any improvement of your health. "
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female


        ElseIf acute1 Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " BE SURE TO VISIT A HOSPITAL TODAY AS YOUR SYMPTOMS SUGGEST YOU ARE UNWELL. PLEASE DO NOT TAKE ANY MEDCINE BEFORE YOU DO "
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female

        ElseIf acute8 Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " YOUR RISK CONDTION IS QUITE LOW AND CAN BE CONTROLLED AT ONCE. THIS IS PROBABLY ACUTE 1 TYPE OF MALARIA AND YOU'LL BE FINE. IF THE HOSPITAL IS OUT OF YOUR REACH RIGHT NOW THEN YOU CAN CONSIDER GOING FOR THESE PRESCRIPTIONS TO SUBSIDE THE PAIN BEFORE HOSPITAL.  TABS: *Diclofenac Sodium (100mg daily) And panadol (2 ~ 2 ~ 2)*"
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female

            'When Input =  One Symptom........................................
        ElseIf hotbody Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " YOU HAVE MINIMAL SYMPTOMS OF MALARIA, BUT IF IT'S JUST 'HIGH BODY TEMPERATURE'... IT CAN BE SOME FORM OF TYPHOID. PROBABLY A MALARIA FEVER FIRST SIGN. YOU SHOULD CONSIDER GOING TO THE HOSPTIAL FOR  FURTHER TEST AND TREATMENT."
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female

        ElseIf bodypain Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " AT THIS STATE, IT MAY NOT BE MALARIA INFECTION... BODY ACHES OR WEAKNESS OF THE BODY CAN BE AS A RESULT OF DIFFERENT REASONS, HOWEVER, BOTH SYMPTOMS ARE MOSTLY TREATED THE SAME WAY. TAKE: Panadol  2 ^ 2^ 2 TO SUBSIDE THE PAIN. OBSERVE FOR 6HOURS. IF THE PAIIN CONTINUES SEE A DOCTOR."
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female

        ElseIf vomiting Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " WHILE THEY MIGHT BE SO MANY REASONS RESPONSIBLE FOR THIS SYMPTOM, BEST SUGGESTION IS TO CONSIDER VISITING THE HOSPITAL TO KNOW THE CAUSE. TAKE LOTS OF WATER AND DO NOT TAKE ANY MEDICATION BEFORE YOU DO. "
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female

        ElseIf abdominalpain Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " YOU HAVE MINIMAL SYMPTOMS OF MALARIA, BUT IF IT'S JUST 'ABDOMINAL PAIN'... PROBABLY IT MAY NOT BE ANY SIGNS OF MALARIA INFECTION YET. TAKE  Buscopan Tab (1 ^ 1 ^ 1) OR MixMag Sirup (Tea-spoon = 2 ^ 2 ^ 2)."
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female

        ElseIf blurredVission Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " YOU HAVE MINIMAL SYMPTOMS OF MALARIA, BUT IF IT'S JUST 'BLURRED VISION'.... NO WORRIES, BLURRED VISION COULD BE AS A RESULT OF HUNGER, STRESS, LESS SLEEP etc. YOU MIGHT WANT TO DEVOTE ENOUGH TIME FOR EATING AND RESTING VERY WELL. IF YOU HAVE BEEN DIAGNOSED OF ANAEMIA AND LOW BP IN THE FORMER, YOU SHOULD SEE A DOCTOR IMMEDIATELY."
            Result.lblOwner.Text = "All is well " & txtFirstName.Text

        ElseIf rigor Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " YOU HAVE MINIMAL SYMPTOMS OF MALARIA, BUT IF IT'S JUST 'RIGOR' WHICH IS A SERIOUS SIGN OF MALARIA. TELL THOSE AROUND YOU, BE INSIDE DOUBLE COVERS (BLANKETS OR SWEATERS), APPLY RUB ALL OVER YOUR BODY TO MAKE SURE YOU'RE WARM. MIND YOU THIS IS THE FIRST AID TREATMENT. IT WILL REDUCE FURTHER DAMAGES BEFORE GETTING TO THE HOSPITAL."
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female

        ElseIf bitterThroat Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " YOU HAVE MINIMAL SYMPTOMS OF MALARIA, BUT IF IT'S JUST 'BITTER THROAT'... PLEASE OBSERVE AND MAKE SURE ITS NOT AS A RESULT OF PREVIOUSLY TAKEN BITTER MEAL BEFORE PROCEEDING TO THE HOSPTAL FOR FURTHER TEST AND TREATMENT AS THIS COULD BE SOMETIMES THE FIRST SIGN OF MALARIA FEVER."
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female

        ElseIf cold Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " YOU HAVE MINIMAL SYMPTOMS OF MALARIA, BUT IF IT'S JUST 'COLD'... BEST ADVICE IS TO TAKE Procold Tab (1^ 1 ^ 1 ^) Panadol(2 ^ 2 ^ 2), BE IN DOUBLE COVERS (BLANKETS OR SWEATERS) THIS SHOULD CONTROL THE SITUATION WHILE YOU MAKE FUTURE ARRANGEMENT TO VISIT A DOCTOR."
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female

        ElseIf dizziness Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " YOU HAVE MINIMAL SYMPTOMS OF MALARIA, BUT IF IT'S JUST 'DIZZINESS'... YOU PROBABLY MIGHT BE EXPERIENCING FATIQUE OR TIREDNESS OR OVER-STRESS 0R DEPRESSION; IN THIS CASE YOU MUST TRY TO TALK TO PEOPLE CLOSER TO YOU, FEEL FREE, MAKE TIME TO REST WELL.  IF YOU HAVE BEEN DIAGNOSED OF ANAEMIA AND LOW BP IN THE FORMER, YOU SHOULD SEE A DOCTOR IMMEDIATELY."
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female

        ElseIf unconsciousness Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " YOU HAVE MINIMAL SYMPTOMS OF MALARIA, BUT IF IT'S JUST 'UNCONCIOUSNES'... PLEASE TAKE EASE... MEET SOMEONE IMMEDIATELY AS YOU WILL NEED GREAT SUPPORT NOW, GO FOR THE NEAREST HOSPITAL AND MAKE SURE YOU SEE A DOCTOR."
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female

        ElseIf fever Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " WHILE FEVER CAN BE A VERY DYNAMIC SYMPTOMS WHICH CAN RESULT TO EITHER MALARIA OR TYPHOID, BEST CASE-ADVICE IS THAT YOU SHOULD GO FOR A LAB TEST. THE RESULT OF THE TEST WILL HELP THE MEDICAL PERSONAL PROVIDE PROPER TREATMENT."
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female

        ElseIf headache Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " YOU HAVE MINIMAL SYMPTOMS OF MALARIA, BUT IF IT'S JUST 'HEADACHE'.... BEST CASE PRESCRIPTIONS: Panadol Tabs (2 ^ 2 ^2) OR Pentax Tabs (2^ 2 ^ 2) . FOR CHRONIC HEADACHE:  Diclofenac Sodium Capsule 100mg  (1 ^  1  ^  1 ). OBSERVE FOR 24HOURS IF THE PAIN CONTINUES, CONSIDER VISITING THE HOSPITAL FOR FURTHER DIAGNOSIS AND TREATMENT."
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female

        ElseIf internalHeat Then
            Result.txtResult.Text = "DEAR " & txtFirstName.Text & " YOU HAVE MINIMAL SYMPTOMS OF MALARIA, BUT IF IT'S JUST 'INTERNAL HEAT'... YOU MIGHT WANT TO GO TO THE HOSPITAL FOR FURTHER CHECK-UP."
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female

        ElseIf lossOfAppetite Then
            Result.txtResult.Text = "Dear " & txtFirstName.Text & " different reasons can be responsible for this symptom. It could be from depression, anger, sadness, hormonal distortation, food not meeting your need at the point. nevertheless, it is adviceable to take control over the situation and try to take something. you can begin with apetizers like fruith, beverages, bread, meat, peanuts, potatoes and juice or milk. you must also try to talk to someone to free yourself."
            Result.lblOwner.Text = "All is well " & txtFirstName.Text
            Result.PictureBox1.Image = My.Resources.doc_female
            Result.lblMDS.Focus()

        Else
            Result.txtResult.Text = "Hey! You have Note selected any symptoms yet. You may want to read the 'Note Me' box below the symptom's list."

            Result.PictureBox1.Image = My.Resources.doc_male
            Result.lblOwner.Dispose()
            Result.lblMDS.Dispose()
            Result.btnPrint.Dispose()
        End If

        'Trigger To lauch the Result in a Dialog Format.............................
        Result.ShowDialog()


    End Sub

    Private Sub chkFever_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFever.CheckedChanged
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button14.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub chkUnconsciousness_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUnconsciousness.CheckedChanged
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button14.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button9.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()


        chkVomiting.Checked = False
        chkAbodominal.Checked = False
        chkBlurred.Checked = False
        chkBitter.Checked = False
        chkCold.Checked = False
        chkDizziness.Checked = False
        chkFever.Checked = False
        chkHeadache.Checked = False
        chkInternalHeat.Checked = False
        chkLossOfAppetite.Checked = False
        chkRigor.Checked = False
        chkUnconsciousness.Checked = False
        chkSweating.Checked = False
        chkhotbody.Checked = False
        chkBodyPain.Checked = False
        chkTrue.Checked = False
    End Sub

    Private Sub Break()
        Throw New NotImplementedException
    End Sub

    Private Sub chkBlurred_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBlurred.CheckedChanged
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button14.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub chkSweating_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSweating.CheckedChanged
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button14.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub chkAbodominal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAbodominal.CheckedChanged
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button14.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub chkBitter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBitter.CheckedChanged
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button14.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub chkBodyPain_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBodyPain.CheckedChanged
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button14.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub chkhotbody_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkhotbody.CheckedChanged
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button14.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub chkDizziness_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDizziness.CheckedChanged
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button14.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub chkCold_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCold.CheckedChanged
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button14.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub chkHeadache_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHeadache.CheckedChanged
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button14.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub chkRigor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRigor.CheckedChanged
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button14.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub chkVomiting_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVomiting.CheckedChanged
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button14.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub chkInternalHeat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInternalHeat.CheckedChanged
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button14.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub chkLossOfAppetite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLossOfAppetite.CheckedChanged
        Dim spath As String
        Dim mysound As Media.SoundPlayer

        spath = "C:\VB Project\Malaria Diagnosis Software\Malaria Diagnosis Software\bin\mysound\button14.wav"
        mysound = New Media.SoundPlayer(spath)
        mysound.Play()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class
