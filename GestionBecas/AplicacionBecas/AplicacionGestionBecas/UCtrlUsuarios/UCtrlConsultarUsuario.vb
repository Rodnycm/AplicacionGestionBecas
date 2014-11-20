Imports EntitiesLayer
Public Class UCtrlConsultarUsuario

    Dim parametro As String

    Public Sub setParametro(ByVal pparametro As String)
        parametro = pparametro
    End Sub

    Private Sub UCtrlConsultarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim objUsuario As Usuario = objGestorUsuario.buscarUnUsuario(Me.parametro)
        Dim genero As String
        dgUsuarios.Rows.Clear()

        If objUsuario.genero = 1 Then
            genero = "Masculino"
        ElseIf objUsuario.genero = 2 Then
            genero = "Femenino"
        Else
            genero = "Otro"
        End If

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim ucntrl As UctrlListarYBuscarUsuario = New UctrlListarYBuscarUsuario()
        Me.Hide()
        FrmIniciarSesion.principal.Controls.Add(ucntrl)
        ucntrl.Location = New Point(120, 0)
        ucntrl.Show()
    End Sub



End Class
