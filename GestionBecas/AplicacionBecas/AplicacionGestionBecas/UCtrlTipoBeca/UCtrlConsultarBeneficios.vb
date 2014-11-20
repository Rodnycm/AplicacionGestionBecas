Imports EntitiesLayer
Public Class uCtrlConsultarBeneficios
    Dim listaBeneficios As New List(Of Beneficio)
    Public Sub setListaBeneficios(ByVal plistas As List(Of Beneficio))
        listaBeneficios = plistas
    End Sub
    Public Sub listarBeneficios()
        For Each beneficio As Beneficio In listaBeneficios
            dtgConsultarBeneficios.Rows.Add(beneficio.Nombre, beneficio.Porcentaje)
        Next
    End Sub
    Private Sub uCtrlConsultarBeneficios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarBeneficios()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        Me.Hide()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub
End Class
