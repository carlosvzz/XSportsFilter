<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblNumRegs = New System.Windows.Forms.Label()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabFilters = New System.Windows.Forms.TabPage()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.btnDoFilter = New System.Windows.Forms.Button()
        Me.btnDoAll = New System.Windows.Forms.Button()
        Me.btnGet = New System.Windows.Forms.Button()
        Me.tabFixtures = New System.Windows.Forms.TabPage()
        Me.chkFixturesSave = New System.Windows.Forms.CheckBox()
        Me.txtFixtures = New System.Windows.Forms.TextBox()
        Me.txtLeagueID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboLeagues = New System.Windows.Forms.ComboBox()
        Me.btnSaveFixtures = New System.Windows.Forms.Button()
        Me.cboApi = New System.Windows.Forms.ComboBox()
        Me.tabMain.SuspendLayout()
        Me.tabFilters.SuspendLayout()
        Me.tabFixtures.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(0, 196)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(471, 19)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Estatus"
        '
        'lblNumRegs
        '
        Me.lblNumRegs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumRegs.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.lblNumRegs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumRegs.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumRegs.ForeColor = System.Drawing.Color.White
        Me.lblNumRegs.Location = New System.Drawing.Point(469, 196)
        Me.lblNumRegs.Name = "lblNumRegs"
        Me.lblNumRegs.Size = New System.Drawing.Size(73, 19)
        Me.lblNumRegs.TabIndex = 5
        Me.lblNumRegs.Text = "00 / 000"
        Me.lblNumRegs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabFilters)
        Me.tabMain.Controls.Add(Me.tabFixtures)
        Me.tabMain.Location = New System.Drawing.Point(-1, 1)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(543, 193)
        Me.tabMain.TabIndex = 6
        '
        'tabFilters
        '
        Me.tabFilters.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.tabFilters.Controls.Add(Me.txtData)
        Me.tabFilters.Controls.Add(Me.btnDoFilter)
        Me.tabFilters.Controls.Add(Me.btnDoAll)
        Me.tabFilters.Controls.Add(Me.btnGet)
        Me.tabFilters.Location = New System.Drawing.Point(4, 23)
        Me.tabFilters.Name = "tabFilters"
        Me.tabFilters.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFilters.Size = New System.Drawing.Size(535, 166)
        Me.tabFilters.TabIndex = 0
        Me.tabFilters.Text = "Filters"
        '
        'txtData
        '
        Me.txtData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtData.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData.ForeColor = System.Drawing.Color.White
        Me.txtData.Location = New System.Drawing.Point(75, 5)
        Me.txtData.Multiline = True
        Me.txtData.Name = "txtData"
        Me.txtData.ReadOnly = True
        Me.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtData.Size = New System.Drawing.Size(454, 123)
        Me.txtData.TabIndex = 8
        Me.txtData.Text = "hola"
        '
        'btnDoFilter
        '
        Me.btnDoFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnDoFilter.FlatAppearance.BorderSize = 0
        Me.btnDoFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDoFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDoFilter.Location = New System.Drawing.Point(9, 6)
        Me.btnDoFilter.Name = "btnDoFilter"
        Me.btnDoFilter.Size = New System.Drawing.Size(60, 37)
        Me.btnDoFilter.TabIndex = 7
        Me.btnDoFilter.Text = "Do Filter"
        Me.btnDoFilter.UseVisualStyleBackColor = False
        '
        'btnDoAll
        '
        Me.btnDoAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnDoAll.FlatAppearance.BorderSize = 0
        Me.btnDoAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDoAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDoAll.Location = New System.Drawing.Point(9, 48)
        Me.btnDoAll.Name = "btnDoAll"
        Me.btnDoAll.Size = New System.Drawing.Size(60, 37)
        Me.btnDoAll.TabIndex = 6
        Me.btnDoAll.Text = "Do All"
        Me.btnDoAll.UseVisualStyleBackColor = False
        '
        'btnGet
        '
        Me.btnGet.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnGet.FlatAppearance.BorderSize = 0
        Me.btnGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGet.Location = New System.Drawing.Point(9, 91)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(60, 37)
        Me.btnGet.TabIndex = 5
        Me.btnGet.Text = "Get Data"
        Me.btnGet.UseVisualStyleBackColor = False
        '
        'tabFixtures
        '
        Me.tabFixtures.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.tabFixtures.Controls.Add(Me.cboApi)
        Me.tabFixtures.Controls.Add(Me.chkFixturesSave)
        Me.tabFixtures.Controls.Add(Me.txtFixtures)
        Me.tabFixtures.Controls.Add(Me.txtLeagueID)
        Me.tabFixtures.Controls.Add(Me.Label1)
        Me.tabFixtures.Controls.Add(Me.cboLeagues)
        Me.tabFixtures.Controls.Add(Me.btnSaveFixtures)
        Me.tabFixtures.Location = New System.Drawing.Point(4, 23)
        Me.tabFixtures.Name = "tabFixtures"
        Me.tabFixtures.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFixtures.Size = New System.Drawing.Size(535, 166)
        Me.tabFixtures.TabIndex = 1
        Me.tabFixtures.Text = "Fixtures"
        '
        'chkFixturesSave
        '
        Me.chkFixturesSave.AutoSize = True
        Me.chkFixturesSave.Checked = True
        Me.chkFixturesSave.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFixturesSave.Location = New System.Drawing.Point(9, 89)
        Me.chkFixturesSave.Name = "chkFixturesSave"
        Me.chkFixturesSave.Size = New System.Drawing.Size(117, 18)
        Me.chkFixturesSave.TabIndex = 13
        Me.chkFixturesSave.Text = "Guardar datos"
        Me.chkFixturesSave.UseVisualStyleBackColor = True
        '
        'txtFixtures
        '
        Me.txtFixtures.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFixtures.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtFixtures.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFixtures.ForeColor = System.Drawing.Color.White
        Me.txtFixtures.Location = New System.Drawing.Point(151, 3)
        Me.txtFixtures.Multiline = True
        Me.txtFixtures.Name = "txtFixtures"
        Me.txtFixtures.ReadOnly = True
        Me.txtFixtures.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFixtures.Size = New System.Drawing.Size(381, 157)
        Me.txtFixtures.TabIndex = 12
        '
        'txtLeagueID
        '
        Me.txtLeagueID.Location = New System.Drawing.Point(85, 59)
        Me.txtLeagueID.Name = "txtLeagueID"
        Me.txtLeagueID.Size = New System.Drawing.Size(63, 22)
        Me.txtLeagueID.TabIndex = 11
        Me.txtLeagueID.Text = "999"
        Me.txtLeagueID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "League Id"
        '
        'cboLeagues
        '
        Me.cboLeagues.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cboLeagues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLeagues.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboLeagues.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboLeagues.FormattingEnabled = True
        Me.cboLeagues.Location = New System.Drawing.Point(9, 37)
        Me.cboLeagues.Name = "cboLeagues"
        Me.cboLeagues.Size = New System.Drawing.Size(139, 22)
        Me.cboLeagues.TabIndex = 9
        '
        'btnSaveFixtures
        '
        Me.btnSaveFixtures.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnSaveFixtures.FlatAppearance.BorderSize = 0
        Me.btnSaveFixtures.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveFixtures.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSaveFixtures.Location = New System.Drawing.Point(9, 113)
        Me.btnSaveFixtures.Name = "btnSaveFixtures"
        Me.btnSaveFixtures.Size = New System.Drawing.Size(136, 46)
        Me.btnSaveFixtures.TabIndex = 8
        Me.btnSaveFixtures.Text = "Get Data"
        Me.btnSaveFixtures.UseVisualStyleBackColor = False
        '
        'cboApi
        '
        Me.cboApi.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.cboApi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboApi.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboApi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboApi.FormattingEnabled = True
        Me.cboApi.Items.AddRange(New Object() {"Fixtures", "Teams"})
        Me.cboApi.Location = New System.Drawing.Point(9, 9)
        Me.cboApi.Name = "cboApi"
        Me.cboApi.Size = New System.Drawing.Size(139, 22)
        Me.cboApi.TabIndex = 14
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(544, 217)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.lblNumRegs)
        Me.Controls.Add(Me.lblStatus)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "X-Sports Filter"
        Me.tabMain.ResumeLayout(False)
        Me.tabFilters.ResumeLayout(False)
        Me.tabFilters.PerformLayout()
        Me.tabFixtures.ResumeLayout(False)
        Me.tabFixtures.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblNumRegs As Label
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabFilters As TabPage
    Friend WithEvents txtData As TextBox
    Friend WithEvents btnDoFilter As Button
    Friend WithEvents btnDoAll As Button
    Friend WithEvents btnGet As Button
    Friend WithEvents tabFixtures As TabPage
    Friend WithEvents txtLeagueID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboLeagues As ComboBox
    Friend WithEvents btnSaveFixtures As Button
    Friend WithEvents txtFixtures As TextBox
    Friend WithEvents chkFixturesSave As CheckBox
    Friend WithEvents cboApi As ComboBox
End Class
