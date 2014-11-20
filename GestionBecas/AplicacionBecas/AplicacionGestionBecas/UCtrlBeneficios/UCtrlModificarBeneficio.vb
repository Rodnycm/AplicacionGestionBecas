Public Class uCtrlModificarBeneficio

    Dim id As Integer
    Dim nombre As String
    Dim porcentaje As Double
    Dim aplicacion As String
    Dim uCntrlBuscarBeneficio As UI.uCntrlBuscarBeneficio
    Dim mBlnFormDragging As Boolean


    Public Sub getFrmBuscar(puCntrlBuscarBeneficio As UI.uCntrlBuscarBeneficio)

        uCntrlBuscarBeneficio = puCntrlBuscarBeneficio

    End Sub

    ''' <summary>
    ''' Este método se encarga de 'Setear' los textbox con los parametros recibidos
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <param name="pnombre">Es el nombre del beneficio</param>
    ''' <param name="pporcentaje">El porcentaje del beneficio</param>
    ''' <param name="paplicacion">La aplicabilidad del beneficio</param>

    Public Sub recieveData(pid As Integer, pnombre As String, pporcentaje As Double, paplicacion As String)

        id = pid
        txtNombre.Text = pnombre
        txtPorcentaje.Text = pporcentaje
        txtAplicabilidad.Text = paplicacion


    End Sub


    ''' <summary>
    ''' Este método se encarga de 'Setear' las variables globales del userControl.
    ''' Las variables se setean con la informacion que se encuentra en los textbox.
    ''' Una vez seteadas las variables, las envia al gestor para modificar el beneficio.
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim formatoCorrecto As Double

        Try

            formatoCorrecto = FormatNumber(txtPorcentaje.Text, 0.0)

            If txtNombre.Text.Length <= 50 And txtAplicabilidad.Text.Length <= 50 Then

                If formatoCorrecto <> CType(txtPorcentaje.Text, Double) And formatoCorrecto <= 1 Then

                    If (IsNumeric(txtPorcentaje.Text) = True) Then

                        Try
                            nombre = txtNombre.Text
                            porcentaje = CType(txtPorcentaje.Text, Double)
                            aplicacion = txtAplicabilidad.Text


                            objGestorBeneficio.modificarBeneficio(id, nombre, porcentaje, aplicacion)
                            objGestorBeneficio.guardarCambios()

                            Dim Uctrl As uCtrlConfirmacion = New uCtrlConfirmacion
                            FrmIniciarSesion.principal.Controls.Add(Uctrl)
                            Uctrl.txtConfirmacion.Text = "El beneficio se modificó correctamente"
                            Uctrl.Location = New Point(430, 250)
                            Uctrl.BringToFront()
                            Uctrl.Show()

                        Catch ex As Exception

                            Dim UCtrl As UctrlAlerta = New UctrlAlerta()

                            FrmIniciarSesion.principal.Controls.Add(UCtrl)
                            UCtrl.txtAlerta.Text = ex.Message
                            UCtrl.Location = New Point(430, 250)
                            UCtrl.BringToFront()
                            UCtrl.Show()

                        End Try
                    Else

                        Dim UCtrl As UctrlAlerta = New UctrlAlerta()
                        FrmIniciarSesion.principal.Controls.Add(UCtrl)
                        UCtrl.txtAlerta.Text = "El porcentaje debe ser numérico (0.00)"
                        UCtrl.Location = New Point(300, 100)
                        UCtrl.BringToFront()
                        UCtrl.Show()


                    End If

                Else

                    Dim UCtrl As UctrlAlerta = New UctrlAlerta()

                    FrmIniciarSesion.principal.Controls.Add(UCtrl)
                    UCtrl.txtAlerta.Text = "Formato del porcentaje Invalido"
                    UCtrl.Location = New Point(300, 100)
                    UCtrl.BringToFront()
                    UCtrl.Show()
                End If

            Else

                Dim UCtrl As UctrlAlerta = New UctrlAlerta()

                FrmIniciarSesion.principal.Controls.Add(UCtrl)
                UCtrl.txtAlerta.Text = "No se aceptan textos tan largos"
                UCtrl.Location = New Point(300, 100)
                UCtrl.BringToFront()
                UCtrl.Show()

            End If


        Catch ex As Exception

            Dim UCtrl As UctrlAlerta = New UctrlAlerta()

            FrmIniciarSesion.principal.Controls.Add(UCtrl)
            UCtrl.txtAlerta.Text = ex.Message
            UCtrl.Location = New Point(250, 50)
            UCtrl.BringToFront()
            UCtrl.Show()

        End Try

        uCntrlBuscarBeneficio.dtaBuscarBeneficio.Rows.Clear()
        uCntrlBuscarBeneficio.listarBeneficios()

        Me.Hide()
        Me.Dispose()

    End Sub

    ''' <summary>
    ''' Este metodo se encarga de esconder el formulario cuando el usuario da click en cancelar.
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        uCntrlBuscarBeneficio.dtaBuscarBeneficio.Rows.Clear()
        uCntrlBuscarBeneficio.listarBeneficios()
        Me.Hide()
        Me.Dispose()
    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        uCntrlBuscarBeneficio.dtaBuscarBeneficio.Rows.Clear()
        uCntrlBuscarBeneficio.listarBeneficios()
        Me.Hide()
        Me.Dispose()
    End Sub

    Private Sub uCtrlRegistrarBeneficio_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mBlnFormDragging = True Then

            Dim position As Point = frmPrincipal.PointToClient(MousePosition)
            Me.Location = New Point(position)

        End If

    End Sub

    Private Sub uCtrlRegistrarBeneficio_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        mBlnFormDragging = False
        Dim position As Point = frmPrincipal.PointToClient(MousePosition)
        Location = New Point(position)

    End Sub

    Public Sub uCtrlRegistrarBeneficio_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        mBlnFormDragging = True

    End Sub

End Class
