Imports EntitiesLayer
Public Class uCtrlAsignarCursosCarrera
    Dim listaCursos As New List(Of Curso)
    Dim listaCursosSeleccionados As New List(Of Curso)
    Dim pantallaCurso As uCtrlCrearCarrera
    Dim alerta As UctrlAlerta

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        Dim indexSeleccionado As Integer = 0

        Try

            For Each indexSeleccionado In chkCursos.CheckedIndices

                listaCursosSeleccionados.Add(listaCursos.Item(indexSeleccionado))



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
        pantallaCurso.setListasC(listaCursosSeleccionados)
        
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        Me.Hide()
    End Sub
    Public Sub enviarcursos(ByVal ppantallaCursos As uCtrlCrearCarrera)
        pantallaCurso = ppantallaCursos

    End Sub

    Private Sub uCtrlAsignarCursosCarrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaCursos = objGestorCurso.consultarCursos()

        For i As Integer = 0 To listaCursos.Count - 1

            chkCursos.Items.Add(listaCursos.Item(i).nombre)

        Next
    End Sub
End Class
