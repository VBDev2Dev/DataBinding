﻿Imports System.ComponentModel
Imports System.Data.Entity
Public Class frmDataBinding
    Dim data As BindingList(Of RowData)
    Dim context As New DataBindingContext
    Private Sub frmDataBinding_Load(sender As Object, e As EventArgs) Handles Me.Load
        context.Database.Log = Sub(m)
                                   Serilog.Log.Information(m)
                               End Sub
        context.SampleData.OrderBy(Function(d) d.A).ThenBy(Function(d) d.B).Load
        data = context.SampleData.Local.ToBindingList

        RowDataBindingSource.DataSource = data

    End Sub

    Private Sub frmDataBinding_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        context.SaveChanges()
    End Sub

    Private Sub btnSelected_Click(sender As Object, e As EventArgs) Handles btnSelected.Click
        MessageBox.Show($"There are {data.Where(Function(r) r.Selected).Count} selected items.")
    End Sub
End Class
