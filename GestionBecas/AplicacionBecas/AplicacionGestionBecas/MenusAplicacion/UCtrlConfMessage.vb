Imports EntitiesLayer
Public Class UCtrlConfMessage

    Dim mBlnFormDragging As Boolean
    Dim alerta As UctrlAlerta

    Public Sub enviarMensaje()

        Dim receptor As String = txtRemitente.Text
        Dim contrasenna As String = txtContraseña.Text
        Dim userName As String = txtRemitente.Text
        Dim smtpserver As String = txtSmtp.Text
        Dim asunto As String = FrmIniciarSesion.principal.mensajeInstaneo.txtAsunto.Text
        Dim mensaje As String = FrmIniciarSesion.principal.mensajeInstaneo.txtMensaje.Text
        Dim emisor As String = FrmIniciarSesion.principal.mensajeInstaneo.txtEmisor.Text

        Try
            objGestorEmail.enviarMensajeInstantaneo(receptor, emisor, asunto, mensaje, smtpserver, userName, contrasenna)
            'Dim mensajeConfirmacion As String = "Configuración de notificaciones modificado con exito"
            'FrmIniciarSesion.principal.mostrarConfirmacion(mensajeConfirmacion)

        Catch ex As Exception

            alerta = New UctrlAlerta()
            alerta.txtAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.BringToFront()
            alerta.Show()

        End Try

    End Sub

    ''' <summary>Posiciona la ventana mientras el usuario da click al compomente</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub uCtrlConfMessage_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mBlnFormDragging = True Then

            Dim position As Point = frmPrincipal.PointToClient(MousePosition)
            Me.Location = New Point(position)

        End If

    End Sub

    ''' <summary>Situa el componente en la posicion final</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub uCtrlConfMessage_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        mBlnFormDragging = False
        Dim position As Point = frmPrincipal.PointToClient(MousePosition)
        Location = New Point(position)

    End Sub


    ''' <summary>Indica si el usuario da click al componente para moverlo</summary>
    ''' <autor>Alvaro Artavia</autor>

    Public Sub uCtrlConfMessage_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        mBlnFormDragging = True

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        enviarMensaje()
        FrmIniciarSesion.principal.mensajeInstaneo.txtAsunto.Text = ""
        FrmIniciarSesion.principal.mensajeInstaneo.txtMensaje.Text = ""
        FrmIniciarSesion.principal.mensajeInstaneo.txtEmisor.Text = ""
        FrmIniciarSesion.principal.mostrarConfirmacion("Su mensaje ha sido enviado con exito")

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
        FrmIniciarSesion.principal.mensajeInstaneo.txtAsunto.Text = ""
        FrmIniciarSesion.principal.mensajeInstaneo.txtMensaje.Text = ""
        FrmIniciarSesion.principal.mensajeInstaneo.txtEmisor.Text = ""

    End Sub

    Private Sub UCtrlConfMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmIniciarSesion.principal.uctrlConfMessage.txtRemitente.Text = Globals.usuario.correoElectronico
    End Sub
End Class
