﻿' <auto-generated />
Imports System.CodeDom.Compiler
Imports System.Data.Entity.Migrations
Imports System.Data.Entity.Migrations.Infrastructure
Imports System.Resources

Namespace Migrations
    <GeneratedCode("EntityFramework.Migrations", "6.4.0")>
    Public NotInheritable Partial Class Increaselengthofname
        Implements IMigrationMetadata
    
        Private ReadOnly Resources As New ResourceManager(GetType(Increaselengthofname))
        
        Private ReadOnly Property IMigrationMetadata_Id() As String Implements IMigrationMetadata.Id
            Get
                Return "201912152328286_Increase length of name"
            End Get
        End Property
        
        Private ReadOnly Property IMigrationMetadata_Source() As String Implements IMigrationMetadata.Source
            Get
                Return Nothing
            End Get
        End Property
        
        Private ReadOnly Property IMigrationMetadata_Target() As String Implements IMigrationMetadata.Target
            Get
                Return Resources.GetString("Target")
            End Get
        End Property
    End Class
End Namespace
