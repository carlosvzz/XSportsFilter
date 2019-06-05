Public Class Game
    Public Property Id As String
    Public Property IdSport As String
    Public Property IdGame As Integer
    Public Property DateGame As DBTimeStamp
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
            Dim nDateTime As DateTime = fnGetDateFromTimestamp(DateGame.value._seconds)
            Return nDateTime.Date
        End Get
    End Property



    Public Class Team
            Public Property City As String
            Public Property Abbreviation As String
            Public Property Name As String
            Public Property ID As String
        End Class
    End Class
