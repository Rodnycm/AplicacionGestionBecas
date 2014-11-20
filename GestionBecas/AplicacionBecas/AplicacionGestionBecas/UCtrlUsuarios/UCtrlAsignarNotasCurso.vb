Imports EntitiesLayer
Imports BLL

Public Class UCtrlAsignarNotasCurso
    Public Sub UctrlAsignarNotasCurso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarUsuarios()
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown

        Dim param As String = txtBuscar.Text

        If e.KeyCode = 13 Then

            buscarUsuario(param)

        End If

    End Sub
    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim combo As ComboBox = CType(sender, ComboBox)

        If combo.SelectedItem = "Ver" Then
            Dim parametro = dgUsuarios.CurrentRow.Cells(0).Value
            'consultarUsuario(parametro)
        End If

    End Sub
    Public Sub buscarUsuario(ByVal pparametro As String)
        Try
            Dim objUsuario As Usuario = objGestorUsuario.buscarUnUsuario(txtBuscar.Text)
            dgUsuarios.Rows.Clear()
            dgUsuarios.Rows.Add(objUsuario.identificacion, objUsuario.primerNombre & " " & objUsuario.primerApellido & " " & objUsuario.segundoApellido, objUsuario.telefono, objUsuario.fechaNacimiento, "", objUsuario.rol.Nombre, objUsuario.correoElectronico)
        Catch ex As Exception
            dgUsuarios.Rows.Clear()
            listarUsuarios()
        End Try
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.MouseClick

        txtBuscar.Text = ""

    End Sub
    '<summary> Método que se encarga de listar los usuarios que hay registrados en el sistema</summary>
    '<author> Gabriela Gutiérrez Corrales </author> 
    '<param> No recibe valor  </param>
    '<returns> No retorna valor.</returns> 
    Public Sub listarUsuarios()
        Try
            dgUsuarios.Rows.Clear()
            Dim listaUsuarios As List(Of Usuario)
            listaUsuarios = objGestorUsuario.buscarUsuarios()

            For Each usuario As Usuario In listaUsuarios
                dgUsuarios.Rows.Add(usuario.identificacion, usuario.primerNombre & " " & usuario.primerApellido & " " & usuario.segundoApellido, usuario.telefono, usuario.fechaNacimiento, "", usuario.rol.Nombre, usuario.correoElectronico)
            Next
        Catch ex As Exception
            Dim uctrlAlerta As UctrlAlerta = New UctrlAlerta()
            Me.Controls.Add(uctrlAlerta)
            uctrlAlerta.Location = New Point(300, 100)
            uctrlAlerta.BringToFront()
            Me.SendToBack()
            uctrlAlerta.txtAlerta.Text = "No hay usuarios registrados"
            uctrlAlerta.Show()

        End Try

    End Sub

    Private Sub txtBuscar_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub dgUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUsuarios.CellContentClick

    End Sub
End Class
