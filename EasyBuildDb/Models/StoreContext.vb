Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure


Public Class StoreContext

    Inherits DbContext

    Public Property Customers As DbSet(Of Customer)
    Public Property Orders As DbSet(Of order)

    Public Sub New()
        MyBase.New("StoreContext")
    End Sub
End Class
