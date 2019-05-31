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
        Me.btnGet = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnDoAll = New System.Windows.Forms.Button()
        Me.btnDoFilter = New System.Windows.Forms.Button()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.lblNumRegs = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGet
        '
        Me.btnGet.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnGet.FlatAppearance.BorderSize = 0
        Me.btnGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnGet.Location = New System.Drawing.Point(-1, 88)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(60, 37)
        Me.btnGet.TabIndex = 0
        Me.btnGet.Text = "Get Data"
        Me.btnGet.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.BackColor = System.Drawing.Color.Black
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.ForeColor = System.Drawing.Color.LightGray
        Me.lblStatus.Location = New System.Drawing.Point(-1, 128)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(331, 19)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Estatus"
        '
        'btnDoAll
        '
        Me.btnDoAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnDoAll.FlatAppearance.BorderSize = 0
        Me.btnDoAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDoAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnDoAll.Location = New System.Drawing.Point(-1, 45)
        Me.btnDoAll.Name = "btnDoAll"
        Me.btnDoAll.Size = New System.Drawing.Size(60, 37)
        Me.btnDoAll.TabIndex = 2
        Me.btnDoAll.Text = "Do All"
        Me.btnDoAll.UseVisualStyleBackColor = False
        '
        'btnDoFilter
        '
        Me.btnDoFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnDoFilter.FlatAppearance.BorderSize = 0
        Me.btnDoFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDoFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnDoFilter.Location = New System.Drawing.Point(-1, 2)
        Me.btnDoFilter.Name = "btnDoFilter"
        Me.btnDoFilter.Size = New System.Drawing.Size(60, 37)
        Me.btnDoFilter.TabIndex = 3
        Me.btnDoFilter.Text = "Do Filter"
        Me.btnDoFilter.UseVisualStyleBackColor = False
        '
        'txtData
        '
        Me.txtData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtData.BackColor = System.Drawing.Color.LightGray
        Me.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtData.Location = New System.Drawing.Point(65, 2)
        Me.txtData.Multiline = True
        Me.txtData.Name = "txtData"
        Me.txtData.ReadOnly = True
        Me.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtData.Size = New System.Drawing.Size(337, 123)
        Me.txtData.TabIndex = 4
        Me.txtData.Text = "hola"
        '
        'lblNumRegs
        '
        Me.lblNumRegs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumRegs.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.lblNumRegs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNumRegs.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumRegs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNumRegs.Location = New System.Drawing.Point(336, 128)
        Me.lblNumRegs.Name = "lblNumRegs"
        Me.lblNumRegs.Size = New System.Drawing.Size(68, 19)
        Me.lblNumRegs.TabIndex = 5
        Me.lblNumRegs.Text = "00 / 000"
        Me.lblNumRegs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(404, 146)
        Me.Controls.Add(Me.lblNumRegs)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.btnDoFilter)
        Me.Controls.Add(Me.btnDoAll)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnGet)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "X-Sports Filter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGet As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnDoAll As Button
    Friend WithEvents btnDoFilter As Button
    Friend WithEvents txtData As TextBox
    Friend WithEvents lblNumRegs As Label
End Class
