Public Class uCtrlMantenimientoCrearRequisito

    Public Property mantenimientoRequisito As uCtrlMantenimientoRequisitos
    Dim mBlnFormDragging As Boolean

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Me.Dispose()

    End Sub

    Private Sub uCtrlCrearRequisito_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mBlnFormDragging = True Then

            Dim position As Point = frmPrincipal.PointToClient(MousePosition)
            Me.Location = New Point(position)

        End If

    End Sub

    ''' <summary>Situa el componente en la posicion final</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub uCtrlCrearRequisito_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        mBlnFormDragging = False
        Dim position As Point = frmPrincipal.PointToClient(MousePosition)
        Location = New Point(position)

    End Sub


    ''' <summary>Indica si el usuario da click al componente para moverlo</summary>
    ''' <autor>Alvaro Artavia</autor>

    Public Sub uCtrlCrearRequisito_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        mBlnFormDragging = True

    End Sub

    Private Sub btnAceptar_Click_1(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim nombre As String = txtNombre.Text
            Dim descripcion As String = txtDescripcion.Text
            objGestorRequisito.crearRequisito(nombre, descripcion)
            objGestorRequisito.guardarCambios()
            mantenimientoRequisito.listarRequisitos()
        Catch ex As Exception
            Dim uctrlAlerta As UctrlAlerta = New UctrlAlerta()
            uctrlAlerta.Location = New Point(400, 300)
            FrmIniciarSesion.principal.Controls.Add(uctrlAlerta)
            uctrlAlerta.BringToFront()
            uctrlAlerta.txtAlerta.Text = ex.Message
            uctrlAlerta.Show()
        End Try
           

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        Me.Dispose()

    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

    End Sub
End Class

