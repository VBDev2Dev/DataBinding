﻿Imports System.ComponentModel
Imports System.Data.Entity
Public Class frmDataBinding
    Dim data As BindingList(Of RowData)
    Dim context As New DataBindingContext
    Private Sub frmDataBinding_Load(sender As Object, e As EventArgs) Handles Me.Load
        context.SampleData.Load
        data = context.SampleData.Local.ToBindingList

        RowDataBindingSource.DataSource = data

    End Sub
End Class
