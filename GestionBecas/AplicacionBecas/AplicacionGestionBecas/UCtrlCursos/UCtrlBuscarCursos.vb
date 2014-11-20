Imports EntitiesLayer
Imports BLL
Public Class UCtrlBuscarCursos

    Dim ucCrearCurso As UCtrlCrearCursos
    Dim ucModificarCurso As uCtrlModificarCurso
    Dim ucEliminarCurso As uCtrlEliminarCurso
    Dim idCurso As Integer
    Dim nombreCurso As String
    Dim codigoCurso As String

    Public Sub dtaListarCursos_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtaListarCursos.EditingControlShowing
        ' Only for a DatagridComboBoxColumn at ColumnIndex 1.
        If dtaListarCursos.CurrentCell.ColumnIndex = 5 Then

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
        If combo.SelectedItem = "Editar" Then
            Dim fila = dtaListarCursos.CurrentRow.Cells(1).Value
            modificarCurso(fila)
        ElseIf combo.SelectedItem = "Eliminar" Then
            Dim fila = dtaListarCursos.CurrentRow.Cells(1).Value
            eliminarCurso(fila)
        End If
    End Sub
    ''' <summary>Método que se encarga de modificar un curso por medio de la fila en que se encuentra</summary>
    ''' <param name="pfila">Código el cual corresponde al curso que se desea modificar</param>
    ''' <autor>Valeria Ramírez</autor>
    ''' 
    Public Sub modificarCurso(ByVal pfila As String)

        Dim codigo As String = pfila
        Dim ucntrl As UCtrlModificarCurso = New UCtrlModificarCurso()
        ucntrl.recieveData(codigo)
        FrmIniciarSesion.principal.Controls.Add(ucntrl)
        ucntrl.Show()
        ucntrl.BringToFront()
        'ucntrl.Location = New Point(290, 48)
        ucntrl.refrecarLista(Me)

    End Sub
    ''' <summary>Método que se encarga de eliminar un curso por medio de la fila en que se encuentra</summary>
    ''' <param name="pfila">Código el cual corresponde al curso que se desea modificar</param>
    ''' <autor>Valeria Ramírez</autor>
    ''' 
    Public Sub eliminarCurso(ByVal pfila As String)

        Dim codigo As String = pfila
        Dim ucntrl As UCtrlEliminarCurso = New UCtrlEliminarCurso()
        ucntrl.recieveData(codigo)
        FrmIniciarSesion.principal.Controls.Add(ucntrl)
        ucntrl.BringToFront()
        ucntrl.Show()
        ucntrl.Location = New Point(280, 48)
        ucntrl.refrecarLista(Me)

    End Sub
    ''' <summary>Método que se encarga de listar en el data grid los cursos que existen en el sistema</summary>
    ''' <autor>Valeria Ramírez</autor>
    ''' 
    Public Sub listarCursos()


        Try
            dtaListarCursos.Rows.Clear()
            Dim listarCursos As List(Of Curso)
            listarCursos = objGestorCurso.consultarCursos()

            For Each curso As Curso In listarCursos
                dtaListarCursos.Rows.Add(curso.nombre, curso.codigo, curso.cuatrimestre, curso.creditos, curso.precio, "", curso.Id)
            Next
        Catch ex As Exception

            Dim uctrlAlerta As UctrlAlerta = New UctrlAlerta()
            Me.Controls.Add(uctrlAlerta)
            uctrlAlerta.Location = New Point(300, 100)
            uctrlAlerta.BringToFront()
            Me.SendToBack()
            uctrlAlerta.txtAlerta.Text = "No hay cursos registrados"
            uctrlAlerta.Show()

        End Try

    End Sub
    ''' <summary>Método que se encarga de buscar un curso en específico</summary>
    ''' <param name="parametro">Nombre o código mediante el cual se filtra la búsqueda</param>
    ''' <autor>Valeria Ramírez</autor>
    ''' 
    Public Sub buscarCursos(parametro As String)
        Try
            Dim objCurso As Curso = objGestorCurso.BuscarCurso(parametro)

            If objCurso Is Nothing Then

                listarCursos()
            Else
                dtaListarCursos.Rows.Clear()
                ''<<<<<<< HEAD
                'dtaListarCursos.Rows.Add(objCurso.nombre, objCurso.codigo, objCurso.cuatrimestre, objCurso.creditos, objCurso.precio, objCurso.Id, "")
                ''=======
                dtaListarCursos.Rows.Add(objCurso.nombre, objCurso.codigo, objCurso.cuatrimestre, objCurso.creditos, objCurso.precio, "", objCurso.Id)

            End If

        Catch ex As Exception
            dtaListarCursos.Rows.Clear()
            listarCursos()
        End Try
    End Sub
    'Public Sub txtBuscarCurso_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCurso.MouseClick
    '    If txtBuscarCurso.Text = "" Then
    '        dtaListarCursos.Rows.Clear()
    '        listarCursos()

    '    End If

    'End Sub
    ''' summary>Cuando el evento se ejecuta al dar presionar la tecla enter llama al metodo buscar curso</summary>
    ''' <autor>Alvaro Artavia</autor>
    ''' 
    Private Sub txtBuscarCurso_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBuscarCurso.KeyDown

        Dim parametro As String = txtBuscarCurso.Text

        If e.KeyCode = 13 Then

            buscarCursos(parametro)

        End If

    End Sub

    Private Sub uCtrlBuscarCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        listarCursos()

    End Sub

    Private Sub txtBuscarCurso_TextChanged_2(sender As Object, e As EventArgs) Handles txtBuscarCurso.TextChanged

        If txtBuscarCurso.Text = "" Then
            listarCursos()
        End If

    End Sub

    Private Sub btnCrearCurso_Click(sender As Object, e As EventArgs) Handles btnCrearCurso.Click

        ucCrearCurso = New UCtrlCrearCursos()
        FrmIniciarSesion.principal.Controls.Add(ucCrearCurso)
        ucCrearCurso.Visible = True
        ucCrearCurso.BringToFront()
        ucCrearCurso.Show()
        ucCrearCurso.Location = New Point(290, 48)
        ucCrearCurso.refrecarLista(Me)

    End Sub

End Class