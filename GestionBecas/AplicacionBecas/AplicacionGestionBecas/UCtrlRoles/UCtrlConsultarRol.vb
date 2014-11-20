Imports EntitiesLayer

Class uCntrlConsultarRol
    Dim listaPermisosRol As New List(Of Permiso)
    Dim nombre As String
    Dim idRol As String
    Dim listarRoles As uCtrlListarRol
    Dim listaPermisos As New List(Of Permiso)

    '''<summary>Este metodo oculta la ventana de consultar rol </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        listarRoles.DGVRol.Rows.Clear()
        listarRoles.ListarRoles()
        Me.Dispose()

    End Sub

    '''<summary>Este metodo enseña los valores del Rol </summary>
    '''<author>Rodny Castro Mathews </author> 
    '''<param name="pnombre"> Nombre del Rol a eliminar  </param> 
    Public Sub enseñarDatos(ByVal pnombre As String)
        txtNombre.Text = pnombre
    End Sub

    Public Sub getFrmBuscar(plistarRoles As uCtrlListarRol)

        listarRoles = plistarRoles
    End Sub
    ''' <summary>
    ''' Este metodo lista los permisos de este rol
    ''' </summary>
    ''' <remarks></remarks>
    Sub listarPermisos()
        Try

            listaPermisos = objGestorRol.consultarPermisosPorRol(idRol)
            If listaPermisos IsNot Nothing Then
                For i As Integer = 0 To listaPermisos.Count - 1
                    CLBPermisos.Items.Add(listaPermisos.Item(i).Nombre)

                Next
                CompararPermisos()
            End If

            
        Catch ex As Exception
            Dim UCtrl As UctrlAlerta = New UctrlAlerta()

            FrmIniciarSesion.principal.Controls.Add(UCtrl)
            UCtrl.txtAlerta.Text = ex.Message
            UCtrl.Location = New Point(375, 100)
            UCtrl.BringToFront()
            UCtrl.Show()
        End Try

    End Sub

    Private Sub CompararPermisos()
        listaPermisosRol = objGestorRol.consultarPermisosPorRol(idRol)

        For j As Integer = 0 To listaPermisosRol.Count - 1
            For i As Integer = 0 To listaPermisos.Count - 1
                If (listaPermisosRol.Item(j).Id = listaPermisos.Item(i).Id) Then

                    CLBPermisos.SetItemChecked(i, True)
                End If

            Next
        Next

    End Sub

    Public Sub recieveData(ByVal pnombre As String, ByVal pidRol As Integer)
        txtNombre.Text = pnombre
        idRol = pidRol
    End Sub

    '''<summary>Este metodo hace que apenas se abra el usuario de control se listen los permisos </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub uCntrlConsultarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarRoles.DGVRol.Rows.Clear()
        listarRoles.ListarRoles()
        listarPermisos()
    End Sub
    ''' <summary>
    ''' Este metodo cierra esta ventana
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        listarRoles.DGVRol.Rows.Clear()
        listarRoles.ListarRoles()
        Me.Dispose()
    End Sub

End Class
