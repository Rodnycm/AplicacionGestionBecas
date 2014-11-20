
Imports EntitiesLayer

Public Class uCtrlMenuMantenimiento

    Public Property uCtrlMantCarreras As uCtrlMantenimientoCarreras = New uCtrlMantenimientoCarreras
    Public Property uCtrlMantCursos As UCtrlBuscarCursos = New UCtrlBuscarCursos()
    Public Property uCtrlMantRequisitos As uCtrlMantenimientoRequisitos = New uCtrlMantenimientoRequisitos()
    Public Property uCntrlMantRol As uCtrlListarRol = New uCtrlListarRol()
    Public Property ucntrlUsuario As UctrlListarYBuscarUsuario = New UctrlListarYBuscarUsuario()
    Public Property uCntrlBuscarBeneficio As uCntrlBuscarBeneficio = New uCntrlBuscarBeneficio()
    Public Property uCtrlTipoBeca As uCtrlBuscarTipoBeca = New uCtrlBuscarTipoBeca

    Public listaPermisos As List(Of Permiso) = New List(Of Permiso)
    '' Dim ListarRol As New ListarRol()
    Private Sub btnRequisitos_Click(sender As Object, e As EventArgs) Handles btnRequisitos.Click

        Me.Hide()
        'uCtrlMantRequisitos = New uCtrlMantenimientoRequisitos()
        FrmIniciarSesion.principal.Controls.Add(uCtrlMantRequisitos)
        uCtrlMantRequisitos.Show()

    End Sub

    Public Sub ListasDePermisos(ByVal plistaPermisos As List(Of Permiso))

        ClearPermisos()
        Try
            For i As Integer = 0 To plistaPermisos.Count - 1
                If plistaPermisos.Item(i).Nombre = "Usuarios" Then
                    btnUsuarios.Visible = True
                ElseIf (plistaPermisos.Item(i).Nombre = "Roles") Then
                    btnRoles.Visible = True
                ElseIf (plistaPermisos.Item(i).Nombre = "Becas") Then
                    btnBecas.Visible = True
                ElseIf (plistaPermisos.Item(i).Nombre = "Requisitos") Then
                    btnRequisitos.Visible = True
                ElseIf (plistaPermisos.Item(i).Nombre = "Beneficios") Then
                    btnBeneficios.Visible = True
                ElseIf (plistaPermisos.Item(i).Nombre = "Cursos") Then
                    btnCursos.Visible = True
                ElseIf (plistaPermisos.Item(i).Nombre = "Carreras") Then
                    btnCarreras.Visible = True
                End If

            Next

        Catch ex As Exception
            Dim uctrlAlerta As UctrlAlerta = New UctrlAlerta()
            Me.Controls.Add(uctrlAlerta)
            uctrlAlerta.Location = New Point(300, 100)
            uctrlAlerta.BringToFront()
            uctrlAlerta.txtAlerta.Text = "No Tiene ningun Permiso"
            uctrlAlerta.Show()
        End Try


    End Sub

    Public Sub ClearPermisos()
        btnUsuarios.Visible = False
        btnRoles.Visible = False
        btnBecas.Visible = False
        btnRequisitos.Visible = False
        btnBeneficios.Visible = False
        btnCursos.Visible = False
        btnCarreras.Visible = False

    End Sub

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton cursos, muestra 
    ''' al usuario el menu de cursos</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnCursos_Click(sender As Object, e As EventArgs) Handles btnCursos.Click

        Me.Hide()
        'uCtrlMantCursos = New uCtrlMantenimientoCursos()
        FrmIniciarSesion.principal.Controls.Add(uCtrlMantCursos)
        uCtrlMantCursos.Show()

    End Sub

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton carreras, muestra 
    ''' al usuario el menu de carreras</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnCarreras_Click(sender As Object, e As EventArgs) Handles btnCarreras.Click

        Me.Hide()
        uCtrlMantCarreras = New uCtrlMantenimientoCarreras()
        FrmIniciarSesion.principal.Controls.Add(uCtrlMantCarreras)
        uCtrlMantCarreras.Show()

    End Sub

    Private Sub btnRoles_Click(sender As Object, e As EventArgs) Handles btnRoles.Click
        Me.Hide()
        FrmIniciarSesion.principal.Controls.Add(uCntrlMantRol)
        uCntrlMantRol.Show()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click

        'Dim ucntrlUsuario As UctrlListarYBuscarUsuario = New UctrlListarYBuscarUsuario()
        Me.SendToBack()
        Me.Hide()
        FrmIniciarSesion.principal.Controls.Add(ucntrlUsuario)
        ucntrlUsuario.Show()

    End Sub

    Private Sub btnBeneficios_Click(sender As Object, e As EventArgs) Handles btnBeneficios.Click
        Me.Hide()
        FrmIniciarSesion.principal.Controls.Add(uCntrlBuscarBeneficio)
        uCntrlBuscarBeneficio.Show()
    End Sub

    Private Sub btnBecas_Click(sender As Object, e As EventArgs) Handles btnBecas.Click

        Me.Hide()
        uCtrlTipoBeca = New uCtrlBuscarTipoBeca()
        FrmIniciarSesion.principal.Controls.Add(uCtrlTipoBeca)
        uCtrlTipoBeca.Show()

    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click

        FrmIniciarSesion.principal.instanciaUctrlEmail()
        FrmIniciarSesion.principal.uCtrlEmail.Show()
        FrmIniciarSesion.principal.uCtrlEmail.BringToFront()

    End Sub

End Class
