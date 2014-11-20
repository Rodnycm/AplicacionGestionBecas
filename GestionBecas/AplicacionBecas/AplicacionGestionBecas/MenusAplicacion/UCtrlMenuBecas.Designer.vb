<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlMenuBecas
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
        Me.lblTituloMenuAcademico = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTituloMenuAcademico
        '
        Me.lblTituloMenuAcademico.AutoSize = True
        Me.lblTituloMenuAcademico.Font = New System.Drawing.Font("Segoe UI Light", 16.0!)
        Me.lblTituloMenuAcademico.ForeColor = System.Drawing.Color.Black
        Me.lblTituloMenuAcademico.Location = New System.Drawing.Point(306, 42)
        Me.lblTituloMenuAcademico.Name = "lblTituloMenuAcademico"
        Me.lblTituloMenuAcademico.Size = New System.Drawing.Size(66, 30)
        Me.lblTituloMenuAcademico.TabIndex = 15
        Me.lblTituloMenuAcademico.Text = "Becas"
        '
        'uCtrlMenuBecas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblTituloMenuAcademico)
        Me.Name = "uCtrlMenuBecas"
        Me.Size = New System.Drawing.Size(1070, 388)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTituloMenuAcademico As System.Windows.Forms.Label

End Class
