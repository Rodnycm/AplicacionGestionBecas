<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlConsultarPlanDeEstudio
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCtrlConsultarPlanDeEstudio))
        Me.lblNombreCarrera = New System.Windows.Forms.Label()
        Me.dtaConsultarPlanEstudio = New System.Windows.Forms.DataGridView()
        Me.dtaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaCreditoos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pctbxBeneficios = New System.Windows.Forms.PictureBox()
        Me.cmbCursos = New System.Windows.Forms.ComboBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblCreditos = New System.Windows.Forms.Label()
        Me.lblSumaCreditos = New System.Windows.Forms.Label()
        Me.lblSumaPrecio = New System.Windows.Forms.Label()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        CType(Me.dtaConsultarPlanEstudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctbxBeneficios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombreCarrera
        '
        Me.lblNombreCarrera.AutoSize = True
        Me.lblNombreCarrera.Font = New System.Drawing.Font("Segoe UI Light", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCarrera.Location = New System.Drawing.Point(11, 52)
        Me.lblNombreCarrera.Name = "lblNombreCarrera"
        Me.lblNombreCarrera.Size = New System.Drawing.Size(191, 28)
        Me.lblNombreCarrera.TabIndex = 34
        Me.lblNombreCarrera.Text = "Nombre de la carrera"
        '
        'dtaConsultarPlanEstudio
        '
        Me.dtaConsultarPlanEstudio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtaConsultarPlanEstudio.BackgroundColor = System.Drawing.Color.White
        Me.dtaConsultarPlanEstudio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtaConsultarPlanEstudio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtaConsultarPlanEstudio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtaConsultarPlanEstudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtaConsultarPlanEstudio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtaNombre, Me.dtaCreditoos, Me.dtaPrecio})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtaConsultarPlanEstudio.DefaultCellStyle = DataGridViewCellStyle5
        Me.dtaConsultarPlanEstudio.Enabled = False
        Me.dtaConsultarPlanEstudio.GridColor = System.Drawing.Color.White
        Me.dtaConsultarPlanEstudio.Location = New System.Drawing.Point(28, 186)
        Me.dtaConsultarPlanEstudio.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.dtaConsultarPlanEstudio.Name = "dtaConsultarPlanEstudio"
        Me.dtaConsultarPlanEstudio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtaConsultarPlanEstudio.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dtaConsultarPlanEstudio.RowHeadersVisible = False
        Me.dtaConsultarPlanEstudio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtaConsultarPlanEstudio.Size = New System.Drawing.Size(947, 271)
        Me.dtaConsultarPlanEstudio.TabIndex = 32
        '
        'dtaNombre
        '
        Me.dtaNombre.HeaderText = "Nombre"
        Me.dtaNombre.Name = "dtaNombre"
        '
        'dtaCreditoos
        '
        Me.dtaCreditoos.HeaderText = "Total De Créditos"
        Me.dtaCreditoos.Name = "dtaCreditoos"
        '
        'dtaPrecio
        '
        Me.dtaPrecio.HeaderText = "Precio"
        Me.dtaPrecio.Name = "dtaPrecio"
        '
        'pctbxBeneficios
        '
        Me.pctbxBeneficios.BackColor = System.Drawing.Color.White
        Me.pctbxBeneficios.BackgroundImage = CType(resources.GetObject("pctbxBeneficios.BackgroundImage"), System.Drawing.Image)
        Me.pctbxBeneficios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctbxBeneficios.Location = New System.Drawing.Point(14, 148)
        Me.pctbxBeneficios.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.pctbxBeneficios.Name = "pctbxBeneficios"
        Me.pctbxBeneficios.Size = New System.Drawing.Size(975, 321)
        Me.pctbxBeneficios.TabIndex = 33
        Me.pctbxBeneficios.TabStop = False
        '
        'cmbCursos
        '
        Me.cmbCursos.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCursos.FormattingEnabled = True
        Me.cmbCursos.Location = New System.Drawing.Point(769, 87)
        Me.cmbCursos.Name = "cmbCursos"
        Me.cmbCursos.Size = New System.Drawing.Size(220, 25)
        Me.cmbCursos.TabIndex = 35
        Me.cmbCursos.Text = "Cuatrimestres"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(705, 496)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(71, 17)
        Me.lblPrecio.TabIndex = 36
        Me.lblPrecio.Text = "Precio Total"
        '
        'lblCreditos
        '
        Me.lblCreditos.AutoSize = True
        Me.lblCreditos.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditos.Location = New System.Drawing.Point(362, 496)
        Me.lblCreditos.Name = "lblCreditos"
        Me.lblCreditos.Size = New System.Drawing.Size(82, 17)
        Me.lblCreditos.TabIndex = 37
        Me.lblCreditos.Text = "Total Creditos"
        '
        'lblSumaCreditos
        '
        Me.lblSumaCreditos.AutoSize = True
        Me.lblSumaCreditos.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSumaCreditos.Location = New System.Drawing.Point(441, 496)
        Me.lblSumaCreditos.Name = "lblSumaCreditos"
        Me.lblSumaCreditos.Size = New System.Drawing.Size(0, 17)
        Me.lblSumaCreditos.TabIndex = 38
        '
        'lblSumaPrecio
        '
        Me.lblSumaPrecio.AutoSize = True
        Me.lblSumaPrecio.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSumaPrecio.Location = New System.Drawing.Point(775, 496)
        Me.lblSumaPrecio.Name = "lblSumaPrecio"
        Me.lblSumaPrecio.Size = New System.Drawing.Size(0, 17)
        Me.lblSumaPrecio.TabIndex = 39
        '
        'btnRefrescar
        '
        Me.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefrescar.Font = New System.Drawing.Font("Segoe UI Light", 8.75!)
        Me.btnRefrescar.ForeColor = System.Drawing.Color.DarkViolet
        Me.btnRefrescar.Location = New System.Drawing.Point(650, 87)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(75, 23)
        Me.btnRefrescar.TabIndex = 40
        Me.btnRefrescar.Text = "Ver Todos"
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'uCtrlConsultarPlanDeEstudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.lblSumaPrecio)
        Me.Controls.Add(Me.lblSumaCreditos)
        Me.Controls.Add(Me.lblCreditos)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.cmbCursos)
        Me.Controls.Add(Me.lblNombreCarrera)
        Me.Controls.Add(Me.dtaConsultarPlanEstudio)
        Me.Controls.Add(Me.pctbxBeneficios)
        Me.Name = "uCtrlConsultarPlanDeEstudio"
        Me.Size = New System.Drawing.Size(1007, 557)
        CType(Me.dtaConsultarPlanEstudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctbxBeneficios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombreCarrera As System.Windows.Forms.Label
    Friend WithEvents dtaConsultarPlanEstudio As System.Windows.Forms.DataGridView
    Friend WithEvents dtaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaCreditoos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pctbxBeneficios As System.Windows.Forms.PictureBox
    Friend WithEvents cmbCursos As System.Windows.Forms.ComboBox
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents lblCreditos As System.Windows.Forms.Label
    Friend WithEvents lblSumaCreditos As System.Windows.Forms.Label
    Friend WithEvents lblSumaPrecio As System.Windows.Forms.Label
    Friend WithEvents btnRefrescar As System.Windows.Forms.Button

End Class
