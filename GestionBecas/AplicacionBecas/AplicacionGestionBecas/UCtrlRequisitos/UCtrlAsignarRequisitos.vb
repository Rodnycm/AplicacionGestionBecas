Imports EntitiesLayer
Public Class uCtrlAsignarRequisitos
    Dim listaRequisitos As New List(Of Requisito)
    Dim listaRequisitosSeleccionados As New List(Of Requisito)
    Dim pantalla As uCtrlCrearTipoBeca
    Dim alerta As UctrlAlerta
   

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        Dim indexSeleccionado As Integer = 0
        
        Try

            For Each indexSeleccionado In chkRequisitos.CheckedIndices

                listaRequisitosSeleccionados.Add(listaRequisitos.Item(indexSeleccionado))



            Next indexSeleccionado
        Catch ex As Exception
            alerta = New UctrlAlerta()
            alerta.txtAlerta.Text = ex.Message
            alerta.Location = New Point(400, 250)
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.BringToFront()
            alerta.Show()
            'MsgBox("Debe escoger almenos una opcion")
        End Try

        'For i As Integer = 0 To listaRequisitosSeleccionados.Count - 1

        '    'MsgBox(listaRequisitosSeleccionados.Item(i).id)

        'Next

        Me.Hide()
        pantalla.setListasR(listaRequisitosSeleccionados)
        'Me.Dispose()

        'uCtrlBuscarTipoBeca.crearTipo.Show()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        Me.Hide()
    End Sub
    Public Sub enviarrequisitos(ByVal ppantallaTipoBeca As uCtrlCrearTipoBeca)
        pantalla = ppantallaTipoBeca

    End Sub

    Private Sub uCtrlAsignarRequisitos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        listaRequisitos = objGestorRequisito.consultarRequisitos()

        For i As Integer = 0 To listaRequisitos.Count - 1

            chkRequisitos.Items.Add(listaRequisitos.Item(i).nombre)

        Next

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub
End Class
