Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("Cliente")>
Public Class Cliente

    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.Identity)>
    Public Property Id As Integer

    <Required(ErrorMessage:="El nombre es obligatorio")>
    <StringLength(100)>
    Public Property Nombre As String

    <Required(ErrorMessage:="El apellido es obligatorio")>
    <StringLength(100)>
    Public Property Apellido As String

    <Required(ErrorMessage:="El email es obligatorio")>
    <EmailAddress>
    <StringLength(150)>
    Public Property Email As String

    <Required(ErrorMessage:="El teléfono es obligatorio")>
    <StringLength(30)>
    Public Property Telefono As String

End Class
