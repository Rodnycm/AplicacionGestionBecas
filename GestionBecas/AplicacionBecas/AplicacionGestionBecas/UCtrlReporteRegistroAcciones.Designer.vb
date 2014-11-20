<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlReporteRegistroAcciones
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
        Me.DB_Proyecto2DataSetConsultarRegistroAcciones = New UI.DB_Proyecto2DataSetConsultarRegistroAcciones()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.lblTituloMenuAcademico = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Tb_BitacoraAccionTableAdapter = New UI.DB_Proyecto2DataSetConsultarRegistroAccionesTableAdapters.Tb_BitacoraAccionTableAdapter()
        Me.DB_Proyecto2DataSet1 = New UI.DB_Proyecto2DataSet1()
        Me.DB_Proyecto2DataSet2 = New UI.DB_Proyecto2DataSet2()
        Me.DB_Proyecto2DataSet3 = New UI.DB_Proyecto2DataSet3()
        Me.Tb_RolesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_RolesTableAdapter = New UI.DB_Proyecto2DataSet3TableAdapters.Tb_RolesTableAdapter()
        CType(Me.Tb_BitacoraAccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_Proyecto2DataSetConsultarRegistroAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_Proyecto2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_Proyecto2DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_Proyecto2DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_RolesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tb_BitacoraAccionBindingSource
        '
        Me.Tb_BitacoraAccionBindingSource.DataMember = "Tb_BitacoraAccion"
        Me.Tb_BitacoraAccionBindingSource.DataSource = Me.DB_Proyecto2DataSetConsultarRegistroAcciones
        '
        'DB_Proyecto2DataSetConsultarRegistroAcciones
        '
        Me.DB_Proyecto2DataSetConsultarRegistroAcciones.DataSetName = "DB_Proyecto2DataSetConsultarRegistroAcciones"
        Me.DB_Proyecto2DataSetConsultarRegistroAcciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetRegistroAcciones"
        ReportDataSource1.Value = Me.Tb_BitacoraAccionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "UI.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(15, 126)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(966, 397)
        Me.ReportViewer1.TabIndex = 0
        '
        'lblTituloMenuAcademico
        '
        Me.lblTituloMenuAcademico.AutoSize = True
        Me.lblTituloMenuAcademico.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloMenuAcademico.ForeColor = System.Drawing.Color.Black
        Me.lblTituloMenuAcademico.Location = New System.Drawing.Point(-5, 13)
        Me.lblTituloMenuAcademico.Name = "lblTituloMenuAcademico"
        Me.lblTituloMenuAcademico.Size = New System.Drawing.Size(259, 45)
        Me.lblTituloMenuAcademico.TabIndex = 31
        Me.lblTituloMenuAcademico.Text = "Bitácora Acciones"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.UI.My.Resources.Resources.tablaFinalGrandeMorada
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(3, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(992, 451)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Tb_BitacoraAccionTableAdapter
        '
        Me.Tb_BitacoraAccionTableAdapter.ClearBeforeFill = True
        '
        'DB_Proyecto2DataSet1
        '
        Me.DB_Proyecto2DataSet1.DataSetName = "DB_Proyecto2DataSet1"
        Me.DB_Proyecto2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DB_Proyecto2DataSet2
        '
        Me.DB_Proyecto2DataSet2.DataSetName = "DB_Proyecto2DataSet2"
        Me.DB_Proyecto2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DB_Proyecto2DataSet3
        '
        Me.DB_Proyecto2DataSet3.DataSetName = "DB_Proyecto2DataSet3"
        Me.DB_Proyecto2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_RolesBindingSource
        '
        Me.Tb_RolesBindingSource.DataMember = "Tb_Roles"
        Me.Tb_RolesBindingSource.DataSource = Me.DB_Proyecto2DataSet3
        '
        'Tb_RolesTableAdapter
        '
        Me.Tb_RolesTableAdapter.ClearBeforeFill = True
        '
        'uCtrlReporteRegistroAcciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.lblTituloMenuAcademico)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Location = New System.Drawing.Point(170, 80)
        Me.Name = "uCtrlReporteRegistroAcciones"
        Me.Size = New System.Drawing.Size(1015, 550)
        CType(Me.Tb_BitacoraAccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_Proyecto2DataSetConsultarRegistroAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_Proyecto2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_Proyecto2DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_Proyecto2DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_RolesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Tb_BitacoraAccionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DB_Proyecto2DataSetConsultarRegistroAcciones As UI.DB_Proyecto2DataSetConsultarRegistroAcciones
    Friend WithEvents Tb_BitacoraAccionTableAdapter As UI.DB_Proyecto2DataSetConsultarRegistroAccionesTableAdapters.Tb_BitacoraAccionTableAdapter

    Friend WithEvents DB_Proyecto2DataSet1 As UI.DB_Proyecto2DataSet1
    Friend WithEvents lblTituloMenuAcademico As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DB_Proyecto2DataSet2 As UI.DB_Proyecto2DataSet2
    Friend WithEvents Tb_RolesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DB_Proyecto2DataSet3 As UI.DB_Proyecto2DataSet3
    Friend WithEvents Tb_RolesTableAdapter As UI.DB_Proyecto2DataSet3TableAdapters.Tb_RolesTableAdapter


End Class
