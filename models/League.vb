Public Class League
    Public Property nombre As String
    Public Property clave As String
    Public Property id As Integer

    Public Sub New(miNombre As String, miClave As String, miId As Integer)
        nombre = miNombre
        clave = miClave
        id = miId
    End Sub
End Class
