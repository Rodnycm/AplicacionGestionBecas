Public Class uCtrlMenuAcademico
    Public Property uCtrlAsignarNotas As uCtrlAsignarCursosCarrera = New uCtrlAsignarCursosCarrera()
    Dim uCtrlCarreras As uCtrlMantenimientoCarreras = New uCtrlMantenimientoCarreras()

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Controls.Add(uCtrlCarreras)
        'ucMenuAcad.Hide()
        uCtrlCarreras.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        FrmIniciarSesion.principal.Controls.Add(uCtrlAsignarNotas)
        uCtrlAsignarNotas.Show()

    End Sub
End Class
