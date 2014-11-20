Imports EntitiesLayer
Imports BLL
Public Class UCtrlModificarCurso

    Dim ucBuscarCursos As uCtrlBuscarCursos
    Dim Id As Integer
    Dim nombre As String
    Dim codigo As String
    Dim cuatrimestre As String
    Dim creditos As String
    Dim precio As String
    Dim alerta As UctrlAlerta
    Dim objCurso As Curso

    ''' <summary>Método que se encarga de recivir el parámetro por el cual se puede hacer una instancia del objeto curso</summary>
    ''' <param name="pcodigo">Código el cual corresponde al curso que se desea modificar</param>
    ''' <autor>Valeria Ramírez</autor>
    ''' 
    Public Sub recieveData(pcodigo As String)
        objCurso = objGestorCurso.BuscarCurso(pcodigo)
        llenarInfoModificar(objCurso)

    End Sub
    ''' <summary>Método que se encarga de llenar los texBox con la información que se desea modificar correspondiente al objetoCurso</summary>
    ''' <param name="pobjCurso">Objeto Curso</param>
    ''' <autor>Valeria Ramírez</autor>
    ''' 
    Public Sub llenarInfoModificar(ByVal pobjCurso As Curso)
        txtNombreCurso.Text = pobjCurso.nombre
        txtCodigoCurso.Text = pobjCurso.codigo
        txtCreditosCurso.Text = pobjCurso.creditos
        txtPrecioCurso.Text = pobjCurso.precio
        cmbCuatrimestreCurso.Text = pobjCurso.cuatrimestre

    End Sub
    ''' <summary>Método que se encarga de limpiar y volver a listar los cursos una vez que han sido modificados</summary>
    ''' <param name="puctrl">Control de usuario de Buscar Cursos</param>
    ''' <autor>Valeria Ramírez</autor>
    ''' 
    Public Sub refrecarLista(ByVal puctrl As uCtrlBuscarCursos)
        ucBuscarCursos = puctrl
    End Sub
    Private Sub btnAceptarModificarCurso_Click(sender As Object, e As EventArgs) Handles btnAceptarModificarCurso.Click
        nombre = txtNombreCurso.Text
        codigo = txtCodigoCurso.Text
        cuatrimestre = cmbCuatrimestreCurso.Text
        creditos = txtCreditosCurso.Text
        precio = txtPrecioCurso.Text
        Id = objCurso.Id

        Try
            objGestorCurso.modificarCurso(codigo, nombre, cuatrimestre, creditos, precio, Id)
            objGestorCurso.guardarCambios()
            ucBuscarCursos.dtaListarCursos.Rows.Clear()
            ucBuscarCursos.listarCursos()

        Catch ex As Exception
            alerta = New uCtrlAlerta()
            alerta.txtAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.Location = New Point(375, 100)
            alerta.BringToFront()
            alerta.Show()
        End Try
        Me.Dispose()
    End Sub
    Private Sub btnCancelarAgregarCurso_Click(sender As Object, e As EventArgs) Handles btnCancelarAgregarCurso.Click
        ucBuscarCursos = New uCtrlBuscarCursos()
        Me.SendToBack()
        Me.Controls.Add(ucBuscarCursos)
        ucBuscarCursos.Show()
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub
End Class