Imports EntitiesLayer

Public Class uCtrlModificarCarrera

    Public Property idCarrera As Integer
    Public Property colorHexadecimal As String
    Public Property mantenimientoCarreras As uCtrlMantenimientoCarreras
    Dim alerta As UctrlAlerta = New UctrlAlerta()
    Dim listaDirectores As List(Of Usuario)
    Dim mBlnFormDragging As Boolean
    Public Property directorAntiguo As String = ""
    Dim c As ColorDialog = New ColorDialog()

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton seleccionar color, este metodo 
    ''' muestra al usuario una paleta de colores</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click

        If c.ShowDialog() = DialogResult.OK Then
            btnColor.BackColor = c.Color
        End If

        btnColor.ForeColor = Color.White

    End Sub

    ''' <summary>Posiciona la ventana mientras el usuario da click al compomente</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub uCtrlModificarCarrera_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mBlnFormDragging = True Then

            Dim position As Point = frmPrincipal.PointToClient(MousePosition)
            Me.Location = New Point(position)

        End If

    End Sub

    ''' <summary>Situa el componente en la posicion final</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub uCtrlModificarCarrera_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        mBlnFormDragging = False
        Dim position As Point = frmPrincipal.PointToClient(MousePosition)
        Location = New Point(position)

    End Sub

    ''' <summary>Indica si el usuario da click al componente para moverlo</summary>
    ''' <autor>Alvaro Artavia</autor>

    Public Sub uCtrlModificarCarrera_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        mBlnFormDragging = True

    End Sub

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton modificar y llama a la clase
    ''' gestor para modificar la informaciòn</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim nombre As String = txtNombre.Text
        Dim codigo As String = txtCodigo.Text
        Dim color As String = "#" + c.Color.R.ToString("X2") + c.Color.G.ToString("X2") + c.Color.B.ToString("X2")
        Dim directorAcademico As String = cmbAcademico.Text
        Dim idDirector As String = buscarDirector(directorAcademico)

        Try

            objGestorCarrera.modificarCarrera(nombre, codigo, color, idCarrera, idDirector)
            objGestorCarrera.guardarCambios()
            mantenimientoCarreras.listarCarreras()
            FrmIniciarSesion.principal.mostrarConfirmacion("Carrera modificada con éxito")

        Catch ex As Exception

            alerta.txtAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.Location = New Point(360, 220)
            alerta.BringToFront()
            alerta.Show()

        End Try

        Me.Dispose()

    End Sub

    ''' <summary>Llena en un combobox los directores academicos</summary>
    ''' <autor>Alvaro Artavia</autor>

    Public Sub llenarDirectoresCmb()

        Try


            listaDirectores = objGestorCarrera.consultarDirectoresAcademicos()

            If listaDirectores Is Nothing Then

            Else

                For i As Integer = 0 To listaDirectores.Count - 1

                    cmbAcademico.Items.Add(listaDirectores(i).primerNombre & " " & listaDirectores(i).primerApellido & " " & listaDirectores(i).segundoApellido)
                Next

            End If

        Catch ex As Exception

            alerta.txtAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.Location = New Point(375, 100)
            alerta.BringToFront()
            alerta.Show()

        End Try

    End Sub

    ''' <summary>Cierra la ventana cuando el usuario da click al boton cancelar</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Me.Dispose()

    End Sub

    ''' <summary>Cierra la ventana cuando el usuario da click al boton cerrar</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        Me.Dispose()

    End Sub

    ''' <summary>Cuando se instancia el componente se llama al metodo llenarDirectoresCmb</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub uCtrlModificarCarrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ColorTranslator.FromHtml(colorHexadecimal)
        'c.Color = ColorTranslator.FromHtml(colorHexadecimal)
        btnColor.BackColor = ColorTranslator.FromHtml(colorHexadecimal)
        btnColor.ForeColor = Color.White
        llenarDirectoresCmb()

    End Sub




    ''' <summary>Busca el director academico anterior para eliminarlo de la base de datos</summary>
    ''' <param name="pdirector">Nombre del director academico</param>
    ''' <autor>Alvaro Artavia</autor>

    Public Function buscarDirector(ByVal pdirector As String) As String

        Dim nombreCompleto As String
        Dim idDirector As String = ""

        If listaDirectores Is Nothing Then

        Else

            For i As Integer = 0 To listaDirectores.Count - 1

                nombreCompleto = listaDirectores(i).primerNombre & " " & listaDirectores(i).primerApellido & " " &
                listaDirectores(i).segundoApellido

                If nombreCompleto.Equals(pdirector) Then

                    idDirector = listaDirectores(i).identificacion

                End If

            Next

        End If

        Return idDirector

    End Function


End Class
