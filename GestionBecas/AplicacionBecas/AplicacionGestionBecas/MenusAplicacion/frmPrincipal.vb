Imports EntitiesLayer

Partial Public Class frmPrincipal

    Inherits Form

    Public Property ucMenuMant As New uCtrlMenuMantenimiento()
    Public Property ucMenuAcad As New uCtrlMenuAcademico()
    Public Property ucMenuRep As New uCtrlMenuReportes()
    Public Property ucMenuBecas As New uCtrlMenuBecas()
    Public Property uCtrlUserProfile As New UCtrlUserProfile()
    Public Property mensajeInstaneo As New UCtrlInstantMessage()
    Public Property uCtrlEmail As UctrlEmailConfiguration = New UctrlEmailConfiguration()
    Public Property confirmacion As uCtrlConfirmacion = New uCtrlConfirmacion()
    Public Property uctrlConfMessage As UCtrlConfMessage = New UCtrlConfMessage()
    Public Property listaPermisos As List(Of Permiso) = New List(Of Permiso)
    Public Property uctrlBitacora As UCtrlUltimasActividades = New UCtrlUltimasActividades()

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        nombreMenuHorizontal()
        ValidarPermisos()
        FrmIniciarSesion.principal.Controls.Add(mensajeInstaneo)
        mensajeInstaneo.BringToFront()
        mensajeInstaneo.Show()
        FrmIniciarSesion.principal.Controls.Add(uctrlBitacora)
        uctrlBitacora.BringToFront()
        uctrlBitacora.Show()

    End Sub

    Public Sub nombreMenuHorizontal()

        Dim nombre As String = ""
        Dim apellido As String = ""
        AlvaroArtaviaToolStripMenuItem.Text = ""
        nombre = Globals.usuario.primerNombre
        apellido = Globals.usuario.primerApellido
        AlvaroArtaviaToolStripMenuItem.Text = nombre & " " & apellido

    End Sub

    Public Sub ValidarPermisos()

        listaPermisos = objGestorRol.consultarPermisosPorRol(Globals.usuario.rol.Id)

    End Sub

    Public Sub New()

        InitializeComponent()
        MenuLateral.Renderer = New MyRenderer()
        MenuHorizontal.Renderer = New MyRenderer()

    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click

        ValidarPermisos()
        uCtrlUserProfile.Dispose()
        ucMenuMant.Hide()
        ocultarComponentes()
        ucMenuMant.ListasDePermisos(listaPermisos)
        uCtrlUserProfile.Dispose()
        ocultarComponentes()
        btnsMenus().Show()
        ucMenuRep.Hide()

    End Sub

    Private Sub MantenimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoToolStripMenuItem.Click

        ucMenuAcad.Hide()
        Me.Controls.Add(ucMenuMant)
        ValidarPermisos()
        ucMenuMant.ListasDePermisos(listaPermisos)
        uCtrlUserProfile.Dispose()
        ocultarComponentes()
        btnsMenus.Hide()
        mensajeInstaneo.Hide()
        uctrlBitacora.Hide()
        ucMenuRep.Hide()
        ucMenuMant.Show()

    End Sub


    Private Sub AcadémicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcadémicoToolStripMenuItem.Click

        uCtrlUserProfile.Dispose()
        ucMenuMant.Hide()
        ocultarComponentes()
        ValidarPermisos()
        ucMenuMant.ListasDePermisos(listaPermisos)
        mensajeInstaneo.Hide()
        uctrlBitacora.Hide()
        ucMenuRep.Hide()

    End Sub


    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click

        uCtrlUserProfile.Dispose()
        ucMenuMant.Hide()
        ocultarComponentes()
        ValidarPermisos()
        ucMenuMant.ListasDePermisos(listaPermisos)
        mensajeInstaneo.Hide()
        btnsMenus.Hide()
        mensajeInstaneo.Hide()
        uctrlBitacora.Hide()
        Me.Controls.Add(ucMenuRep)
        ucMenuRep.Show()

    End Sub

    Private Sub btnMantenimiento_Click(sender As Object, e As EventArgs) Handles btnMantenimiento.Click

        ValidarPermisos()
        ucMenuMant.ListasDePermisos(listaPermisos)
        btnsMenus.Hide()
        mensajeInstaneo.Hide()
        uctrlBitacora.Hide()
        Me.Controls.Add(ucMenuMant)
        ucMenuMant.Show()

    End Sub

    Private Sub btnAcademico_Click(sender As Object, e As EventArgs) Handles btnAcademico.Click

        'btnsMenus.Hide()
        'mensajeInstaneo.Hide()
        'Me.Controls.Add(ucMenuAcad)
        'ucMenuAcad.Show()
        ''ocultarComponentes()

    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click

        btnsMenus.Hide()
        mensajeInstaneo.Hide()
        uctrlBitacora.Hide()
        Me.Controls.Add(ucMenuRep)
        ucMenuRep.Show()

    End Sub

    Public Sub ocultarComponentes()

        ucMenuMant.uCtrlMantCarreras.Hide()
        ucMenuMant.uCtrlMantCursos.Hide()
        ucMenuMant.uCtrlMantRequisitos.Hide()
        ucMenuMant.uCntrlMantRol.Hide()
        ucMenuMant.ucntrlUsuario.Hide()
        ucMenuMant.uCtrlTipoBeca.Hide()
        ucMenuRep.uctrlReportesBitcoraAcciones.Hide()
        ucMenuRep.uctrlPlanEstudio.Hide()
        ucMenuMant.uCntrlBuscarBeneficio.Hide()
        mensajeInstaneo.Show()
        btnsMenus.Show()
        uctrlBitacora.Show()

    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click

        cerrarSesionUsuario()

    End Sub

    Public Sub cerrarSesionUsuario()

        objGestorUsuario.cerrarSesion()
        Me.Hide()
        ocultarComponentes()
        FrmIniciarSesion.Show()
        Dim UcntrlIniciar As UCtrlIniciar = New UCtrlIniciar()
        FrmIniciarSesion.Controls.Add(UcntrlIniciar)
        UcntrlIniciar.Location = New Point(135, 125)
        Globals.clear()

    End Sub

    Private Sub VerPerfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerPerfilToolStripMenuItem.Click

        ocultarComponentes()
        mensajeInstaneo.Hide()
        uctrlBitacora.Hide()
        btnsMenus.Hide()
        uCtrlUserProfile = New UCtrlUserProfile()
        FrmIniciarSesion.principal.Controls.Add(uCtrlUserProfile)
        uCtrlUserProfile.BringToFront()
        uCtrlUserProfile.Show()

    End Sub

    Public Sub instanciaUctrlEmail()

        uCtrlEmail = New UctrlEmailConfiguration()
        Me.Controls.Add(uCtrlEmail)
        uCtrlEmail.Hide()

    End Sub

    Public Sub instanciaUctrlConfMessage()

        uctrlConfMessage = New UCtrlConfMessage()
        Me.Controls.Add(uctrlConfMessage)
        uctrlConfMessage.BringToFront()
        uctrlConfMessage.Show()

    End Sub

    Public Sub mostrarConfirmacion(ByVal mensaje As String)

        confirmacion = New uCtrlConfirmacion()
        Me.Controls.Add(confirmacion)
        confirmacion.txtConfirmacion.Text = mensaje
        confirmacion.BringToFront()
        confirmacion.Show()

    End Sub


End Class

Public Class MyRenderer

    Inherits ToolStripProfessionalRenderer

    Protected Overloads Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)

        Dim rc As New Rectangle(Point.Empty, e.Item.Size)
        Dim c As Color = IIf(e.Item.Selected, Color.FromArgb(50, 133, 43, 153), Color.FromArgb(0, 48, 44, 43))

        Using brush As New SolidBrush(c)
            e.Graphics.FillRectangle(brush, rc)
        End Using

    End Sub

End Class
