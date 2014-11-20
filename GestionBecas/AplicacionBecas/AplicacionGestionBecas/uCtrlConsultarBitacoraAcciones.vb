Public Class uCtrlConsultarBitacoraAcciones

    
    Private Sub uCtrlConsultarBitacoraAcciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Tb_BitácoraAcciónTableAdapter.Fill(Me.DB_Proyecto2DataSet.Tb_BitácoraAcción)

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class
