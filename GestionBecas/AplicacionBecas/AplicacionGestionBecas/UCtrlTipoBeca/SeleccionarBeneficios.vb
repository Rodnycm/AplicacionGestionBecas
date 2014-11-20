Imports EntitiesLayer
Public Class SeleccionarBeneficios
    Dim listaBeneficios As New List(Of Beneficio)
    Dim listaBeneficiosSeleccionados As New List(Of Beneficio)
    Dim pantalla As uCtrlCrearTipoBeca
    Dim alerta As UctrlAlerta

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim indexSeleccionado As Integer = 0
        Try

            For Each indexSeleccionado In chkBeneficios.CheckedIndices

                listaBeneficiosSeleccionados.Add(listaBeneficios.Item(indexSeleccionado))

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


        Me.Hide()
        pantalla.setListas(listaBeneficiosSeleccionados)



    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        Me.Hide()
    End Sub

    'Private Sub chkBeneficios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chkBeneficios.SelectedIndexChanged
    '    listaBeneficios = gestorBeneficio.buscarBeneficios()

    '    For i As Integer = 0 To listaBeneficios.Count - 1

    '        chkBeneficios.Items.Add(listaBeneficios.Item(i).Porcentaje & " " & listaBeneficios.Item(i).id)


    '    Next
    'End Sub

    Public Sub enviarbeneficios(ByVal ppantallaTipoBeca As uCtrlCrearTipoBeca)
        pantalla = ppantallaTipoBeca

    End Sub


    Private Sub SeleccionarBeneficios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaBeneficios = objGestorBeneficio.buscarBeneficios()

        For i As Integer = 0 To listaBeneficios.Count - 1

            chkBeneficios.Items.Add(listaBeneficios.Item(i).Nombre & " " & listaBeneficios.Item(i).Porcentaje)

        Next
    End Sub
End Class
