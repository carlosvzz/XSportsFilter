Public Class Game
    Public Property Id As String
    Public Property IdSport As String
    Public Property IdGame As Integer
    Public Property DateGame As customDate
    Public Property Time As String
    Public Property CountDraw As Integer
    Public Property CountAway As Integer
    Public Property CountHome As Integer
    Public Property AwayTeam As Team
    Public Property HomeTeam As Team
    Public Property CountOverUnder As Integer
    Public Property CountExtra As Integer
    Public Property Location As String


    Public ReadOnly Property DateReal() As DateTime
        Get
            Dim nTimestamp As Double = DateGame.Value._seconds
            Dim nDateTime As System.DateTime = New System.DateTime(1970, 1, 1, 0, 0, 0, 0)
            nDateTime = nDateTime.AddSeconds(nTimestamp)

            Return nDateTime.Date

        End Get
    End Property

    Public Class Value
        Public Property _seconds As Integer
        Public Property _nanoseconds As Integer
    End Class


    Public Class customDate
        Public Property __datatype__ As String
        Public Property Value As Value
    End Class

    Public Class Team
            Public Property City As String
            Public Property Abbreviation As String
            Public Property Name As String
            Public Property ID As String
        End Class
    End Class
