Public Class Gameentry
    Public Property iD As Integer
    Public Property idSport As String
    Public Property gameTimestamp As DBTimeStampSeconds
    Public Property awayTeam As GameentryTeam
    Public Property homeTeam As GameentryTeam
    Public Property location As String

    'Public Sub New(mIdSport As String, myID As Integer, mgGameTimestamp As Integer, mAwayTeam As GameentryTeam, mhomeTeam As GameentryTeam, mLocation As String)
    '    Me.idSport = mIdSport

    '    Me.iD = myID
    '    Me.gameTimestamp = mgGameTimestamp
    '    Me.awayTeam = mAwayTeam
    '    Me.homeTeam = mhomeTeam
    '    Me.location = mLocation
    'End Sub

    Public Sub New(mIdSport As String, oGame As Fixture)
        Me.idSport = mIdSport

        Me.iD = oGame.fixture_id
        Me.awayTeam = New GameentryTeam(oGame.awayTeam)
        Me.homeTeam = New GameentryTeam(oGame.homeTeam)
        Me.location = oGame.venue

        'TimeStamp preparado para firestore
        Me.gameTimestamp = New DBTimeStampSeconds(oGame.event_timestamp)
    End Sub

End Class

Public Class GameentryTeam
    Public Property iD As Integer
    Public Property name As String
    Public Property abbreviation As String

    Public Sub New(myID As Integer, mName As String, mAbbreviation As String)
        Me.iD = myID
        Me.name = mName
        Me.abbreviation = mAbbreviation
    End Sub

    Public Sub New(oTeam As FixtureTeam)
        Me.iD = oTeam.team_id
        Me.name = oTeam.team_name
        Me.abbreviation = oTeam.team_abbreviation
    End Sub
End Class

