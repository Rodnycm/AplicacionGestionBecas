Imports System.Windows.Forms.VisualStyles.VisualStyleElement

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCtrlBuscarCursos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCtrlBuscarCursos))
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.dtaListarCursos = New System.Windows.Forms.DataGridView()
        Me.lblTituloCursos = New System.Windows.Forms.Label()
        Me.btnCrearCurso = New System.Windows.Forms.Button()
        Me.txtBuscarCurso = New System.Windows.Forms.TextBox()
        Me.imgBuscarCursos = New System.Windows.Forms.PictureBox()
        Me.columnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuatrimestre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Créditos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.columId = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.dtaListarCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBuscarCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.BackColor = System.Drawing.Color.White
        Me.lblBuscar.Font = New System.Drawing.Font("Segoe UI Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(437, 150)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(0, 23)
        Me.lblBuscar.TabIndex = 30
        '
        'dtaListarCursos
        '
        Me.dtaListarCursos.AllowUserToAddRows = False
        Me.dtaListarCursos.BackgroundColor = System.Drawing.Color.White
        Me.dtaListarCursos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtaListarCursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtaListarCursos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtaListarCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtaListarCursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnNombre, Me.Column1, Me.Cuatrimestre, Me.Créditos, Me.Precio, Me.Column2, Me.columId})
        Me.dtaListarCursos.GridColor = System.Drawing.Color.White
        Me.dtaListarCursos.Location = New System.Drawing.Point(37, 255)
        Me.dtaListarCursos.Name = "dtaListarCursos"
        Me.dtaListarCursos.RowHeadersVisible = False
        Me.dtaListarCursos.Size = New System.Drawing.Size(951, 271)
        Me.dtaListarCursos.TabIndex = 38
        '
        'lblTituloCursos
        '
        Me.lblTituloCursos.AutoSize = True
        Me.lblTituloCursos.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloCursos.ForeColor = System.Drawing.Color.Black
        Me.lblTituloCursos.Location = New System.Drawing.Point(29, 36)
        Me.lblTituloCursos.Name = "lblTituloCursos"
        Me.lblTituloCursos.Size = New System.Drawing.Size(113, 45)
        Me.lblTituloCursos.TabIndex = 37
        Me.lblTituloCursos.Text = "Cursos"
        '
        'btnCrearCurso
        '
        Me.btnCrearCurso.BackgroundImage = CType(resources.GetObject("btnCrearCurso.BackgroundImage"), System.Drawing.Image)
        Me.btnCrearCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearCurso.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearCurso.ForeColor = System.Drawing.Color.White
        Me.btnCrearCurso.Location = New System.Drawing.Point(786, 125)
        Me.btnCrearCurso.Name = "btnCrearCurso"
        Me.btnCrearCurso.Size = New System.Drawing.Size(222, 79)
        Me.btnCrearCurso.TabIndex = 36
        Me.btnCrearCurso.Text = "Crear Curso"
        Me.btnCrearCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCrearCurso.UseVisualStyleBackColor = True
        '
        'txtBuscarCurso
        '
        Me.txtBuscarCurso.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarCurso.ForeColor = System.Drawing.Color.Black
        Me.txtBuscarCurso.Location = New System.Drawing.Point(34, 177)
        Me.txtBuscarCurso.Name = "txtBuscarCurso"
        Me.txtBuscarCurso.Size = New System.Drawing.Size(746, 27)
        Me.txtBuscarCurso.TabIndex = 35
        Me.txtBuscarCurso.Text = "Buscar:"
        '
        'imgBuscarCursos
        '
        Me.imgBuscarCursos.Image = CType(resources.GetObject("imgBuscarCursos.Image"), System.Drawing.Image)
        Me.imgBuscarCursos.Location = New System.Drawing.Point(33, 221)
        Me.imgBuscarCursos.Name = "imgBuscarCursos"
        Me.imgBuscarCursos.Size = New System.Drawing.Size(975, 321)
        Me.imgBuscarCursos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBuscarCursos.TabIndex = 34
        Me.imgBuscarCursos.TabStop = False
        '
        'columnNombre
        '
        Me.columnNombre.HeaderText = "Nombre"
        Me.columnNombre.Name = "columnNombre"
        Me.columnNombre.ReadOnly = True
        Me.columnNombre.Width = 160
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 160
        '
        'Cuatrimestre
        '
        Me.Cuatrimestre.HeaderText = "Cuatrimestre"
        Me.Cuatrimestre.Name = "Cuatrimestre"
        Me.Cuatrimestre.ReadOnly = True
        Me.Cuatrimestre.Width = 160
        '
        'Créditos
        '
        Me.Créditos.HeaderText = "Créditos"
        Me.Créditos.Name = "Créditos"
        Me.Créditos.ReadOnly = True
        Me.Créditos.Width = 160
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 160
        '
        'Column2
        '
        Me.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column2.HeaderText = "Opciones"
        Me.Column2.Items.AddRange(New Object() {"Editar", "Eliminar"})
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 145
        '
        'columId
        '
        Me.columId.HeaderText = ""
        Me.columId.Name = "columId"
        Me.columId.Visible = False
        '
        'UCtrlBuscarCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.dtaListarCursos)
        Me.Controls.Add(Me.lblTituloCursos)
        Me.Controls.Add(Me.btnCrearCurso)
        Me.Controls.Add(Me.txtBuscarCurso)
        Me.Controls.Add(Me.imgBuscarCursos)
        Me.Controls.Add(Me.lblBuscar)
        Me.Location = New System.Drawing.Point(145, 50)
        Me.Name = "UCtrlBuscarCursos"
        Me.Size = New System.Drawing.Size(1037, 578)
        CType(Me.dtaListarCursos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBuscarCursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents dtaListarCursos As System.Windows.Forms.DataGridView
    Friend WithEvents lblTituloCursos As System.Windows.Forms.Label
    Friend WithEvents btnCrearCurso As System.Windows.Forms.Button
    Friend WithEvents txtBuscarCurso As System.Windows.Forms.TextBox
    Friend WithEvents imgBuscarCursos As System.Windows.Forms.PictureBox
    Friend WithEvents columnNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuatrimestre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Créditos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents columId As System.Windows.Forms.DataGridViewComboBoxColumn

End Class
