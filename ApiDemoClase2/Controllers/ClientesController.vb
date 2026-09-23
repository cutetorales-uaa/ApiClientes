Imports System.Security.Cryptography.X509Certificates
Imports Microsoft.AspNetCore.DataProtection.Repositories
Imports Microsoft.AspNetCore.Mvc

<Route("api/[controller]")>
<ApiController>
Public Class ClientesController
    Inherits ControllerBase

    Private ReadOnly servicio As ClienteService

    Public Sub New(servicio As ClienteService)
        Me.servicio = servicio
    End Sub

    'GET: api/clientes
    <HttpGet>
    Public Function ObtenerClientes()
        Dim clientes = servicio.ObtenerTodos()
        Return Ok(clientes)
    End Function

    'GET: api/clientes/1
    <HttpGet("{id}")>
    Public Function ObtenerPorId(id As Integer)
        Dim cliente = servicio.ObtenerporId(id)

        If cliente Is Nothing Then
            Return NotFound("Cliente no encontrado")
        End If

        Return Ok(cliente)
    End Function

    'POST: api/clientes
    <HttpPost>
    Public Function Crear(cliente As Cliente)
        Dim clienteCreado = servicio.Crear(cliente)

        Return CreatedAtAction(
            NameOf(ObtenerPorId),
            New With {.id = clienteCreado.Id},
            clienteCreado
        )
    End Function

    'PUT: api/clientes/1
    <HttpPut("{id}")>
    Public Function Modificar(id As Integer, clienteModificado As Cliente)

        Dim cliente = servicio.Modificar(id, clienteModificado)

        If cliente Is Nothing Then
            Return NotFound("Cliente no encontrado")
        End If

        Return Ok(cliente)
    End Function

    'DELETE: api/clientes/1
    <HttpDelete("{id}")>
    Public Function Eliminar(id As Integer)

        Dim eliminado = servicio.Eliminar(id)

        If Not eliminado Then
            Return NotFound("Cliente no encontrado")
        End If

        Return Ok("Cliente eliminado")
    End Function

End Class
