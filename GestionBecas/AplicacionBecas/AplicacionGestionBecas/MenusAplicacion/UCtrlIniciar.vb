Imports EntitiesLayer

Public Class UCtrlIniciar

    Dim alerta As UctrlAlerta
    Dim uctrlMenuMant As New uCtrlMenuMantenimiento


    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click

        Dim nombreUsuario As String = txtNombreUsuario.Text
        Dim contraseña As String = txtContraseña.Text


        Dim listaUsuarios As List(Of Usuario)

        Try

            uctrlMenuMant.ClearPermisos()
            listaUsuarios = objGestorUsuario.iniciarSesion(nombreUsuario, contraseña)

            If listaUsuarios.Count > 0 Then

                Me.Hide()
                Globals.usuario = listaUsuarios(0)
                FrmIniciarSesion.Hide()
                FrmIniciarSesion.principal.Show()
                FrmIniciarSesion.principal.nombreMenuHorizontal()
                FrmIniciarSesion.principal.ValidarPermisos()
                FrmIniciarSesion.principal.ucMenuMant.ListasDePermisos(FrmIniciarSesion.principal.listaPermisos)

            Else
                alerta = New UctrlAlerta()
                alerta.txtAlerta.Text = "Nombre de usuario o contraseña incorrectos"
                FrmIniciarSesion.Controls.Add(alerta)
                alerta.BringToFront()
                alerta.Location = New Point(50, 250)
                alerta.Show()
            End If

        Catch ex As Exception

            alerta = New UctrlAlerta()
            alerta.txtAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.BringToFront()
            alerta.Show()

        End Try

    End Sub

    Private Sub btnRecuperar_Click(sender As Object, e As EventArgs) Handles btnRecuperar.Click

        Dim uctrlRecuperar As UctrlRecuperarContraseña = New UctrlRecuperarContraseña()
        FrmIniciarSesion.Controls.Add(uctrlRecuperar)
        uctrlRecuperar.BringToFront()
        uctrlRecuperar.Location = New Point(140, 260)

    End Sub

End Class

