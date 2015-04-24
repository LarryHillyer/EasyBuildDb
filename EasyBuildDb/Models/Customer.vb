Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema


Public Class Customer

    <Key>
    Public Property CustomerID As Int32

    <Required>
    Public Property CustomerName As String

    Public Property CustomerAddress As String

    Public Property Orders As ICollection(Of order)
End Class
