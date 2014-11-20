Imports EntitiesLayer

Public Class uCtrlConsultarBeneficio

    Dim nombre As String

    ''' <summary>
    ''' Trae del Gestor, una instancia de un beneficio y lo muestra en un datagrid.
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub uCtrlConsultarBeneficio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim beneficio As Beneficio

        dtaConsultarBeneficio.Rows.Clear()
        beneficio = objGestorBeneficio.buscarPorNombre(nombre)

        dtaConsultarBeneficio.Rows.Add(1)


        dtaConsultarBeneficio.Rows(0).Cells(0).Value = beneficio.Nombre
        dtaConsultarBeneficio.Rows(0).Cells(1).Value = beneficio.Porcentaje
        dtaConsultarBeneficio.Rows(0).Cells(2).Value = beneficio.Aplicacion



    End Sub

    ''' <summary>
    ''' Recibe el nombre del beneficio que se va a mostrar
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <param name="pnombre">Es el nombre del beneficio</param>
    ''' <remarks></remarks>
    Public Sub recibirInfo(ByVal pnombre As String)

        nombre = pnombre

    End Sub


    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        Me.Dispose()

        Dim uctrl As uCntrlBuscarBeneficio = New uCntrlBuscarBeneficio
        FrmIniciarSesion.principal.Controls.Add(uctrl)
        uctrl.Show()
        uctrl.Location = New Point(130, 50)


    End Sub

End Class
