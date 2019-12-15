Public Class frmDataBinding
    Dim data As New List(Of RowData)

    Private Sub frmDataBinding_Load(sender As Object, e As EventArgs) Handles Me.Load
        RowDataBindingSource.DataSource = data

    End Sub
End Class
