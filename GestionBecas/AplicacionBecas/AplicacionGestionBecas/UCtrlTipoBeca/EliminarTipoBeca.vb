Imports EntitiesLayer
Public Class EliminarTipoBeca
    Dim nombre As String
    Dim id As Integer
    Dim estado As String
    Dim descripcion As String
    Dim buscar As uCtrlBuscarTipoBeca
    Dim mBlnFormDragging As Boolean
    Dim confirmacionPopUp As uCtrlConfirmacion
    Public Sub setNombre(ByVal pnombre As String)
        nombre = pnombre
    End Sub
    Public Sub getUCtrBuscar(pbuscar As uCtrlBuscarTipoBeca)

        buscar = pbuscar

    End Sub
    ''' <summary>
    ''' Método que recibe datos del tipo de beca
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <param name="pid">id del tipo de beca</param>
    ''' <param name="pnombre">nombre del tipo de beca</param>
    ''' <param name="pestado">estado del tipo de beca</param>
    ''' <param name="pdescripcion">descripción del tipo de beca</param>
    ''' <remarks></remarks>
    Public Sub recibirDatos(ByVal pid As Integer, ByVal pnombre As String, ByVal pestado As String, ByVal pdescripcion As String)
        id = pid
        nombre = pnombre
        estado = pestado
        descripcion = pdescripcion

    End Sub
    ''' <summary>
    ''' Método que programa el botón aceptar 
    ''' elimina el tipo de beca y guarda los cambios y lista de nuevo los tipo de beca
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs)
        gestorTipoBeca.eliminarTipoBeca(Me.nombre)
        gestorTipoBeca.guardarCambios()
        Me.Dispose()
        buscar.dtaTipoBeca.Rows.Clear()
        buscar.listarTiposBeca()
    End Sub

    ''' <summary>
    ''' Método que programa el botón cancelar 
    ''' cancela la acción que se iba a realizar y muestra la lista de tipo de becas
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Dim buscarTipoBeca As uCtrlBuscarTipoBeca = New uCtrlBuscarTipoBeca()
        Me.Hide()
        frmPrincipal.Controls.Add(buscarTipoBeca)
        buscarTipoBeca.Location = New Point(120, 0)
        buscarTipoBeca.Show()
    End Sub
    ''' <summary>
    ''' Método que refresca la lista del buscar tipo de beca, luego de haber realizado una acción
    ''' </summary>
    ''' <author>María Jesús Gutiérrez Calvo</author>
    ''' <param name="pbuscar"></param>
    ''' <remarks></remarks>
    Public Sub refrescarLista(ByVal pbuscar As uCtrlBuscarTipoBeca)
        buscar = pbuscar
    End Sub
    Public Sub EliminarTipoBeca_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mBlnFormDragging = True Then

            Dim position As Point = FrmIniciarSesion.principal.PointToClient(MousePosition)
            Me.Location = New Point(position)

        End If

    End Sub
    Public Sub EliminarTipoBeca_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        mBlnFormDragging = False
        Dim position As Point = FrmIniciarSesion.principal.PointToClient(MousePosition)
        Location = New Point(position)

    End Sub
    Public Sub EliminarTipoBeca_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        mBlnFormDragging = True

    End Sub

    Private Sub btnAceptar_Click_1(sender As Object, e As EventArgs) Handles btnAceptar.Click
        gestorTipoBeca.eliminarTipoBeca(Me.nombre)
        gestorTipoBeca.guardarCambios()
        Me.Dispose()
        buscar.dtaTipoBeca.Rows.Clear()
        buscar.listarTiposBeca()
    End Sub
End Class
