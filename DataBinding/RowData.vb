Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
<Table("RowData")>
Public Class RowData
    Property A As Integer
    Property B As Integer
    ReadOnly Property C As Integer
        Get
            Return A + B
        End Get
    End Property
    <Key>
    <StringLength(200)>
    Property Name As String
    Property SomeFlag As Boolean = False
    <NotMapped>
    Property Selected As Boolean
End Class


Partial Class DataBindingContext
    Property SampleData As DbSet(Of RowData)
End Class