Public Class League
    Public Property nombre As String
    Public Property clave As String
    Public Property id As Integer

    Public Sub New(miClave As String, miNombre As String, miId As Integer)
        Me.clave = miClave
        Me.nombre = miNombre
        Me.id = miId
    End Sub
End Class
