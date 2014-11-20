<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlReporteAcciones
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Tb_BitacoraAccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_Proyecto2DataSetConsultarAcciones = New AplicacionGestionBecas.DB_Proyecto2DataSetConsultarAcciones()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Tb_BitacoraAccionTableAdapter = New AplicacionGestionBecas.DB_Proyecto2DataSetConsultarAccionesTableAdapters.Tb_BitacoraAccionTableAdapter()
        CType(Me.Tb_BitacoraAccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_Proyecto2DataSetConsultarAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tb_BitacoraAccionBindingSource
        '
        Me.Tb_BitacoraAccionBindingSource.DataMember = "Tb_BitacoraAccion"
        Me.Tb_BitacoraAccionBindingSource.DataSource = Me.DB_Proyecto2DataSetConsultarAcciones
        '
        'DB_Proyecto2DataSetConsultarAcciones
        '
        Me.DB_Proyecto2DataSetConsultarAcciones.DataSetName = "DB_Proyecto2DataSetConsultarAcciones"
        Me.DB_Proyecto2DataSetConsultarAcciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetConsultarAcciones"
        ReportDataSource1.Value = Me.Tb_BitacoraAccionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AplicacionGestionBecas.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 16)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(753, 291)
        Me.ReportViewer1.TabIndex = 0
        '
        'Tb_BitacoraAccionTableAdapter
        '
        Me.Tb_BitacoraAccionTableAdapter.ClearBeforeFill = True
        '
        'uCtrlReporteAcciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "uCtrlReporteAcciones"
        Me.Size = New System.Drawing.Size(794, 325)
        CType(Me.Tb_BitacoraAccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_Proyecto2DataSetConsultarAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Tb_BitacoraAccionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DB_Proyecto2DataSetConsultarAcciones As AplicacionGestionBecas.DB_Proyecto2DataSetConsultarAcciones
    Friend WithEvents Tb_BitacoraAccionTableAdapter As AplicacionGestionBecas.DB_Proyecto2DataSetConsultarAccionesTableAdapters.Tb_BitacoraAccionTableAdapter

End Class
