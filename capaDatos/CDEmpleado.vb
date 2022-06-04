Imports MySql.Data.MySqlClient
Imports capaEntidad

Public Class CDEmpleado

    Private _cadenaConexion As String = "Server=127.0.0.1;User=root;Password=;Port=3306;database=prueba.net"

    Public Sub ProbarConexion()

        Dim Conexion As New MySqlConnection(_cadenaConexion)

        Try
            Conexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        MessageBox.Show("Conectado")
        Conexion.Close()

    End Sub

    Public Sub Insertar(ByVal empleado As CEEmpleado)
        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()
        Dim Query As String = "INSERT INTO `hr_departamento` (`id`, `cod_empresa`, `cod_departamento`, `nombre`) VALUES (NULL, '" & empleado.CodEmpresa & "', '" & empleado.Apellido & "', '" & empleado.Nombre & "');"
        Dim Comando As New MySqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()
        MessageBox.Show("Registro Creado")
    End Sub


    Public Sub Moficar(ByVal empleado As CEEmpleado)
        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()
        Dim Query As String = "UPDATE `hr_pago` SET `cod_empresa` = '" & empleado.CodEmpresa & "' WHERE `hr_pago`.`cod_departamento` = " & empleado.Apellido & ";"
        Dim Comando As New MySqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()
        MessageBox.Show("Registro Editado")
    End Sub



    Public Function Listar() As DataSet

        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()
        Dim Query As String = "SELECT * FROM hr_departamento WHERE nombre ='ADAM'"
        Dim Adaptardor As MySqlDataAdapter
        Dim dataSet As New DataSet

        Adaptardor = New MySqlDataAdapter(Query, Conexion)
        Adaptardor.Fill(dataSet, "empleado")

        Return dataSet
    End Function

    Public Function ListarDepartamento(ByVal empleado As CEEmpleado) As DataSet

        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()
        Dim Query As String = "SELECT * FROM hr_departamento WHERE = '" & empleado.Nombre & "'"
        Dim Adaptardor As MySqlDataAdapter
        Dim dataSet As New DataSet

        Adaptardor = New MySqlDataAdapter(Query, Conexion)
        Adaptardor.Fill(dataSet, "empleado")

        Return dataSet
    End Function

End Class
