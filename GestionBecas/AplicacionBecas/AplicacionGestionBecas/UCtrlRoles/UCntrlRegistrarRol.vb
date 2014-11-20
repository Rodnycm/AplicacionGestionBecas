Imports EntitiesLayer
Public Class UCntrlRegistrarRol

    Dim mBlnFormDragging As Boolean
    Dim listarRoles As uCtrlListarRol
    Dim listaPermisos As New List(Of Permiso)
    Dim listaPermisosSeleccionados As New List(Of Permiso)
    Dim idRol As Integer
    '''<summary>crea un nuevo Rol en el sistema </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim nombre As String = txtNombre.Text


        If txtNombre.Text.Length <= 50 Then

            Try
                objGestorRol.agregarRol(nombre)
                objGestorRol.guardarCambios()
                idRol = objGestorRol.consultarRolPorNombre(nombre).Id
                asignarPermisosAUnRol()

                Dim Uctrl As uCtrlConfirmacion = New uCtrlConfirmacion
                FrmIniciarSesion.principal.Controls.Add(Uctrl)
                Uctrl.txtConfirmacion.Text = "El rol se creó correctamente"
                Uctrl.Location = New Point(450, 250)
                Uctrl.BringToFront()
                Uctrl.Show()

            Catch ex As Exception

                Dim uctrlAlerta As UctrlAlerta = New UctrlAlerta()
                Me.Controls.Add(uctrlAlerta)
                uctrlAlerta.Location = New Point(100, 100)
                uctrlAlerta.BringToFront()
                uctrlAlerta.txtAlerta.Text = ex.Message
                uctrlAlerta.Show()
            End Try
        Else
            Dim uctrlAlerta As UctrlAlerta = New UctrlAlerta()
            Me.Controls.Add(uctrlAlerta)
            uctrlAlerta.Location = New Point(100, 100)
            uctrlAlerta.BringToFront()
            uctrlAlerta.txtAlerta.Text = "No se aceptan textos tan largos"
            uctrlAlerta.Show()

        End If

        listarRoles.DGVRol.Rows.Clear()
        listarRoles.ListarRoles()

    End Sub

    ''' <summary>
    ''' Este metodo consigue la lista de roles
    ''' </summary>
    ''' <param name="plistarRoles"></param>
    ''' <remarks></remarks>
    Public Sub getFrmBuscar(plistarRoles As uCtrlListarRol)

        listarRoles = plistarRoles
    End Sub

    '''<summary>Este metodo oculta el usuario de control de registrar Rol </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        listarRoles.DGVRol.Rows.Clear()
        listarRoles.ListarRoles()
        Me.Dispose()

    End Sub

    '''<summary>Este metodo muestr el menu de mantenimiento </summary>
    '''<author>Rodny Castro Mathews </author> 
    Public Sub MostrarMenuMant()
        Dim ucMenuMant As New uCtrlMenuMantenimiento()
        ucMenuMant.Show()
    End Sub

    ''' <summary>
    ''' Este metodo cierra Esta ventana
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        listarRoles.DGVRol.Rows.Clear()
        listarRoles.ListarRoles()
        Me.Dispose()
    End Sub

    Public Sub listarPermisos()
        Try
            listaPermisos = objGestorRol.consultarPermisos()
            For i As Integer = 0 To listaPermisos.Count - 1
                CLBPermisos.Items.Add(listaPermisos.Item(i).Nombre)

            Next

            'CompararPermisos()
        Catch ex As Exception

            Dim UCtrl As UctrlAlerta = New UctrlAlerta()

            Me.Controls.Add(UCtrl)
            UCtrl.txtAlerta.Text = ex.Message
            UCtrl.Location = New Point(375, 100)
            UCtrl.BringToFront()
            UCtrl.Show()

        End Try

    End Sub

    Sub asignarPermisosAUnRol()

        Dim listaPermisosSeleccionados As New List(Of Permiso)
        Dim ListaPermisosQuitar As New List(Of Permiso)
        Dim listaIdROlesPermisos As New List(Of Integer)

        Try
        listaPermisosSeleccionados = PermisosSeleccionados()

        If listaPermisosSeleccionados.Count <> Nothing Then
            For i As Integer = 0 To listaPermisosSeleccionados.Count - 1
                objGestorRol.asignarPermisoAUnRol(listaPermisosSeleccionados.Item(i).Id(), idRol)

            Next
            End If

        Catch ex As Exception
            Dim UCtrl As UctrlAlerta = New UctrlAlerta()

            Me.Controls.Add(UCtrl)
            UCtrl.txtAlerta.Text = ex.Message
            UCtrl.Location = New Point(300, 100)
            UCtrl.BringToFront()
            UCtrl.Show()
        End Try
    End Sub

    Public Function PermisosSeleccionados()
        Dim indexSeleccionado As Integer = 0
        Dim listaPermisosSeleccionados As New List(Of Permiso)
        Try

            For Each indexSeleccionado In CLBPermisos.CheckedIndices

                listaPermisosSeleccionados.Add(listaPermisos.Item(indexSeleccionado))

            Next indexSeleccionado

        Catch ex As Exception

            Dim UCtrl As UctrlAlerta = New UctrlAlerta()
            Me.Controls.Add(UCtrl)
            UCtrl.txtAlerta.Text = ex.Message
            UCtrl.Location = New Point(300, 100)
            UCtrl.BringToFront()
            UCtrl.Show()

        End Try

        Return listaPermisosSeleccionados

    End Function

    Private Sub UCntrlRegistrarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarPermisos()
    End Sub

    Private Sub CntrlRegistrarRol_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mBlnFormDragging = True Then

            Dim position As Point = frmPrincipal.PointToClient(MousePosition)
            Me.Location = New Point(position)

        End If

    End Sub

    Private Sub CntrlRegistrarRol_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        mBlnFormDragging = False
        Dim position As Point = frmPrincipal.PointToClient(MousePosition)
        Location = New Point(position)

    End Sub

    Public Sub CntrlRegistrarRol_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        mBlnFormDragging = True

    End Sub

End Class
