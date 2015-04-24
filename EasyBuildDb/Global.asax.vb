
Imports System.Web.Optimization

Public Class Global_asax
    Inherits HttpApplication

    Sub Application_Start(sender As Object, e As EventArgs)
        ' Fires when the application is started
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)

        'Dim _dbStoreContext As New StoreContext
        'Dim customer1 = New Customer
        'customer1.CustomerID = 1
        'customer1.CustomerName = "Pat"
        '_dbStoreContext.Customers.Add(customer1)
        '_dbStoreContext.SaveChanges()

    End Sub
End Class