Imports EntitiesLayer

Public Class uCtrlModificarRol

    Dim mBlnFormDragging As Boolean
    Dim nombre As String
    Dim idRol As Integer
    Dim listarRoles As uCtrlListarRol
    Dim listaPermisos As New List(Of Permiso)
    Dim listaPermisosRol As New List(Of Permiso)

    '''<summary> Descripción del método o clase</summary>
    '''<author> Autor del código.</author> 
    '''<name> Parámetros que recibe el método </name>  

    Public Sub getFrmBuscar(plistarRoles As uCtrlListarRol)

        listarRoles = plistarRoles
    End Sub
    Public Sub recieveData(ByVal pnombre As String, ByVal pidRol As Integer)
        txtNombre.Text = pnombre
        idRol = pidRol
    End Sub

    '''<summary> Descripción del método o clase</summary>
    '''<author> Autor del código.</author> 
    '''<name> Parámetros que recibe el método </name>  
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub



    '''<summary> Descripción del método o clase</summary>
    '''<author> Autor del código.</author> 

    Public Sub listarPermisos()
        Try
            listaPermisos = objGestorRol.consultarPermisos()
            For i As Integer = 0 To listaPermisos.Count - 1
                CLBPermisos.Items.Add(listaPermisos.Item(i).Nombre)

            Next

            'CompararPermisos()

        Catch ex As Exception

            Dim UCtrl As UctrlAlerta = New UctrlAlerta()

            FrmIniciarSesion.principal.Controls.Add(UCtrl)
            UCtrl.txtAlerta.Text = ex.Message
            UCtrl.Location = New Point(300, 100)
            UCtrl.BringToFront()
            UCtrl.Show()

        End Try

        Try

            CompararPermisos()
        Catch ex As Exception
            Dim UCtrl As UctrlAlerta = New UctrlAlerta()

            Me.Controls.Add(UCtrl)
            UCtrl.txtAlerta.Text = ex.Message
            UCtrl.Location = New Point(300, 100)
            UCtrl.BringToFront()
            UCtrl.Show()
        End Try

    End Sub



    '''<summary> Descripción del método o clase</summary>
    '''<author> Autor del código.</author> 
    '''<name> Parámetros que recibe el método </name> 
    Private Sub uCtrlModificarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarPermisos()
        ''CompararPermisos()
    End Sub
    ''' <summary>
    ''' Este Metodo compara y pone un check a los permisos que este rol tenga asignados. 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CompararPermisos()

        Try
            listaPermisosRol = objGestorRol.consultarPermisosPorRol(idRol)
            If listaPermisosRol IsNot Nothing Then

                For j As Integer = 0 To listaPermisosRol.Count - 1
                    For i As Integer = 0 To listaPermisos.Count - 1
                        If (listaPermisosRol.Item(j).Id = listaPermisos.Item(i).Id) Then

                            CLBPermisos.SetItemChecked(i, True)
                        End If

                    Next
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

    ''' <summary>
    ''' Esconde la pantalla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        listarRoles.DGVRol.Rows.Clear()
        listarRoles.ListarRoles()
        Me.Dispose()
    End Sub
    '''<summary> Descripción del método o clase</summary>
    '''<author> Autor del código.</author> 
    '''<name> Parámetros que recibe el método </name>  
    Private Sub btnAceptar_Click_1(sender As Object, e As EventArgs) Handles btnAceptar.Click


        If txtNombre.Text.Length <= 50 Then
            Try
                EditarRol()
                ValidarPermisos()
                Dim Uctrl As uCtrlConfirmacion = New uCtrlConfirmacion()
                FrmIniciarSesion.principal.Controls.Add(Uctrl)
                Uctrl.txtConfirmacion.Text = "El rol se modificó correctamente"
                Uctrl.Location = New Point(450, 250)
                Uctrl.BringToFront()
                Uctrl.Show()

            Catch ex As Exception
                Dim UCtrl As UctrlAlerta = New UctrlAlerta()

                FrmIniciarSesion.principal.Controls.Add(UCtrl)
                UCtrl.txtAlerta.Text = ex.Message
                UCtrl.Location = New Point(300, 100)
                UCtrl.BringToFront()
                UCtrl.Show()
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

        Me.Dispose()
    End Sub

    Sub EditarRol()

        Try

            nombre = txtNombre.Text

            objGestorRol.modificarRol(nombre, idRol)
            objGestorRol.guardarCambios()

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

            FrmIniciarSesion.principal.Controls.Add(UCtrl)
            UCtrl.txtAlerta.Text = ex.Message
            UCtrl.Location = New Point(300, 100)
            UCtrl.BringToFront()
            UCtrl.Show()

        End Try



        Return listaPermisosSeleccionados
    End Function


    Public Sub ValidarPermisos()

        Try

            Dim listaPermisosSeleccionados As New List(Of Permiso)

            listaPermisosSeleccionados = PermisosSeleccionados()


            If listaPermisosRol IsNot Nothing Then
                For i As Integer = 0 To listaPermisosRol.Count - 1

                    objGestorRol.eliminarPermisoAUnRol(listaPermisosRol.Item(i).Id, idRol)

                Next
            End If
            
            For i As Integer = 0 To listaPermisosSeleccionados.Count - 1

                objGestorRol.asignarPermisoAUnRol(listaPermisosSeleccionados.Item(i).Id(), idRol)

            Next

        Catch ex As Exception

            Dim UCtrl As UctrlAlerta = New UctrlAlerta()

            Me.Controls.Add(UCtrl)
            UCtrl.txtAlerta.Text = ex.Message
            UCtrl.Location = New Point(300, 100)
            UCtrl.BringToFront()
            UCtrl.Show()

        End Try
    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub uCtrlModificarRol_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mBlnFormDragging = True Then

            Dim position As Point = frmPrincipal.PointToClient(MousePosition)
            Me.Location = New Point(position)

        End If

    End Sub

    Private Sub uCtrlModificarRol_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        mBlnFormDragging = False
        Dim position As Point = frmPrincipal.PointToClient(MousePosition)
        Location = New Point(position)

    End Sub

    Public Sub uCtrlModificarRol_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        mBlnFormDragging = True

    End Sub

End Class
