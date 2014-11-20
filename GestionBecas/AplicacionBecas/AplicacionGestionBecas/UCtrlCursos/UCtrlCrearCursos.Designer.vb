<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCtrlCrearCursos
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
        Me.btnAgregarCurso = New System.Windows.Forms.Button()
        Me.btnCancelarAgregarCurso = New System.Windows.Forms.Button()
        Me.txtPrecioCurso = New System.Windows.Forms.TextBox()
        Me.lblPrecioCurso = New System.Windows.Forms.Label()
        Me.txtCreditosCurso = New System.Windows.Forms.TextBox()
        Me.lblCreditosCurso = New System.Windows.Forms.Label()
        Me.lblCuatrimestre = New System.Windows.Forms.Label()
        Me.txtCodigoCurso = New System.Windows.Forms.TextBox()
        Me.lblCodigoCurso = New System.Windows.Forms.Label()
        Me.txtNombreCurso = New System.Windows.Forms.TextBox()
        Me.lblNombreCurso = New System.Windows.Forms.Label()
        Me.cmbCuatrimestreCurso = New System.Windows.Forms.ComboBox()
        Me.imgCrearCurso = New System.Windows.Forms.PictureBox()
        CType(Me.imgCrearCurso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgregarCurso
        '
        Me.btnAgregarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCurso.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCurso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnAgregarCurso.Location = New System.Drawing.Point(362, 215)
        Me.btnAgregarCurso.Name = "btnAgregarCurso"
        Me.btnAgregarCurso.Size = New System.Drawing.Size(86, 29)
        Me.btnAgregarCurso.TabIndex = 26
        Me.btnAgregarCurso.Text = "Añadir"
        Me.btnAgregarCurso.UseVisualStyleBackColor = True
        '
        'btnCancelarAgregarCurso
        '
        Me.btnCancelarAgregarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarAgregarCurso.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarAgregarCurso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnCancelarAgregarCurso.Location = New System.Drawing.Point(260, 215)
        Me.btnCancelarAgregarCurso.Name = "btnCancelarAgregarCurso"
        Me.btnCancelarAgregarCurso.Size = New System.Drawing.Size(86, 29)
        Me.btnCancelarAgregarCurso.TabIndex = 25
        Me.btnCancelarAgregarCurso.Text = "Cancelar"
        Me.btnCancelarAgregarCurso.UseVisualStyleBackColor = True
        '
        'txtPrecioCurso
        '
        Me.txtPrecioCurso.Location = New System.Drawing.Point(327, 88)
        Me.txtPrecioCurso.Name = "txtPrecioCurso"
        Me.txtPrecioCurso.Size = New System.Drawing.Size(121, 20)
        Me.txtPrecioCurso.TabIndex = 24
        '
        'lblPrecioCurso
        '
        Me.lblPrecioCurso.AutoSize = True
        Me.lblPrecioCurso.BackColor = System.Drawing.Color.White
        Me.lblPrecioCurso.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioCurso.Location = New System.Drawing.Point(256, 85)
        Me.lblPrecioCurso.Name = "lblPrecioCurso"
        Me.lblPrecioCurso.Size = New System.Drawing.Size(51, 21)
        Me.lblPrecioCurso.TabIndex = 23
        Me.lblPrecioCurso.Text = "Precio"
        '
        'txtCreditosCurso
        '
        Me.txtCreditosCurso.Location = New System.Drawing.Point(327, 54)
        Me.txtCreditosCurso.Name = "txtCreditosCurso"
        Me.txtCreditosCurso.Size = New System.Drawing.Size(121, 20)
        Me.txtCreditosCurso.TabIndex = 22
        '
        'lblCreditosCurso
        '
        Me.lblCreditosCurso.AutoSize = True
        Me.lblCreditosCurso.BackColor = System.Drawing.Color.White
        Me.lblCreditosCurso.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditosCurso.Location = New System.Drawing.Point(256, 51)
        Me.lblCreditosCurso.Name = "lblCreditosCurso"
        Me.lblCreditosCurso.Size = New System.Drawing.Size(65, 21)
        Me.lblCreditosCurso.TabIndex = 21
        Me.lblCreditosCurso.Text = "Créditos"
        '
        'lblCuatrimestre
        '
        Me.lblCuatrimestre.AutoSize = True
        Me.lblCuatrimestre.BackColor = System.Drawing.Color.White
        Me.lblCuatrimestre.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuatrimestre.Location = New System.Drawing.Point(3, 120)
        Me.lblCuatrimestre.Name = "lblCuatrimestre"
        Me.lblCuatrimestre.Size = New System.Drawing.Size(95, 21)
        Me.lblCuatrimestre.TabIndex = 19
        Me.lblCuatrimestre.Text = "Cuatrimestre"
        '
        'txtCodigoCurso
        '
        Me.txtCodigoCurso.Location = New System.Drawing.Point(104, 86)
        Me.txtCodigoCurso.Name = "txtCodigoCurso"
        Me.txtCodigoCurso.Size = New System.Drawing.Size(121, 20)
        Me.txtCodigoCurso.TabIndex = 18
        '
        'lblCodigoCurso
        '
        Me.lblCodigoCurso.AutoSize = True
        Me.lblCodigoCurso.BackColor = System.Drawing.Color.White
        Me.lblCodigoCurso.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoCurso.Location = New System.Drawing.Point(3, 83)
        Me.lblCodigoCurso.Name = "lblCodigoCurso"
        Me.lblCodigoCurso.Size = New System.Drawing.Size(59, 21)
        Me.lblCodigoCurso.TabIndex = 17
        Me.lblCodigoCurso.Text = "Código"
        '
        'txtNombreCurso
        '
        Me.txtNombreCurso.Location = New System.Drawing.Point(104, 54)
        Me.txtNombreCurso.Name = "txtNombreCurso"
        Me.txtNombreCurso.Size = New System.Drawing.Size(121, 20)
        Me.txtNombreCurso.TabIndex = 16
        '
        'lblNombreCurso
        '
        Me.lblNombreCurso.AutoSize = True
        Me.lblNombreCurso.BackColor = System.Drawing.Color.White
        Me.lblNombreCurso.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCurso.Location = New System.Drawing.Point(3, 51)
        Me.lblNombreCurso.Name = "lblNombreCurso"
        Me.lblNombreCurso.Size = New System.Drawing.Size(65, 21)
        Me.lblNombreCurso.TabIndex = 15
        Me.lblNombreCurso.Text = "Nombre"
        '
        'cmbCuatrimestreCurso
        '
        Me.cmbCuatrimestreCurso.FormattingEnabled = True
        Me.cmbCuatrimestreCurso.Items.AddRange(New Object() {"Primero", "Segundo", "Tercero"})
        Me.cmbCuatrimestreCurso.Location = New System.Drawing.Point(104, 123)
        Me.cmbCuatrimestreCurso.Name = "cmbCuatrimestreCurso"
        Me.cmbCuatrimestreCurso.Size = New System.Drawing.Size(121, 21)
        Me.cmbCuatrimestreCurso.TabIndex = 27
        '
        'imgCrearCurso
        '

        Me.imgCrearCurso.Location = New System.Drawing.Point(0, 0)
        Me.imgCrearCurso.Name = "imgCrearCurso"
        Me.imgCrearCurso.Size = New System.Drawing.Size(458, 252)
        Me.imgCrearCurso.TabIndex = 14
        Me.imgCrearCurso.TabStop = False
        '
        'UCtrlCrearCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.cmbCuatrimestreCurso)
        Me.Controls.Add(Me.btnAgregarCurso)
        Me.Controls.Add(Me.btnCancelarAgregarCurso)
        Me.Controls.Add(Me.txtPrecioCurso)
        Me.Controls.Add(Me.lblPrecioCurso)
        Me.Controls.Add(Me.txtCreditosCurso)
        Me.Controls.Add(Me.lblCreditosCurso)
        Me.Controls.Add(Me.lblCuatrimestre)
        Me.Controls.Add(Me.txtCodigoCurso)
        Me.Controls.Add(Me.lblCodigoCurso)
        Me.Controls.Add(Me.txtNombreCurso)
        Me.Controls.Add(Me.lblNombreCurso)
        Me.Controls.Add(Me.imgCrearCurso)
        Me.Name = "UCtrlCrearCursos"
        Me.Size = New System.Drawing.Size(458, 252)
        CType(Me.imgCrearCurso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregarCurso As System.Windows.Forms.Button
    Friend WithEvents btnCancelarAgregarCurso As System.Windows.Forms.Button
    Friend WithEvents txtPrecioCurso As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecioCurso As System.Windows.Forms.Label
    Friend WithEvents txtCreditosCurso As System.Windows.Forms.TextBox
    Friend WithEvents lblCreditosCurso As System.Windows.Forms.Label
    Friend WithEvents lblCuatrimestre As System.Windows.Forms.Label
    Friend WithEvents txtCodigoCurso As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigoCurso As System.Windows.Forms.Label
    Friend WithEvents txtNombreCurso As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreCurso As System.Windows.Forms.Label
    Friend WithEvents imgCrearCurso As System.Windows.Forms.PictureBox
    Friend WithEvents cmbCuatrimestreCurso As System.Windows.Forms.ComboBox

End Class
