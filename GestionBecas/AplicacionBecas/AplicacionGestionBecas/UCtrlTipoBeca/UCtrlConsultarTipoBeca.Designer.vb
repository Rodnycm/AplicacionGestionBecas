<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlConsultarTipoBeca
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCtrlConsultarTipoBeca))
        Me.dataGridVTipoBeca = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCreacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Requisitos = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Beneficios = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.mantenimiento = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dataGridVTipoBeca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridVTipoBeca
        '
        Me.dataGridVTipoBeca.BackgroundColor = System.Drawing.Color.White
        Me.dataGridVTipoBeca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridVTipoBeca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridVTipoBeca.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridVTipoBeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridVTipoBeca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.FechaCreacion, Me.Estado, Me.Descripcion, Me.Requisitos, Me.Beneficios, Me.mantenimiento})
        Me.dataGridVTipoBeca.GridColor = System.Drawing.Color.White
        Me.dataGridVTipoBeca.Location = New System.Drawing.Point(167, 198)
        Me.dataGridVTipoBeca.Name = "dataGridVTipoBeca"
        Me.dataGridVTipoBeca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataGridVTipoBeca.RowHeadersVisible = False
        Me.dataGridVTipoBeca.Size = New System.Drawing.Size(709, 209)
        Me.dataGridVTipoBeca.TabIndex = 11
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "VER"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Light", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle2
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'FechaCreacion
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Light", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaCreacion.DefaultCellStyle = DataGridViewCellStyle3
        Me.FechaCreacion.HeaderText = "Fecha"
        Me.FechaCreacion.Name = "FechaCreacion"
        '
        'Estado
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Estado.DefaultCellStyle = DataGridViewCellStyle4
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'Descripcion
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semilight", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.DefaultCellStyle = DataGridViewCellStyle5
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'Requisitos
        '
        Me.Requisitos.DataPropertyName = "Requisitos"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        Me.Requisitos.DefaultCellStyle = DataGridViewCellStyle6
        Me.Requisitos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Requisitos.HeaderText = "Requisitos"
        Me.Requisitos.Name = "Requisitos"
        Me.Requisitos.ReadOnly = True
        Me.Requisitos.Text = "Ver"
        Me.Requisitos.UseColumnTextForButtonValue = True
        '
        'Beneficios
        '
        Me.Beneficios.DataPropertyName = "Beneficios"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        Me.Beneficios.DefaultCellStyle = DataGridViewCellStyle7
        Me.Beneficios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Beneficios.HeaderText = "Beneficios"
        Me.Beneficios.Name = "Beneficios"
        Me.Beneficios.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Beneficios.Text = "Ver"
        Me.Beneficios.ToolTipText = "Ver"
        Me.Beneficios.UseColumnTextForButtonValue = True
        '
        'mantenimiento
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        Me.mantenimiento.DefaultCellStyle = DataGridViewCellStyle8
        Me.mantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mantenimiento.HeaderText = "Opciones"
        Me.mantenimiento.Items.AddRange(New Object() {"Ver", "Editar", "Eliminar"})
        Me.mantenimiento.Name = "mantenimiento"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(138, 138)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(757, 321)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'uCtrlConsultarTipoBeca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dataGridVTipoBeca)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "uCtrlConsultarTipoBeca"
        Me.Size = New System.Drawing.Size(1032, 642)
        CType(Me.dataGridVTipoBeca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dataGridVTipoBeca As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCreacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Requisitos As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Beneficios As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents mantenimiento As System.Windows.Forms.DataGridViewComboBoxColumn

End Class
