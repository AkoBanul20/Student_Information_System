﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherViewGradesFrm
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
        Me.LoadBtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PdfBtn = New System.Windows.Forms.Button()
        Me.Close_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gradelevel_cmb = New System.Windows.Forms.ComboBox()
        Me.section_cmb = New System.Windows.Forms.ComboBox()
        Me.subjectcmb = New System.Windows.Forms.ComboBox()
        Me.School_year_label = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GradeReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoadBtn
        '
        Me.LoadBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.LoadBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoadBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.LoadBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.LoadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.LoadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.LoadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadBtn.ForeColor = System.Drawing.Color.White
        Me.LoadBtn.Location = New System.Drawing.Point(545, 5)
        Me.LoadBtn.Name = "LoadBtn"
        Me.LoadBtn.Size = New System.Drawing.Size(88, 25)
        Me.LoadBtn.TabIndex = 3
        Me.LoadBtn.Text = "Load"
        Me.LoadBtn.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PdfBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(5, 489)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(728, 26)
        Me.Panel3.TabIndex = 15
        '
        'PdfBtn
        '
        Me.PdfBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.PdfBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PdfBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.PdfBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.PdfBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.PdfBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.PdfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PdfBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PdfBtn.ForeColor = System.Drawing.Color.White
        Me.PdfBtn.Location = New System.Drawing.Point(0, 0)
        Me.PdfBtn.Name = "PdfBtn"
        Me.PdfBtn.Size = New System.Drawing.Size(107, 26)
        Me.PdfBtn.TabIndex = 4
        Me.PdfBtn.Text = "Export to PDf"
        Me.PdfBtn.UseVisualStyleBackColor = False
        Me.PdfBtn.Visible = False
        '
        'Close_btn
        '
        Me.Close_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Close_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close_btn.Dock = System.Windows.Forms.DockStyle.Right
        Me.Close_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_btn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close_btn.ForeColor = System.Drawing.Color.White
        Me.Close_btn.Location = New System.Drawing.Point(633, 5)
        Me.Close_btn.Name = "Close_btn"
        Me.Close_btn.Size = New System.Drawing.Size(90, 25)
        Me.Close_btn.TabIndex = 1
        Me.Close_btn.Text = "Close"
        Me.Close_btn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grades"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Filter By:"
        '
        'gradelevel_cmb
        '
        Me.gradelevel_cmb.Dock = System.Windows.Forms.DockStyle.Right
        Me.gradelevel_cmb.FormattingEnabled = True
        Me.gradelevel_cmb.Items.AddRange(New Object() {"7", "8", "9", "10"})
        Me.gradelevel_cmb.Location = New System.Drawing.Point(66, 0)
        Me.gradelevel_cmb.Name = "gradelevel_cmb"
        Me.gradelevel_cmb.Size = New System.Drawing.Size(147, 21)
        Me.gradelevel_cmb.TabIndex = 20
        '
        'section_cmb
        '
        Me.section_cmb.Dock = System.Windows.Forms.DockStyle.Right
        Me.section_cmb.FormattingEnabled = True
        Me.section_cmb.Location = New System.Drawing.Point(213, 0)
        Me.section_cmb.Name = "section_cmb"
        Me.section_cmb.Size = New System.Drawing.Size(144, 21)
        Me.section_cmb.TabIndex = 19
        '
        'subjectcmb
        '
        Me.subjectcmb.Dock = System.Windows.Forms.DockStyle.Right
        Me.subjectcmb.FormattingEnabled = True
        Me.subjectcmb.Location = New System.Drawing.Point(357, 0)
        Me.subjectcmb.Name = "subjectcmb"
        Me.subjectcmb.Size = New System.Drawing.Size(144, 21)
        Me.subjectcmb.TabIndex = 21
        '
        'School_year_label
        '
        Me.School_year_label.AutoSize = True
        Me.School_year_label.Location = New System.Drawing.Point(74, 14)
        Me.School_year_label.Name = "School_year_label"
        Me.School_year_label.Size = New System.Drawing.Size(39, 13)
        Me.School_year_label.TabIndex = 23
        Me.School_year_label.Text = "Label3"
        Me.School_year_label.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.gradelevel_cmb)
        Me.Panel2.Controls.Add(Me.section_cmb)
        Me.Panel2.Controls.Add(Me.subjectcmb)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(44, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(501, 25)
        Me.Panel2.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.LoadBtn)
        Me.Panel1.Controls.Add(Me.School_year_label)
        Me.Panel1.Controls.Add(Me.Close_btn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(728, 35)
        Me.Panel1.TabIndex = 14
        '
        'GradeReportViewer
        '
        Me.GradeReportViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GradeReportViewer.Location = New System.Drawing.Point(5, 46)
        Me.GradeReportViewer.Name = "GradeReportViewer"
        Me.GradeReportViewer.Size = New System.Drawing.Size(728, 429)
        Me.GradeReportViewer.TabIndex = 16
        '
        'TeacherViewGradesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(738, 520)
        Me.Controls.Add(Me.GradeReportViewer)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TeacherViewGradesFrm"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "TeacherViewGradesFrm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoadBtn As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Close_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gradelevel_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents section_cmb As System.Windows.Forms.ComboBox
    Friend WithEvents subjectcmb As System.Windows.Forms.ComboBox
    Friend WithEvents School_year_label As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GradeReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PdfBtn As System.Windows.Forms.Button
End Class
