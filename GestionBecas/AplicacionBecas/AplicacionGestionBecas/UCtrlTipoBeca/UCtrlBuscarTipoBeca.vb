Imports EntitiesLayer


Public Class uCtrlBuscarTipoBeca

    Dim crearTipo As uCtrlCrearTipoBeca
    Dim uCtrlConsultarTB As uCtrlConsultarTipoBeca = New uCtrlConsultarTipoBeca()

    
    Private Sub PantallaConsultarTipoBeca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        listarTiposBeca()

    End Sub
    Public Sub listarTiposBeca()
        Try
            Dim tipoBecas As List(Of TipoBeca) = gestorTipoBeca.consultarTipoBeca()
            dtaTipoBeca.Rows.Clear()

            For Each tipos As TipoBeca In tipoBecas

                dtaTipoBeca.Rows.Add(tipos.nombre, tipos.estado)

            Next
        Catch
            Dim uctrlAlerta As UctrlAlerta = New UctrlAlerta()
            Me.Controls.Add(uctrlAlerta)
            uctrlAlerta.Location = New Point(300, 100)
            uctrlAlerta.BringToFront()
            Me.SendToBack()
            uctrlAlerta.txtAlerta.Text = "Noy hay tipos de beca registrados"
            uctrlAlerta.Show()
        End Try

    End Sub


    Public Sub dtaTipoBeca_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtaTipoBeca.EditingControlShowing
        ' Only for a DatagridComboBoxColumn at ColumnIndex 1.
        If dtaTipoBeca.CurrentCell.ColumnIndex = 6 Then
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
   
    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim combo As ComboBox = CType(sender, ComboBox)

        If combo.SelectedItem = "Ver" Then
            Dim param = dtaTipoBeca.CurrentRow.Cells(0).Value
            verTipoBeca(param)
        ElseIf combo.SelectedItem = "Editar" Then
            Dim param = dtaTipoBeca.CurrentRow.Cells(0).Value
            editarTipoBeca(param)

        ElseIf combo.SelectedItem = "Eliminar" Then
            Dim param = dtaTipoBeca.CurrentRow.Cells(0).Value
            eliminarTipoBeca(param)
        End If
    End Sub

    Public Sub verTipoBeca(ByVal pparam As String)
        Dim nombre As String = pparam
        Dim tipoBecaConsulta As TipoBeca = gestorTipoBeca.buscarUnTipoBeca(nombre)
        dtaTipoBeca.Rows.Clear()
        dtaTipoBeca.Columns("Fecha").Visible = True
        dtaTipoBeca.Columns("Descripcion").Visible = True
        dtaTipoBeca.Columns("Requisitos").Visible = True
        dtaTipoBeca.Columns("Beneficios").Visible = True
        dtaTipoBeca.Columns("opciones").Visible = False
        btnVolver.Visible = True
        dtaTipoBeca.Rows.Add(tipoBecaConsulta.nombre, tipoBecaConsulta.objD.ToShortDateString, tipoBecaConsulta.estado, tipoBecaConsulta.descripcion, "", "", "")

    End Sub
    Private Sub dtaTipoBeca_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtaTipoBeca.CellContentClick

        Dim senderGrid = DirectCast(sender, DataGridView)

        If dtaTipoBeca.Columns(e.ColumnIndex).Name = "Requisitos" Then
            Dim nombre As String = dtaTipoBeca.CurrentRow.Cells(0).Value
            requisitosConsultados(nombre)

        End If

        If dtaTipoBeca.Columns(e.ColumnIndex).Name = "Beneficios" Then
            Dim nombre As String = dtaTipoBeca.CurrentRow.Cells(0).Value
            beneficiosConsultados(nombre)
        End If
    End Sub


    Public Sub requisitosConsultados(ByVal pnombre As String)
        Try
            Dim nombreTipo As String = pnombre
            Dim tipoBeca As TipoBeca = gestorTipoBeca.buscarUnTipoBeca(nombreTipo)
            Dim requisitosLista As List(Of Requisito) = objGestorRequisito.mostrarRequisitoTB(tipoBeca)
            If requisitosLista.Count > 0 Then
                Dim requisitos As uCtrlConsultarRequisitos = New uCtrlConsultarRequisitos
                requisitos.setListaRequisitos(requisitosLista)
                FrmIniciarSesion.principal.Controls.Add(requisitos)
                requisitos.Location = New Point(470, 180)
                requisitos.BringToFront()
                Me.SendToBack()
                requisitos.Show()
            End If
        Catch ex As Exception
            Dim uctrlAlerta As UctrlAlerta = New UctrlAlerta()
            uctrlAlerta.Location = New Point(400, 250)
            uctrlAlerta.txtAlerta.Text = "El tipo de beca seleccionado no tiene requisitos asignados"
            FrmIniciarSesion.principal.Controls.Add(uctrlAlerta)
            uctrlAlerta.BringToFront()
            uctrlAlerta.Show()
        End Try
    End Sub

    Public Sub beneficiosConsultados(ByVal pnombre)
        Try

            Dim nombre As String = pnombre
            Dim tipoBeca As TipoBeca = gestorTipoBeca.buscarUnTipoBeca(nombre)
            Dim beneficiosLista As List(Of Beneficio) = objGestorBeneficio.mostrarBeneficioTB(tipoBeca)
            If beneficiosLista.Count > 0 Then
                Dim beneficios As uCtrlConsultarBeneficios = New uCtrlConsultarBeneficios
                Beneficios.setListaBeneficios(beneficiosLista)
                FrmIniciarSesion.principal.Controls.Add(Beneficios)
                beneficios.Location = New Point(470, 200)
                Beneficios.BringToFront()
                Me.SendToBack()
                Beneficios.Show()
            End If
        Catch ex As Exception
            Dim uctrlAlerta As UctrlAlerta = New UctrlAlerta()
            uctrlAlerta.Location = New Point(400, 200)
            FrmIniciarSesion.principal.Controls.Add(uctrlAlerta)
            uctrlAlerta.BringToFront()
            uctrlAlerta.txtAlerta.Text = "El tipo de beca seleccionado no tiene beneficios asignados"
            uctrlAlerta.Show()


        End Try
    End Sub
    Private Sub editarTipoBeca(ByVal parametro As String)
        Dim uCtrlModificarTB As New uCtrlModificarTipoBeca

        Dim nombre As String = dtaTipoBeca.CurrentRow.Cells(0).Value
        'Dim objD As Date = dtaTipoBeca.CurrentRow.Cells(1).Value
        Dim estado As String = dtaTipoBeca.CurrentRow.Cells(1).Value
        Dim descripcion As String = dtaTipoBeca.CurrentRow.Cells(2).Value


        Dim objTipoBeca As TipoBeca = gestorTipoBeca.buscarUnTipoBeca(nombre)

        uCtrlModificarTB.objTipo = objTipoBeca

        'frmPrincipal.Controls.Add(uCtrlModificarTB)
        uCtrlModificarTB.getFrmBuscar(Me)
        Me.Controls.Add(uCtrlModificarTB)
        uCtrlModificarTB.refrecarLista(Me)
        Me.dtaTipoBeca.SendToBack()
        Me.PbTipoBeca.SendToBack()
        Me.btnCrearTipoBeca.SendToBack()
        Me.txtBarraBusqueda.SendToBack()
        uCtrlModificarTB.Location = New Point(155, 50)
        uCtrlModificarTB.Show()
        'uCtrlModificarTB.recieveData(nombre, estado, descripcion)
        uCtrlModificarTB.BringToFront()
        'uCtrlModificarTB.Show()
        'uCtrlModificarTB.Location = New Point(290, 48)

    End Sub

    Private Sub eliminarTipoBeca(ByVal pparametro As String)
        Dim eliminarTipoBeca As EliminarTipoBeca = New EliminarTipoBeca()

        'Dim id As Integer = dtaTipoBeca.CurrentRow.Cells(0).Value
        Dim nombre As String = dtaTipoBeca.CurrentRow.Cells(0).Value
        Dim id As Integer = gestorTipoBeca.idTipoBeca(nombre)
        ' Dim objD As Date = dtaTipoBeca.CurrentRow.Cells(1).Value
        Dim estado As String = dtaTipoBeca.CurrentRow.Cells(1).Value
        Dim descripcion As String = dtaTipoBeca.CurrentRow.Cells(2).Value

        'eliminarTipoBeca.setParametro(parametro)
        eliminarTipoBeca.refrescarLista(Me)
        'FrmIniciarSesion.principal.Controls.Add(ctrlUsuario)
        Me.Controls.Add(eliminarTipoBeca)
        Me.dtaTipoBeca.SendToBack()
        eliminarTipoBeca.BringToFront()
        eliminarTipoBeca.Location = New Point(280, 200)
        eliminarTipoBeca.Show()

        'frmPrincipal.Controls.Add(eliminarTipoBeca)
        eliminarTipoBeca.getUCtrBuscar(Me)
        eliminarTipoBeca.recibirDatos(id, nombre, estado, descripcion)
        'eliminarTipoBeca.BringToFront()
        'eliminarTipoBeca.Show()
        'eliminarTipoBeca.Location = New Point(290, 48)


        listarTiposBeca()

    End Sub

    Private Sub txtBarraBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBarraBusqueda.MouseClick

        txtBarraBusqueda.Text = ""

    End Sub

  

    Private Sub txtBarraBusqueda_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBarraBusqueda.KeyDown

        Dim param As String = txtBarraBusqueda.Text

        If e.KeyCode = 13 Then

            buscarTipoBeca(param)

        End If

    End Sub

    Public Sub buscarTipoBeca(ByVal pparam)
        Try
            Dim tipoBeca As TipoBeca = gestorTipoBeca.buscarUnTipoBeca(pparam)

            If tipoBeca Is Nothing Then
                dtaTipoBeca.Rows.Clear()
                listarTiposBeca()
            Else
                dtaTipoBeca.Rows.Clear()
                dtaTipoBeca.Rows.Add(1)
                dtaTipoBeca.Rows(0).Cells(0).Value = tipoBeca.nombre
                dtaTipoBeca.Rows(0).Cells(1).Value = tipoBeca.estado
            End If
           
        Catch ex As Exception
            dtaTipoBeca.Rows.Clear()
            listarTiposBeca()
        End Try
    End Sub


    Private Sub uCtrlBuscarTipoBeca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarTiposBeca()
    End Sub

    'Private Sub btnCrearTipoBeca_Click(sender As Object, e As EventArgs)
    '    crearTipo = New uCtrlCrearTipoBeca()
    '    FrmIniciarSesion.principal.Controls.Add(crearTipo)
    '    crearTipo.Location = New Point(300, 100)
    '    crearTipo.BringToFront()
    '    crearTipo.Show()


    'End Sub
    Private Sub txtBarraBusqueda_TextChanged_2(sender As Object, e As EventArgs) Handles txtBarraBusqueda.TextChanged
        If (txtBarraBusqueda.Text = "") Then
            listarTiposBeca()
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        dtaTipoBeca.Rows.Clear()
        dtaTipoBeca.Columns("Fecha").Visible = False
        dtaTipoBeca.Columns("Descripcion").Visible = False
        dtaTipoBeca.Columns("Requisitos").Visible = False
        dtaTipoBeca.Columns("Beneficios").Visible = False
        dtaTipoBeca.Columns("opciones").Visible = True
        btnVolver.Visible = False
        dtaTipoBeca.Rows.Clear()
        listarTiposBeca()
    End Sub

    Private Sub btnCrearTipoBeca_Click_1(sender As Object, e As EventArgs) Handles btnCrearTipoBeca.Click
        crearTipo = New uCtrlCrearTipoBeca()
        FrmIniciarSesion.principal.Controls.Add(crearTipo)
        crearTipo.Location = New Point(430, 180)
        crearTipo.BringToFront()
        crearTipo.Show()
    End Sub
End Class
