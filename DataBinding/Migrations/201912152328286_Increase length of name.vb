Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Increaselengthofname
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropPrimaryKey("dbo.RowData")
            AlterColumn("dbo.RowData", "Name", Function(c) c.String(nullable := False, maxLength := 200))
            AddPrimaryKey("dbo.RowData", "Name")
        End Sub
        
        Public Overrides Sub Down()
            DropPrimaryKey("dbo.RowData")
            AlterColumn("dbo.RowData", "Name", Function(c) c.String(nullable := False, maxLength := 128))
            AddPrimaryKey("dbo.RowData", "Name")
        End Sub
    End Class
End Namespace
