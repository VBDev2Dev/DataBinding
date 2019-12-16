Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Addnewbooleanflag
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.RowData", "SomeFlag", Function(c) c.Boolean(nullable:=False, defaultValue:=False))
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.RowData", "SomeFlag")
        End Sub
    End Class
End Namespace
