Public Class Gameentry
    Public Property idGame As Integer
    Public Property idSport As String
    Public Property gameTimestamp As Integer
    Public Property gameDate As Integer         'En formato AAAAMMDD
    Public Property awayTeam As GameentryTeam
    Public Property homeTeam As GameentryTeam
    Public Property location As String

    Public Sub New(mIdSport As String, oGame As Fixture)
        Me.idSport = mIdSport

        Me.idGame = oGame.fixture_id
        Me.awayTeam = New GameentryTeam(oGame.awayTeam)
        Me.homeTeam = New GameentryTeam(oGame.homeTeam)
        Me.location = oGame.venue

        'TimeStamp preparado para firestore
        Me.gameTimestamp = oGame.event_timestamp
        Me.gameDate = Val(Format(fnGetDateFromTimestamp(oGame.event_timestamp).Date, "yyyyMMdd"))
    End Sub

End Class

Public Class GameentryTeam
    Public Property ID As String
    Public Property Name As String
    Public Property Abbreviation As String

    Public Sub New(myID As Integer, mName As String, mAbbreviation As String)
        Me.ID = myID
        Me.Name = mName
        Me.Abbreviation = mAbbreviation
    End Sub

    Public Sub New(oTeam As FixtureTeam)
        Me.ID = oTeam.team_id.ToString
        Me.Name = oTeam.team_name
        Me.Abbreviation = oTeam.team_abbreviation
    End Sub
End Class

