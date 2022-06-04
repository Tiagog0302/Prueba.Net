Public Class CEEmpleado

    Private _id As Integer
    Private _nombre As String
    Private _apellido As String
    Private _codempresa As String

    Public Sub New()
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property CodEmpresa As String
        Get
            Return _codempresa
        End Get
        Set(value As String)
            _codempresa = value
        End Set
    End Property
End Class
