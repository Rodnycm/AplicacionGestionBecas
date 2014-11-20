<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UctrlListarYBuscarUsuario
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UctrlListarYBuscarUsuario))
        Me.dgUsuarios = New System.Windows.Forms.DataGridView()
        Me.Identificación = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolAsignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoElect = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.opciones = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnCrearUsuario = New System.Windows.Forms.Button()
        Me.PbUsuarios = New System.Windows.Forms.PictureBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblTituloCursos = New System.Windows.Forms.Label()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgUsuarios
        '
        Me.dgUsuarios.AllowUserToAddRows = False
        Me.dgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgUsuarios.BackgroundColor = System.Drawing.Color.White
        Me.dgUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identificación, Me.Nombre, Me.tel, Me.Fecha, Me.gen, Me.RolAsignado, Me.CorreoElect, Me.opciones})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgUsuarios.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgUsuarios.GridColor = System.Drawing.Color.White
        Me.dgUsuarios.Location = New System.Drawing.Point(42, 233)
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgUsuarios.RowHeadersVisible = False
        Me.dgUsuarios.Size = New System.Drawing.Size(947, 271)
        Me.dgUsuarios.TabIndex = 16
        '
        'Identificación
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Identificación.DefaultCellStyle = DataGridViewCellStyle2
        Me.Identificación.FillWeight = 101.7639!
        Me.Identificación.HeaderText = "Identificación"
        Me.Identificación.Name = "Identificación"
        '
        'Nombre
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle3
        Me.Nombre.FillWeight = 271.8829!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'tel
        '
        Me.tel.HeaderText = "Teléfono"
        Me.tel.Name = "tel"
        Me.tel.Visible = False
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha Nacimiento"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Visible = False
        '
        'gen
        '
        Me.gen.HeaderText = "Género"
        Me.gen.Name = "gen"
        Me.gen.Visible = False
        '
        'RolAsignado
        '
        Me.RolAsignado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RolAsignado.DefaultCellStyle = DataGridViewCellStyle4
        Me.RolAsignado.HeaderText = "Rol Asignado"
        Me.RolAsignado.Name = "RolAsignado"
        Me.RolAsignado.Width = 99
        '
        'CorreoElect
        '
        Me.CorreoElect.HeaderText = "Correo Electrónico"
        Me.CorreoElect.Name = "CorreoElect"
        Me.CorreoElect.Visible = False
        '
        'opciones
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opciones.DefaultCellStyle = DataGridViewCellStyle5
        Me.opciones.FillWeight = 126.3532!
        Me.opciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opciones.HeaderText = "Opciones"
        Me.opciones.Items.AddRange(New Object() {"Ver", "Editar", "Eliminar"})
        Me.opciones.Name = "opciones"
        Me.opciones.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.opciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(30, 158)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(746, 29)
        Me.txtBuscar.TabIndex = 17
        Me.txtBuscar.Text = "Buscar:"
        '
        'btnCrearUsuario
        '
        Me.btnCrearUsuario.BackgroundImage = CType(resources.GetObject("btnCrearUsuario.BackgroundImage"), System.Drawing.Image)
        Me.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearUsuario.ForeColor = System.Drawing.Color.White
        Me.btnCrearUsuario.Location = New System.Drawing.Point(783, 108)
        Me.btnCrearUsuario.Name = "btnCrearUsuario"
        Me.btnCrearUsuario.Size = New System.Drawing.Size(222, 79)
        Me.btnCrearUsuario.TabIndex = 15
        Me.btnCrearUsuario.Text = "Crear Usuario"
        Me.btnCrearUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCrearUsuario.UseVisualStyleBackColor = True
        '
        'PbUsuarios
        '
        Me.PbUsuarios.BackgroundImage = CType(resources.GetObject("PbUsuarios.BackgroundImage"), System.Drawing.Image)
        Me.PbUsuarios.Image = CType(resources.GetObject("PbUsuarios.Image"), System.Drawing.Image)
        Me.PbUsuarios.Location = New System.Drawing.Point(30, 202)
        Me.PbUsuarios.Name = "PbUsuarios"
        Me.PbUsuarios.Size = New System.Drawing.Size(975, 321)
        Me.PbUsuarios.TabIndex = 14
        Me.PbUsuarios.TabStop = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.White
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnVolver.Location = New System.Drawing.Point(880, 529)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(89, 29)
        Me.btnVolver.TabIndex = 65
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        Me.btnVolver.Visible = False
        '
        'lblTituloCursos
        '
        Me.lblTituloCursos.AutoSize = True
        Me.lblTituloCursos.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloCursos.ForeColor = System.Drawing.Color.Black
        Me.lblTituloCursos.Location = New System.Drawing.Point(26, 17)
        Me.lblTituloCursos.Name = "lblTituloCursos"
        Me.lblTituloCursos.Size = New System.Drawing.Size(137, 45)
        Me.lblTituloCursos.TabIndex = 66
        Me.lblTituloCursos.Text = "Usuarios"
        '
        'UctrlListarYBuscarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblTituloCursos)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.dgUsuarios)
        Me.Controls.Add(Me.btnCrearUsuario)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.PbUsuarios)
        Me.Location = New System.Drawing.Point(145, 50)
        Me.Name = "UctrlListarYBuscarUsuario"
        Me.Size = New System.Drawing.Size(1037, 578)
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PbUsuarios As System.Windows.Forms.PictureBox
    Friend WithEvents btnCrearUsuario As System.Windows.Forms.Button
    Friend WithEvents dgUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Identificación As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RolAsignado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CorreoElect As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents opciones As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblTituloCursos As System.Windows.Forms.Label

End Class
