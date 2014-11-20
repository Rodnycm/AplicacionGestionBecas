Imports EntitiesLayer

Public Class uCtrlCrearCarrera

    Public Property mantenimientoCarreras As uCtrlMantenimientoCarreras
    Dim mBlnFormDragging As Boolean
    Dim listaDirectores As List(Of Usuario)
    Dim alerta As UctrlAlerta = New UctrlAlerta()
    Dim c As ColorDialog = New ColorDialog()
    Dim listaC As List(Of Curso)
    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton seleccionar color, este metodo 
    ''' muestra al usuario una paleta de colores</summary>
    ''' <autor>Alvaro Artavia</autor>
    Public Sub setListasC(ByVal plistasC As List(Of Curso))
        listaC = plistasC
    End Sub
    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click

        If c.ShowDialog() = DialogResult.OK Then
            btnColor.BackColor = c.Color
        End If
        btnColor.ForeColor = Color.White

    End Sub

    ''' <summary>Posiciona la ventana mientras el usuario da click al compomente</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub uCtrlCrearCarrera_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mBlnFormDragging = True Then

            Dim position As Point = frmPrincipal.PointToClient(MousePosition)
            Me.Location = New Point(position)

        End If

    End Sub

    ''' <summary>Situa el componente en la posicion final</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub uCtrlCrearCarrera_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        mBlnFormDragging = False
        Dim position As Point = frmPrincipal.PointToClient(MousePosition)
        Location = New Point(position)

    End Sub


    ''' <summary>Indica si el usuario da click al componente para moverlo</summary>
    ''' <autor>Alvaro Artavia</autor>

    Public Sub uCtrlCrearCarrera_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        mBlnFormDragging = True

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

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton añadir y llama a la clase
    ''' gestor para enviar la informaciòn</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click

        Dim nombre As String = txtNombre.Text
        Dim codigo As String = txtCodigo.Text
        Dim color As String = "#" + c.Color.R.ToString("X2") + c.Color.G.ToString("X2") + c.Color.B.ToString("X2")
        Dim directorAcademico As String = cmbAcademico.Text
        Dim nombreCompleto As String
        Dim idDirector As String = ""

        If listaDirectores Is Nothing Then

        Else

            For i As Integer = 0 To listaDirectores.Count - 1

                nombreCompleto = listaDirectores(i).primerNombre & " " & listaDirectores(i).primerApellido & " " &
                listaDirectores(i).segundoApellido

                If nombreCompleto.Equals(directorAcademico) Then

                    idDirector = listaDirectores(i).identificacion

                End If

            Next
        End If


        Try

            objGestorCarrera.agregarCarrera(nombre, codigo, color, idDirector)
            objGestorCarrera.guardarCambios()


            mantenimientoCarreras.listarCarreras()

        Catch ex As Exception

            alerta.txtAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.Location = New Point(375, 100)
            alerta.BringToFront()
            alerta.Show()
            Me.Dispose()

        End Try

    End Sub


    ''' <summary>Cierra la ventana cuando el usuario da click al boton cerrar</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    ''' <summary>Cierra la ventana cuando el usuario da click al boton cancelar</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    ''' <summary>Cuando se instancia el componente se llama al metodo llenarDirectoresCmb</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub uCtrlCrearCarrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarDirectoresCmb()

    End Sub

    Private Sub btnCursos_Click(sender As Object, e As EventArgs) Handles btnCursos.Click
        'Dim cursos As uCtrlAsignarCursosCarrera = New uCtrlAsignarCursosCarrera()
        'FrmIniciarSesion.principal.Controls.Add(cursos)
        'cursos.enviarcursos(Me)
        'cursos.Location = New Point(150, 250)
        'cursos.BringToFront()
        'cursos.Show()
    End Sub
End Class
