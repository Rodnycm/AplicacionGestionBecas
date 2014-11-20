Imports EntitiesLayer

Public Class UCtrlUserProfile

    Dim alerta As UctrlAlerta
    Dim confirmacionPopUp As uCtrlConfirmacion

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub modificarUsuario()

        Dim pNombre As String = txtNombre.Text
        Dim sNombre As String = txtSegundoNombre.Text
        Dim pApellido As String = txtPrimerApellido.Text
        Dim sApellido As String = txtSegundoApellido.Text
        Dim identificacion As String = txtIdentificacion.Text
        Dim telefono As String = txtTelefono.Text
        Dim fechaNacimiento As Date = DtpFechaNacimiento.Value.Date
        Dim rol As String = cmbRoles.Text
        Dim genero As Integer
        Dim correoElectronico As String = txtCorreoElectronico.Text
        Dim contraseña As String = txtContraseña.Text
        Dim confirmacion As String = txtConfirmacionContraseña.Text


        If (rbtMasculino.Checked = True) Then
            genero = 1

        ElseIf (rbtFemenino.Checked = True) Then
            genero = 2

        Else
            genero = 3
        End If

        Try
            objGestorUsuario.modificarUsuario(pNombre, sNombre, pApellido, sApellido, identificacion, telefono, fechaNacimiento, rol, genero, correoElectronico, contraseña, confirmacion, Globals.usuario.Id)
            objGestorUsuario.guardarCambios()
            confirmacionPopUp = New uCtrlConfirmacion()
            confirmacionPopUp.txtConfirmacion.Text = "Datos modificados con éxito"
            Me.Controls.Add(confirmacionPopUp)
            confirmacionPopUp.BringToFront()
            confirmacionPopUp.Show()

        Catch ex As Exception

            alerta = New UctrlAlerta()
            alerta.txtAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.Location = New Point(300, 200)
            alerta.BringToFront()
            alerta.Show()

        End Try

    End Sub

    Private Sub btnAceptar_Click_1(sender As Object, e As EventArgs) Handles btnAceptar.Click

        modificarUsuario()

    End Sub

    Public Sub llenarComboRoles()

        Try
            Dim listaRoles As List(Of Rol) = New List(Of Rol)

            listaRoles = objGestorRol.consultarRoles()

            For i As Integer = 0 To listaRoles.Count - 1

                cmbRoles.Items.Add(listaRoles(i).Nombre)

            Next

        Catch ex As Exception

            alerta = New UctrlAlerta
            alerta.txtAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.BringToFront()
            alerta.Show()

        End Try

    End Sub

    Private Sub cargarInformacion()

        lblNameUser.Text = Globals.usuario.primerNombre & " " & Globals.usuario.primerApellido & " " & Globals.usuario.segundoApellido
        llenarComboRoles()
        cmbRoles.Text = Globals.usuario.rol.Nombre
        txtNombre.Text = Globals.usuario.primerNombre
        txtSegundoNombre.Text = Globals.usuario.segundoNombre
        txtPrimerApellido.Text = Globals.usuario.primerApellido
        txtSegundoApellido.Text = Globals.usuario.segundoApellido
        txtIdentificacion.Text = Globals.usuario.identificacion
        txtTelefono.Text = Globals.usuario.telefono
        DtpFechaNacimiento.Value = Globals.usuario.fechaNacimiento
        txtCorreoElectronico.Text = Globals.usuario.correoElectronico

        Dim contraseña As String = objGestorUsuario.Desencriptar(Globals.usuario.contraseña)
        txtContraseña.Text = contraseña

        If Globals.usuario.genero = 1 Then
            rbtMasculino.Select()
        ElseIf Globals.usuario.genero = 2 Then
            rbtFemenino.Select()
        Else
            rbtOtro.Select()
        End If

    End Sub

    Private Sub UCtrlUserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarInformacion()

    End Sub

End Class
