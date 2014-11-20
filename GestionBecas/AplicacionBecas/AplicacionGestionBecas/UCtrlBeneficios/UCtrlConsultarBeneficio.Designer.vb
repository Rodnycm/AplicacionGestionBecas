<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlConsultarBeneficio
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

        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtaConsultarBeneficio = New System.Windows.Forms.DataGridView()
        Me.pctbxBeneficios = New System.Windows.Forms.PictureBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.dtaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaPorcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaAplicabilidad = New System.Windows.Forms.DataGridViewTextBoxColumn()

        CType(Me.dtaConsultarBeneficio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctbxBeneficios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtaConsultarBeneficio
        '
        Me.dtaConsultarBeneficio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtaConsultarBeneficio.BackgroundColor = System.Drawing.Color.White
        Me.dtaConsultarBeneficio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtaConsultarBeneficio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]

        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtaConsultarBeneficio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtaConsultarBeneficio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtaConsultarBeneficio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtaNombre, Me.dtaPorcentaje, Me.dtaAplicabilidad})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtaConsultarBeneficio.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtaConsultarBeneficio.GridColor = System.Drawing.Color.White
        Me.dtaConsultarBeneficio.Location = New System.Drawing.Point(27, 41)
        Me.dtaConsultarBeneficio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtaConsultarBeneficio.Name = "dtaConsultarBeneficio"
        Me.dtaConsultarBeneficio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtaConsultarBeneficio.RowHeadersVisible = False
        Me.dtaConsultarBeneficio.Size = New System.Drawing.Size(941, 271)
        Me.dtaConsultarBeneficio.TabIndex = 25
        '
        'pctbxBeneficios
        '
        Me.pctbxBeneficios.BackgroundImage = Global.UI.My.Resources.Resources.tablaFinalGrandeAzul
        Me.pctbxBeneficios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctbxBeneficios.Location = New System.Drawing.Point(9, 4)
        Me.pctbxBeneficios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pctbxBeneficios.Name = "pctbxBeneficios"
        Me.pctbxBeneficios.Size = New System.Drawing.Size(975, 321)
        Me.pctbxBeneficios.TabIndex = 24
        Me.pctbxBeneficios.TabStop = False
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(811, 353)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(79, 25)
        Me.btnVolver.TabIndex = 26
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True

        '
        'dtaNombre
        '
        Me.dtaNombre.HeaderText = "Nombre"
        Me.dtaNombre.Name = "dtaNombre"
        '
        'dtaPorcentaje
        '
        Me.dtaPorcentaje.HeaderText = "Porcentaje"
        Me.dtaPorcentaje.Name = "dtaPorcentaje"
        '
        'dtaAplicabilidad
        '
        Me.dtaAplicabilidad.HeaderText = "Aplicabilidad"
        Me.dtaAplicabilidad.Name = "dtaAplicabilidad"
        '

        'uCtrlConsultarBeneficio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.dtaConsultarBeneficio)
        Me.Controls.Add(Me.pctbxBeneficios)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "uCtrlConsultarBeneficio"
        Me.Size = New System.Drawing.Size(1022, 389)

        CType(Me.dtaConsultarBeneficio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctbxBeneficios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtaConsultarBeneficio As System.Windows.Forms.DataGridView
    Friend WithEvents pctbxBeneficios As System.Windows.Forms.PictureBox

    Friend WithEvents dtaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaPorcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaAplicabilidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnVolver As System.Windows.Forms.Button


End Class
