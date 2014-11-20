Imports EntitiesLayer

Public Class uCtrlConsultarPlanDeEstudio

    Dim carrera As Carrera

    Private Sub uCtrlConsultarPlanDeEstudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarCursos()
        llenarComboCursos()
    End Sub

    Public Sub listarCursos()

        Try

        limpiarGrid()

        Dim listaCursos As New List(Of Curso)
        listaCursos = objGestorCurso.consultarCursos()
        Dim totalCreditos = 0
        Dim precioTotal = 0

        For Each Curso In listaCursos

            dtaConsultarPlanEstudio.Rows.Add(Curso.nombre, Curso.creditos, Curso.precio)
            totalCreditos = totalCreditos + Curso.creditos
            precioTotal = precioTotal + Curso.precio
        Next

        lblSumaCreditos.Text = totalCreditos
        lblSumaPrecio.Text = precioTotal

        Catch ex As Exception

            Dim UCtrl As New UctrlAlerta

            Me.Controls.Add(UCtrl)
            UCtrl.txtAlerta.Text = ex.Message
            UCtrl.Location = New Point(300, 100)
            UCtrl.BringToFront()
            UCtrl.Show()

        End Try

    End Sub

    Public Sub llenarComboCursos()
        Try

            Dim listaCursos As Array
            listaCursos = objGestorCurso.consultarCursosPorCuatrimestre()

            For i As Integer = 0 To listaCursos.Length - 1

                cmbCursos.Items.Add(listaCursos(i))
            Next

        Catch ex As Exception

            Dim UCtrl As New UctrlAlerta

            Me.Controls.Add(UCtrl)
            UCtrl.txtAlerta.Text = ex.Message
            UCtrl.Location = New Point(300, 100)
            UCtrl.BringToFront()
            UCtrl.Show()

        End Try

    End Sub

    Public Sub listarCursosPorCuatri()
        Try

       
        Dim listaCursos As New List(Of Curso)
        listaCursos = objGestorCurso.getCursoPorCuatrimestre(cmbCursos.SelectedItem)
        Dim precioTotal As Double
        Dim totalCreditos As Integer

        limpiarGrid()

        For i As Integer = 0 To listaCursos.Count - 1

            dtaConsultarPlanEstudio.Rows.Add(listaCursos.Item(i).nombre, listaCursos.Item(i).creditos, listaCursos.Item(i).precio)
            totalCreditos = totalCreditos + listaCursos.Item(i).creditos
            precioTotal = precioTotal + listaCursos.Item(i).precio
        Next

        lblSumaCreditos.Text = totalCreditos
            lblSumaPrecio.Text = precioTotal

        Catch ex As Exception

            Dim UCtrl As New UctrlAlerta
            Me.Controls.Add(UCtrl)
            UCtrl.txtAlerta.Text = ex.Message
            UCtrl.Location = New Point(300, 100)
            UCtrl.BringToFront()
            UCtrl.Show()

        End Try

    End Sub


    Public Sub limpiarGrid()

        dtaConsultarPlanEstudio.Rows.Clear()

    End Sub

    Private Sub cmbCursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCursos.SelectedIndexChanged
        listarCursosPorCuatri()
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click

        listarCursos()
        cmbCursos.Text = "Cuatrimestres"

    End Sub
End Class
