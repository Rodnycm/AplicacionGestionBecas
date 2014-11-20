Imports EntitiesLayer

Public Class UCtrlAsignarCursos

    Dim mBlnFormDragging As Boolean

    Private Sub listarPermisos()

        Dim listaCursos As New List(Of Curso)

        Try

            listaCursos = objGestorCurso.consultarCursos

            For Each curso In listaCursos

                listBoxCursos.Items.Add(curso.nombre)

            Next

        Catch ex As Exception

        End Try

    End Sub

    ''' <summary>Posiciona la ventana mientras el usuario da click al compomente</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub uCtrlAsignarCursos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mBlnFormDragging = True Then

            Dim position As Point = frmPrincipal.PointToClient(MousePosition)
            Me.Location = New Point(position)

        End If

    End Sub

    ''' <summary>Situa el componente en la posicion final</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub uCtrlAsignarCursos_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        mBlnFormDragging = False
        Dim position As Point = frmPrincipal.PointToClient(MousePosition)
        Location = New Point(position)

    End Sub


    ''' <summary>Indica si el usuario da click al componente para moverlo</summary>
    ''' <autor>Alvaro Artavia</autor>

    Public Sub uCtrlAsignarCursos_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        mBlnFormDragging = True

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub
End Class
