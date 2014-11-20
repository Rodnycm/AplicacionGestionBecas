Imports BLL
Imports EntitiesLayer
Public Class UCtrlCrearCursos

    Dim alerta As New UctrlAlerta
    Dim ucBuscarCursos As New uCtrlBuscarCursos

    Private Sub btnAgregarCurso_Click(sender As Object, e As EventArgs) Handles btnAgregarCurso.Click
        Dim nombre As String = txtNombreCurso.Text
        Dim codigo As String = txtCodigoCurso.Text
        Dim cuatrimestre As String = cmbCuatrimestreCurso.Text
        Dim creditos As String = txtCreditosCurso.Text
        Dim precio As String = txtPrecioCurso.Text


        Try
            objGestorCurso.agregarCurso(nombre, codigo, cuatrimestre, creditos, precio)
            objGestorCurso.guardarCambios()
            ucBuscarCursos.dtaListarCursos.Rows.Clear()
            ucBuscarCursos.listarCursos()

        Catch ex As Exception
           
            alerta.txtAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.Location = New Point(375, 100)
            alerta.BringToFront()
            alerta.Show()
        End Try
        Me.Dispose()

    End Sub
    ''' <summary>Método que se encarga de limpiar y cargar la lista de cursos una vez creado el curso</summary>
    ''' <param name="puctrl">control de usuario de buscar cursos</param>
    ''' <autor>Valeria Ramírez</autor>
    ''' 
    Public Sub refrecarLista(ByVal puctrl As uCtrlBuscarCursos)
        ucBuscarCursos = puctrl
    End Sub
    Private Sub btnCancelarAgregarCurso_Click(sender As Object, e As EventArgs) Handles btnCancelarAgregarCurso.Click
        Me.Hide()

    End Sub
End Class
