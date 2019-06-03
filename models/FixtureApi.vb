Public Class FixtureApi
    Public Property api As Response
End Class

Public Class Response
    Public Property results As Integer
    Public Property fixtures As List(Of Fixture)
End Class

Public Class Fixture
    Public Property fixture_id As Integer
    Public Property league_id As Integer
    Public Property event_date As DateTime
    Public Property event_timestamp As Integer
    Public Property venue As String
    Public Property homeTeam As FixtureTeam
    Public Property awayTeam As FixtureTeam
    Public Property goalsHomeTeam As Integer
End Class


Public Class FixtureTeam
    Public Property team_id As Integer
    Public Property team_name As String

    Public ReadOnly Property team_abbreviation() As String
        Get
            Return fnGetTeamAbbreviation(team_name)
        End Get
    End Property

    Private Function fnGetTeamAbbreviation(tName As String) As String
        Dim tAbbr As String = tName.Substring(0, 3).ToUpper

        Select Case tName
            'USA - MLS
            Case "New York City FC" : tAbbr = "NYC"
            Case "FC Dallas" : tAbbr = "DAL"
            Case "New England Revolution" : tAbbr = "NE"
            Case "Columbus Crew" : tAbbr = "CLB"
            Case "New York Red Bulls" : tAbbr = "NYR"
            Case "Real Salt Lake" : tAbbr = "RSL"
            Case "Los Angeles Galaxy" : tAbbr = "LAG"
            Case "San Jose Earthquakes" : tAbbr = "SJ"
            Case "FC Cincinnati" : tAbbr = "CIN"
            Case "DC United" : tAbbr = "DC"
            Case "Los Angeles FC" : tAbbr = "LAF"
            Case "Sporting Kansas City" : tAbbr = "KC"
        End Select

        Return tAbbr

    End Function



End Class




