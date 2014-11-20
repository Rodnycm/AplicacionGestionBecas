<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlBuscarTipoBeca
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCtrlBuscarTipoBeca))
        Me.txtBarraBusqueda = New System.Windows.Forms.TextBox()
        Me.dtaTipoBeca = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Requisitos = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Beneficios = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.opciones = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.PbTipoBeca = New System.Windows.Forms.PictureBox()
        Me.btnCrearTipoBeca = New System.Windows.Forms.Button()
        Me.lblTituloTiposDeBeca = New System.Windows.Forms.Label()
        CType(Me.dtaTipoBeca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbTipoBeca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBarraBusqueda
        '
        Me.txtBarraBusqueda.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtBarraBusqueda.Location = New System.Drawing.Point(32, 134)
        Me.txtBarraBusqueda.Name = "txtBarraBusqueda"
        Me.txtBarraBusqueda.Size = New System.Drawing.Size(746, 27)
        Me.txtBarraBusqueda.TabIndex = 22
        Me.txtBarraBusqueda.Text = "Buscar:"
        '
        'dtaTipoBeca
        '
        Me.dtaTipoBeca.AllowUserToAddRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtaTipoBeca.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtaTipoBeca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtaTipoBeca.BackgroundColor = System.Drawing.Color.White
        Me.dtaTipoBeca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtaTipoBeca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtaTipoBeca.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtaTipoBeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtaTipoBeca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Fecha, Me.Estado, Me.Descripcion, Me.Requisitos, Me.Beneficios, Me.opciones})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtaTipoBeca.DefaultCellStyle = DataGridViewCellStyle6
        Me.dtaTipoBeca.GridColor = System.Drawing.Color.White
        Me.dtaTipoBeca.Location = New System.Drawing.Point(42, 211)
        Me.dtaTipoBeca.Name = "dtaTipoBeca"
        Me.dtaTipoBeca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtaTipoBeca.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dtaTipoBeca.RowHeadersVisible = False
        Me.dtaTipoBeca.Size = New System.Drawing.Size(947, 271)
        Me.dtaTipoBeca.TabIndex = 21
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha Creación"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Visible = False
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Visible = False
        '
        'Requisitos
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent
        Me.Requisitos.DefaultCellStyle = DataGridViewCellStyle3
        Me.Requisitos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Requisitos.HeaderText = "Requisitos"
        Me.Requisitos.Name = "Requisitos"
        Me.Requisitos.Text = "Ver"
        Me.Requisitos.UseColumnTextForButtonValue = True
        Me.Requisitos.Visible = False
        '
        'Beneficios
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Transparent
        Me.Beneficios.DefaultCellStyle = DataGridViewCellStyle4
        Me.Beneficios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Beneficios.HeaderText = "Beneficios"
        Me.Beneficios.Name = "Beneficios"
        Me.Beneficios.Text = "Ver"
        Me.Beneficios.UseColumnTextForButtonValue = True
        Me.Beneficios.Visible = False
        '
        'opciones
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.opciones.DefaultCellStyle = DataGridViewCellStyle5
        Me.opciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opciones.HeaderText = "Opciones"
        Me.opciones.Items.AddRange(New Object() {"Ver", "Editar", "Eliminar"})
        Me.opciones.Name = "opciones"
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.White
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnVolver.Location = New System.Drawing.Point(917, 521)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(89, 29)
        Me.btnVolver.TabIndex = 66
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        Me.btnVolver.Visible = False
        '
        'PbTipoBeca
        '
        Me.PbTipoBeca.Image = CType(resources.GetObject("PbTipoBeca.Image"), System.Drawing.Image)
        Me.PbTipoBeca.Location = New System.Drawing.Point(31, 176)
        Me.PbTipoBeca.Name = "PbTipoBeca"
        Me.PbTipoBeca.Size = New System.Drawing.Size(975, 321)
        Me.PbTipoBeca.TabIndex = 20
        Me.PbTipoBeca.TabStop = False
        '
        'btnCrearTipoBeca
        '
        Me.btnCrearTipoBeca.BackgroundImage = CType(resources.GetObject("btnCrearTipoBeca.BackgroundImage"), System.Drawing.Image)
        Me.btnCrearTipoBeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearTipoBeca.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearTipoBeca.ForeColor = System.Drawing.Color.White
        Me.btnCrearTipoBeca.Location = New System.Drawing.Point(784, 82)
        Me.btnCrearTipoBeca.Name = "btnCrearTipoBeca"
        Me.btnCrearTipoBeca.Size = New System.Drawing.Size(222, 79)
        Me.btnCrearTipoBeca.TabIndex = 19
        Me.btnCrearTipoBeca.Text = "Crear Tipo de Beca"
        Me.btnCrearTipoBeca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCrearTipoBeca.UseVisualStyleBackColor = True
        '
        'lblTituloTiposDeBeca
        '
        Me.lblTituloTiposDeBeca.AutoSize = True
        Me.lblTituloTiposDeBeca.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloTiposDeBeca.ForeColor = System.Drawing.Color.Black
        Me.lblTituloTiposDeBeca.Location = New System.Drawing.Point(26, 17)
        Me.lblTituloTiposDeBeca.Name = "lblTituloTiposDeBeca"
        Me.lblTituloTiposDeBeca.Size = New System.Drawing.Size(209, 45)
        Me.lblTituloTiposDeBeca.TabIndex = 67
        Me.lblTituloTiposDeBeca.Text = "Tipos de Beca"
        '
        'uCtrlBuscarTipoBeca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblTituloTiposDeBeca)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtBarraBusqueda)
        Me.Controls.Add(Me.btnCrearTipoBeca)
        Me.Controls.Add(Me.dtaTipoBeca)
        Me.Controls.Add(Me.PbTipoBeca)
        Me.Location = New System.Drawing.Point(145, 50)
        Me.Name = "uCtrlBuscarTipoBeca"
        Me.Size = New System.Drawing.Size(1037, 578)
        CType(Me.dtaTipoBeca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbTipoBeca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBarraBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents dtaTipoBeca As System.Windows.Forms.DataGridView
    Friend WithEvents PbTipoBeca As System.Windows.Forms.PictureBox
    Friend WithEvents btnCrearTipoBeca As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Requisitos As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Beneficios As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents opciones As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents lblTituloTiposDeBeca As System.Windows.Forms.Label

End Class
