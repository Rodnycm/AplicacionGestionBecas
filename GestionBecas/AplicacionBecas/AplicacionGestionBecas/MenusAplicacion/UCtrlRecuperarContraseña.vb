Public Class UctrlRecuperarContraseña
    Dim alerta As UctrlAlerta = New UctrlAlerta()
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Try
            Dim usuario As String = txtNombreUsuario.Text
            objGestorUsuario.recuperarContraseña(usuario)
            Me.Hide()
        Catch ex As Exception
            alerta.txtAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.BringToFront()
            alerta.Show()
        End Try

    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Me.Hide()
    End Sub
End Class
