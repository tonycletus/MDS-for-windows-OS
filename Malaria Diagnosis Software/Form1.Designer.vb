<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientInfo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatientInfo))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.lblSubTitle1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSubTitle2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tablabTech = New System.Windows.Forms.TabPage()
        Me.txtClinician = New System.Windows.Forms.TextBox()
        Me.lblClinician = New System.Windows.Forms.Label()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.lblTerms_Conditions = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PicLab = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblInvestigation = New System.Windows.Forms.Label()
        Me.cboInvestigation = New System.Windows.Forms.ComboBox()
        Me.lblClinicianDiagnosisTarget = New System.Windows.Forms.Label()
        Me.txtMalariaParasite = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblPushMeNote = New System.Windows.Forms.Label()
        Me.btnPushMe = New System.Windows.Forms.Button()
        Me.tabPatientBioData = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOthers = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblOthers = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblGenoType = New System.Windows.Forms.Label()
        Me.cboGenotype = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cboBloodGroup = New System.Windows.Forms.ComboBox()
        Me.lblBloodGroup = New System.Windows.Forms.Label()
        Me.tabPatientPersonalInfos = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.computer = New System.Windows.Forms.PictureBox()
        Me.txtAge = New System.Windows.Forms.NumericUpDown()
        Me.cboSex = New System.Windows.Forms.ComboBox()
        Me.txtSex = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rectBlue = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rectRed = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rectGreen = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.tabClinicianPatient = New System.Windows.Forms.TabControl()
        Me.Green = New System.Windows.Forms.Timer(Me.components)
        Me.Red = New System.Windows.Forms.Timer(Me.components)
        Me.Blue = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tablabTech.SuspendLayout()
        CType(Me.PicLab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tabPatientBioData.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.tabPatientPersonalInfos.SuspendLayout()
        CType(Me.computer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabClinicianPatient.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Black
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.No
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.Font = New System.Drawing.Font("SansSerif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Lavender
        Me.lblTitle.Location = New System.Drawing.Point(497, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(557, 57)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Malaria Diagnosing System(MDS)"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.Cursor = System.Windows.Forms.Cursors.No
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lavender
        Me.Label1.Location = New System.Drawing.Point(547, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(458, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Expert System And Additional Prescriptions"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.MonthCalendar1.BackColor = System.Drawing.SystemColors.Menu
        Me.MonthCalendar1.ForeColor = System.Drawing.Color.DarkRed
        Me.MonthCalendar1.Location = New System.Drawing.Point(1142, 4)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 22
        Me.MonthCalendar1.TitleBackColor = System.Drawing.SystemColors.GrayText
        Me.MonthCalendar1.TitleForeColor = System.Drawing.SystemColors.HotTrack
        Me.MonthCalendar1.TrailingForeColor = System.Drawing.SystemColors.MenuHighlight
        '
        'lblSubTitle1
        '
        Me.lblSubTitle1.BackColor = System.Drawing.Color.OrangeRed
        Me.lblSubTitle1.Cursor = System.Windows.Forms.Cursors.No
        Me.lblSubTitle1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubTitle1.Font = New System.Drawing.Font("SansSerif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblSubTitle1.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblSubTitle1.Location = New System.Drawing.Point(544, 131)
        Me.lblSubTitle1.Name = "lblSubTitle1"
        Me.lblSubTitle1.Size = New System.Drawing.Size(180, 53)
        Me.lblSubTitle1.TabIndex = 23
        Me.lblSubTitle1.Text = "Clinician "
        Me.lblSubTitle1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LemonChiffon
        Me.Label4.Location = New System.Drawing.Point(-1, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(431, 49)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = " DIAGNOSTIC CENTRE; KOGI STATE UNIVERSITY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " God's arrows piercing to the root of " & _
            "your aliment"
        '
        'lblSubTitle2
        '
        Me.lblSubTitle2.BackColor = System.Drawing.Color.Navy
        Me.lblSubTitle2.Cursor = System.Windows.Forms.Cursors.No
        Me.lblSubTitle2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubTitle2.Font = New System.Drawing.Font("SansSerif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblSubTitle2.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblSubTitle2.Location = New System.Drawing.Point(719, 131)
        Me.lblSubTitle2.Name = "lblSubTitle2"
        Me.lblSubTitle2.Size = New System.Drawing.Size(181, 53)
        Me.lblSubTitle2.TabIndex = 26
        Me.lblSubTitle2.Text = " Patient"
        Me.lblSubTitle2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.MalariaDiagnosisSoftware.My.Resources.Resources.mosquito_128
        Me.PictureBox1.Location = New System.Drawing.Point(42, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'tablabTech
        '
        Me.tablabTech.Controls.Add(Me.txtClinician)
        Me.tablabTech.Controls.Add(Me.lblClinician)
        Me.tablabTech.Controls.Add(Me.DateTimePicker)
        Me.tablabTech.Controls.Add(Me.lblTerms_Conditions)
        Me.tablabTech.Controls.Add(Me.Label5)
        Me.tablabTech.Controls.Add(Me.PicLab)
        Me.tablabTech.Controls.Add(Me.GroupBox2)
        Me.tablabTech.Controls.Add(Me.GroupBox3)
        Me.tablabTech.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tablabTech.Location = New System.Drawing.Point(4, 37)
        Me.tablabTech.Name = "tablabTech"
        Me.tablabTech.Padding = New System.Windows.Forms.Padding(3)
        Me.tablabTech.Size = New System.Drawing.Size(980, 494)
        Me.tablabTech.TabIndex = 2
        Me.tablabTech.Text = "Lab Technologist Only"
        Me.tablabTech.UseVisualStyleBackColor = True
        '
        'txtClinician
        '
        Me.txtClinician.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtClinician.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClinician.ForeColor = System.Drawing.Color.Navy
        Me.txtClinician.Location = New System.Drawing.Point(127, 33)
        Me.txtClinician.Multiline = True
        Me.txtClinician.Name = "txtClinician"
        Me.txtClinician.Size = New System.Drawing.Size(394, 30)
        Me.txtClinician.TabIndex = 24
        '
        'lblClinician
        '
        Me.lblClinician.BackColor = System.Drawing.Color.Transparent
        Me.lblClinician.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClinician.ForeColor = System.Drawing.Color.Black
        Me.lblClinician.Location = New System.Drawing.Point(6, 34)
        Me.lblClinician.Name = "lblClinician"
        Me.lblClinician.Size = New System.Drawing.Size(137, 29)
        Me.lblClinician.TabIndex = 23
        Me.lblClinician.Text = "CLINICIAN"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.DateTimePicker.CalendarTitleForeColor = System.Drawing.Color.OrangeRed
        Me.DateTimePicker.Location = New System.Drawing.Point(733, 34)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(244, 29)
        Me.DateTimePicker.TabIndex = 22
        '
        'lblTerms_Conditions
        '
        Me.lblTerms_Conditions.BackColor = System.Drawing.Color.Transparent
        Me.lblTerms_Conditions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTerms_Conditions.Font = New System.Drawing.Font("Lucida Fax", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerms_Conditions.ForeColor = System.Drawing.Color.Black
        Me.lblTerms_Conditions.Location = New System.Drawing.Point(3, 296)
        Me.lblTerms_Conditions.Name = "lblTerms_Conditions"
        Me.lblTerms_Conditions.Size = New System.Drawing.Size(506, 202)
        Me.lblTerms_Conditions.TabIndex = 21
        Me.lblTerms_Conditions.Text = resources.GetString("lblTerms_Conditions.Text")
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label5.Location = New System.Drawing.Point(0, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(977, 28)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "                           CLINICIAN && LABORATORY SCIENTIST ONLY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PicLab
        '
        Me.PicLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicLab.Image = CType(resources.GetObject("PicLab.Image"), System.Drawing.Image)
        Me.PicLab.Location = New System.Drawing.Point(0, 66)
        Me.PicLab.Margin = New System.Windows.Forms.Padding(0)
        Me.PicLab.Name = "PicLab"
        Me.PicLab.Padding = New System.Windows.Forms.Padding(4)
        Me.PicLab.Size = New System.Drawing.Size(322, 216)
        Me.PicLab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLab.TabIndex = 1
        Me.PicLab.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblInvestigation)
        Me.GroupBox2.Controls.Add(Me.cboInvestigation)
        Me.GroupBox2.Controls.Add(Me.lblClinicianDiagnosisTarget)
        Me.GroupBox2.Controls.Add(Me.txtMalariaParasite)
        Me.GroupBox2.Location = New System.Drawing.Point(337, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(647, 140)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'lblInvestigation
        '
        Me.lblInvestigation.BackColor = System.Drawing.Color.Transparent
        Me.lblInvestigation.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvestigation.ForeColor = System.Drawing.Color.Black
        Me.lblInvestigation.Location = New System.Drawing.Point(143, 85)
        Me.lblInvestigation.Name = "lblInvestigation"
        Me.lblInvestigation.Size = New System.Drawing.Size(184, 29)
        Me.lblInvestigation.TabIndex = 25
        Me.lblInvestigation.Text = "Investigating For"
        '
        'cboInvestigation
        '
        Me.cboInvestigation.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.cboInvestigation.ForeColor = System.Drawing.Color.Navy
        Me.cboInvestigation.FormattingEnabled = True
        Me.cboInvestigation.Items.AddRange(New Object() {"Acute Malaria", "Chronic Malaria", "Celibral Malaria"})
        Me.cboInvestigation.Location = New System.Drawing.Point(333, 82)
        Me.cboInvestigation.Name = "cboInvestigation"
        Me.cboInvestigation.Size = New System.Drawing.Size(245, 32)
        Me.cboInvestigation.TabIndex = 28
        '
        'lblClinicianDiagnosisTarget
        '
        Me.lblClinicianDiagnosisTarget.BackColor = System.Drawing.Color.Transparent
        Me.lblClinicianDiagnosisTarget.Font = New System.Drawing.Font("Lucida Fax", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClinicianDiagnosisTarget.ForeColor = System.Drawing.Color.Black
        Me.lblClinicianDiagnosisTarget.Location = New System.Drawing.Point(143, 28)
        Me.lblClinicianDiagnosisTarget.Name = "lblClinicianDiagnosisTarget"
        Me.lblClinicianDiagnosisTarget.Size = New System.Drawing.Size(171, 29)
        Me.lblClinicianDiagnosisTarget.TabIndex = 26
        Me.lblClinicianDiagnosisTarget.Text = "Suspected For "
        '
        'txtMalariaParasite
        '
        Me.txtMalariaParasite.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtMalariaParasite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMalariaParasite.ForeColor = System.Drawing.Color.Navy
        Me.txtMalariaParasite.Location = New System.Drawing.Point(333, 27)
        Me.txtMalariaParasite.Multiline = True
        Me.txtMalariaParasite.Name = "txtMalariaParasite"
        Me.txtMalariaParasite.ReadOnly = True
        Me.txtMalariaParasite.Size = New System.Drawing.Size(245, 30)
        Me.txtMalariaParasite.TabIndex = 1
        Me.txtMalariaParasite.Text = "        Malaria Parasite Inf. "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSubmit)
        Me.GroupBox3.Controls.Add(Me.lblPushMeNote)
        Me.GroupBox3.Controls.Add(Me.btnPushMe)
        Me.GroupBox3.Location = New System.Drawing.Point(602, 282)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(378, 184)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.OrangeRed
        Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(6, 118)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(133, 60)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "Save"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'lblPushMeNote
        '
        Me.lblPushMeNote.BackColor = System.Drawing.Color.Transparent
        Me.lblPushMeNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPushMeNote.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPushMeNote.ForeColor = System.Drawing.Color.Black
        Me.lblPushMeNote.Location = New System.Drawing.Point(6, 25)
        Me.lblPushMeNote.Name = "lblPushMeNote"
        Me.lblPushMeNote.Size = New System.Drawing.Size(366, 75)
        Me.lblPushMeNote.TabIndex = 30
        Me.lblPushMeNote.Text = "Click The 'Save' button to Store the completed form." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click The 'Next' button to " & _
            "launch the diagnosis Section. "
        '
        'btnPushMe
        '
        Me.btnPushMe.BackColor = System.Drawing.Color.Navy
        Me.btnPushMe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite
        Me.btnPushMe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnPushMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPushMe.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPushMe.Location = New System.Drawing.Point(224, 118)
        Me.btnPushMe.Name = "btnPushMe"
        Me.btnPushMe.Size = New System.Drawing.Size(151, 60)
        Me.btnPushMe.TabIndex = 29
        Me.btnPushMe.Text = "Next"
        Me.btnPushMe.UseVisualStyleBackColor = False
        '
        'tabPatientBioData
        '
        Me.tabPatientBioData.BackColor = System.Drawing.SystemColors.Highlight
        Me.tabPatientBioData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tabPatientBioData.Controls.Add(Me.Label7)
        Me.tabPatientBioData.Controls.Add(Me.txtOthers)
        Me.tabPatientBioData.Controls.Add(Me.GroupBox1)
        Me.tabPatientBioData.Controls.Add(Me.Label6)
        Me.tabPatientBioData.Controls.Add(Me.GroupBox4)
        Me.tabPatientBioData.Controls.Add(Me.GroupBox5)
        Me.tabPatientBioData.Location = New System.Drawing.Point(4, 37)
        Me.tabPatientBioData.Name = "tabPatientBioData"
        Me.tabPatientBioData.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPatientBioData.Size = New System.Drawing.Size(980, 494)
        Me.tabPatientBioData.TabIndex = 1
        Me.tabPatientBioData.Text = "Bio Data"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Adobe Arabic", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label7.Location = New System.Drawing.Point(267, 463)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(710, 28)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "USAID: Protect Your Family and Youself: Get the Free mosquito net for good health" & _
            "y family living...." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtOthers
        '
        Me.txtOthers.BackColor = System.Drawing.SystemColors.Info
        Me.txtOthers.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOthers.ForeColor = System.Drawing.Color.Navy
        Me.txtOthers.Location = New System.Drawing.Point(601, 174)
        Me.txtOthers.Multiline = True
        Me.txtOthers.Name = "txtOthers"
        Me.txtOthers.Size = New System.Drawing.Size(351, 178)
        Me.txtOthers.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblOthers)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FloralWhite
        Me.GroupBox1.Location = New System.Drawing.Point(551, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 402)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Optional"
        '
        'lblOthers
        '
        Me.lblOthers.BackColor = System.Drawing.Color.OrangeRed
        Me.lblOthers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOthers.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOthers.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.lblOthers.Location = New System.Drawing.Point(119, 76)
        Me.lblOthers.Name = "lblOthers"
        Me.lblOthers.Size = New System.Drawing.Size(193, 41)
        Me.lblOthers.TabIndex = 22
        Me.lblOthers.Text = "Others(Specify)"
        Me.lblOthers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label6.Location = New System.Drawing.Point(0, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(993, 28)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "                                       Blood Group | Genotype | Others()" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblGenoType)
        Me.GroupBox4.Controls.Add(Me.cboGenotype)
        Me.GroupBox4.Location = New System.Drawing.Point(169, 243)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(340, 203)
        Me.GroupBox4.TabIndex = 31
        Me.GroupBox4.TabStop = False
        '
        'lblGenoType
        '
        Me.lblGenoType.BackColor = System.Drawing.Color.OrangeRed
        Me.lblGenoType.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenoType.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.lblGenoType.Location = New System.Drawing.Point(98, 54)
        Me.lblGenoType.Name = "lblGenoType"
        Me.lblGenoType.Size = New System.Drawing.Size(133, 37)
        Me.lblGenoType.TabIndex = 20
        Me.lblGenoType.Text = "Genotype"
        Me.lblGenoType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboGenotype
        '
        Me.cboGenotype.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGenotype.ForeColor = System.Drawing.Color.Navy
        Me.cboGenotype.FormattingEnabled = True
        Me.cboGenotype.Items.AddRange(New Object() {"AA", "AS", "SS"})
        Me.cboGenotype.Location = New System.Drawing.Point(40, 126)
        Me.cboGenotype.Name = "cboGenotype"
        Me.cboGenotype.Size = New System.Drawing.Size(248, 39)
        Me.cboGenotype.TabIndex = 27
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cboBloodGroup)
        Me.GroupBox5.Controls.Add(Me.lblBloodGroup)
        Me.GroupBox5.Location = New System.Drawing.Point(169, 44)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(340, 193)
        Me.GroupBox5.TabIndex = 32
        Me.GroupBox5.TabStop = False
        '
        'cboBloodGroup
        '
        Me.cboBloodGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBloodGroup.ForeColor = System.Drawing.Color.Navy
        Me.cboBloodGroup.FormattingEnabled = True
        Me.cboBloodGroup.Items.AddRange(New Object() {"A+", "A-", "B+", "B_", "AB-", "AB+", "O-", "O+"})
        Me.cboBloodGroup.Location = New System.Drawing.Point(40, 113)
        Me.cboBloodGroup.Name = "cboBloodGroup"
        Me.cboBloodGroup.Size = New System.Drawing.Size(248, 39)
        Me.cboBloodGroup.TabIndex = 26
        '
        'lblBloodGroup
        '
        Me.lblBloodGroup.BackColor = System.Drawing.Color.OrangeRed
        Me.lblBloodGroup.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBloodGroup.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.lblBloodGroup.Location = New System.Drawing.Point(74, 41)
        Me.lblBloodGroup.Name = "lblBloodGroup"
        Me.lblBloodGroup.Size = New System.Drawing.Size(164, 37)
        Me.lblBloodGroup.TabIndex = 19
        Me.lblBloodGroup.Text = "Blood Group"
        Me.lblBloodGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabPatientPersonalInfos
        '
        Me.tabPatientPersonalInfos.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.tabPatientPersonalInfos.BackColor = System.Drawing.SystemColors.Highlight
        Me.tabPatientPersonalInfos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabPatientPersonalInfos.Controls.Add(Me.Label8)
        Me.tabPatientPersonalInfos.Controls.Add(Me.computer)
        Me.tabPatientPersonalInfos.Controls.Add(Me.txtAge)
        Me.tabPatientPersonalInfos.Controls.Add(Me.cboSex)
        Me.tabPatientPersonalInfos.Controls.Add(Me.txtSex)
        Me.tabPatientPersonalInfos.Controls.Add(Me.txtLastName)
        Me.tabPatientPersonalInfos.Controls.Add(Me.txtFirstName)
        Me.tabPatientPersonalInfos.Controls.Add(Me.Label3)
        Me.tabPatientPersonalInfos.Controls.Add(Me.lblAge)
        Me.tabPatientPersonalInfos.Controls.Add(Me.lblFirstName)
        Me.tabPatientPersonalInfos.Controls.Add(Me.lblSex)
        Me.tabPatientPersonalInfos.Controls.Add(Me.lblSurname)
        Me.tabPatientPersonalInfos.Controls.Add(Me.ShapeContainer1)
        Me.tabPatientPersonalInfos.Location = New System.Drawing.Point(4, 37)
        Me.tabPatientPersonalInfos.Name = "tabPatientPersonalInfos"
        Me.tabPatientPersonalInfos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPatientPersonalInfos.Size = New System.Drawing.Size(980, 494)
        Me.tabPatientPersonalInfos.TabIndex = 0
        Me.tabPatientPersonalInfos.Text = "Personal Details"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(678, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(216, 19)
        Me.Label8.TabIndex = 33
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'computer
        '
        Me.computer.Image = Global.MalariaDiagnosisSoftware.My.Resources.Resources.background1
        Me.computer.Location = New System.Drawing.Point(635, 139)
        Me.computer.Name = "computer"
        Me.computer.Size = New System.Drawing.Size(320, 225)
        Me.computer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.computer.TabIndex = 32
        Me.computer.TabStop = False
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.ForeColor = System.Drawing.Color.Navy
        Me.txtAge.Location = New System.Drawing.Point(135, 293)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(140, 38)
        Me.txtAge.TabIndex = 25
        '
        'cboSex
        '
        Me.cboSex.AllowDrop = True
        Me.cboSex.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSex.ForeColor = System.Drawing.Color.Navy
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.IntegralHeight = False
        Me.cboSex.ItemHeight = 29
        Me.cboSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboSex.Location = New System.Drawing.Point(135, 200)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(255, 37)
        Me.cboSex.TabIndex = 23
        '
        'txtSex
        '
        Me.txtSex.AutoSize = True
        Me.txtSex.Location = New System.Drawing.Point(377, 150)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(0, 25)
        Me.txtSex.TabIndex = 22
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtLastName.ForeColor = System.Drawing.Color.Navy
        Me.txtLastName.Location = New System.Drawing.Point(209, 110)
        Me.txtLastName.Multiline = True
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(319, 37)
        Me.txtLastName.TabIndex = 3
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.ForeColor = System.Drawing.Color.Navy
        Me.txtFirstName.Location = New System.Drawing.Point(209, 20)
        Me.txtFirstName.Multiline = True
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(319, 37)
        Me.txtFirstName.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("SansSerif", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Label3.Location = New System.Drawing.Point(6, 382)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(973, 111)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'lblAge
        '
        Me.lblAge.BackColor = System.Drawing.Color.OrangeRed
        Me.lblAge.Font = New System.Drawing.Font("Lucida Fax", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.lblAge.Location = New System.Drawing.Point(53, 293)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(76, 38)
        Me.lblAge.TabIndex = 10
        Me.lblAge.Text = "Age"
        Me.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFirstName
        '
        Me.lblFirstName.BackColor = System.Drawing.Color.OrangeRed
        Me.lblFirstName.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.lblFirstName.Location = New System.Drawing.Point(54, 20)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(149, 37)
        Me.lblFirstName.TabIndex = 3
        Me.lblFirstName.Text = "First Name"
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSex
        '
        Me.lblSex.AllowDrop = True
        Me.lblSex.BackColor = System.Drawing.Color.OrangeRed
        Me.lblSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSex.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.lblSex.Location = New System.Drawing.Point(54, 200)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(75, 37)
        Me.lblSex.TabIndex = 8
        Me.lblSex.Text = "Sex"
        Me.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSurname
        '
        Me.lblSurname.BackColor = System.Drawing.Color.OrangeRed
        Me.lblSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSurname.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.lblSurname.Location = New System.Drawing.Point(54, 110)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(149, 37)
        Me.lblSurname.TabIndex = 1
        Me.lblSurname.Text = "Surname"
        Me.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.rectBlue, Me.RectangleShape4, Me.rectRed, Me.rectGreen, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(972, 486)
        Me.ShapeContainer1.TabIndex = 31
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.White
        Me.RectangleShape3.BorderColor = System.Drawing.Color.Yellow
        Me.RectangleShape3.CornerRadius = 25
        Me.RectangleShape3.Location = New System.Drawing.Point(872, 40)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(68, 67)
        '
        'rectBlue
        '
        Me.rectBlue.BackColor = System.Drawing.Color.Yellow
        Me.rectBlue.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rectBlue.BorderColor = System.Drawing.Color.White
        Me.rectBlue.CornerRadius = 14
        Me.rectBlue.Location = New System.Drawing.Point(881, 47)
        Me.rectBlue.Name = "rectBlue"
        Me.rectBlue.Size = New System.Drawing.Size(50, 28)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BackColor = System.Drawing.Color.White
        Me.RectangleShape4.BorderColor = System.Drawing.Color.Red
        Me.RectangleShape4.CornerRadius = 25
        Me.RectangleShape4.Location = New System.Drawing.Point(634, 40)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(68, 67)
        '
        'rectRed
        '
        Me.rectRed.BackColor = System.Drawing.Color.Red
        Me.rectRed.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rectRed.BorderColor = System.Drawing.Color.White
        Me.rectRed.CornerRadius = 14
        Me.rectRed.Location = New System.Drawing.Point(643, 47)
        Me.rectRed.Name = "rectRed"
        Me.rectRed.Size = New System.Drawing.Size(50, 29)
        '
        'rectGreen
        '
        Me.rectGreen.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.rectGreen.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rectGreen.BorderColor = System.Drawing.Color.White
        Me.rectGreen.CornerRadius = 14
        Me.rectGreen.Location = New System.Drawing.Point(763, 47)
        Me.rectGreen.Name = "rectGreen"
        Me.rectGreen.Size = New System.Drawing.Size(50, 28)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.White
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Green
        Me.RectangleShape1.CornerRadius = 25
        Me.RectangleShape1.Location = New System.Drawing.Point(754, 39)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(68, 67)
        '
        'tabClinicianPatient
        '
        Me.tabClinicianPatient.AllowDrop = True
        Me.tabClinicianPatient.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabClinicianPatient.Controls.Add(Me.tabPatientPersonalInfos)
        Me.tabClinicianPatient.Controls.Add(Me.tabPatientBioData)
        Me.tabClinicianPatient.Controls.Add(Me.tablabTech)
        Me.tabClinicianPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabClinicianPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabClinicianPatient.Location = New System.Drawing.Point(211, 189)
        Me.tabClinicianPatient.Margin = New System.Windows.Forms.Padding(5)
        Me.tabClinicianPatient.Name = "tabClinicianPatient"
        Me.tabClinicianPatient.Padding = New System.Drawing.Point(0, 0)
        Me.tabClinicianPatient.SelectedIndex = 0
        Me.tabClinicianPatient.Size = New System.Drawing.Size(988, 535)
        Me.tabClinicianPatient.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabClinicianPatient.TabIndex = 3
        '
        'Green
        '
        Me.Green.Enabled = True
        Me.Green.Interval = 1
        '
        'Red
        '
        Me.Red.Enabled = True
        Me.Red.Interval = 1
        '
        'Blue
        '
        Me.Blue.Enabled = True
        Me.Blue.Interval = 1
        '
        'frmPatientInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImage = Global.MalariaDiagnosisSoftware.My.Resources.Resources.background2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1372, 751)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblSubTitle2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSubTitle1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.tabClinicianPatient)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Cornsilk
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPatientInfo"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDS Form Collection"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tablabTech.ResumeLayout(False)
        Me.tablabTech.PerformLayout()
        CType(Me.PicLab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.tabPatientBioData.ResumeLayout(False)
        Me.tabPatientBioData.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.tabPatientPersonalInfos.ResumeLayout(False)
        Me.tabPatientPersonalInfos.PerformLayout()
        CType(Me.computer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabClinicianPatient.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblSubTitle1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSubTitle2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tablabTech As System.Windows.Forms.TabPage
    Friend WithEvents txtClinician As System.Windows.Forms.TextBox
    Friend WithEvents lblClinician As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTerms_Conditions As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PicLab As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblInvestigation As System.Windows.Forms.Label
    Friend WithEvents cboInvestigation As System.Windows.Forms.ComboBox
    Friend WithEvents lblClinicianDiagnosisTarget As System.Windows.Forms.Label
    Friend WithEvents txtMalariaParasite As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblPushMeNote As System.Windows.Forms.Label
    Friend WithEvents btnPushMe As System.Windows.Forms.Button
    Friend WithEvents tabPatientBioData As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtOthers As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblOthers As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblGenoType As System.Windows.Forms.Label
    Friend WithEvents cboGenotype As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cboBloodGroup As System.Windows.Forms.ComboBox
    Friend WithEvents lblBloodGroup As System.Windows.Forms.Label
    Friend WithEvents tabPatientPersonalInfos As System.Windows.Forms.TabPage
    Friend WithEvents txtAge As System.Windows.Forms.NumericUpDown
    Friend WithEvents cboSex As System.Windows.Forms.ComboBox
    Friend WithEvents txtSex As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents tabClinicianPatient As System.Windows.Forms.TabControl
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rectRed As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rectGreen As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Green As System.Windows.Forms.Timer
    Friend WithEvents Red As System.Windows.Forms.Timer
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rectBlue As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Blue As System.Windows.Forms.Timer
    Friend WithEvents computer As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
