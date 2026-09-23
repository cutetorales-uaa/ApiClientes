Imports Microsoft.AspNetCore.Mvc

Public Class ClienteService

    Private ReadOnly repository As ClienteRepository

    Public Sub New(repository As ClienteRepository)
        Me.repository = repository
    End Sub

    Public Function Crear(cliente As Cliente) As Cliente
        repository.Agregar(cliente)
        Return cliente
    End Function

    Public Function ObtenerTodos() As List(Of Cliente)
        Return repository.ObtenerTodos()
    End Function

    Public Function ObtenerporId(id As Integer) As Cliente
        Return repository.ObtenerporId(id)
    End Function

    Public Function Modificar(id As Integer, clienteModificado As Cliente) As Cliente

        Dim cliente = repository.ObtenerporId(id)

        If cliente Is Nothing Then
            Return Nothing
        End If

        cliente.Nombre = clienteModificado.Nombre
        cliente.Apellido = clienteModificado.Apellido
        cliente.Email = clienteModificado.Email
        cliente.Telefono = clienteModificado.Telefono

        repository.Modificar(cliente)

        Return cliente

    End Function

    Public Function Eliminar(id As Integer) As Boolean

        Dim cliente = repository.ObtenerporId(id)

        If cliente Is Nothing Then
            Return False
        End If

        repository.Eliminar(cliente)

        Return True

    End Function

End Class