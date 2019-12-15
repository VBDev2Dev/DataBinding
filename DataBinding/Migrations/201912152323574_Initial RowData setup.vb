Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialRowDatasetup
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.RowData",
                Function(c) New With
                    {
                        .Name = c.String(nullable := False, maxLength := 128),
                        .A = c.Int(nullable := False),
                        .B = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.Name)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.RowData")
        End Sub
    End Class
End Namespace
