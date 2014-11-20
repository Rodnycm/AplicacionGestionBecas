Imports BLL
Imports EntitiesLayer

Public Class uCtrlCurso

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
        Catch ex As Exception
            
            alerta.txtAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.Location = New Point(375, 100)
            alerta.BringToFront()
            alerta.Show()



            ucBuscarCursos.dtaListarCursos.Rows.Clear()
            ucBuscarCursos.listarCursos()
        End Try
        Me.Hide()

    End Sub

    Public Sub refrescarPantalla()

        Me.Hide()
        ucBuscarCursos.Refresh()
        ucBuscarCursos.dtaListarCursos.Rows.Clear()
        ucBuscarCursos.listarCursos()





    End Sub
    Private Sub btnCancelarAgregarCurso_Click(sender As Object, e As EventArgs) Handles btnCancelarAgregarCurso.Click


        Me.Hide()
        'dtaListarCursos.Clear()



    End Sub



    Private Sub uCtrlCurso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
