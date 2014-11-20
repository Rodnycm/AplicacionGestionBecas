Public Class uCtrlMenuReportes


    Public Property uctrlReportesBitcoraAcciones As New uCtrlReporteRegistroAcciones()
    Public Property uctrlPlanEstudio As New uCtrlConsultarPlanDeEstudio()

    Private Sub btnConsultarBitacoraAcciones_Click(sender As Object, e As EventArgs) Handles btnConsultarBitacoraAcciones.Click


        Me.Hide()
        uctrlReportesBitcoraAcciones = New uCtrlReporteRegistroAcciones()
        FrmIniciarSesion.principal.Controls.Add(uctrlReportesBitcoraAcciones)
        uctrlReportesBitcoraAcciones.Show()


    End Sub


    Private Sub btnPlanDeEstudio_Click(sender As Object, e As EventArgs) Handles btnPlanDeEstudio.Click

         Me.Hide()
        uctrlPlanEstudio = New uCtrlConsultarPlanDeEstudio()
        FrmIniciarSesion.principal.Controls.Add(uctrlPlanEstudio)
        uctrlPlanEstudio.Show()
        uctrlPlanEstudio.Location = New Point(170, 120)

    End Sub
End Class
