<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlListarRol
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCtrlListarRol))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvRoles = New System.Windows.Forms.DataGridView()
        Me.dtaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.PbRoles = New System.Windows.Forms.PictureBox()
        Me.btnCrearRol = New System.Windows.Forms.Button()
        Me.DGVRol = New System.Windows.Forms.DataGridView()
        Me.dtaId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaOpciones = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PbUsuarios = New System.Windows.Forms.PictureBox()
        Me.txtBuscarRol = New System.Windows.Forms.TextBox()
        Me.btnCrearRoles = New System.Windows.Forms.Button()
        Me.lblTituloRoles = New System.Windows.Forms.Label()
        CType(Me.dgvRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVRol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRoles
        '
        Me.dgvRoles.BackgroundColor = System.Drawing.Color.White
        Me.dgvRoles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtaNombre})
        Me.dgvRoles.GridColor = System.Drawing.Color.White
        Me.dgvRoles.Location = New System.Drawing.Point(43, 197)
        Me.dgvRoles.Name = "dgvRoles"
        Me.dgvRoles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvRoles.RowHeadersVisible = False
        Me.dgvRoles.Size = New System.Drawing.Size(778, 208)
        Me.dgvRoles.TabIndex = 12
        '
        'dtaNombre
        '
        Me.dtaNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dtaNombre.HeaderText = "Nombre"
        Me.dtaNombre.Name = "dtaNombre"
        Me.dtaNombre.ReadOnly = True
        Me.dtaNombre.Width = 200
        '
        'ComboBox
        '
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Items.AddRange(New Object() {"Ver", "Editar", "Eliminar"})
        Me.ComboBox.Location = New System.Drawing.Point(360, 232)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox.TabIndex = 14
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(130, 65)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscar.TabIndex = 15
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(49, 63)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(50, 20)
        Me.lblBuscar.TabIndex = 16
        Me.lblBuscar.Text = "Buscar"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(270, 55)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(102, 34)
        Me.btnBuscar.TabIndex = 17
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'PbRoles
        '
        Me.PbRoles.Image = CType(resources.GetObject("PbRoles.Image"), System.Drawing.Image)
        Me.PbRoles.Location = New System.Drawing.Point(43, 167)
        Me.PbRoles.Name = "PbRoles"
        Me.PbRoles.Size = New System.Drawing.Size(778, 238)
        Me.PbRoles.TabIndex = 11
        Me.PbRoles.TabStop = False
        '
        'btnCrearRol
        '
        Me.btnCrearRol.BackgroundImage = CType(resources.GetObject("btnCrearRol.BackgroundImage"), System.Drawing.Image)
        Me.btnCrearRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearRol.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearRol.ForeColor = System.Drawing.Color.White
        Me.btnCrearRol.Location = New System.Drawing.Point(599, 65)
        Me.btnCrearRol.Name = "btnCrearRol"
        Me.btnCrearRol.Size = New System.Drawing.Size(222, 79)
        Me.btnCrearRol.TabIndex = 5
        Me.btnCrearRol.Text = "Crear Rol"
        Me.btnCrearRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCrearRol.UseVisualStyleBackColor = True
        '
        'DGVRol
        '
        Me.DGVRol.AllowUserToAddRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVRol.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGVRol.BackgroundColor = System.Drawing.Color.White
        Me.DGVRol.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVRol.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVRol.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGVRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRol.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtaId, Me.dtNombre, Me.dtaOpciones})
        Me.DGVRol.GridColor = System.Drawing.Color.White
        Me.DGVRol.Location = New System.Drawing.Point(41, 204)
        Me.DGVRol.Name = "DGVRol"
        Me.DGVRol.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVRol.RowHeadersVisible = False
        Me.DGVRol.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGVRol.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.DGVRol.Size = New System.Drawing.Size(947, 271)
        Me.DGVRol.TabIndex = 31
        '
        'dtaId
        '
        Me.dtaId.HeaderText = "Id"
        Me.dtaId.Name = "dtaId"
        Me.dtaId.Visible = False
        '
        'dtNombre
        '
        Me.dtNombre.HeaderText = "Nombre"
        Me.dtNombre.Name = "dtNombre"
        Me.dtNombre.Width = 473
        '
        'dtaOpciones
        '
        Me.dtaOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dtaOpciones.HeaderText = "Opciones"
        Me.dtaOpciones.Items.AddRange(New Object() {"Ver", "Editar", "Eliminar"})
        Me.dtaOpciones.Name = "dtaOpciones"
        Me.dtaOpciones.Width = 473
        '
        'PbUsuarios
        '
        Me.PbUsuarios.BackgroundImage = CType(resources.GetObject("PbUsuarios.BackgroundImage"), System.Drawing.Image)
        Me.PbUsuarios.Image = CType(resources.GetObject("PbUsuarios.Image"), System.Drawing.Image)
        Me.PbUsuarios.Location = New System.Drawing.Point(31, 174)
        Me.PbUsuarios.Name = "PbUsuarios"
        Me.PbUsuarios.Size = New System.Drawing.Size(975, 321)
        Me.PbUsuarios.TabIndex = 30
        Me.PbUsuarios.TabStop = False
        '
        'txtBuscarRol
        '
        Me.txtBuscarRol.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtBuscarRol.Location = New System.Drawing.Point(31, 136)
        Me.txtBuscarRol.Name = "txtBuscarRol"
        Me.txtBuscarRol.Size = New System.Drawing.Size(746, 27)
        Me.txtBuscarRol.TabIndex = 29
        Me.txtBuscarRol.Text = "Buscar:"
        '
        'btnCrearRoles
        '
        Me.btnCrearRoles.BackgroundImage = CType(resources.GetObject("btnCrearRoles.BackgroundImage"), System.Drawing.Image)
        Me.btnCrearRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearRoles.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearRoles.ForeColor = System.Drawing.Color.White
        Me.btnCrearRoles.Location = New System.Drawing.Point(784, 84)
        Me.btnCrearRoles.Name = "btnCrearRoles"
        Me.btnCrearRoles.Size = New System.Drawing.Size(222, 79)
        Me.btnCrearRoles.TabIndex = 28
        Me.btnCrearRoles.Text = "Crear Rol"
        Me.btnCrearRoles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCrearRoles.UseVisualStyleBackColor = True
        '
        'lblTituloRoles
        '
        Me.lblTituloRoles.AutoSize = True
        Me.lblTituloRoles.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloRoles.ForeColor = System.Drawing.Color.Black
        Me.lblTituloRoles.Location = New System.Drawing.Point(26, 17)
        Me.lblTituloRoles.Name = "lblTituloRoles"
        Me.lblTituloRoles.Size = New System.Drawing.Size(91, 45)
        Me.lblTituloRoles.TabIndex = 33
        Me.lblTituloRoles.Text = "Roles"
        '
        'uCtrlListarRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblTituloRoles)
        Me.Controls.Add(Me.DGVRol)
        Me.Controls.Add(Me.PbUsuarios)
        Me.Controls.Add(Me.txtBuscarRol)
        Me.Controls.Add(Me.btnCrearRoles)
        Me.Location = New System.Drawing.Point(145, 50)
        Me.Name = "uCtrlListarRol"
        Me.Size = New System.Drawing.Size(1037, 578)
        CType(Me.dgvRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVRol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCrearRol As System.Windows.Forms.Button
    Friend WithEvents PbRoles As System.Windows.Forms.PictureBox
    Friend WithEvents dgvRoles As System.Windows.Forms.DataGridView
    Public WithEvents ventana As UI.UCntrlRegistrarRol
    Friend WithEvents dtaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UCntrlRegistrarRol1 As UI.UCntrlRegistrarRol
    Friend WithEvents ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents DGVRol As System.Windows.Forms.DataGridView
    Friend WithEvents PbUsuarios As System.Windows.Forms.PictureBox
    Friend WithEvents txtBuscarRol As System.Windows.Forms.TextBox
    Friend WithEvents btnCrearRoles As System.Windows.Forms.Button
    Friend WithEvents dtaId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaOpciones As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents lblTituloRoles As System.Windows.Forms.Label

End Class
