Imports EntitiesLayer
Public Class FrmIniciarSesion

    Public Property principal As frmPrincipal = New frmPrincipal()

    Private Sub FrmIniciarSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim UcntrlIniciar As UCtrlIniciar = New UCtrlIniciar()
        Me.Controls.Add(UcntrlIniciar)
        UcntrlIniciar.Location = New Point(135, 125)
        UcntrlIniciar.BringToFront()
        UcntrlIniciar.Show()

    End Sub
End Class