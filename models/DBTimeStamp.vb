Public Class DBTimeStamp
    Public Property __datatype__ As String
    Public Property value As DBTimeStampSeconds

    Public Sub New(seconds As Integer)
        Me.__datatype__ = "timestamp"
        Me.value = New DBTimeStampSeconds(seconds)
    End Sub

End Class

Public Class DBTimeStampSeconds
    Public Property _seconds As Integer
    Public Property _nanoseconds As Integer

    Public Sub New(seconds As Integer)
        _seconds = seconds
    End Sub
End Class


