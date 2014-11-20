Imports EntitiesLayer

Public Class uCtrlMantenimientoRequisitos
    Dim ucCrearCurso As CrearCursos
    Dim ucModificarRequisito As uCtrlModificarRequisito
    'Dim id As Integer
    'Dim nombre As String
    'Dim descripcion As String



    Private Sub dtaListarCursos_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvRequisitos.EditingControlShowing



        ' Only for a DatagridComboBoxColumn at ColumnIndex 1.
        If dgvRequisitos.CurrentCell.ColumnIndex = 2 Then
            Dim combo As ComboBox = CType(e.Control, ComboBox)
            If (combo IsNot Nothing) Then
                ' Remove an existing event-handler, if present, to avoid 
                ' adding multiple handlers when the editing control is reused.
                RemoveHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)

                ' Add the event handler. 
                AddHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
            End If
        End If


    End Sub

    ''' <summary>Metodo encargado de controlar cuando se da click al combobox se ejecuten las acciones</summary>
    ''' <autor>Valeria Ramírez Cordero</autor>



    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim combo As ComboBox = CType(sender, ComboBox)
        Dim fila As Integer = dgvRequisitos.CurrentCell.RowIndex

        If combo.SelectedItem = "Editar" Then

            Dim parametro = dgvRequisitos.CurrentRow.Cells(0).Value
            modificarRequisito()


            'modificarCarrera(fila)

        ElseIf combo.SelectedItem = "Eliminar" Then




            'eliminarCarrera(fila)

        End If



    End Sub


    Public Sub modificarRequisito()


        'Dim id As Integer

        Dim nombre As String = dgvRequisitos.CurrentRow.Cells(0).Value
        Dim descripcion As String = dgvRequisitos.CurrentRow.Cells(1).Value
        Dim id As String = dgvRequisitos.CurrentRow.Cells(3).Value


        Dim ucntrl As uCtrlModificarRequisito = New uCtrlModificarRequisito()

        ucntrl.recieveData(nombre, descripcion, id)

        'imgBuscarCursos.Hide()
        FrmIniciarSesion.principal.Controls.Add(ucntrl)
        ucntrl.BringToFront()
        ucntrl.Show()
        'ucntrl.setParametro(pparametro)
        ucntrl.Location = New Point(290, 48)
        ucntrl.refrecarLista(Me)

    End Sub


    Public Sub listarRequisitos()

        dgvRequisitos.Rows.Clear()
        Dim listaRequisitos As New List(Of Requisito)
        listaRequisitos = objGestorRequisito.consultarRequisitos

        For Each requisito As Requisito In listaRequisitos

            dgvRequisitos.Rows.Add(requisito.nombre, requisito.descripcion, "", requisito.Id)

        Next

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.MouseClick

        txtBuscar.Text = ""

    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown

        Dim param As String = txtBuscar.Text

        If e.KeyCode = 13 Then

            buscarRequisito(param)

        End If

    End Sub

    Private Sub buscarRequisito(ByVal param As String)

        Dim r As Requisito = objGestorRequisito.buscarRequisito(param)

        dgvRequisitos.Rows.Clear()
        dgvRequisitos.Rows.Add(r.nombre, r.descripcion, "", "")

        If r.nombre = "" Then

            dgvRequisitos.Rows.Clear()
            listarRequisitos()

        End If

    End Sub

    Private Sub uCtrlMantenimientoRequisitos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        listarRequisitos()

    End Sub


  
End Class
