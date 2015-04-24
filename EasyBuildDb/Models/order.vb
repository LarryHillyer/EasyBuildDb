Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema


Public Class order

    <Key>
    Public Property Table2Id As Int32

    Public Property CustomerName As String

    Public Property OrderDate As String

    Public Property ProductId As Int32


End Class
