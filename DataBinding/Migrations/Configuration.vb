Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Migrations
Imports System.Linq

Namespace Migrations

    Friend NotInheritable Class Configuration
        Inherits DbMigrationsConfiguration(Of DataBindingContext)

        Public Sub New()
            AutomaticMigrationsEnabled = False
        End Sub

        Protected Overrides Sub Seed(context As DataBindingContext)
            '  This method will be called after migrating to the latest version.

            '  You can use the DbSet(Of T).AddOrUpdate() helper extension method 
            '  to avoid creating duplicate seed data.

            context.SampleData.AddOrUpdate(
                New RowData With {.Name = "John", .A = 5, .B = 10},
                New RowData With {.Name = "Sarah", .A = 1, .B = 6}
                )
        End Sub

    End Class

End Namespace
