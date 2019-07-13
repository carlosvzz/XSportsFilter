Public Class FixtureApi
    Public Property api As Response
End Class



Public Class Fixture
    Public Property fixture_id As Integer
    Public Property league_id As Integer
    Public Property event_date As DateTime
    Public Property event_timestamp As Integer
    Public Property venue As String
    Public Property homeTeam As FixtureTeam
    Public Property awayTeam As FixtureTeam
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
        tName = tName & Space(3)  'x si es menor a 3 caracteres
        Dim tAbbr As String = tName.Substring(0, 3).ToUpper

        Select Case tName.Trim
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

            'ENG - PREMIER
            Case "West Ham" : tAbbr = "HAM"
            Case "Crystal Palace" : tAbbr = "CPA"
            Case "Manchester United" : tAbbr = "MUN"

                'ENG2 = CHAMPIONSHIP
            Case "West Brom" : tAbbr = "WEB"
                'FRA
            Case "Montpellier" : tAbbr = "MTP"
            Case "Paris Saint Germain" : tAbbr = "PSG"
            Case "Saint Etienne" : tAbbr = "STE"

                'HOL 
            Case "De Graafschap" : tAbbr = "DEG"
            Case "FC OSS" : tAbbr = "OSS"

                'HOL2
            Case "De Graafschap" : tAbbr = "DEG"
            Case "FC Eindhoven" : tAbbr = "EIN"
            Case "FC OSS" : tAbbr = "OSS"
            Case "FC Volendam" : tAbbr = "VOL"
            Case "Jong Ajax" : tAbbr = "AJA"
            Case "Jong AZ" : tAbbr = "AZ "
            Case "Jong PSV" : tAbbr = "PSV"
            Case "Jong Utrecht" : tAbbr = "UTR"

                'MEX 
            Case "Atletico San Luis" : tAbbr = "SLP"
            Case "Club America" : tAbbr = "AME"
            Case "Club Queretaro" : tAbbr = "QRO"
            Case "Club Tijuana" : tAbbr = "TIJ"
            Case "FC Juarez" : tAbbr = "JUA"
            Case "Monarcas" : tAbbr = "MOR"
            Case "Monterrey" : tAbbr = "MTY"
            Case "U.N.A.M. - Pumas" : tAbbr = "PUM"
        End Select

        Return tAbbr

    End Function



End Class




