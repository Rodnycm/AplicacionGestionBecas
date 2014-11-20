Imports EntitiesLayer
Public Class uCtrlConsultarRequisitos
    Dim listaRequisitos As New List(Of Requisito)
    
    Public Sub setListaRequisitos(ByVal plistas As List(Of Requisito))
        listaRequisitos = plistas
    End Sub
    Public Sub listarRequisitos()

        For Each requisito As Requisito In listaRequisitos

            dtgConsultarRequisito.Rows.Add(requisito.nombre)
        Next
      
    End Sub
    Private Sub uCtrlConsultarRequisitos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarRequisitos()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        Me.Hide()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub
End Class
