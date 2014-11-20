<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCtrlConsultarUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCtrlConsultarUsuario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PbUsuarios = New System.Windows.Forms.PictureBox()
        Me.dgUsuarios = New System.Windows.Forms.DataGridView()
        Me.Identificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.PbUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PbUsuarios
        '
        Me.PbUsuarios.BackgroundImage = CType(resources.GetObject("PbUsuarios.BackgroundImage"), System.Drawing.Image)
        Me.PbUsuarios.Image = CType(resources.GetObject("PbUsuarios.Image"), System.Drawing.Image)
        Me.PbUsuarios.Location = New System.Drawing.Point(90, 215)
        Me.PbUsuarios.Name = "PbUsuarios"
        Me.PbUsuarios.Size = New System.Drawing.Size(866, 238)
        Me.PbUsuarios.TabIndex = 15
        Me.PbUsuarios.TabStop = False
        '
        'dgUsuarios
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Light", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgUsuarios.BackgroundColor = System.Drawing.Color.White
        Me.dgUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Light", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identificacion, Me.Nombre, Me.Telefono, Me.fechaNacimiento, Me.genero, Me.rol, Me.correo})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgUsuarios.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgUsuarios.GridColor = System.Drawing.Color.White
        Me.dgUsuarios.Location = New System.Drawing.Point(90, 244)
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgUsuarios.RowHeadersVisible = False
        Me.dgUsuarios.Size = New System.Drawing.Size(866, 209)
        Me.dgUsuarios.TabIndex = 17
        '
        'Identificacion
        '
        Me.Identificacion.FillWeight = 87.01656!
        Me.Identificacion.HeaderText = "Identificación "
        Me.Identificacion.Name = "Identificacion"
        Me.Identificacion.Width = 105
        '
        'Nombre
        '
        Me.Nombre.FillWeight = 133.0179!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 161
        '
        'Telefono
        '
        Me.Telefono.FillWeight = 84.55829!
        Me.Telefono.HeaderText = "Teléfono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Width = 102
        '
        'fechaNacimiento
        '
        Me.fechaNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.fechaNacimiento.HeaderText = "Fecha de Nacimiento"
        Me.fechaNacimiento.Name = "fechaNacimiento"
        Me.fechaNacimiento.Width = 168
        '
        'genero
        '
        Me.genero.FillWeight = 89.92645!
        Me.genero.HeaderText = "Género"
        Me.genero.Name = "genero"
        Me.genero.Width = 108
        '
        'rol
        '
        Me.rol.FillWeight = 86.24375!
        Me.rol.HeaderText = "Rol Asignado"
        Me.rol.Name = "rol"
        Me.rol.Width = 104
        '
        'correo
        '
        Me.correo.FillWeight = 119.237!
        Me.correo.HeaderText = "Correo Electrónico"
        Me.correo.Name = "correo"
        Me.correo.Width = 144
        '
        'btnVolver
        '
        Me.btnVolver.BackgroundImage = CType(resources.GetObject("btnVolver.BackgroundImage"), System.Drawing.Image)
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(824, 533)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(132, 41)
        Me.btnVolver.TabIndex = 19
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'UCtrlConsultarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.dgUsuarios)
        Me.Controls.Add(Me.PbUsuarios)
        Me.Name = "UCtrlConsultarUsuario"
        Me.Size = New System.Drawing.Size(1032, 642)
        CType(Me.PbUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PbUsuarios As System.Windows.Forms.PictureBox
    Friend WithEvents dgUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents Identificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaNacimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents genero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents correo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnVolver As System.Windows.Forms.Button

End Class
