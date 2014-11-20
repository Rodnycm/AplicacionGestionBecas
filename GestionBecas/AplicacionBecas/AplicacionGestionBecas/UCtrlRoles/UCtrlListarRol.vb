Imports EntitiesLayer

Public Class uCtrlListarRol

    Public Property uCtrlRol As UCntrlRegistrarRol = New UCntrlRegistrarRol()


    '''<summary> Este metodo lista los roles</summary>
    '''<author>Rodny Castro Mathews </author> 
    Sub ListarRoles()

        Try

            DGVRol.Rows.Clear()
            Dim listaRoles As New List(Of Rol)
            listaRoles = objGestorRol.consultarRoles()

            'For i As Integer = 0 To listaRoles.Count - 1

            '    DGVRol.Rows.Add(1)
            '    DGVRol.Rows(i).Cells(0).Value = listaRoles.Item(i).Id()
            '    DGVRol.Rows(i).Cells(1).Value = listaRoles.Item(i).Nombre()
            '    DGVRol.Columns("dtaId").Visible = False
            'Next
            For Each rol As Rol In listaRoles
                DGVRol.Rows.Add(rol.Id, rol.Nombre)
            Next

        Catch ex As Exception

            Dim uctrlAlerta As UctrlAlerta = New UctrlAlerta()
            Me.Controls.Add(uctrlAlerta)
            uctrlAlerta.Location = New Point(375, 100)
            uctrlAlerta.BringToFront()
            uctrlAlerta.txtAlerta.Text = "No hay roles registrados"
            uctrlAlerta.Show()

        End Try

    End Sub
    '''<summary>Este metodo hace que apenas se abra el usuario de control le liste los roles </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub ListarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarRoles()
    End Sub

    '''<summary>Metodo  modifica el rol seleccionado</summary>
    '''<author>Rodny Castro Mathews </author>
    ''' '''<param name="numfila"> numero de fila en el que se encuentra el rol a modificar  </param>  
    Private Sub modificarRol(numfila As Integer)

        Try
            Dim value1 As Object = DGVRol.Rows(numfila).Cells(1).Value
            Dim idROl As Integer = DGVRol.Rows(numfila).Cells(0).Value
            Dim uCtrlModRol As New uCtrlModificarRol()
            uCtrlModRol.recieveData(value1, idROl)
            uCtrlModRol.txtNombre.Text = CType(value1, String)
            uCtrlModRol.getFrmBuscar(Me)
            frmIniciarSesion.principal.Controls.Add(uCtrlModRol)
            uCtrlModRol.BringToFront()
            uCtrlModRol.Location = New Point(350, 170)
            uCtrlModRol.Show()

        Catch ex As Exception

            Dim uctrlAlerta As UctrlAlerta = New UctrlAlerta()
            Me.Controls.Add(uctrlAlerta)
            uctrlAlerta.Location = New Point(375, 100)
            uctrlAlerta.BringToFront()
            uctrlAlerta.txtAlerta.Text = ex.Message
            uctrlAlerta.Show()

        End Try
    End Sub

    '''<summary>Este metodo elimina el rol seleccionado </summary>
    '''<author>Rodny Castro Mathews </author> 
    '''<param name="numfila"> Numero de fila del rol a eliminar  </param> 
    Private Sub eliminarRol(numfila As Integer)
        Try
            Dim value1 As Object = DGVRol.Rows(numfila).Cells(1).Value
            Dim idROl As Integer = DGVRol.Rows(numfila).Cells(0).Value
            Dim uCtrlEliRol As New uCtrlEliminarRol()
            uCtrlEliRol.recieveData(value1, idROl)
            uCtrlEliRol.getFrmBuscar(Me)

            'frmPrincipal.Controls.Add(uCtrlEliRol)
            frmIniciarSesion.principal.Controls.Add(uCtrlEliRol)

            uCtrlEliRol.Show()
            uCtrlEliRol.Location = New Point(400, 250)
            uCtrlEliRol.BringToFront()

        Catch ex As Exception

            Dim uctrlAlerta As UctrlAlerta = New UctrlAlerta()
            Me.Controls.Add(uctrlAlerta)
            uctrlAlerta.Location = New Point(375, 100)
            uctrlAlerta.BringToFront()
            uctrlAlerta.txtAlerta.Text = ex.Message
            uctrlAlerta.Show()
        End Try
    End Sub

    '''<summary>Este metodo consulta el rol seleccionado </summary>
    '''<author>Rodny Castro Mathews </author> 
    '''<param name="numfila"> Numero de fila de rol a consultar  </param> 
    Private Sub consultarRol(numfila As Integer)
        Try

            Dim value1 As Object = DGVRol.Rows(numfila).Cells(1).Value
            Dim idROl As Integer = DGVRol.Rows(numfila).Cells(0).Value
            Dim uCtrlConsulRol As New uCntrlConsultarRol()
            uCtrlConsulRol.enseñarDatos(value1)
            uCtrlConsulRol.recieveData(value1, idROl)
            uCtrlConsulRol.txtNombre.Text = value1
            uCtrlConsulRol.getFrmBuscar(Me)

            frmIniciarSesion.principal.Controls.Add(uCtrlConsulRol)
            'frmPrincipal.Controls.Add(uCtrlConsulRol)

            uCtrlConsulRol.Show()
            uCtrlConsulRol.BringToFront()
            uCtrlConsulRol.Location = New Point(350, 170)
        Catch ex As Exception

            Dim uctrlAlerta As UctrlAlerta = New UctrlAlerta()
            Me.Controls.Add(uctrlAlerta)
            uctrlAlerta.Location = New Point(375, 100)
            uctrlAlerta.BringToFront()
            uctrlAlerta.txtAlerta.Text = ex.Message
            uctrlAlerta.Show()
        End Try

    End Sub

    '''<summary> </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub DGVRol_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DGVRol.EditingControlShowing
        ' Only for a DatagridComboBoxColumn at ColumnIndex 1.
        If DGVRol.CurrentCell.ColumnIndex = 2 Then
            Dim combo As ComboBox = CType(e.Control, ComboBox)
            If (combo IsNot Nothing) Then
                ' Remove an existing event-handler, if present, to avoid 
                ' adding multiple handlers when the  editing control is reused.
                RemoveHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)

                ' Add the event handler. 
                AddHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
            End If
        End If
    End Sub

    '''<summary> Este metodo indica si hay que eliminar,ver,modificar dependiendo de lo que escoja </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As EventArgs)
        Dim combo As ComboBox = CType(sender, ComboBox)
        Dim fila As Integer = DGVRol.CurrentCell.RowIndex
        If combo.SelectedItem = "Editar" Then

            modificarRol(fila)

        ElseIf combo.SelectedItem = "Eliminar" Then

            eliminarRol(fila)

        ElseIf combo.SelectedItem = "Ver" Then

            consultarRol(fila)


        End If

    End Sub


    Private Sub btnCrearRoles_Click_1(sender As Object, e As EventArgs) Handles btnCrearRoles.Click

        Try

            uCtrlRol = New UCntrlRegistrarRol()
            uCtrlRol.getFrmBuscar(Me)

            FrmIniciarSesion.principal.Controls.Add(uCtrlRol)

            uCtrlRol.BringToFront()
            uCtrlRol.Location = New Point(300, 170)
            uCtrlRol.Show()

        Catch ex As Exception
            Dim uctrlAlerta As UctrlAlerta = New UctrlAlerta()
            Me.Controls.Add(uctrlAlerta)
            uctrlAlerta.Location = New Point(300, 100)
            uctrlAlerta.BringToFront()
            uctrlAlerta.txtAlerta.Text = ex.Message
            uctrlAlerta.Show()

        End Try

    End Sub

    Private Sub txtBuscarRol_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscarRol.TextChanged

        If txtBuscarRol.Text = "" Then
            ListarRoles()
        End If

    End Sub



    Public Sub buscarRol(ByVal param As String)


        ' Dim objRol As Rol = objGestorRol.consultarRolPorNombre(txtBuscar.Text)


        Try
            Dim Rol As New Rol
            Rol = objGestorRol.consultarRolPorNombre(txtBuscarRol.Text)

            If Rol.Nombre = "" Then
                DGVRol.Rows.Clear()
                ListarRoles()
            Else
                DGVRol.Rows.Clear()
                DGVRol.Rows.Add(1)
                DGVRol.Rows(0).Cells(1).Value = Rol.Nombre()
            End If

        Catch ex As Exception
            DGVRol.Rows.Clear()
            ListarRoles()
        End Try

    End Sub

    Private Sub txtBuscarRol_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscarRol.KeyDown
        Dim param As String = txtBuscar.Text

        If e.KeyCode = 13 Then

            buscarRol(param)

        End If
    End Sub

End Class
