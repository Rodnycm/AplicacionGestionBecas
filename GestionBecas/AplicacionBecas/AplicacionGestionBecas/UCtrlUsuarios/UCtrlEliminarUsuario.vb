
Public Class UctrlEliminarUsuario
    Dim parametro As String
    Dim Uctrl As UctrlListarYBuscarUsuario
    Dim mBlnFormDragging As Boolean
    Dim confirmacionPopUp As uCtrlConfirmacion


    Public Sub setParametro(ByVal pparametro As String)
        parametro = pparametro
    End Sub

    Public Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        objGestorUsuario.eliminarUsuario(Me.parametro)
        objGestorUsuario.guardarCambios()
        'confirmacionPopUp = New uCtrlConfirmacion()
        'confirmacionPopUp.lblConfirmacion.Text = "El usuario ha sido eliminado"
        'Me.Controls.Add(confirmacionPopUp)
        'confirmacionPopUp.Location = New Point(200, 250)
        'confirmacionPopUp.BringToFront()
        'confirmacionPopUp.Show()
        Me.Dispose()
        Uctrl.dgUsuarios.Rows.Clear()
        Uctrl.listarUsuarios()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim ucntrl As UctrlListarYBuscarUsuario = New UctrlListarYBuscarUsuario()
        Me.Hide()
        frmPrincipal.Controls.Add(ucntrl)
        ucntrl.Location = New Point(120, 0)
        ucntrl.Show()
    End Sub

    Public Sub refrescarLista(ByVal puctrl As UctrlListarYBuscarUsuario)
        Uctrl = puctrl
    End Sub


    Public Sub uctrlEliminarUsuario_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mBlnFormDragging = True Then

            Dim position As Point = FrmIniciarSesion.principal.PointToClient(MousePosition)
            Me.Location = New Point(position)

        End If

    End Sub
    Public Sub uctrlEliminarUsuario_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        mBlnFormDragging = False
        Dim position As Point = FrmIniciarSesion.principal.PointToClient(MousePosition)
        Location = New Point(position)

    End Sub

    Public Sub uctrlEliminarUsuario_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        mBlnFormDragging = True

    End Sub

End Class

