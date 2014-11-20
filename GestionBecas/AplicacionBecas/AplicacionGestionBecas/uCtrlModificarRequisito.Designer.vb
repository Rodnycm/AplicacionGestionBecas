<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlModificarRequisito
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
        Me.btnEditarModificarRequisito = New System.Windows.Forms.Button()
        Me.btnCancelarModificarRequisito = New System.Windows.Forms.Button()
        Me.txtDescripcionRequisito = New System.Windows.Forms.TextBox()
        Me.lblCreditosCurso = New System.Windows.Forms.Label()
        Me.txtNombreRequisito = New System.Windows.Forms.TextBox()
        Me.lblNombreCurso = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEditarModificarRequisito
        '
        Me.btnEditarModificarRequisito.BackColor = System.Drawing.Color.White
        Me.btnEditarModificarRequisito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarModificarRequisito.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarModificarRequisito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnEditarModificarRequisito.Location = New System.Drawing.Point(347, 170)
        Me.btnEditarModificarRequisito.Name = "btnEditarModificarRequisito"
        Me.btnEditarModificarRequisito.Size = New System.Drawing.Size(86, 29)
        Me.btnEditarModificarRequisito.TabIndex = 44
        Me.btnEditarModificarRequisito.Text = "Editar"
        Me.btnEditarModificarRequisito.UseVisualStyleBackColor = False
        '
        'btnCancelarModificarRequisito
        '
        Me.btnCancelarModificarRequisito.BackColor = System.Drawing.Color.White
        Me.btnCancelarModificarRequisito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarModificarRequisito.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarModificarRequisito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnCancelarModificarRequisito.Location = New System.Drawing.Point(255, 170)
        Me.btnCancelarModificarRequisito.Name = "btnCancelarModificarRequisito"
        Me.btnCancelarModificarRequisito.Size = New System.Drawing.Size(86, 29)
        Me.btnCancelarModificarRequisito.TabIndex = 43
        Me.btnCancelarModificarRequisito.Text = "Cancelar"
        Me.btnCancelarModificarRequisito.UseVisualStyleBackColor = False
        '
        'txtDescripcionRequisito
        '
        Me.txtDescripcionRequisito.Location = New System.Drawing.Point(321, 57)
        Me.txtDescripcionRequisito.Name = "txtDescripcionRequisito"
        Me.txtDescripcionRequisito.Size = New System.Drawing.Size(121, 20)
        Me.txtDescripcionRequisito.TabIndex = 42
        '
        'lblCreditosCurso
        '
        Me.lblCreditosCurso.AutoSize = True
        Me.lblCreditosCurso.BackColor = System.Drawing.Color.White
        Me.lblCreditosCurso.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditosCurso.Location = New System.Drawing.Point(228, 57)
        Me.lblCreditosCurso.Name = "lblCreditosCurso"
        Me.lblCreditosCurso.Size = New System.Drawing.Size(87, 21)
        Me.lblCreditosCurso.TabIndex = 41
        Me.lblCreditosCurso.Text = "Descripción"
        '
        'txtNombreRequisito
        '
        Me.txtNombreRequisito.Location = New System.Drawing.Point(79, 57)
        Me.txtNombreRequisito.Name = "txtNombreRequisito"
        Me.txtNombreRequisito.Size = New System.Drawing.Size(121, 20)
        Me.txtNombreRequisito.TabIndex = 40
        '
        'lblNombreCurso
        '
        Me.lblNombreCurso.AutoSize = True
        Me.lblNombreCurso.BackColor = System.Drawing.Color.White
        Me.lblNombreCurso.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCurso.Location = New System.Drawing.Point(8, 56)
        Me.lblNombreCurso.Name = "lblNombreCurso"
        Me.lblNombreCurso.Size = New System.Drawing.Size(65, 21)
        Me.lblNombreCurso.TabIndex = 39
        Me.lblNombreCurso.Text = "Nombre"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(321, 95)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(121, 20)
        Me.txtId.TabIndex = 45
        Me.txtId.Visible = False
        '
        'uCtrlModificarRequisito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UI.My.Resources.Resources.tablaFinalMedianaAzul3
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.btnEditarModificarRequisito)
        Me.Controls.Add(Me.btnCancelarModificarRequisito)
        Me.Controls.Add(Me.txtDescripcionRequisito)
        Me.Controls.Add(Me.lblCreditosCurso)
        Me.Controls.Add(Me.txtNombreRequisito)
        Me.Controls.Add(Me.lblNombreCurso)
        Me.Name = "uCtrlModificarRequisito"
        Me.Size = New System.Drawing.Size(460, 215)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEditarModificarRequisito As System.Windows.Forms.Button
    Friend WithEvents btnCancelarModificarRequisito As System.Windows.Forms.Button
    Friend WithEvents txtDescripcionRequisito As System.Windows.Forms.TextBox
    Friend WithEvents lblCreditosCurso As System.Windows.Forms.Label
    Friend WithEvents txtNombreRequisito As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreCurso As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox

End Class
