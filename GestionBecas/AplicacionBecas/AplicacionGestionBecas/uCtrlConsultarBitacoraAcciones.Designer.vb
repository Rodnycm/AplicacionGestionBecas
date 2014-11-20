<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlConsultarBitacoraAcciones
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
        Me.Tb_BitácoraAcciónBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_Proyecto2DataSet = New AplicacionGestionBecas.DB_Proyecto2DataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Tb_BitácoraAcciónTableAdapter = New AplicacionGestionBecas.DB_Proyecto2DataSetTableAdapters.Tb_BitácoraAcciónTableAdapter()
        CType(Me.Tb_BitácoraAcciónBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_Proyecto2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tb_BitácoraAcciónBindingSource
        '
        Me.Tb_BitácoraAcciónBindingSource.DataMember = "Tb_BitácoraAcción"
        Me.Tb_BitácoraAcciónBindingSource.DataSource = Me.DB_Proyecto2DataSet
        '
        'DB_Proyecto2DataSet
        '
        Me.DB_Proyecto2DataSet.DataSetName = "DB_Proyecto2DataSet"
        Me.DB_Proyecto2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSize = True
        Me.ReportViewer1.DocumentMapWidth = 55
        ReportDataSource1.Name = "DataSetRegistroAcciones"
        ReportDataSource1.Value = Me.Tb_BitácoraAcciónBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AplicacionGestionBecas.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(668, 331)
        Me.ReportViewer1.TabIndex = 0
        '
        'Tb_BitácoraAcciónTableAdapter
        '
        Me.Tb_BitácoraAcciónTableAdapter.ClearBeforeFill = True
        '
        'uCtrlConsultarBitacoraAcciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "uCtrlConsultarBitacoraAcciones"
        Me.Size = New System.Drawing.Size(674, 338)
        CType(Me.Tb_BitácoraAcciónBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_Proyecto2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Tb_BitácoraAcciónBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DB_Proyecto2DataSet As AplicacionGestionBecas.DB_Proyecto2DataSet
    Friend WithEvents Tb_BitácoraAcciónTableAdapter As AplicacionGestionBecas.DB_Proyecto2DataSetTableAdapters.Tb_BitácoraAcciónTableAdapter

End Class
