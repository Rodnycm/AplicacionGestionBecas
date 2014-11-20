
Imports EntitiesLayer
Imports BLL

Public Class UCtrlEliminarRequisitos
    Dim listarRequisitos As uCtrlMantenimientoRequisitos
    Dim idRequisito As Integer
    Dim nombre As String
    Dim descripcion As String

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Public Sub getFrmBuscar(plistarRequisitos As uCtrlMantenimientoRequisitos)

        listarRequisitos = plistarRequisitos
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ValidarELiminarRequisito()
        listarRequisitos.dgvRequisitos.Rows.Clear()
        listarRequisitos.listarRequisitos()
        Me.Dispose()
    End Sub


    Public Sub recieveData(ByVal pnombre As String, ByVal pdescripcion As String, ByVal pid As Integer)

        idRequisito = pid
        nombre = pnombre
        descripcion = pdescripcion
    End Sub

    Private Sub ValidarELiminarRequisito()

        If objGestorRequisito.consultarBecasPorRequisitos(idRequisito) Is Nothing Then
            objGestorRequisito.eliminarRequisito(nombre, descripcion, idRequisito)
            objGestorRequisito.guardarCambios()
            Dim Uctrl As uCtrlConfirmacion = New uCtrlConfirmacion
            FrmIniciarSesion.principal.Controls.Add(Uctrl)
            Uctrl.txtConfirmacion.Text = "El requisito se elimino correctamente"
            Uctrl.Location = New Point(450, 250)
            Uctrl.BringToFront()
            Uctrl.Show()
        Else
            Dim UCtrl As UctrlAlerta = New UctrlAlerta()
            FrmIniciarSesion.principal.Controls.Add(UCtrl)
            UCtrl.txtAlerta.Text = "No se puede eliminar el requisito"
            UCtrl.Location = New Point(400, 250)
            UCtrl.BringToFront()
            UCtrl.Show()
        End If

    End Sub
End Class
