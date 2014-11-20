Imports EntitiesLayer

Public Class UCtrlUltimasActividades

    Public Sub listarRegistros()

        Try

            dgvBitacora.Rows.Clear()
            Dim listaAcciones As List(Of RegistroAccion) = objGestorBitacora.consultarBitacoraAccionesFecha()

            If listaAcciones Is Nothing Then

            Else

                For k As Integer = 0 To listaAcciones.Count - 1

                    dgvBitacora.Rows.Add(1)
                    dgvBitacora.Rows(k).Cells(1).Value = listaAcciones.Item(k).nombreUsuario
                    dgvBitacora.Rows(k).Cells(2).Value = listaAcciones.Item(k).descripcion

                Next

            End If

        Catch ex As Exception

            dgvBitacora.Rows.Clear()

        End Try

    End Sub

    Private Sub UCtrlUltimasActividades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarRegistros()
    End Sub

End Class
