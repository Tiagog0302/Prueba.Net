Imports capaEntidad
Imports capaNegocio
Public Class Form1

    Dim NegocioEmpleado As New CNEmpleado()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
    End Sub

    Private Sub CargarGrid()
        gridDatos.DataSource = NegocioEmpleado.Listar().Tables("empleado")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Dim empleado As New CEEmpleado()
        Dim Validacion As Boolean

        empleado.Id = txtId.Value
        empleado.CodEmpresa = txtCodEmpresa.Text
        empleado.Nombre = txtNombre.Text
        empleado.Apellido = txtApellido.Text


        Validacion = NegocioEmpleado.ValidarDatos(empleado)

        If Validacion = False Then Exit Sub

        If empleado.Id = 0 Then
            NegocioEmpleado.Insertar(empleado)
            NegocioEmpleado.Editar(empleado)
        Else
            NegocioEmpleado.Editar(empleado)
        End If


        CargarGrid()

    End Sub

    Private Sub btnNombre_Click(sender As Object, e As EventArgs) Handles btnNombre.Click

        txtId.Value = 0
        txtCodEmpresa.Text = ""
        txtApellido.Text = ""
        txtNombre.Text = ""


    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs)
        NegocioEmpleado.PruebaMysql()

    End Sub

    Private Sub gridDatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridDatos.CellDoubleClick
        txtId.Value = gridDatos.CurrentRow.Cells("id").Value
        txtCodEmpresa.Text = gridDatos.CurrentRow.Cells("CodEmpresa").Value
        txtApellido.Text = gridDatos.CurrentRow.Cells("Apellido").Value
        txtNombre.Text = gridDatos.CurrentRow.Cells("Nombre").Value

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
