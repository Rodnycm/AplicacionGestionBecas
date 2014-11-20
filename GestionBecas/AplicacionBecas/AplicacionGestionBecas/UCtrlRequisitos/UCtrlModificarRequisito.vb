Imports BLL
Imports EntitiesLayer
Public Class UCtrlModificarRequisito


    Dim ucMantRequisito As uCtrlMantenimientoRequisitos
    Dim Id As Integer
    Dim nombre As String
    Dim descripcion As String
    Dim alerta As UctrlAlerta
    Dim objRequisito As Requisito

    Public Sub recieveData(pparam As String)
        objRequisito = objGestorRequisito.buscarRequisito(pparam)
        llenarInfoModificar(objRequisito)

    End Sub

    Public Sub llenarInfoModificar(ByVal pobjRequisito As Requisito)
        txtNombreRequisito.Text = pobjRequisito.nombre
        txtDescripcion.Text = pobjRequisito.descripcion

    End Sub
    Public Sub refrecarLista(ByVal puctrl As uCtrlMantenimientoRequisitos)
        ucMantRequisito = puctrl
    End Sub


    Private Sub btnEditarRequisito_Click(sender As Object, e As EventArgs) Handles btnEditarRequisito.Click
        nombre = txtNombreRequisito.Text
        descripcion = txtDescripcion.Text()
        Id = objRequisito.Id

        Try

            objGestorRequisito.modificarRequisito(nombre, descripcion, Id)
            objGestorRequisito.guardarCambios()
            ucMantRequisito.dgvRequisitos.Rows.Clear()
            ucMantRequisito.listarRequisitos()
            Me.Dispose()
        Catch ex As Exception

            alerta = New UctrlAlerta()
            alerta.txtAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.BringToFront()
            alerta.Location = New Point(375, 300)
            alerta.Show()
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'ucMantRequisito = New uCtrlMantenimientoRequisitos()
        'Me.SendToBack()
        'Me.Controls.Add(ucMantRequisito)
        'ucMantRequisito.Show()
        Me.Dispose()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub
End Class
