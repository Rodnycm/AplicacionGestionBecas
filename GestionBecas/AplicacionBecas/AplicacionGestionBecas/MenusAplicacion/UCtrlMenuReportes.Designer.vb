<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlMenuReportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCtrlMenuReportes))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnConsultarBitacoraAcciones = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnPlanDeEstudio = New System.Windows.Forms.Button()
        Me.lblTituloMenuAcademico = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnConsultarBitacoraAcciones, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button5, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPlanDeEstudio, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(250, 170)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.40174!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.59826!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(850, 229)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'btnConsultarBitacoraAcciones
        '
        Me.btnConsultarBitacoraAcciones.BackgroundImage = CType(resources.GetObject("btnConsultarBitacoraAcciones.BackgroundImage"), System.Drawing.Image)
        Me.btnConsultarBitacoraAcciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultarBitacoraAcciones.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultarBitacoraAcciones.ForeColor = System.Drawing.Color.White
        Me.btnConsultarBitacoraAcciones.Location = New System.Drawing.Point(3, 3)
        Me.btnConsultarBitacoraAcciones.MaximumSize = New System.Drawing.Size(128, 99)
        Me.btnConsultarBitacoraAcciones.MinimumSize = New System.Drawing.Size(128, 99)
        Me.btnConsultarBitacoraAcciones.Name = "btnConsultarBitacoraAcciones"
        Me.btnConsultarBitacoraAcciones.Size = New System.Drawing.Size(128, 99)
        Me.btnConsultarBitacoraAcciones.TabIndex = 8
        Me.btnConsultarBitacoraAcciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultarBitacoraAcciones.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(168, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(128, 99)
        Me.Button5.TabIndex = 10
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnPlanDeEstudio
        '
        Me.btnPlanDeEstudio.BackgroundImage = CType(resources.GetObject("btnPlanDeEstudio.BackgroundImage"), System.Drawing.Image)
        Me.btnPlanDeEstudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlanDeEstudio.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlanDeEstudio.ForeColor = System.Drawing.Color.White
        Me.btnPlanDeEstudio.Location = New System.Drawing.Point(333, 3)
        Me.btnPlanDeEstudio.Name = "btnPlanDeEstudio"
        Me.btnPlanDeEstudio.Size = New System.Drawing.Size(128, 99)
        Me.btnPlanDeEstudio.TabIndex = 9
        Me.btnPlanDeEstudio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPlanDeEstudio.UseVisualStyleBackColor = True
        '
        'lblTituloMenuAcademico
        '
        Me.lblTituloMenuAcademico.AutoSize = True
        Me.lblTituloMenuAcademico.Font = New System.Drawing.Font("Segoe UI Semilight", 28.0!)
        Me.lblTituloMenuAcademico.ForeColor = System.Drawing.Color.Black
        Me.lblTituloMenuAcademico.Location = New System.Drawing.Point(241, 65)
        Me.lblTituloMenuAcademico.Name = "lblTituloMenuAcademico"
        Me.lblTituloMenuAcademico.Size = New System.Drawing.Size(168, 51)
        Me.lblTituloMenuAcademico.TabIndex = 16
        Me.lblTituloMenuAcademico.Text = "Reportes"
        '
        'uCtrlMenuReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblTituloMenuAcademico)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "uCtrlMenuReportes"
        Me.Size = New System.Drawing.Size(1070, 551)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnConsultarBitacoraAcciones As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnPlanDeEstudio As System.Windows.Forms.Button
    Friend WithEvents lblTituloMenuAcademico As System.Windows.Forms.Label

End Class
