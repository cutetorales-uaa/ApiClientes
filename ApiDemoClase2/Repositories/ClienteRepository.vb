Imports System.Security.Cryptography.X509Certificates

Public Class ClienteRepository
    Private ReadOnly contexto As AppDbContext

    Public Sub New(contexto As AppDbContext)
        Me.contexto = contexto
    End Sub

    Public Sub Agregar(cliente As Cliente)
        contexto.Clientes.Add(cliente)
        contexto.SaveChanges()
    End Sub

    Public Function ObtenerTodos() As List(Of Cliente)
        Return contexto.Clientes.ToList()
    End Function

    Public Function ObtenerporId(id As Integer) As Cliente
        Return contexto.Clientes.FirstOrDefault(Function(c) c.Id = id)
    End Function

    Public Sub Modificar(cliente As Cliente)
        contexto.Clientes.Update(cliente)
        contexto.SaveChanges()
    End Sub

    Public Sub Eliminar(cliente As Cliente)
        contexto.Clientes.Remove(cliente)
        contexto.SaveChanges()
    End Sub
End Class