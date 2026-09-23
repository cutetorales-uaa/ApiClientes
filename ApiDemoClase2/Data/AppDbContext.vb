Imports System.Net.Http.Headers
Imports Microsoft.EntityFrameworkCore


Public Class AppDbContext
    Inherits DbContext

    Public Sub New(options As DbContextOptions(Of AppDbContext))
        MyBase.New(options)
    End Sub

    Public Property Clientes As DbSet(Of Cliente)

End Class