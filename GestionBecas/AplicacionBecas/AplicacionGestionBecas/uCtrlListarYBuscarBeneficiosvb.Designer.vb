<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlListarYBuscarBeneficiosvb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCtrlListarYBuscarBeneficiosvb))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnMantenimiento = New System.Windows.Forms.Button()
        Me.pctbxBeneficios = New System.Windows.Forms.PictureBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.dtaOpciones = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dtaAplicabilidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaPorcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaBuscarBeneficio = New System.Windows.Forms.DataGridView()
        CType(Me.pctbxBeneficios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtaBuscarBeneficio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(36, 74)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(732, 20)
        Me.txtBuscar.TabIndex = 30
        Me.txtBuscar.Text = "Buscar:"
        '
        'btnMantenimiento
        '
        Me.btnMantenimiento.BackgroundImage = CType(resources.GetObject("btnMantenimiento.BackgroundImage"), System.Drawing.Image)
        Me.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMantenimiento.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMantenimiento.ForeColor = System.Drawing.Color.White
        Me.btnMantenimiento.Location = New System.Drawing.Point(789, 20)
        Me.btnMantenimiento.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnMantenimiento.Name = "btnMantenimiento"
        Me.btnMantenimiento.Size = New System.Drawing.Size(222, 79)
        Me.btnMantenimiento.TabIndex = 31
        Me.btnMantenimiento.Text = "Crear Beneficio"
        Me.btnMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMantenimiento.UseVisualStyleBackColor = True
        '
        'pctbxBeneficios
        '
        Me.pctbxBeneficios.BackColor = System.Drawing.Color.White
        Me.pctbxBeneficios.BackgroundImage = Global.UI.My.Resources.Resources.tablaFinalGrandeAzul
        Me.pctbxBeneficios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctbxBeneficios.Location = New System.Drawing.Point(36, 136)
        Me.pctbxBeneficios.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.pctbxBeneficios.Name = "pctbxBeneficios"
        Me.pctbxBeneficios.Size = New System.Drawing.Size(975, 321)
        Me.pctbxBeneficios.TabIndex = 32
        Me.pctbxBeneficios.TabStop = False
        '
        'btnVolver
        '
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnVolver.Location = New System.Drawing.Point(830, 473)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(118, 33)
        Me.btnVolver.TabIndex = 34
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        Me.btnVolver.Visible = False
        '
        'dtaOpciones
        '
        Me.dtaOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dtaOpciones.HeaderText = "Opciones"
        Me.dtaOpciones.Items.AddRange(New Object() {"Ver", "Editar", "Eliminar"})
        Me.dtaOpciones.Name = "dtaOpciones"
        '
        'dtaAplicabilidad
        '
        Me.dtaAplicabilidad.HeaderText = "Aplicabilidad"
        Me.dtaAplicabilidad.Name = "dtaAplicabilidad"
        '
        'dtaPorcentaje
        '
        Me.dtaPorcentaje.HeaderText = "Porcentaje"
        Me.dtaPorcentaje.Name = "dtaPorcentaje"
        '
        'dtaNombre
        '
        Me.dtaNombre.HeaderText = "Nombre"
        Me.dtaNombre.Name = "dtaNombre"
        '
        'dtaId
        '
        Me.dtaId.HeaderText = "Id"
        Me.dtaId.Name = "dtaId"
        '
        'dtaBuscarBeneficio
        '
        Me.dtaBuscarBeneficio.AllowUserToAddRows = False
        Me.dtaBuscarBeneficio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtaBuscarBeneficio.BackgroundColor = System.Drawing.Color.White
        Me.dtaBuscarBeneficio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtaBuscarBeneficio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtaBuscarBeneficio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtaBuscarBeneficio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtaBuscarBeneficio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtaId, Me.dtaNombre, Me.dtaPorcentaje, Me.dtaAplicabilidad, Me.dtaOpciones})
        Me.dtaBuscarBeneficio.GridColor = System.Drawing.Color.White
        Me.dtaBuscarBeneficio.Location = New System.Drawing.Point(50, 176)
        Me.dtaBuscarBeneficio.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.dtaBuscarBeneficio.Name = "dtaBuscarBeneficio"
        Me.dtaBuscarBeneficio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtaBuscarBeneficio.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtaBuscarBeneficio.RowHeadersVisible = False
        Me.dtaBuscarBeneficio.Size = New System.Drawing.Size(947, 271)
        Me.dtaBuscarBeneficio.TabIndex = 33
        '
        'uCtrlListarYBuscarBeneficiosvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.dtaBuscarBeneficio)
        Me.Controls.Add(Me.pctbxBeneficios)
        Me.Controls.Add(Me.btnMantenimiento)
        Me.Controls.Add(Me.txtBuscar)
        Me.Name = "uCtrlListarYBuscarBeneficiosvb"
        Me.Size = New System.Drawing.Size(1042, 519)
        CType(Me.pctbxBeneficios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtaBuscarBeneficio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnMantenimiento As System.Windows.Forms.Button
    Friend WithEvents pctbxBeneficios As System.Windows.Forms.PictureBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents dtaOpciones As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dtaAplicabilidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaPorcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaBuscarBeneficio As System.Windows.Forms.DataGridView

End Class
