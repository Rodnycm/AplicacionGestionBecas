<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCtrlAsignarNotasCurso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCtrlAsignarNotasCurso))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.imgBuscarCursos = New System.Windows.Forms.PictureBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgUsuarios = New System.Windows.Forms.DataGridView()
        Me.Identificación = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RolAsignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CorreoElect = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.opciones = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.imgBuscarCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgBuscarCursos
        '
        Me.imgBuscarCursos.Image = CType(resources.GetObject("imgBuscarCursos.Image"), System.Drawing.Image)
        Me.imgBuscarCursos.Location = New System.Drawing.Point(30, 202)
        Me.imgBuscarCursos.Name = "imgBuscarCursos"
        Me.imgBuscarCursos.Size = New System.Drawing.Size(975, 321)
        Me.imgBuscarCursos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBuscarCursos.TabIndex = 27
        Me.imgBuscarCursos.TabStop = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(31, 158)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(746, 29)
        Me.txtBuscar.TabIndex = 31
        Me.txtBuscar.Text = "Buscar:"
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
        Me.dgUsuarios.TabIndex = 32
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
        Me.RolAsignado.Visible = False
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
        'UCtrlAsignarNotasCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.dgUsuarios)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.imgBuscarCursos)
        Me.Location = New System.Drawing.Point(145, 50)
        Me.Name = "UCtrlAsignarNotasCurso"
        Me.Size = New System.Drawing.Size(1011, 528)
        CType(Me.imgBuscarCursos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgBuscarCursos As System.Windows.Forms.PictureBox
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents dgUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents Identificación As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RolAsignado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CorreoElect As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents opciones As System.Windows.Forms.DataGridViewComboBoxColumn

End Class
