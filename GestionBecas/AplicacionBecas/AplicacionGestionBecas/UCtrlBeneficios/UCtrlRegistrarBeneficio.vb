Public Class uCtrlRegistrarBeneficio

    Dim uCntrlBuscarBeneficio As UI.uCntrlBuscarBeneficio

    Dim mBlnFormDragging As Boolean

    ''' <summary>
    ''' Setea una instancia del UsrControlBuscarBeneficio
    ''' </summary>
    ''' <param name="puCntrlBuscarBeneficio">Es la instancia del usrControl</param>
    ''' <remarks></remarks>

    Public Sub getFrmBuscar(puCntrlBuscarBeneficio As UI.uCntrlBuscarBeneficio)


        uCntrlBuscarBeneficio = puCntrlBuscarBeneficio
    End Sub

    ''' <summary>
    ''' Este método toma los valores ingresados en la pantalla y los envía al GestorBeneficios para crear un beneficio.
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <param name="sender"></param>
    ''' <param name="e">Es el evento</param>

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click

        Dim nombre As String
        Dim porcentaje As Double
        Dim asociacion As String
        Dim formatoCorrecto As Double

        Try
            formatoCorrecto = FormatNumber(txPorcentaje.Text, 0.0)

            If txtNombre.Text.Length <= 50 And txtAplicacion.Text.Length <= 50 Then

                If formatoCorrecto <> CType(txPorcentaje.Text, Double) And formatoCorrecto <= 1 Then

                    If (IsNumeric(txPorcentaje.Text) = True) Then

                        nombre = txtNombre.Text
                        porcentaje = CType(txPorcentaje.Text, Double)
                        asociacion = txtAplicacion.Text


                        Try
                            objGestorBeneficio.agregarBeneficio(nombre, porcentaje, asociacion)
                            objGestorBeneficio.guardarCambios()

                            Dim Uctrl As uCtrlConfirmacion = New uCtrlConfirmacion
                            FrmIniciarSesion.principal.Controls.Add(Uctrl)
                            Uctrl.txtConfirmacion.Text = "El beneficio se registró correctamente"
                            Uctrl.Location = New Point(400, 250)
                            Uctrl.BringToFront()
                            Uctrl.Show()

                        Catch ex As Exception

                            Dim UCtrl As UctrlAlerta = New UctrlAlerta()

                            FrmIniciarSesion.principal.Controls.Add(UCtrl)
                            UCtrl.txtAlerta.Text = ex.Message
                            UCtrl.Location = New Point(300, 250)
                            UCtrl.BringToFront()
                            UCtrl.Show()

                        End Try

                    Else

                        Dim UCtrl As UctrlAlerta = New UctrlAlerta()

                        FrmIniciarSesion.principal.Controls.Add(UCtrl)
                        UCtrl.txtAlerta.Text = "El porcentaje debe ser un numero"
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
                'aqui
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
            UCtrl.Location = New Point(300, 100)
            UCtrl.BringToFront()
            UCtrl.Show()

        End Try

        uCntrlBuscarBeneficio.dtaBuscarBeneficio.Rows.Clear()
        uCntrlBuscarBeneficio.listarBeneficios()

        Me.Hide()
        Me.Dispose()

    End Sub

    ''' <summary>
    ''' Este método esconde la pantalla, cuando el usuario selecciona el boton cancelar.
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        uCntrlBuscarBeneficio.dtaBuscarBeneficio.Rows.Clear()
        uCntrlBuscarBeneficio.listarBeneficios()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        Me.Hide()
        uCntrlBuscarBeneficio.dtaBuscarBeneficio.Rows.Clear()
        uCntrlBuscarBeneficio.listarBeneficios()

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
