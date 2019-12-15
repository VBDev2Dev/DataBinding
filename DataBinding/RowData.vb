Public Class RowData
    Property A As Integer
    Property B As Integer
    ReadOnly Property C As Integer
        Get
            Return A + B
        End Get
    End Property
    Property Name As String
End Class

