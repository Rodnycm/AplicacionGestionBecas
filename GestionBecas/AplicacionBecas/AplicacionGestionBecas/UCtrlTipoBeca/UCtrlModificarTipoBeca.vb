Imports EntitiesLayer
Public Class uCtrlModificarTipoBeca
    Dim buscar As uCtrlBuscarTipoBeca
    ''' <summary>
    ''' Declaración de la lista de los beneficios seleccionados a un tipo de beca
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <remarks></remarks>
    Dim listas As List(Of Beneficio)
    ''' <summary>
    ''' Declaración de la lista de los requisitos seleccionados a un tipo de beca
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <remarks></remarks>
    Dim listasR As List(Of Requisito)
    ''' <summary>
    ''' Declaración de la lista de todos los requisitos disponibles para asignar a un tipo de beca
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <remarks></remarks>
    Dim listaRequisito As List(Of Requisito)
    ''' <summary>
    ''' Declaración dela lista de todos los beneficios disponibles para asignar a un tipo de beca
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <remarks></remarks>
    Dim listaBeneficio As List(Of Beneficio)

    ''' <summary>
    ''' Declaración de la lista de los beneficios que traen solo el id de los beneficios
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <remarks></remarks>
    Dim listaIdBeneficios As List(Of Integer) = New List(Of Integer)
    ''' <summary>
    ''' Declaración de la lista de los requisitos que traen el id de los requisitos
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <remarks></remarks>
    Dim listaIdRequisitos As List(Of Integer) = New List(Of Integer)
    Dim listaIdBeneficiosRol As List(Of Integer) = New List(Of Integer)
    Dim listaIdRequisitosRol As List(Of Integer) = New List(Of Integer)

    Dim alerta As UctrlAlerta
    Dim mBlnFormDragging As Boolean
    Dim confirmacionPopUp As uCtrlConfirmacion

    Public objTipo As TipoBeca
   
    Public Sub getFrmBuscar(pbuscar As uCtrlBuscarTipoBeca)
        buscar = pbuscar
    End Sub
    ''' <summary>
    ''' Método que seta la lista de los beneficios seleccionados a un tipo de beca
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <param name="plista"></param>
    ''' <remarks></remarks>
    Public Sub setListas(ByVal plista As List(Of Beneficio))
        listas = plista
    End Sub
    ''' <summary>
    ''' Método que setea la lista de los requisitos seleccionados a un tipo de beca
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <param name="plistaR"></param>
    ''' <remarks></remarks>
    Public Sub setListasR(ByVal plistaR As List(Of Requisito))
        listasR = plistaR
    End Sub
    'Public Sub recibirDatos(pnombre As String, pestado As String, pdescripcion As String)

    '    'txtNombre.Text = pnombre
    '    txtEstado.Text = pestado
    '    txtDescripcion.Text = pdescripcion

    'End Sub
    ''' <summary>
    ''' Método que trae los requisitos relacionado a un tipo de beca
    ''' busca los requisitos que están asociados a un tipo de beca por medio de su id
    ''' los agrega a una lista de requisitos asociados
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <remarks></remarks>
    Private Sub RequisitosRelacionados()
        For Each requisito As Requisito In gestorTipoBeca.buscarRequisitosRelacionadosTipoBeca(objTipo.id)
            listaIdRequisitosRol.Add(requisito.id)
        Next
    End Sub
    ''' <summary>
    ''' Método que trae los beneficios relacionados a un tipo  de beca
    ''' busca los beneficios que están asociados a un tipo de beca por medio de su id
    ''' agrega esos beneficios a una lista
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <remarks></remarks>
    Private Sub BeneficiosRelacionados()
        For Each beneficio As Beneficio In gestorTipoBeca.buscarBeneficiosRelacionadosTipoBeca(objTipo.id)
            listaIdBeneficiosRol.Add(beneficio.id)
        Next
    End Sub
    ''' <summary>
    ''' Método que programa el botón de modificar del formulario Modifica tipo de beca
    ''' modifica los datos del tipo de beca y envía la lista con los id de los beneficios seleccionados  y otra lista con los id de los requisitos
    ''' seleccionados a un tipo de beca, guarda los cambios y muestra la lista de tipos de beca.
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnModificar_Click(sender As Object, e As EventArgs)
        Try
            Dim nombre As String = TextBox2.Text
            Dim estado As String = cmbEstado.Text
            Dim descripcion As String = TextBox1.Text

            Dim listaIdBeneficiosSeleccionados As List(Of Integer) = obtenerBeneficiosSeleccionados()
            Dim listaIdRequisitosSeleccionados As List(Of Integer) = obtenerRequisitosSeleccionados()

            gestorTipoBeca.modificarTipoBeca(objTipo.Id, nombre, estado, descripcion, listaIdBeneficiosSeleccionados, listaIdRequisitosSeleccionados)
            gestorTipoBeca.guardarCambios()
            buscar.dtaTipoBeca.Rows.Clear()
            buscar.listarTiposBeca()
            confirmacionPopUp = New uCtrlConfirmacion()
            confirmacionPopUp.txtConfirmacion.Text = "Datos modificados con éxito"
            Me.Controls.Add(confirmacionPopUp)
            confirmacionPopUp.Location = New Point(130, 150)
            confirmacionPopUp.BringToFront()
            confirmacionPopUp.Show()

        Catch ex As Exception
            alerta = New UctrlAlerta()
            alerta.txtAlerta.Text = ex.Message
            alerta.Location = New Point(400, 250)
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.BringToFront()
            alerta.Show()
        End Try

    End Sub
    ''' <summary>
    ''' Método que obtiene los beneficios seleccionados a un tipo de beca
    ''' recorre el checklist de beneficios por medio de un for para poder obtener los beneficios que fueron seleccionados
    ''' y los agrega a una lista de beneficios seleccionados.
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <returns>retorna una lista de beneficios seleccionados</returns>
    ''' <remarks></remarks>
    Private Function obtenerBeneficiosSeleccionados() As List(Of Integer)
        Dim listaBeneficiosSeleccionados As New List(Of Integer)
        For Each beneficioSeleccionado As Integer In ChkListaBeneficios.CheckedIndices
            listaBeneficiosSeleccionados.Add(listaIdBeneficios.Item(beneficioSeleccionado))
        Next
        Return listaBeneficiosSeleccionados
    End Function
    ''' <summary>
    ''' Método que obtiene los requisitos seleccionados de un tipo de beca
    ''' recorre el checklist de requisitos por medio de un for para poder obtener los requisitos seleccionados que fueron seleccionados
    ''' y los agrega a una lista de requisitos seleccionados.
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <returns>retorna una lista de requisitos seleccionados</returns>
    ''' <remarks></remarks>
    Private Function obtenerRequisitosSeleccionados() As List(Of Integer)
        Dim listaRequisitosSeleccionados As New List(Of Integer)
        For Each requisitoSeleccionado As Integer In chkListaRequisitos.CheckedIndices
            listaRequisitosSeleccionados.Add(listaIdRequisitos.Item(requisitoSeleccionado))
        Next
        Return listaRequisitosSeleccionados
    End Function
    ''' <summary>
    ''' Método que programa el botón de "Cancelar" del formulario de modificar tipo de beca
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Dim buscarTB As uCtrlBuscarTipoBeca = New uCtrlBuscarTipoBeca()
        Me.Hide()
        frmPrincipal.Controls.Add(buscarTB)
        buscarTB.Location = New Point(120, 0)
        buscarTB.Show()
    End Sub
   
    ''' <summary>
    ''' Método que carga los checklist de beneficios y requisitos con los que fueron seleccionados en el momento de crear el tipo de beca
    ''' para que puedan ser modificados.
    ''' Además trae lleno el campo del nombre, estado y descripción del repectivo tipo de beca.
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub editar_load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerBeneficios()
        obtenerRequisitos()

        RequisitosRelacionados()
        BeneficiosRelacionados()

        TextBox2.Text = objTipo.nombre
        cmbEstado.SelectedText = objTipo.estado
        TextBox1.Text = objTipo.descripcion

        asociarBeneficios()
        asociarRequisitos()


    End Sub
    ''' <summary>
    ''' Método que asocia los beneficios a un tipo de beca,
    ''' recorre el checklist por medio de un for para poder ver cuales fueron marcados y traerlos marcados por medio de true en el 
    ''' momento de modificar un tipo de beca
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <remarks></remarks>
    Private Sub asociarBeneficios()
        For Each beneficioDeBeca As Integer In listaIdBeneficiosRol
            For i As Integer = 0 To listaIdBeneficios.Count - 1
                If listaIdBeneficios.Item(i) = beneficioDeBeca Then
                    ChkListaBeneficios.SetItemChecked(i, True)
                End If
            Next
        Next
    End Sub
    ''' <summary>
    ''' Método que asocia los requisitos a un tipo de beca
    ''' recorre el checklist pormedio de un for para ver cuales requisitos fueron marcados y ponerlos en true
    ''' para en el momento de modificar un tipo de beca estos vengan marcados en el formulario.
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <remarks></remarks>
    Private Sub asociarRequisitos()
        For Each requisitosDeBeca As Integer In listaIdRequisitosRol
            For i As Integer = 0 To listaIdRequisitos.Count - 1
                If listaIdRequisitos.Item(i) = requisitosDeBeca Then
                    chkListaRequisitos.SetItemChecked(i, True)
                End If
            Next
        Next
    End Sub
    ''' <summary>
    ''' Método que obtiene los requisitos marcados en el checklist de requisitos y los agrega a una lista de requisitos que mantiene solo 
    ''' los id de estos.
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <remarks></remarks>
    Private Sub obtenerRequisitos()
        For Each requisito As Requisito In objGestorRequisito.buscarRequisito()
            chkListaRequisitos.Items.Add(requisito.nombre)
            listaIdRequisitos.Add(requisito.Id)
        Next
    End Sub
    ''' <summary>
    ''' Método que obtiene los beneficios marcados en un checklist de beneficios y los agrega a una lista de beneficios que mantiene solo 
    ''' los id de los beneficios.
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <remarks></remarks>
    Private Sub obtenerBeneficios()
        For Each beneficio As Beneficio In objGestorBeneficio.buscarBeneficios()
            ChkListaBeneficios.Items.Add(beneficio.Nombre)
            listaIdBeneficios.Add(beneficio.Id)
        Next
    End Sub
    ''' <summary>
    ''' Método que refresca la lista de los tipos de beca en la pantalla de buscar tipo de beca.
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <param name="puctrl"></param>
    ''' <remarks></remarks>
    Public Sub refrecarLista(ByVal puctrl As uCtrlBuscarTipoBeca)
        buscar = puctrl
    End Sub
   
    Public Sub uCtrlModificarTipoBeca_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mBlnFormDragging = True Then

            Dim position As Point = FrmIniciarSesion.principal.PointToClient(MousePosition)
            Me.Location = New Point(position)

        End If

    End Sub
    Public Sub uCtrlModificarTipoBeca_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        mBlnFormDragging = False
        Dim position As Point = FrmIniciarSesion.principal.PointToClient(MousePosition)
        Location = New Point(position)

    End Sub
    Public Sub uCtrlModificarTipoBeca_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        mBlnFormDragging = True

    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub
End Class
