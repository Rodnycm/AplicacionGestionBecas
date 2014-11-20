Imports EntitiesLayer
Imports BLL

Public Class uCtrlModificarRequisito
    Dim ucMantenimientoRequisito As uCtrlMantenimientoRequisitos
    Dim Id As Integer
    Dim nombre As String
    Dim descripcion As String
    Dim alerta As UctrlAlerta




    Public Sub recieveData(pnombre As String, pdescripcion As String, pid As Integer)

        txtNombreRequisito.Text = pnombre
        txtDescripcionRequisito.Text = pdescripcion
        txtId.Text = pid

    End Sub
    Public Sub refrecarLista(ByVal puctrl As uCtrlMantenimientoRequisitos)
        ucMantenimientoRequisito = puctrl
    End Sub


    Private Sub btnEditarModificarRequisito_Click(sender As Object, e As EventArgs) Handles btnEditarModificarRequisito.Click
        nombre = txtNombreRequisito.Text
        descripcion = txtDescripcionRequisito.Text
        Id = txtId.Text
     
        Try
            objGestorRequisito.modificarRequisito(nombre, descripcion, Id)
            objGestorRequisito.guardarCambios()


            ucMantenimientoRequisito.dgvRequisitos.Rows.Clear()
            ucMantenimientoRequisito.listarRequisitos()
            Me.Dispose()

        Catch ex As Exception
            alerta = New UctrlAlerta()
            alerta.lblAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.BringToFront()
            alerta.Location = New Point(290, 48)
            alerta.Show()
        End Try
    End Sub

    Private Sub btnCancelarModificarRequisito_Click(sender As Object, e As EventArgs) Handles btnCancelarModificarRequisito.Click
        ucMantenimientoRequisito = New uCtrlMantenimientoRequisitos()
        Me.SendToBack()
        Me.Controls.Add(ucMantenimientoRequisito)
        ucMantenimientoRequisito.Show()
    End Sub
End Class
