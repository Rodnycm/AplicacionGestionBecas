Imports EntitiesLayer
Public Class UctrlEmailConfiguration

    Dim idEmail As Integer
    Dim mBlnFormDragging As Boolean
    Dim alerta As UctrlAlerta = New UctrlAlerta()
    Dim confirmacion As uCtrlConfirmacion

    ''' <summary>Posiciona la ventana mientras el usuario da click al compomente</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub uCtrlEmailConfiguration_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mBlnFormDragging = True Then

            Dim position As Point = frmPrincipal.PointToClient(MousePosition)
            Me.Location = New Point(position)

        End If

    End Sub

    ''' <summary>Situa el componente en la posicion final</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub uCtrlEmailConfiguration_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        mBlnFormDragging = False
        Dim position As Point = frmPrincipal.PointToClient(MousePosition)
        Location = New Point(position)

    End Sub

    ''' <summary>Indica si el usuario da click al componente para moverlo</summary>
    ''' <autor>Alvaro Artavia</autor>

    Public Sub uCtrlEmailConfiguration_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        mBlnFormDragging = True

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        Me.Dispose()
    End Sub


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Me.Dispose()

    End Sub

    Private Sub cargarInformacion()

        Dim email As Email = objGestorEmail.getEmail()
        txtAsunto.Text = email.asunto
        txtEmisor.Text = email.emisor
        txtContrasenna.Text = email.contrasenna
        txtServidor.Text = email.smtpServidor
        txtMensaje.Text = email.mensaje
        txtUserName.Text = email.userName
        idEmail = email.Id

    End Sub

    Private Sub modificarEmail()

        Dim asunto As String = txtAsunto.Text
        Dim emisor As String = txtEmisor.Text
        Dim contrasenna As String = txtContrasenna.Text
        Dim servidor As String = txtServidor.Text
        Dim mensaje As String = txtMensaje.Text
        Dim userName As String = txtUserName.Text
        Dim receptor As String = "alvartabe777@gmail.com"
        Try

            objGestorEmail.modificarEmail(emisor, receptor, asunto, mensaje, servidor, userName, contrasenna, idEmail)
            Dim mensajeConfirmacion As String = "Configuración de notificaciones modificado con exito"
            FrmIniciarSesion.principal.mostrarConfirmacion(mensajeConfirmacion)

        Catch ex As Exception

            alerta = New UctrlAlerta()
            alerta.txtAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.BringToFront()
            alerta.Show()

        End Try

    End Sub

    Private Sub UctrlEmailConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarInformacion()

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        modificarEmail()

    End Sub

End Class
