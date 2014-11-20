Public Class uCtrlReporteRegistroAcciones

    
    Private Sub uCtrlReporteRegistroAcciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Me.Tb_BitacoraAccionTableAdapter.Fill(Me.DB_Proyecto2DataSetConsultarRegistroAcciones.Tb_BitacoraAccion)

            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception

            Dim UCtrl As New UctrlAlerta

            Me.Controls.Add(UCtrl)
            UCtrl.txtAlerta.Text = ex.Message
            UCtrl.Location = New Point(300, 100)
            UCtrl.BringToFront()
            UCtrl.Show()

        End Try
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class
