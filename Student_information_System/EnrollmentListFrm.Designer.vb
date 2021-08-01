<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnrollmentListFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SearchBar = New MetroFramework.Controls.MetroTextBox()
        Me.EnrollBtn = New System.Windows.Forms.Button()
        Me.School_year_label = New System.Windows.Forms.Label()
        Me.Close_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Enrolled_List_Grid = New System.Windows.Forms.DataGridView()
        Me.Drop = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.EID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.Enrolled_List_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.SearchBar)
        Me.Panel1.Controls.Add(Me.EnrollBtn)
        Me.Panel1.Controls.Add(Me.School_year_label)
        Me.Panel1.Controls.Add(Me.Close_btn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(738, 34)
        Me.Panel1.TabIndex = 6
        '
        'SearchBar
        '
        '
        '
        '
        Me.SearchBar.CustomButton.Image = Nothing
        Me.SearchBar.CustomButton.Location = New System.Drawing.Point(277, 2)
        Me.SearchBar.CustomButton.Name = ""
        Me.SearchBar.CustomButton.Size = New System.Drawing.Size(19, 19)
        Me.SearchBar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.SearchBar.CustomButton.TabIndex = 1
        Me.SearchBar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.SearchBar.CustomButton.UseSelectable = True
        Me.SearchBar.CustomButton.Visible = False
        Me.SearchBar.DisplayIcon = True
        Me.SearchBar.Dock = System.Windows.Forms.DockStyle.Right
        Me.SearchBar.Icon = Global.Student_information_System.My.Resources.Resources.search_18px
        Me.SearchBar.Lines = New String(-1) {}
        Me.SearchBar.Location = New System.Drawing.Point(216, 5)
        Me.SearchBar.MaxLength = 32767
        Me.SearchBar.Name = "SearchBar"
        Me.SearchBar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchBar.PromptText = "Search LRN No | Press Enter key to search"
        Me.SearchBar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SearchBar.SelectedText = ""
        Me.SearchBar.SelectionLength = 0
        Me.SearchBar.SelectionStart = 0
        Me.SearchBar.ShortcutsEnabled = True
        Me.SearchBar.ShowClearButton = True
        Me.SearchBar.Size = New System.Drawing.Size(299, 24)
        Me.SearchBar.TabIndex = 26
        Me.SearchBar.UseSelectable = True
        Me.SearchBar.WaterMark = "Search LRN No | Press Enter key to search"
        Me.SearchBar.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SearchBar.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'EnrollBtn
        '
        Me.EnrollBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.EnrollBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EnrollBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.EnrollBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.EnrollBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.EnrollBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.EnrollBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EnrollBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnrollBtn.ForeColor = System.Drawing.Color.White
        Me.EnrollBtn.Location = New System.Drawing.Point(515, 5)
        Me.EnrollBtn.Name = "EnrollBtn"
        Me.EnrollBtn.Size = New System.Drawing.Size(111, 24)
        Me.EnrollBtn.TabIndex = 25
        Me.EnrollBtn.Text = "Enroll Student"
        Me.EnrollBtn.UseVisualStyleBackColor = False
        '
        'School_year_label
        '
        Me.School_year_label.AutoSize = True
        Me.School_year_label.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.School_year_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.School_year_label.Location = New System.Drawing.Point(188, 10)
        Me.School_year_label.Name = "School_year_label"
        Me.School_year_label.Size = New System.Drawing.Size(51, 16)
        Me.School_year_label.TabIndex = 24
        Me.School_year_label.Text = "Label3"
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
        Me.Close_btn.Location = New System.Drawing.Point(626, 5)
        Me.Close_btn.Name = "Close_btn"
        Me.Close_btn.Size = New System.Drawing.Size(107, 24)
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
        Me.Label1.Size = New System.Drawing.Size(177, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enrollment MasterList"
        '
        'Enrolled_List_Grid
        '
        Me.Enrolled_List_Grid.AllowUserToAddRows = False
        Me.Enrolled_List_Grid.AllowUserToDeleteRows = False
        Me.Enrolled_List_Grid.BackgroundColor = System.Drawing.Color.White
        Me.Enrolled_List_Grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Enrolled_List_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Enrolled_List_Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Enrolled_List_Grid.ColumnHeadersHeight = 30
        Me.Enrolled_List_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Enrolled_List_Grid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Drop, Me.EID, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Enrolled_List_Grid.DefaultCellStyle = DataGridViewCellStyle3
        Me.Enrolled_List_Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Enrolled_List_Grid.EnableHeadersVisualStyles = False
        Me.Enrolled_List_Grid.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Enrolled_List_Grid.Location = New System.Drawing.Point(0, 34)
        Me.Enrolled_List_Grid.Name = "Enrolled_List_Grid"
        Me.Enrolled_List_Grid.ReadOnly = True
        Me.Enrolled_List_Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Enrolled_List_Grid.RowHeadersVisible = False
        Me.Enrolled_List_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Enrolled_List_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.Enrolled_List_Grid.ShowEditingIcon = False
        Me.Enrolled_List_Grid.ShowRowErrors = False
        Me.Enrolled_List_Grid.Size = New System.Drawing.Size(738, 486)
        Me.Enrolled_List_Grid.TabIndex = 12
        '
        'Drop
        '
        Me.Drop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.Drop.DefaultCellStyle = DataGridViewCellStyle2
        Me.Drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Drop.HeaderText = ""
        Me.Drop.Name = "Drop"
        Me.Drop.ReadOnly = True
        Me.Drop.Width = 5
        '
        'EID
        '
        Me.EID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.EID.HeaderText = "ID"
        Me.EID.Name = "EID"
        Me.EID.ReadOnly = True
        Me.EID.Width = 44
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Student LRN"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Student Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Grade Level"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 109
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Section"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 78
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Date Enrolled"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 118
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Status"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 69
        '
        'EnrollmentListFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(738, 520)
        Me.Controls.Add(Me.Enrolled_List_Grid)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EnrollmentListFrm"
        Me.Text = "EnrollmentListFrm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Enrolled_List_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Close_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents School_year_label As System.Windows.Forms.Label
    Friend WithEvents EnrollBtn As System.Windows.Forms.Button
    Friend WithEvents Enrolled_List_Grid As System.Windows.Forms.DataGridView
    Friend WithEvents Drop As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents EID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents SearchBar As MetroFramework.Controls.MetroTextBox
End Class
