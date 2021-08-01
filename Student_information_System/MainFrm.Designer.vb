<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Close_btn = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.MaintenancePanel = New System.Windows.Forms.Panel()
        Me.UserBtn = New System.Windows.Forms.Button()
        Me.SubjectBtn = New System.Windows.Forms.Button()
        Me.Grading_PeriodBtn = New System.Windows.Forms.Button()
        Me.SchoolyearBtn = New System.Windows.Forms.Button()
        Me.SectionBtn = New System.Windows.Forms.Button()
        Me.Maintenancebtn = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.RecordsPanel = New System.Windows.Forms.Panel()
        Me.ArchiveBtn = New System.Windows.Forms.Button()
        Me.ClassListBtn = New System.Windows.Forms.Button()
        Me.EnrollmentRecordBtn = New System.Windows.Forms.Button()
        Me.RecordsBtn = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.InputDataPanel = New System.Windows.Forms.Panel()
        Me.TeacherSubjectBtn = New System.Windows.Forms.Button()
        Me.AddTeacherBtn = New System.Windows.Forms.Button()
        Me.AddStudentBtn = New System.Windows.Forms.Button()
        Me.InputDatabtn = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TransactionPanel = New System.Windows.Forms.Panel()
        Me.GradingBtn = New System.Windows.Forms.Button()
        Me.SMSbtn = New System.Windows.Forms.Button()
        Me.EnrollmentBtn = New System.Windows.Forms.Button()
        Me.TransactionBtn = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DashboardBtn = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.FormPanel = New System.Windows.Forms.Panel()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.Close_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.MaintenancePanel.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.RecordsPanel.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.InputDataPanel.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TransactionPanel.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 1
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Close_btn)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(997, 28)
        Me.Panel1.TabIndex = 12
        '
        'Close_btn
        '
        Me.Close_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close_btn.Dock = System.Windows.Forms.DockStyle.Right
        Me.Close_btn.Image = Global.Student_information_System.My.Resources.Resources.close_window_35px
        Me.Close_btn.Location = New System.Drawing.Point(961, 0)
        Me.Close_btn.Name = "Close_btn"
        Me.Close_btn.Size = New System.Drawing.Size(36, 28)
        Me.Close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Close_btn.TabIndex = 11
        Me.Close_btn.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 21)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Student Information System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.btnlogout)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(251, 746)
        Me.Panel2.TabIndex = 13
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 153)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(251, 548)
        Me.Panel5.TabIndex = 8
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel11)
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.Panel6)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(251, 548)
        Me.Panel7.TabIndex = 21
        '
        'Panel11
        '
        Me.Panel11.AutoScroll = True
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel11.Controls.Add(Me.MaintenancePanel)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 202)
        Me.Panel11.MaximumSize = New System.Drawing.Size(250, 290)
        Me.Panel11.MinimumSize = New System.Drawing.Size(250, 50)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(250, 50)
        Me.Panel11.TabIndex = 23
        '
        'MaintenancePanel
        '
        Me.MaintenancePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.MaintenancePanel.Controls.Add(Me.UserBtn)
        Me.MaintenancePanel.Controls.Add(Me.SubjectBtn)
        Me.MaintenancePanel.Controls.Add(Me.Grading_PeriodBtn)
        Me.MaintenancePanel.Controls.Add(Me.SchoolyearBtn)
        Me.MaintenancePanel.Controls.Add(Me.SectionBtn)
        Me.MaintenancePanel.Controls.Add(Me.Maintenancebtn)
        Me.MaintenancePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaintenancePanel.Location = New System.Drawing.Point(0, 0)
        Me.MaintenancePanel.MaximumSize = New System.Drawing.Size(250, 290)
        Me.MaintenancePanel.MinimumSize = New System.Drawing.Size(250, 50)
        Me.MaintenancePanel.Name = "MaintenancePanel"
        Me.MaintenancePanel.Size = New System.Drawing.Size(250, 50)
        Me.MaintenancePanel.TabIndex = 14
        '
        'UserBtn
        '
        Me.UserBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.UserBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.UserBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.UserBtn.FlatAppearance.BorderSize = 0
        Me.UserBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.UserBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.UserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UserBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserBtn.ForeColor = System.Drawing.Color.White
        Me.UserBtn.Image = CType(resources.GetObject("UserBtn.Image"), System.Drawing.Image)
        Me.UserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UserBtn.Location = New System.Drawing.Point(0, 239)
        Me.UserBtn.Name = "UserBtn"
        Me.UserBtn.Padding = New System.Windows.Forms.Padding(15, 5, 5, 5)
        Me.UserBtn.Size = New System.Drawing.Size(250, 47)
        Me.UserBtn.TabIndex = 14
        Me.UserBtn.Text = "User Accounts"
        Me.UserBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UserBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.UserBtn.UseVisualStyleBackColor = False
        '
        'SubjectBtn
        '
        Me.SubjectBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.SubjectBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SubjectBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.SubjectBtn.FlatAppearance.BorderSize = 0
        Me.SubjectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.SubjectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.SubjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubjectBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectBtn.ForeColor = System.Drawing.Color.White
        Me.SubjectBtn.Image = CType(resources.GetObject("SubjectBtn.Image"), System.Drawing.Image)
        Me.SubjectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SubjectBtn.Location = New System.Drawing.Point(0, 192)
        Me.SubjectBtn.Name = "SubjectBtn"
        Me.SubjectBtn.Padding = New System.Windows.Forms.Padding(15, 5, 5, 5)
        Me.SubjectBtn.Size = New System.Drawing.Size(250, 47)
        Me.SubjectBtn.TabIndex = 11
        Me.SubjectBtn.Text = "Subject"
        Me.SubjectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SubjectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SubjectBtn.UseVisualStyleBackColor = False
        '
        'Grading_PeriodBtn
        '
        Me.Grading_PeriodBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Grading_PeriodBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Grading_PeriodBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Grading_PeriodBtn.FlatAppearance.BorderSize = 0
        Me.Grading_PeriodBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Grading_PeriodBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Grading_PeriodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Grading_PeriodBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grading_PeriodBtn.ForeColor = System.Drawing.Color.White
        Me.Grading_PeriodBtn.Image = CType(resources.GetObject("Grading_PeriodBtn.Image"), System.Drawing.Image)
        Me.Grading_PeriodBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Grading_PeriodBtn.Location = New System.Drawing.Point(0, 145)
        Me.Grading_PeriodBtn.Name = "Grading_PeriodBtn"
        Me.Grading_PeriodBtn.Padding = New System.Windows.Forms.Padding(15, 5, 5, 5)
        Me.Grading_PeriodBtn.Size = New System.Drawing.Size(250, 47)
        Me.Grading_PeriodBtn.TabIndex = 13
        Me.Grading_PeriodBtn.Text = "Grading Period"
        Me.Grading_PeriodBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Grading_PeriodBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Grading_PeriodBtn.UseVisualStyleBackColor = False
        '
        'SchoolyearBtn
        '
        Me.SchoolyearBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.SchoolyearBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SchoolyearBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.SchoolyearBtn.FlatAppearance.BorderSize = 0
        Me.SchoolyearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.SchoolyearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.SchoolyearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SchoolyearBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchoolyearBtn.ForeColor = System.Drawing.Color.White
        Me.SchoolyearBtn.Image = CType(resources.GetObject("SchoolyearBtn.Image"), System.Drawing.Image)
        Me.SchoolyearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SchoolyearBtn.Location = New System.Drawing.Point(0, 98)
        Me.SchoolyearBtn.Name = "SchoolyearBtn"
        Me.SchoolyearBtn.Padding = New System.Windows.Forms.Padding(15, 5, 5, 5)
        Me.SchoolyearBtn.Size = New System.Drawing.Size(250, 47)
        Me.SchoolyearBtn.TabIndex = 10
        Me.SchoolyearBtn.Text = "School Year"
        Me.SchoolyearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SchoolyearBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SchoolyearBtn.UseVisualStyleBackColor = False
        '
        'SectionBtn
        '
        Me.SectionBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.SectionBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SectionBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.SectionBtn.FlatAppearance.BorderSize = 0
        Me.SectionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.SectionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.SectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SectionBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectionBtn.ForeColor = System.Drawing.Color.White
        Me.SectionBtn.Image = CType(resources.GetObject("SectionBtn.Image"), System.Drawing.Image)
        Me.SectionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SectionBtn.Location = New System.Drawing.Point(0, 51)
        Me.SectionBtn.Name = "SectionBtn"
        Me.SectionBtn.Padding = New System.Windows.Forms.Padding(15, 5, 5, 5)
        Me.SectionBtn.Size = New System.Drawing.Size(250, 47)
        Me.SectionBtn.TabIndex = 9
        Me.SectionBtn.Text = "Section"
        Me.SectionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SectionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SectionBtn.UseVisualStyleBackColor = False
        '
        'Maintenancebtn
        '
        Me.Maintenancebtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Maintenancebtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Maintenancebtn.FlatAppearance.BorderSize = 0
        Me.Maintenancebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Maintenancebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Maintenancebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Maintenancebtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Maintenancebtn.ForeColor = System.Drawing.Color.White
        Me.Maintenancebtn.Image = Global.Student_information_System.My.Resources.Resources.settings_35px
        Me.Maintenancebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Maintenancebtn.Location = New System.Drawing.Point(0, 0)
        Me.Maintenancebtn.Name = "Maintenancebtn"
        Me.Maintenancebtn.Padding = New System.Windows.Forms.Padding(5)
        Me.Maintenancebtn.Size = New System.Drawing.Size(250, 51)
        Me.Maintenancebtn.TabIndex = 7
        Me.Maintenancebtn.Text = "Maintenance"
        Me.Maintenancebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Maintenancebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Maintenancebtn.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel10.Controls.Add(Me.RecordsPanel)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 152)
        Me.Panel10.MaximumSize = New System.Drawing.Size(250, 195)
        Me.Panel10.MinimumSize = New System.Drawing.Size(250, 50)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(250, 50)
        Me.Panel10.TabIndex = 22
        '
        'RecordsPanel
        '
        Me.RecordsPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.RecordsPanel.Controls.Add(Me.ArchiveBtn)
        Me.RecordsPanel.Controls.Add(Me.ClassListBtn)
        Me.RecordsPanel.Controls.Add(Me.EnrollmentRecordBtn)
        Me.RecordsPanel.Controls.Add(Me.RecordsBtn)
        Me.RecordsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RecordsPanel.Location = New System.Drawing.Point(0, 0)
        Me.RecordsPanel.MaximumSize = New System.Drawing.Size(250, 195)
        Me.RecordsPanel.MinimumSize = New System.Drawing.Size(250, 50)
        Me.RecordsPanel.Name = "RecordsPanel"
        Me.RecordsPanel.Size = New System.Drawing.Size(250, 50)
        Me.RecordsPanel.TabIndex = 17
        '
        'ArchiveBtn
        '
        Me.ArchiveBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ArchiveBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ArchiveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ArchiveBtn.FlatAppearance.BorderSize = 0
        Me.ArchiveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ArchiveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ArchiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ArchiveBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchiveBtn.ForeColor = System.Drawing.Color.White
        Me.ArchiveBtn.Image = CType(resources.GetObject("ArchiveBtn.Image"), System.Drawing.Image)
        Me.ArchiveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ArchiveBtn.Location = New System.Drawing.Point(0, 145)
        Me.ArchiveBtn.Name = "ArchiveBtn"
        Me.ArchiveBtn.Padding = New System.Windows.Forms.Padding(15, 5, 5, 5)
        Me.ArchiveBtn.Size = New System.Drawing.Size(250, 47)
        Me.ArchiveBtn.TabIndex = 10
        Me.ArchiveBtn.Text = "Archive"
        Me.ArchiveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ArchiveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ArchiveBtn.UseVisualStyleBackColor = False
        '
        'ClassListBtn
        '
        Me.ClassListBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClassListBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ClassListBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClassListBtn.FlatAppearance.BorderSize = 0
        Me.ClassListBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClassListBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClassListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClassListBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassListBtn.ForeColor = System.Drawing.Color.White
        Me.ClassListBtn.Image = CType(resources.GetObject("ClassListBtn.Image"), System.Drawing.Image)
        Me.ClassListBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClassListBtn.Location = New System.Drawing.Point(0, 98)
        Me.ClassListBtn.Name = "ClassListBtn"
        Me.ClassListBtn.Padding = New System.Windows.Forms.Padding(15, 5, 5, 5)
        Me.ClassListBtn.Size = New System.Drawing.Size(250, 47)
        Me.ClassListBtn.TabIndex = 9
        Me.ClassListBtn.Text = "Class List"
        Me.ClassListBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClassListBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ClassListBtn.UseVisualStyleBackColor = False
        '
        'EnrollmentRecordBtn
        '
        Me.EnrollmentRecordBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.EnrollmentRecordBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.EnrollmentRecordBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.EnrollmentRecordBtn.FlatAppearance.BorderSize = 0
        Me.EnrollmentRecordBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.EnrollmentRecordBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.EnrollmentRecordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EnrollmentRecordBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnrollmentRecordBtn.ForeColor = System.Drawing.Color.White
        Me.EnrollmentRecordBtn.Image = CType(resources.GetObject("EnrollmentRecordBtn.Image"), System.Drawing.Image)
        Me.EnrollmentRecordBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EnrollmentRecordBtn.Location = New System.Drawing.Point(0, 51)
        Me.EnrollmentRecordBtn.Name = "EnrollmentRecordBtn"
        Me.EnrollmentRecordBtn.Padding = New System.Windows.Forms.Padding(15, 5, 5, 5)
        Me.EnrollmentRecordBtn.Size = New System.Drawing.Size(250, 47)
        Me.EnrollmentRecordBtn.TabIndex = 8
        Me.EnrollmentRecordBtn.Text = "Enrollment Record"
        Me.EnrollmentRecordBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EnrollmentRecordBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EnrollmentRecordBtn.UseVisualStyleBackColor = False
        '
        'RecordsBtn
        '
        Me.RecordsBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.RecordsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.RecordsBtn.FlatAppearance.BorderSize = 0
        Me.RecordsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.RecordsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.RecordsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RecordsBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordsBtn.ForeColor = System.Drawing.Color.White
        Me.RecordsBtn.Image = Global.Student_information_System.My.Resources.Resources.moleskine_35px
        Me.RecordsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RecordsBtn.Location = New System.Drawing.Point(0, 0)
        Me.RecordsBtn.Name = "RecordsBtn"
        Me.RecordsBtn.Padding = New System.Windows.Forms.Padding(5)
        Me.RecordsBtn.Size = New System.Drawing.Size(250, 51)
        Me.RecordsBtn.TabIndex = 7
        Me.RecordsBtn.Text = "Records"
        Me.RecordsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RecordsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RecordsBtn.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.InputDataPanel)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 101)
        Me.Panel9.MaximumSize = New System.Drawing.Size(250, 200)
        Me.Panel9.MinimumSize = New System.Drawing.Size(250, 50)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(250, 51)
        Me.Panel9.TabIndex = 21
        '
        'InputDataPanel
        '
        Me.InputDataPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.InputDataPanel.Controls.Add(Me.TeacherSubjectBtn)
        Me.InputDataPanel.Controls.Add(Me.AddTeacherBtn)
        Me.InputDataPanel.Controls.Add(Me.AddStudentBtn)
        Me.InputDataPanel.Controls.Add(Me.InputDatabtn)
        Me.InputDataPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InputDataPanel.Location = New System.Drawing.Point(0, 0)
        Me.InputDataPanel.MaximumSize = New System.Drawing.Size(250, 200)
        Me.InputDataPanel.MinimumSize = New System.Drawing.Size(250, 50)
        Me.InputDataPanel.Name = "InputDataPanel"
        Me.InputDataPanel.Size = New System.Drawing.Size(250, 51)
        Me.InputDataPanel.TabIndex = 16
        '
        'TeacherSubjectBtn
        '
        Me.TeacherSubjectBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.TeacherSubjectBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.TeacherSubjectBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.TeacherSubjectBtn.FlatAppearance.BorderSize = 0
        Me.TeacherSubjectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.TeacherSubjectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TeacherSubjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TeacherSubjectBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherSubjectBtn.ForeColor = System.Drawing.Color.White
        Me.TeacherSubjectBtn.Image = CType(resources.GetObject("TeacherSubjectBtn.Image"), System.Drawing.Image)
        Me.TeacherSubjectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TeacherSubjectBtn.Location = New System.Drawing.Point(0, 145)
        Me.TeacherSubjectBtn.Name = "TeacherSubjectBtn"
        Me.TeacherSubjectBtn.Padding = New System.Windows.Forms.Padding(15, 5, 5, 5)
        Me.TeacherSubjectBtn.Size = New System.Drawing.Size(250, 47)
        Me.TeacherSubjectBtn.TabIndex = 10
        Me.TeacherSubjectBtn.Text = "Teacher's  Subject"
        Me.TeacherSubjectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TeacherSubjectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TeacherSubjectBtn.UseVisualStyleBackColor = False
        '
        'AddTeacherBtn
        '
        Me.AddTeacherBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.AddTeacherBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddTeacherBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.AddTeacherBtn.FlatAppearance.BorderSize = 0
        Me.AddTeacherBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.AddTeacherBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.AddTeacherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddTeacherBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddTeacherBtn.ForeColor = System.Drawing.Color.White
        Me.AddTeacherBtn.Image = CType(resources.GetObject("AddTeacherBtn.Image"), System.Drawing.Image)
        Me.AddTeacherBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddTeacherBtn.Location = New System.Drawing.Point(0, 98)
        Me.AddTeacherBtn.Name = "AddTeacherBtn"
        Me.AddTeacherBtn.Padding = New System.Windows.Forms.Padding(15, 5, 5, 5)
        Me.AddTeacherBtn.Size = New System.Drawing.Size(250, 47)
        Me.AddTeacherBtn.TabIndex = 9
        Me.AddTeacherBtn.Text = "Teacher"
        Me.AddTeacherBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddTeacherBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddTeacherBtn.UseVisualStyleBackColor = False
        '
        'AddStudentBtn
        '
        Me.AddStudentBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.AddStudentBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddStudentBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.AddStudentBtn.FlatAppearance.BorderSize = 0
        Me.AddStudentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.AddStudentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.AddStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddStudentBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStudentBtn.ForeColor = System.Drawing.Color.White
        Me.AddStudentBtn.Image = CType(resources.GetObject("AddStudentBtn.Image"), System.Drawing.Image)
        Me.AddStudentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddStudentBtn.Location = New System.Drawing.Point(0, 51)
        Me.AddStudentBtn.Name = "AddStudentBtn"
        Me.AddStudentBtn.Padding = New System.Windows.Forms.Padding(15, 5, 5, 5)
        Me.AddStudentBtn.Size = New System.Drawing.Size(250, 47)
        Me.AddStudentBtn.TabIndex = 8
        Me.AddStudentBtn.Text = "Student"
        Me.AddStudentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddStudentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AddStudentBtn.UseVisualStyleBackColor = False
        '
        'InputDatabtn
        '
        Me.InputDatabtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.InputDatabtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.InputDatabtn.FlatAppearance.BorderSize = 0
        Me.InputDatabtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.InputDatabtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.InputDatabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InputDatabtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputDatabtn.ForeColor = System.Drawing.Color.White
        Me.InputDatabtn.Image = Global.Student_information_System.My.Resources.Resources.insert_35px
        Me.InputDatabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.InputDatabtn.Location = New System.Drawing.Point(0, 0)
        Me.InputDatabtn.Name = "InputDatabtn"
        Me.InputDatabtn.Padding = New System.Windows.Forms.Padding(5)
        Me.InputDatabtn.Size = New System.Drawing.Size(250, 51)
        Me.InputDatabtn.TabIndex = 7
        Me.InputDatabtn.Text = "Input Data"
        Me.InputDatabtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.InputDatabtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.InputDatabtn.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.TransactionPanel)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 51)
        Me.Panel6.MaximumSize = New System.Drawing.Size(250, 200)
        Me.Panel6.MinimumSize = New System.Drawing.Size(250, 50)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(250, 50)
        Me.Panel6.TabIndex = 20
        '
        'TransactionPanel
        '
        Me.TransactionPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.TransactionPanel.Controls.Add(Me.GradingBtn)
        Me.TransactionPanel.Controls.Add(Me.SMSbtn)
        Me.TransactionPanel.Controls.Add(Me.EnrollmentBtn)
        Me.TransactionPanel.Controls.Add(Me.TransactionBtn)
        Me.TransactionPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TransactionPanel.Location = New System.Drawing.Point(0, 0)
        Me.TransactionPanel.MaximumSize = New System.Drawing.Size(250, 200)
        Me.TransactionPanel.MinimumSize = New System.Drawing.Size(250, 50)
        Me.TransactionPanel.Name = "TransactionPanel"
        Me.TransactionPanel.Size = New System.Drawing.Size(250, 50)
        Me.TransactionPanel.TabIndex = 18
        '
        'GradingBtn
        '
        Me.GradingBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.GradingBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.GradingBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.GradingBtn.FlatAppearance.BorderSize = 0
        Me.GradingBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.GradingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.GradingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GradingBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradingBtn.ForeColor = System.Drawing.Color.White
        Me.GradingBtn.Image = CType(resources.GetObject("GradingBtn.Image"), System.Drawing.Image)
        Me.GradingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GradingBtn.Location = New System.Drawing.Point(0, 145)
        Me.GradingBtn.Name = "GradingBtn"
        Me.GradingBtn.Padding = New System.Windows.Forms.Padding(15, 5, 5, 5)
        Me.GradingBtn.Size = New System.Drawing.Size(250, 47)
        Me.GradingBtn.TabIndex = 9
        Me.GradingBtn.Text = "Grading"
        Me.GradingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GradingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GradingBtn.UseVisualStyleBackColor = False
        '
        'SMSbtn
        '
        Me.SMSbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.SMSbtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SMSbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.SMSbtn.FlatAppearance.BorderSize = 0
        Me.SMSbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.SMSbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.SMSbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SMSbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SMSbtn.ForeColor = System.Drawing.Color.White
        Me.SMSbtn.Image = CType(resources.GetObject("SMSbtn.Image"), System.Drawing.Image)
        Me.SMSbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SMSbtn.Location = New System.Drawing.Point(0, 98)
        Me.SMSbtn.Name = "SMSbtn"
        Me.SMSbtn.Padding = New System.Windows.Forms.Padding(15, 5, 5, 5)
        Me.SMSbtn.Size = New System.Drawing.Size(250, 47)
        Me.SMSbtn.TabIndex = 12
        Me.SMSbtn.Text = "SMS"
        Me.SMSbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SMSbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SMSbtn.UseVisualStyleBackColor = False
        '
        'EnrollmentBtn
        '
        Me.EnrollmentBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.EnrollmentBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.EnrollmentBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.EnrollmentBtn.FlatAppearance.BorderSize = 0
        Me.EnrollmentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.EnrollmentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.EnrollmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EnrollmentBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnrollmentBtn.ForeColor = System.Drawing.Color.White
        Me.EnrollmentBtn.Image = CType(resources.GetObject("EnrollmentBtn.Image"), System.Drawing.Image)
        Me.EnrollmentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EnrollmentBtn.Location = New System.Drawing.Point(0, 51)
        Me.EnrollmentBtn.Name = "EnrollmentBtn"
        Me.EnrollmentBtn.Padding = New System.Windows.Forms.Padding(15, 5, 5, 5)
        Me.EnrollmentBtn.Size = New System.Drawing.Size(250, 47)
        Me.EnrollmentBtn.TabIndex = 8
        Me.EnrollmentBtn.Text = "Enrollment"
        Me.EnrollmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EnrollmentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EnrollmentBtn.UseVisualStyleBackColor = False
        '
        'TransactionBtn
        '
        Me.TransactionBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.TransactionBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.TransactionBtn.FlatAppearance.BorderSize = 0
        Me.TransactionBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.TransactionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TransactionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TransactionBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionBtn.ForeColor = System.Drawing.Color.White
        Me.TransactionBtn.Image = Global.Student_information_System.My.Resources.Resources.process_35px
        Me.TransactionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TransactionBtn.Location = New System.Drawing.Point(0, 0)
        Me.TransactionBtn.Name = "TransactionBtn"
        Me.TransactionBtn.Padding = New System.Windows.Forms.Padding(5)
        Me.TransactionBtn.Size = New System.Drawing.Size(250, 51)
        Me.TransactionBtn.TabIndex = 7
        Me.TransactionBtn.Text = "Transactions"
        Me.TransactionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TransactionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TransactionBtn.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Panel3)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.MaximumSize = New System.Drawing.Size(250, 148)
        Me.Panel8.MinimumSize = New System.Drawing.Size(250, 50)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(250, 51)
        Me.Panel8.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel3.Controls.Add(Me.DashboardBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.MaximumSize = New System.Drawing.Size(250, 148)
        Me.Panel3.MinimumSize = New System.Drawing.Size(250, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(250, 50)
        Me.Panel3.TabIndex = 19
        '
        'DashboardBtn
        '
        Me.DashboardBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.DashboardBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.DashboardBtn.FlatAppearance.BorderSize = 0
        Me.DashboardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.DashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashboardBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashboardBtn.ForeColor = System.Drawing.Color.White
        Me.DashboardBtn.Image = Global.Student_information_System.My.Resources.Resources.dashboard_35px
        Me.DashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardBtn.Location = New System.Drawing.Point(0, 0)
        Me.DashboardBtn.Name = "DashboardBtn"
        Me.DashboardBtn.Padding = New System.Windows.Forms.Padding(5)
        Me.DashboardBtn.Size = New System.Drawing.Size(250, 50)
        Me.DashboardBtn.TabIndex = 7
        Me.DashboardBtn.Text = "Dashboard"
        Me.DashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DashboardBtn.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(251, 153)
        Me.Panel4.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Welcome"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.Student_information_System.My.Resources.Resources.username_icon_png_74
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(251, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnlogout
        '
        Me.btnlogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnlogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnlogout.FlatAppearance.BorderSize = 0
        Me.btnlogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.btnlogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogout.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogout.ForeColor = System.Drawing.Color.White
        Me.btnlogout.Image = Global.Student_information_System.My.Resources.Resources.exit_35px
        Me.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogout.Location = New System.Drawing.Point(0, 701)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Padding = New System.Windows.Forms.Padding(5)
        Me.btnlogout.Size = New System.Drawing.Size(251, 45)
        Me.btnlogout.TabIndex = 5
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 15
        '
        'Timer2
        '
        Me.Timer2.Interval = 15
        '
        'Timer3
        '
        Me.Timer3.Interval = 15
        '
        'Timer4
        '
        Me.Timer4.Interval = 15
        '
        'FormPanel
        '
        Me.FormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormPanel.Location = New System.Drawing.Point(251, 28)
        Me.FormPanel.Name = "FormPanel"
        Me.FormPanel.Size = New System.Drawing.Size(746, 746)
        Me.FormPanel.TabIndex = 14
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(997, 774)
        Me.Controls.Add(Me.FormPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainFrm"
        Me.Text = "MainFrm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Close_btn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.MaintenancePanel.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.RecordsPanel.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.InputDataPanel.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.TransactionPanel.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Close_btn As System.Windows.Forms.PictureBox
    Friend WithEvents MaintenancePanel As System.Windows.Forms.Panel
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Maintenancebtn As System.Windows.Forms.Button
    Friend WithEvents SubjectBtn As System.Windows.Forms.Button
    Friend WithEvents SchoolyearBtn As System.Windows.Forms.Button
    Friend WithEvents SectionBtn As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents InputDataPanel As System.Windows.Forms.Panel
    Friend WithEvents AddTeacherBtn As System.Windows.Forms.Button
    Friend WithEvents AddStudentBtn As System.Windows.Forms.Button
    Friend WithEvents InputDatabtn As System.Windows.Forms.Button
    Friend WithEvents RecordsPanel As System.Windows.Forms.Panel
    Friend WithEvents ArchiveBtn As System.Windows.Forms.Button
    Friend WithEvents ClassListBtn As System.Windows.Forms.Button
    Friend WithEvents EnrollmentRecordBtn As System.Windows.Forms.Button
    Friend WithEvents RecordsBtn As System.Windows.Forms.Button
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents TransactionPanel As System.Windows.Forms.Panel
    Friend WithEvents GradingBtn As System.Windows.Forms.Button
    Friend WithEvents EnrollmentBtn As System.Windows.Forms.Button
    Friend WithEvents TransactionBtn As System.Windows.Forms.Button
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DashboardBtn As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents FormPanel As System.Windows.Forms.Panel
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents TeacherSubjectBtn As System.Windows.Forms.Button
    Friend WithEvents Grading_PeriodBtn As System.Windows.Forms.Button
    Friend WithEvents SMSbtn As System.Windows.Forms.Button
    Friend WithEvents UserBtn As System.Windows.Forms.Button
End Class
