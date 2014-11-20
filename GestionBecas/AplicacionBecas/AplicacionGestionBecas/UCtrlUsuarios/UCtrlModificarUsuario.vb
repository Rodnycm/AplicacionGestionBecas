Imports EntitiesLayer

Public Class UctrlModificarUsuario

    Dim idUsuario As Integer
    Dim parametro As String
    Dim ucntrl As UctrlListarYBuscarUsuario
    Dim alerta As UctrlAlerta
    Dim mBlnFormDragging As Boolean
    Dim confirmacionPopUp As uCtrlConfirmacion
    Dim objetoUsuario As Usuario


    Public Sub setIdUsuario(ByVal pid As Integer)
        idUsuario = pid
    End Sub
    Public Sub setParametro(ByVal pparametro As String)
        parametro = pparametro
    End Sub
    Private Sub UctrlModificarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarComboRoles()
        llenarInfoEditar()
    End Sub

    '<summary> Método que se encarga de llenar un combo box de objetos Rol</summary>
    '<author> Gabriela Gutiérrez Corrales </author> 
    '<param> No recibe valor  </param>
    '<returns> No retorna valor.</returns> 
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


    Public Sub llenarInfoEditar()

        objetoUsuario = objGestorUsuario.buscarUnUsuario(parametro)
        txtNombre.Text = objetoUsuario.primerNombre
        txtSegundoNombre.Text = objetoUsuario.segundoNombre
        txtPrimerApellido.Text = objetoUsuario.primerApellido
        txtSegundoApellido.Text = objetoUsuario.segundoApellido
        txtIdentificacion.Text = objetoUsuario.identificacion
        txtTelefono.Text = objetoUsuario.telefono
        'DtpFechaNacimiento = 
        If objetoUsuario.genero = 1 Then
            rbtMasculino.Select()
        ElseIf objetoUsuario.genero = 2 Then
            rbtFemenino.Select()
        Else
            rbtOtro.Select()
        End If
        cmbRoles.SelectedText = objetoUsuario.rol.Nombre
        txtCorreoElectronico.Text = objetoUsuario.correoElectronico
        'txtContraseña.Text = objetoUsuario.contraseña
        setIdUsuario(objetoUsuario.Id)


    End Sub

    Public Sub refrecarLista(ByVal puctrl As UctrlListarYBuscarUsuario)
        ucntrl = puctrl
    End Sub

    Private Sub btnAceptar_Click_1(sender As Object, e As EventArgs) Handles btnAceptar.Click

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
      

        If (rbtMasculino.Checked = True) Then
            genero = 1
        Else
            If (rbtFemenino.Checked = True) Then
                genero = 2

            Else
                genero = 3
            End If
        End If

        Try
            objGestorUsuario.modificar(pNombre, sNombre, pApellido, sApellido, identificacion, telefono, fechaNacimiento, rol, genero, correoElectronico, objetoUsuario.contraseña, Me.idUsuario)
            'objGestorUsuario.modificarUsuario(pNombre, sNombre, pApellido, sApellido, identificacion, telefono, fechaNacimiento, rol, genero, correoElectronico, objetoUsuario.contraseña, "", Me.idUsuario)
            objGestorUsuario.guardarCambios()
            ucntrl.dgUsuarios.Rows.Clear()
            ucntrl.listarUsuarios()
            confirmacionPopUp = New uCtrlConfirmacion()
            confirmacionPopUp.txtConfirmacion.Text = "Datos modificados con éxito"
            Me.Controls.Add(confirmacionPopUp)
            confirmacionPopUp.Location = New Point(130, 150)
            confirmacionPopUp.BringToFront()
            confirmacionPopUp.Show()
        Catch ex As Exception
            alerta = New UctrlAlerta()
            alerta.txtAlerta.Text = ex.Message
            alerta.Location = New Point(400, 250)
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.BringToFront()
            alerta.Show()
        End Try

    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim ucntrl As UctrlListarYBuscarUsuario = New UctrlListarYBuscarUsuario()
        Me.Hide()
        frmPrincipal.Controls.Add(ucntrl)
        ucntrl.Location = New Point(120, 0)
        ucntrl.Show()
    End Sub


    Public Sub uCtrlModificarUsuario_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mBlnFormDragging = True Then

            Dim position As Point = FrmIniciarSesion.principal.PointToClient(MousePosition)
            Me.Location = New Point(position)

        End If

    End Sub

    Public Sub uCtrlModificarUsuario_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        mBlnFormDragging = False
        Dim position As Point = FrmIniciarSesion.principal.PointToClient(MousePosition)
        Location = New Point(position)

    End Sub

    Public Sub uCtrlModificarUsuario_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        mBlnFormDragging = True

    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Me.Dispose()
    End Sub
End Class
