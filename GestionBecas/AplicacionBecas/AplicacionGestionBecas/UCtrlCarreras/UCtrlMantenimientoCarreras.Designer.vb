<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlMantenimientoCarreras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCtrlMantenimientoCarreras))
        Me.dgvCarreras = New System.Windows.Forms.DataGridView()
        Me.dtaCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaDirector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cursos = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Modificarcmb = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.color = New System.Windows.Forms.DataGridViewTextBoxColumn()

        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMantenimiento = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txtBuscar = New System.Windows.Forms.TextBox()

        Me.lblTituloCarreras = New System.Windows.Forms.Label()

        CType(Me.dgvCarreras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCarreras
        '
        Me.dgvCarreras.AllowUserToAddRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCarreras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCarreras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCarreras.BackgroundColor = System.Drawing.Color.White
        Me.dgvCarreras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCarreras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCarreras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarreras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtaCodigo, Me.dtaNombre, Me.dtaDirector, Me.Cursos, Me.Modificarcmb, Me.id, Me.color})
        Me.dgvCarreras.GridColor = System.Drawing.Color.White
        Me.dgvCarreras.Location = New System.Drawing.Point(40, 235)
        Me.dgvCarreras.Name = "dgvCarreras"
        Me.dgvCarreras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCarreras.RowHeadersVisible = False
        Me.dgvCarreras.Size = New System.Drawing.Size(947, 271)
        Me.dgvCarreras.TabIndex = 12
        '
        'dtaCodigo
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.dtaCodigo.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtaCodigo.HeaderText = "Código"
        Me.dtaCodigo.Name = "dtaCodigo"
        Me.dtaCodigo.ReadOnly = True
        '
        'dtaNombre
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.dtaNombre.DefaultCellStyle = DataGridViewCellStyle4
        Me.dtaNombre.HeaderText = "Nombre"
        Me.dtaNombre.Name = "dtaNombre"
        Me.dtaNombre.ReadOnly = True
        '
        'dtaDirector
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.dtaDirector.DefaultCellStyle = DataGridViewCellStyle5
        Me.dtaDirector.HeaderText = "Director Académico"
        Me.dtaDirector.Name = "dtaDirector"
        Me.dtaDirector.ReadOnly = True
        '
        'Cursos
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.Cursos.DefaultCellStyle = DataGridViewCellStyle6
        Me.Cursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cursos.HeaderText = "Cursos"
        Me.Cursos.Name = "Cursos"
        Me.Cursos.Text = "Agregar"
        '
        'Modificarcmb
        '
        Me.Modificarcmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Modificarcmb.HeaderText = "Opciones"
        Me.Modificarcmb.Items.AddRange(New Object() {"Editar", "Eliminar"})
        Me.Modificarcmb.Name = "Modificarcmb"
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'color
        '
        Me.color.HeaderText = "color"
        Me.color.Name = "color"
        Me.color.Visible = False
        '

        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.Black
        Me.txtBuscar.Location = New System.Drawing.Point(31, 160)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(746, 27)
        Me.txtBuscar.TabIndex = 15
        Me.txtBuscar.Text = "Buscar:"
        '

        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 202)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(975, 321)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnMantenimiento
        '
        Me.btnMantenimiento.BackgroundImage = CType(resources.GetObject("btnMantenimiento.BackgroundImage"), System.Drawing.Image)
        Me.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMantenimiento.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMantenimiento.ForeColor = System.Drawing.Color.White
        Me.btnMantenimiento.Location = New System.Drawing.Point(783, 108)
        Me.btnMantenimiento.Name = "btnMantenimiento"
        Me.btnMantenimiento.Size = New System.Drawing.Size(222, 79)
        Me.btnMantenimiento.TabIndex = 5
        Me.btnMantenimiento.Text = "Crear Carrera"
        Me.btnMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMantenimiento.UseVisualStyleBackColor = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Editar"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '

        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.Black
        Me.txtBuscar.Location = New System.Drawing.Point(31, 160)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(746, 27)
        Me.txtBuscar.TabIndex = 15
        Me.txtBuscar.Text = "Buscar:"
        '
        'lblTituloCarreras
        '
        Me.lblTituloCarreras.AutoSize = True
        Me.lblTituloCarreras.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloCarreras.ForeColor = System.Drawing.Color.Black
        Me.lblTituloCarreras.Location = New System.Drawing.Point(26, 17)
        Me.lblTituloCarreras.Name = "lblTituloCarreras"
        Me.lblTituloCarreras.Size = New System.Drawing.Size(134, 45)
        Me.lblTituloCarreras.TabIndex = 31
        Me.lblTituloCarreras.Text = "Carreras"
        '
        'uCtrlMantenimientoCarreras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.lblTituloCarreras)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgvCarreras)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnMantenimiento)
        Me.Location = New System.Drawing.Point(145, 50)
        Me.Name = "uCtrlMantenimientoCarreras"
        Me.Size = New System.Drawing.Size(1037, 578)
        CType(Me.dgvCarreras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMantenimiento As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dgvCarreras As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents dtaCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaDirector As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cursos As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Modificarcmb As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents color As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTituloCarreras As System.Windows.Forms.Label

End Class
