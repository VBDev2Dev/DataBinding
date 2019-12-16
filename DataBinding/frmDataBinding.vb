Imports System.ComponentModel
Imports System.Data.Entity
Public Class frmDataBinding
    Dim data As BindingList(Of RowData)
    Dim context As New DataBindingContext
    Private Sub frmDataBinding_Load(sender As Object, e As EventArgs) Handles Me.Load
        context.SampleData.Load
        data = context.SampleData.Local.ToBindingList

        RowDataBindingSource.DataSource = data

    End Sub

    Private Sub frmDataBinding_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        context.SaveChanges()
    End Sub
End Class
