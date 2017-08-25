<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpertSystem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExpertSystem))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpHolder = New System.Windows.Forms.GroupBox()
        Me.txtFirstName = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chkTrue = New System.Windows.Forms.CheckBox()
        Me.chkFalse = New System.Windows.Forms.CheckBox()
        Me.grpSymptomBox = New System.Windows.Forms.GroupBox()
        Me.chkhotbody = New System.Windows.Forms.CheckBox()
        Me.chkBodyPain = New System.Windows.Forms.CheckBox()
        Me.chkVomiting = New System.Windows.Forms.CheckBox()
        Me.chkUnconsciousness = New System.Windows.Forms.CheckBox()
        Me.chkSweating = New System.Windows.Forms.CheckBox()
        Me.chkRigor = New System.Windows.Forms.CheckBox()
        Me.chkLossOfAppetite = New System.Windows.Forms.CheckBox()
        Me.chkInternalHeat = New System.Windows.Forms.CheckBox()
        Me.chkHeadache = New System.Windows.Forms.CheckBox()
        Me.chkFever = New System.Windows.Forms.CheckBox()
        Me.chkDizziness = New System.Windows.Forms.CheckBox()
        Me.chkCold = New System.Windows.Forms.CheckBox()
        Me.chkBlurred = New System.Windows.Forms.CheckBox()
        Me.chkBitter = New System.Windows.Forms.CheckBox()
        Me.chkAbodominal = New System.Windows.Forms.CheckBox()
        Me.grpBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSex = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.Label()
        Me.txtBloodGroup = New System.Windows.Forms.Label()
        Me.txtGenoType = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblGenoType = New System.Windows.Forms.Label()
        Me.lblBloodGroup = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLabTech = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblLabTech = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpSmallCheckup = New System.Windows.Forms.GroupBox()
        Me.btnDiagnose = New System.Windows.Forms.Button()
        Me.lblState = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.grpHolder.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.grpSymptomBox.SuspendLayout()
        Me.grpBox2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grpSmallCheckup.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.No
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.Font = New System.Drawing.Font("SansSerif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Lavender
        Me.lblTitle.Location = New System.Drawing.Point(317, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(759, 52)
        Me.lblTitle.TabIndex = 22
        Me.lblTitle.Text = "Malaria Diagnosing System (MDS)"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpHolder
        '
        Me.grpHolder.BackColor = System.Drawing.SystemColors.Control
        Me.grpHolder.Controls.Add(Me.txtFirstName)
        Me.grpHolder.Controls.Add(Me.GroupBox5)
        Me.grpHolder.Controls.Add(Me.grpSymptomBox)
        Me.grpHolder.Controls.Add(Me.grpBox2)
        Me.grpHolder.Controls.Add(Me.lblWelcome)
        Me.grpHolder.Controls.Add(Me.lblNote)
        Me.grpHolder.Controls.Add(Me.GroupBox2)
        Me.grpHolder.Controls.Add(Me.lblState)
        Me.grpHolder.Controls.Add(Me.GroupBox1)
        Me.grpHolder.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grpHolder.ForeColor = System.Drawing.Color.OrangeRed
        Me.grpHolder.Location = New System.Drawing.Point(70, 99)
        Me.grpHolder.Name = "grpHolder"
        Me.grpHolder.Size = New System.Drawing.Size(1237, 591)
        Me.grpHolder.TabIndex = 23
        Me.grpHolder.TabStop = False
        Me.grpHolder.Text = "`"
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.Transparent
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!)
        Me.txtFirstName.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtFirstName.Location = New System.Drawing.Point(543, 15)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(397, 32)
        Me.txtFirstName.TabIndex = 39
        Me.txtFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkTrue)
        Me.GroupBox5.Controls.Add(Me.chkFalse)
        Me.GroupBox5.Location = New System.Drawing.Point(937, 113)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(292, 57)
        Me.GroupBox5.TabIndex = 38
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Any Form Of Reoccurence"
        '
        'chkTrue
        '
        Me.chkTrue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkTrue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkTrue.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTrue.Location = New System.Drawing.Point(41, 32)
        Me.chkTrue.Name = "chkTrue"
        Me.chkTrue.Size = New System.Drawing.Size(76, 30)
        Me.chkTrue.TabIndex = 13
        Me.chkTrue.Text = "YES"
        Me.chkTrue.UseVisualStyleBackColor = True
        '
        'chkFalse
        '
        Me.chkFalse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkFalse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkFalse.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFalse.Location = New System.Drawing.Point(158, 38)
        Me.chkFalse.Name = "chkFalse"
        Me.chkFalse.Size = New System.Drawing.Size(59, 24)
        Me.chkFalse.TabIndex = 14
        Me.chkFalse.Text = "NO"
        Me.chkFalse.UseVisualStyleBackColor = True
        '
        'grpSymptomBox
        '
        Me.grpSymptomBox.BackColor = System.Drawing.SystemColors.Highlight
        Me.grpSymptomBox.Controls.Add(Me.chkhotbody)
        Me.grpSymptomBox.Controls.Add(Me.chkBodyPain)
        Me.grpSymptomBox.Controls.Add(Me.chkVomiting)
        Me.grpSymptomBox.Controls.Add(Me.chkUnconsciousness)
        Me.grpSymptomBox.Controls.Add(Me.chkSweating)
        Me.grpSymptomBox.Controls.Add(Me.chkRigor)
        Me.grpSymptomBox.Controls.Add(Me.chkLossOfAppetite)
        Me.grpSymptomBox.Controls.Add(Me.chkInternalHeat)
        Me.grpSymptomBox.Controls.Add(Me.chkHeadache)
        Me.grpSymptomBox.Controls.Add(Me.chkFever)
        Me.grpSymptomBox.Controls.Add(Me.chkDizziness)
        Me.grpSymptomBox.Controls.Add(Me.chkCold)
        Me.grpSymptomBox.Controls.Add(Me.chkBlurred)
        Me.grpSymptomBox.Controls.Add(Me.chkBitter)
        Me.grpSymptomBox.Controls.Add(Me.chkAbodominal)
        Me.grpSymptomBox.ForeColor = System.Drawing.Color.Snow
        Me.grpSymptomBox.Location = New System.Drawing.Point(6, 176)
        Me.grpSymptomBox.Name = "grpSymptomBox"
        Me.grpSymptomBox.Size = New System.Drawing.Size(1226, 134)
        Me.grpSymptomBox.TabIndex = 37
        Me.grpSymptomBox.TabStop = False
        Me.grpSymptomBox.Text = "Picker"
        '
        'chkhotbody
        '
        Me.chkhotbody.AutoSize = True
        Me.chkhotbody.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.chkhotbody.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkhotbody.Location = New System.Drawing.Point(366, 27)
        Me.chkhotbody.Name = "chkhotbody"
        Me.chkhotbody.Size = New System.Drawing.Size(200, 24)
        Me.chkhotbody.TabIndex = 14
        Me.chkhotbody.Text = "High Body Temperation"
        Me.chkhotbody.UseVisualStyleBackColor = True
        '
        'chkBodyPain
        '
        Me.chkBodyPain.AutoSize = True
        Me.chkBodyPain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.chkBodyPain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBodyPain.Location = New System.Drawing.Point(207, 91)
        Me.chkBodyPain.Name = "chkBodyPain"
        Me.chkBodyPain.Size = New System.Drawing.Size(191, 24)
        Me.chkBodyPain.TabIndex = 13
        Me.chkBodyPain.Text = "Body Aches/Weakness"
        Me.chkBodyPain.UseVisualStyleBackColor = True
        '
        'chkVomiting
        '
        Me.chkVomiting.AutoSize = True
        Me.chkVomiting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.chkVomiting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkVomiting.Location = New System.Drawing.Point(747, 27)
        Me.chkVomiting.Name = "chkVomiting"
        Me.chkVomiting.Size = New System.Drawing.Size(92, 24)
        Me.chkVomiting.TabIndex = 12
        Me.chkVomiting.Text = "Vomiting"
        Me.chkVomiting.UseVisualStyleBackColor = True
        '
        'chkUnconsciousness
        '
        Me.chkUnconsciousness.AutoSize = True
        Me.chkUnconsciousness.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.chkUnconsciousness.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkUnconsciousness.Location = New System.Drawing.Point(1022, 91)
        Me.chkUnconsciousness.Name = "chkUnconsciousness"
        Me.chkUnconsciousness.Size = New System.Drawing.Size(151, 24)
        Me.chkUnconsciousness.TabIndex = 11
        Me.chkUnconsciousness.Text = "Unconsciousness"
        Me.chkUnconsciousness.UseVisualStyleBackColor = True
        '
        'chkSweating
        '
        Me.chkSweating.AutoSize = True
        Me.chkSweating.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.chkSweating.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkSweating.Location = New System.Drawing.Point(1022, 27)
        Me.chkSweating.Name = "chkSweating"
        Me.chkSweating.Size = New System.Drawing.Size(195, 24)
        Me.chkSweating.TabIndex = 10
        Me.chkSweating.Text = "Sweating intermitently"
        Me.chkSweating.UseVisualStyleBackColor = True
        '
        'chkRigor
        '
        Me.chkRigor.AutoSize = True
        Me.chkRigor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.chkRigor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkRigor.Location = New System.Drawing.Point(747, 87)
        Me.chkRigor.Name = "chkRigor"
        Me.chkRigor.Size = New System.Drawing.Size(64, 24)
        Me.chkRigor.TabIndex = 9
        Me.chkRigor.Text = "Rigor"
        Me.chkRigor.UseVisualStyleBackColor = True
        '
        'chkLossOfAppetite
        '
        Me.chkLossOfAppetite.AutoSize = True
        Me.chkLossOfAppetite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.chkLossOfAppetite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkLossOfAppetite.Location = New System.Drawing.Point(859, 91)
        Me.chkLossOfAppetite.Name = "chkLossOfAppetite"
        Me.chkLossOfAppetite.Size = New System.Drawing.Size(141, 24)
        Me.chkLossOfAppetite.TabIndex = 8
        Me.chkLossOfAppetite.Text = "Loss of appetite"
        Me.chkLossOfAppetite.UseVisualStyleBackColor = True
        '
        'chkInternalHeat
        '
        Me.chkInternalHeat.AutoSize = True
        Me.chkInternalHeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.chkInternalHeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkInternalHeat.Location = New System.Drawing.Point(859, 27)
        Me.chkInternalHeat.Name = "chkInternalHeat"
        Me.chkInternalHeat.Size = New System.Drawing.Size(121, 24)
        Me.chkInternalHeat.TabIndex = 7
        Me.chkInternalHeat.Text = "Internal heat"
        Me.chkInternalHeat.UseVisualStyleBackColor = True
        '
        'chkHeadache
        '
        Me.chkHeadache.AutoSize = True
        Me.chkHeadache.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.chkHeadache.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkHeadache.Location = New System.Drawing.Point(616, 27)
        Me.chkHeadache.Name = "chkHeadache"
        Me.chkHeadache.Size = New System.Drawing.Size(100, 24)
        Me.chkHeadache.TabIndex = 6
        Me.chkHeadache.Text = "Headache"
        Me.chkHeadache.UseVisualStyleBackColor = True
        '
        'chkFever
        '
        Me.chkFever.AutoSize = True
        Me.chkFever.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.chkFever.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkFever.Location = New System.Drawing.Point(635, 91)
        Me.chkFever.Name = "chkFever"
        Me.chkFever.Size = New System.Drawing.Size(65, 24)
        Me.chkFever.TabIndex = 5
        Me.chkFever.Text = "Fever"
        Me.chkFever.UseVisualStyleBackColor = True
        '
        'chkDizziness
        '
        Me.chkDizziness.AutoSize = True
        Me.chkDizziness.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.chkDizziness.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDizziness.Location = New System.Drawing.Point(410, 91)
        Me.chkDizziness.Name = "chkDizziness"
        Me.chkDizziness.Size = New System.Drawing.Size(91, 24)
        Me.chkDizziness.TabIndex = 4
        Me.chkDizziness.Text = "Dizziness"
        Me.chkDizziness.UseVisualStyleBackColor = True
        '
        'chkCold
        '
        Me.chkCold.AutoSize = True
        Me.chkCold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.chkCold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCold.Location = New System.Drawing.Point(537, 91)
        Me.chkCold.Name = "chkCold"
        Me.chkCold.Size = New System.Drawing.Size(58, 24)
        Me.chkCold.TabIndex = 3
        Me.chkCold.Text = "Cold"
        Me.chkCold.UseVisualStyleBackColor = True
        '
        'chkBlurred
        '
        Me.chkBlurred.AutoSize = True
        Me.chkBlurred.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.chkBlurred.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.chkBlurred.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBlurred.Location = New System.Drawing.Point(207, 27)
        Me.chkBlurred.Name = "chkBlurred"
        Me.chkBlurred.Size = New System.Drawing.Size(126, 24)
        Me.chkBlurred.TabIndex = 2
        Me.chkBlurred.Text = "Blurred vision"
        Me.chkBlurred.UseVisualStyleBackColor = True
        '
        'chkBitter
        '
        Me.chkBitter.AutoSize = True
        Me.chkBitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.chkBitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBitter.Location = New System.Drawing.Point(37, 87)
        Me.chkBitter.Name = "chkBitter"
        Me.chkBitter.Size = New System.Drawing.Size(116, 24)
        Me.chkBitter.TabIndex = 1
        Me.chkBitter.Text = "Bitter throat"
        Me.chkBitter.UseVisualStyleBackColor = True
        '
        'chkAbodominal
        '
        Me.chkAbodominal.AutoSize = True
        Me.chkAbodominal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.chkAbodominal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkAbodominal.Location = New System.Drawing.Point(37, 27)
        Me.chkAbodominal.Name = "chkAbodominal"
        Me.chkAbodominal.Size = New System.Drawing.Size(149, 24)
        Me.chkAbodominal.TabIndex = 0
        Me.chkAbodominal.Text = "Abdominal Pains"
        Me.chkAbodominal.UseVisualStyleBackColor = True
        '
        'grpBox2
        '
        Me.grpBox2.BackColor = System.Drawing.SystemColors.Highlight
        Me.grpBox2.Controls.Add(Me.txtSex)
        Me.grpBox2.Controls.Add(Me.txtAge)
        Me.grpBox2.Controls.Add(Me.txtBloodGroup)
        Me.grpBox2.Controls.Add(Me.txtGenoType)
        Me.grpBox2.Controls.Add(Me.lblAge)
        Me.grpBox2.Controls.Add(Me.lblGenoType)
        Me.grpBox2.Controls.Add(Me.lblBloodGroup)
        Me.grpBox2.Location = New System.Drawing.Point(-1, 61)
        Me.grpBox2.Name = "grpBox2"
        Me.grpBox2.Size = New System.Drawing.Size(1238, 46)
        Me.grpBox2.TabIndex = 21
        Me.grpBox2.TabStop = False
        '
        'txtSex
        '
        Me.txtSex.BackColor = System.Drawing.SystemColors.Control
        Me.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtSex.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!)
        Me.txtSex.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtSex.Location = New System.Drawing.Point(1083, 8)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(155, 37)
        Me.txtSex.TabIndex = 33
        Me.txtSex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.SystemColors.Control
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtAge.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!)
        Me.txtAge.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtAge.Location = New System.Drawing.Point(905, 8)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(72, 37)
        Me.txtAge.TabIndex = 32
        Me.txtAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBloodGroup
        '
        Me.txtBloodGroup.BackColor = System.Drawing.SystemColors.Control
        Me.txtBloodGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBloodGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtBloodGroup.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!)
        Me.txtBloodGroup.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtBloodGroup.Location = New System.Drawing.Point(172, 6)
        Me.txtBloodGroup.Name = "txtBloodGroup"
        Me.txtBloodGroup.Size = New System.Drawing.Size(80, 37)
        Me.txtBloodGroup.TabIndex = 30
        Me.txtBloodGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGenoType
        '
        Me.txtGenoType.BackColor = System.Drawing.SystemColors.Control
        Me.txtGenoType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGenoType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtGenoType.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!)
        Me.txtGenoType.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtGenoType.Location = New System.Drawing.Point(580, 8)
        Me.txtGenoType.Name = "txtGenoType"
        Me.txtGenoType.Size = New System.Drawing.Size(80, 37)
        Me.txtGenoType.TabIndex = 31
        Me.txtGenoType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAge
        '
        Me.lblAge.BackColor = System.Drawing.Color.Navy
        Me.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAge.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.White
        Me.lblAge.Location = New System.Drawing.Point(838, 8)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(69, 37)
        Me.lblAge.TabIndex = 26
        Me.lblAge.Text = "Age"
        Me.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGenoType
        '
        Me.lblGenoType.BackColor = System.Drawing.Color.Navy
        Me.lblGenoType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGenoType.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenoType.ForeColor = System.Drawing.Color.White
        Me.lblGenoType.Location = New System.Drawing.Point(441, 8)
        Me.lblGenoType.Name = "lblGenoType"
        Me.lblGenoType.Size = New System.Drawing.Size(145, 37)
        Me.lblGenoType.TabIndex = 24
        Me.lblGenoType.Text = "GenoType"
        Me.lblGenoType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBloodGroup
        '
        Me.lblBloodGroup.BackColor = System.Drawing.Color.Navy
        Me.lblBloodGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBloodGroup.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBloodGroup.ForeColor = System.Drawing.Color.Azure
        Me.lblBloodGroup.Location = New System.Drawing.Point(1, 6)
        Me.lblBloodGroup.Name = "lblBloodGroup"
        Me.lblBloodGroup.Size = New System.Drawing.Size(174, 37)
        Me.lblBloodGroup.TabIndex = 22
        Me.lblBloodGroup.Text = "Blood Group"
        Me.lblBloodGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWelcome.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!)
        Me.lblWelcome.ForeColor = System.Drawing.Color.SlateGray
        Me.lblWelcome.Location = New System.Drawing.Point(396, 15)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(149, 32)
        Me.lblWelcome.TabIndex = 4
        Me.lblWelcome.Text = "Welcome"
        '
        'lblNote
        '
        Me.lblNote.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNote.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.ForeColor = System.Drawing.Color.Black
        Me.lblNote.Location = New System.Drawing.Point(6, 313)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(388, 275)
        Me.lblNote.TabIndex = 29
        Me.lblNote.Text = resources.GetString("lblNote.Text")
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.txtLabTech)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.lblLabTech)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.grpSmallCheckup)
        Me.GroupBox2.Location = New System.Drawing.Point(467, 297)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(764, 294)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        '
        'txtLabTech
        '
        Me.txtLabTech.BackColor = System.Drawing.SystemColors.Control
        Me.txtLabTech.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLabTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtLabTech.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.0!)
        Me.txtLabTech.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtLabTech.Location = New System.Drawing.Point(461, 257)
        Me.txtLabTech.Name = "txtLabTech"
        Me.txtLabTech.Size = New System.Drawing.Size(301, 34)
        Me.txtLabTech.TabIndex = 35
        Me.txtLabTech.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCancel)
        Me.GroupBox3.Font = New System.Drawing.Font("Adobe Gothic Std B", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(225, 65)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = """"""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Navy
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Lavender
        Me.btnCancel.Location = New System.Drawing.Point(39, 16)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(151, 49)
        Me.btnCancel.TabIndex = 32
        Me.btnCancel.Text = "Clear"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblLabTech
        '
        Me.lblLabTech.BackColor = System.Drawing.Color.Navy
        Me.lblLabTech.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLabTech.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabTech.ForeColor = System.Drawing.Color.White
        Me.lblLabTech.Location = New System.Drawing.Point(348, 257)
        Me.lblLabTech.Name = "lblLabTech"
        Me.lblLabTech.Size = New System.Drawing.Size(117, 34)
        Me.lblLabTech.TabIndex = 19
        Me.lblLabTech.Text = "Lab Tech:"
        Me.lblLabTech.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnClose)
        Me.GroupBox4.Font = New System.Drawing.Font("Adobe Gothic Std B", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(554, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(210, 65)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = """"""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Navy
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Lavender
        Me.btnClose.Location = New System.Drawing.Point(34, 16)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(151, 49)
        Me.btnClose.TabIndex = 32
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'grpSmallCheckup
        '
        Me.grpSmallCheckup.Controls.Add(Me.btnDiagnose)
        Me.grpSmallCheckup.Font = New System.Drawing.Font("Adobe Gothic Std B", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.grpSmallCheckup.Location = New System.Drawing.Point(286, 16)
        Me.grpSmallCheckup.Name = "grpSmallCheckup"
        Me.grpSmallCheckup.Size = New System.Drawing.Size(206, 65)
        Me.grpSmallCheckup.TabIndex = 33
        Me.grpSmallCheckup.TabStop = False
        Me.grpSmallCheckup.Text = "Result"
        '
        'btnDiagnose
        '
        Me.btnDiagnose.BackColor = System.Drawing.Color.Navy
        Me.btnDiagnose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite
        Me.btnDiagnose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnDiagnose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiagnose.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiagnose.ForeColor = System.Drawing.Color.Lavender
        Me.btnDiagnose.Location = New System.Drawing.Point(28, 16)
        Me.btnDiagnose.Name = "btnDiagnose"
        Me.btnDiagnose.Size = New System.Drawing.Size(151, 49)
        Me.btnDiagnose.TabIndex = 32
        Me.btnDiagnose.Text = "Check Up"
        Me.btnDiagnose.UseVisualStyleBackColor = False
        '
        'lblState
        '
        Me.lblState.BackColor = System.Drawing.Color.Transparent
        Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblState.Cursor = System.Windows.Forms.Cursors.No
        Me.lblState.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblState.Font = New System.Drawing.Font("SansSerif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.SlateGray
        Me.lblState.Location = New System.Drawing.Point(372, 131)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(459, 42)
        Me.lblState.TabIndex = 30
        Me.lblState.Text = "SYMPTOMS CHECKING/UPDATE"
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Adobe Gothic Std B", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(363, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 77)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Picker"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Adobe Arabic", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label3.Location = New System.Drawing.Point(644, 714)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(717, 28)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "USAID: Protect Your Family and Youself: Get the Free mosquito net for good health" & _
            "y family living..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker.Location = New System.Drawing.Point(-1, 1)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(244, 31)
        Me.DateTimePicker.TabIndex = 26
        '
        'ExpertSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.MalariaDiagnosisSoftware.My.Resources.Resources.background2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpHolder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ExpertSystem"
        Me.Text = "MDS Data Formating..."
        Me.grpHolder.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.grpSymptomBox.ResumeLayout(False)
        Me.grpSymptomBox.PerformLayout()
        Me.grpBox2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.grpSmallCheckup.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpHolder As System.Windows.Forms.GroupBox
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents grpBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblGenoType As System.Windows.Forms.Label
    Friend WithEvents lblBloodGroup As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLabTech As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents grpSmallCheckup As System.Windows.Forms.GroupBox
    Friend WithEvents btnDiagnose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents grpSymptomBox As System.Windows.Forms.GroupBox
    Friend WithEvents chkVomiting As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnconsciousness As System.Windows.Forms.CheckBox
    Friend WithEvents chkSweating As System.Windows.Forms.CheckBox
    Friend WithEvents chkRigor As System.Windows.Forms.CheckBox
    Friend WithEvents chkLossOfAppetite As System.Windows.Forms.CheckBox
    Friend WithEvents chkInternalHeat As System.Windows.Forms.CheckBox
    Friend WithEvents chkHeadache As System.Windows.Forms.CheckBox
    Friend WithEvents chkFever As System.Windows.Forms.CheckBox
    Friend WithEvents chkDizziness As System.Windows.Forms.CheckBox
    Friend WithEvents chkCold As System.Windows.Forms.CheckBox
    Friend WithEvents chkBlurred As System.Windows.Forms.CheckBox
    Friend WithEvents chkBitter As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTrue As System.Windows.Forms.CheckBox
    Friend WithEvents chkFalse As System.Windows.Forms.CheckBox
    Friend WithEvents chkhotbody As System.Windows.Forms.CheckBox
    Friend WithEvents chkBodyPain As System.Windows.Forms.CheckBox
    Friend WithEvents txtFirstName As System.Windows.Forms.Label
    Friend WithEvents txtBloodGroup As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.Label
    Friend WithEvents txtGenoType As System.Windows.Forms.Label
    Friend WithEvents txtSex As System.Windows.Forms.Label
    Friend WithEvents txtLabTech As System.Windows.Forms.Label
    Friend WithEvents chkAbodominal As System.Windows.Forms.CheckBox
End Class
