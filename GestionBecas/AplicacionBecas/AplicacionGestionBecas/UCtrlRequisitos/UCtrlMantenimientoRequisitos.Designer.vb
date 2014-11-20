<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlMantenimientoRequisitos
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCtrlMantenimientoRequisitos))
        Me.dgvRequisitos = New System.Windows.Forms.DataGridView()
        Me.dtaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificarcmb = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colmId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCrearRequisito = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblTituloCursos = New System.Windows.Forms.Label()
        CType(Me.dgvRequisitos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRequisitos
        '
        Me.dgvRequisitos.AllowUserToAddRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRequisitos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRequisitos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRequisitos.BackgroundColor = System.Drawing.Color.White
        Me.dgvRequisitos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRequisitos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRequisitos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRequisitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequisitos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtaNombre, Me.descripcion, Me.Modificarcmb, Me.colmId})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRequisitos.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvRequisitos.GridColor = System.Drawing.Color.White
        Me.dgvRequisitos.Location = New System.Drawing.Point(40, 235)
        Me.dgvRequisitos.Name = "dgvRequisitos"
        Me.dgvRequisitos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRequisitos.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvRequisitos.RowHeadersVisible = False
        Me.dgvRequisitos.ShowEditingIcon = False
        Me.dgvRequisitos.Size = New System.Drawing.Size(952, 271)
        Me.dgvRequisitos.TabIndex = 15
        '
        'dtaNombre
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtaNombre.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtaNombre.HeaderText = "Nombre"
        Me.dtaNombre.Name = "dtaNombre"
        Me.dtaNombre.ReadOnly = True
        '
        'descripcion
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descripcion.DefaultCellStyle = DataGridViewCellStyle4
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        '
        'Modificarcmb
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modificarcmb.DefaultCellStyle = DataGridViewCellStyle5
        Me.Modificarcmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Modificarcmb.HeaderText = "Opciones"
        Me.Modificarcmb.Items.AddRange(New Object() {"Editar", "Eliminar"})
        Me.Modificarcmb.Name = "Modificarcmb"
        '
        'colmId
        '
        Me.colmId.HeaderText = ""
        Me.colmId.Name = "colmId"
        Me.colmId.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 202)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(975, 321)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'btnCrearRequisito
        '
        Me.btnCrearRequisito.BackgroundImage = CType(resources.GetObject("btnCrearRequisito.BackgroundImage"), System.Drawing.Image)
        Me.btnCrearRequisito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearRequisito.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearRequisito.ForeColor = System.Drawing.Color.White
        Me.btnCrearRequisito.Location = New System.Drawing.Point(783, 108)
        Me.btnCrearRequisito.Name = "btnCrearRequisito"
        Me.btnCrearRequisito.Size = New System.Drawing.Size(222, 79)
        Me.btnCrearRequisito.TabIndex = 13
        Me.btnCrearRequisito.Text = "Crear Requisito"
        Me.btnCrearRequisito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCrearRequisito.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.Black
        Me.txtBuscar.Location = New System.Drawing.Point(31, 160)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(746, 27)
        Me.txtBuscar.TabIndex = 16
        '
        'lblTituloCursos
        '
        Me.lblTituloCursos.AutoSize = True
        Me.lblTituloCursos.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloCursos.ForeColor = System.Drawing.Color.Black
        Me.lblTituloCursos.Location = New System.Drawing.Point(26, 17)
        Me.lblTituloCursos.Name = "lblTituloCursos"
        Me.lblTituloCursos.Size = New System.Drawing.Size(157, 45)
        Me.lblTituloCursos.TabIndex = 33
        Me.lblTituloCursos.Text = "Requisitos"
        '
        'uCtrlMantenimientoRequisitos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblTituloCursos)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgvRequisitos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCrearRequisito)
        Me.Location = New System.Drawing.Point(145, 50)
        Me.Name = "uCtrlMantenimientoRequisitos"
        Me.Size = New System.Drawing.Size(1037, 578)
        CType(Me.dgvRequisitos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvRequisitos As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCrearRequisito As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents dtaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modificarcmb As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colmId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTituloCursos As System.Windows.Forms.Label

End Class
