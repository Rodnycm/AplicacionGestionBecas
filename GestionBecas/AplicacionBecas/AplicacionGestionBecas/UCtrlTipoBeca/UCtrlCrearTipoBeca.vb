Imports EntitiesLayer
Public Class uCtrlCrearTipoBeca
    Dim listas As List(Of Beneficio)
    Dim listasR As List(Of Requisito)
    Dim uCtrlBuscarTB As uCtrlBuscarTipoBeca
    Dim uCtrlConsultarTb As uCtrlConsultarTipoBeca
    Dim mBlnFormDragging As Boolean
    Dim confirmacion As uCtrlConfirmacion
    ''' <summary>
    ''' Método que setea las listad de los beneficios
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <param name="plista">lista de beneficios</param>
    ''' <remarks></remarks>
    Public Sub setListas(ByVal plista As List(Of Beneficio))
        listas = plista
    End Sub
    ''' <summary>
    ''' Método que setea la lista de requisitos
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <param name="plistaR">lista de requisitos</param>
    ''' <remarks></remarks>
    Public Sub setListasR(ByVal plistaR As List(Of Requisito))
        listasR = plistaR
    End Sub
    Public Sub setLista(ByVal plista As uCtrlBuscarTipoBeca)
        uCtrlBuscarTB = plista
    End Sub
    'Public Sub getFrmBuscarTipoBeca(puCtrlBuscarTB As uCtrlBuscarTipoBeca)

    '    uCtrlBuscarTipoBeca = puCtrlBuscarTB
    'End Sub
    ''' <summary>
    ''' Método que programa el botón "Añadir" del formulario Crear tipo de beca
    ''' agrega los datos del tipo de beca por medio del gestor tipo de beca
    ''' guarda los cambios y asigna los benficios y requisitos a el tipo de beca creado.
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click

        Try
            Dim nombre As String = txtNombre.Text
            Dim estado As String = cmbEstado.Text
            Dim descripcion As String = txtDescripcion.Text
            Dim tipo As TipoBeca = gestorTipoBeca.agregarTipoBeca(nombre, estado, descripcion)
            gestorTipoBeca.guardarCambios()
            gestorTipoBeca.asignarBeneficioTipoBeca(listas, tipo)
            gestorTipoBeca.asignarRequisitoTipoBeca(listasR, tipo)

            Dim Uctrl As uCtrlConfirmacion = New uCtrlConfirmacion
            FrmIniciarSesion.principal.Controls.Add(Uctrl)
            Uctrl.txtConfirmacion.Text = "El tipo de beca se registró correctamente"
            Uctrl.Location = New Point(430, 250)
            Uctrl.BringToFront()
            Uctrl.Show()
            uCtrlBuscarTB.dtaTipoBeca.Rows.Clear()
            uCtrlBuscarTB.listarTiposBeca()
            Me.Dispose()


        Catch ex As Exception
            Dim UCtrl As UctrlAlerta = New UctrlAlerta()
            FrmIniciarSesion.principal.Controls.Add(UCtrl)
            UCtrl.txtAlerta.Text = ex.Message
            UCtrl.Location = New Point(400, 250)
            UCtrl.BringToFront()
            UCtrl.Show()

        End Try
        uCtrlBuscarTB.dtaTipoBeca.Rows.Clear()
        uCtrlBuscarTB.listarTiposBeca()

    End Sub

    ''' <summary>
    ''' Método que programa el botón de beneficios, este abre la pantalla de los beneficios disponibles que se pueden seleccionar 
    ''' para el tipo de beca que se va a crear.
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnBeneficios_Click(sender As Object, e As EventArgs) Handles btnBeneficios.Click
        Dim beneficio As SeleccionarBeneficios = New SeleccionarBeneficios()
        FrmIniciarSesion.principal.Controls.Add(beneficio)
        beneficio.enviarbeneficios(Me)
        beneficio.Location = New Point(470, 180)
        beneficio.BringToFront()
        beneficio.Show()


    End Sub
    ''' <summary>
    ''' Método que programa el botón de requisitos, este abre la pantalla de los requisitos disponibles para asignarle a ese tipo de beca
    ''' a crear.
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRequisitos_Click(sender As Object, e As EventArgs) Handles btnRequisitos.Click
        Dim requisito As uCtrlAsignarRequisitos = New uCtrlAsignarRequisitos()
        FrmIniciarSesion.principal.Controls.Add(requisito)
        requisito.enviarrequisitos(Me)
        requisito.Location = New Point(470, 180)
        requisito.BringToFront()
        requisito.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
        'uCtrlBuscarTB.dtaTipoBeca.Rows.Clear()
        'uCtrlBuscarTB.listarTiposBeca()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        'Me.Hide()
        'uCtrlBuscarTB.dtaTipoBeca.Rows.Clear()
        'uCtrlBuscarTB.listarTiposBeca()
    End Sub
    Public Sub uCtrlCrearTipoBeca_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mBlnFormDragging = True Then

            Dim position As Point = FrmIniciarSesion.principal.PointToClient(MousePosition)
            Me.Location = New Point(position)

        End If

    End Sub
    Public Sub uCtrlCrearTipoBeca_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        mBlnFormDragging = False
        Dim position As Point = FrmIniciarSesion.principal.PointToClient(MousePosition)
        Location = New Point(position)

    End Sub
    Public Sub uCtrlCrearTipoBeca_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        mBlnFormDragging = True

    End Sub
End Class
