Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq


Public Class frmMain
    Private _rutaArchivoDB As String

#Region "Main"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        _rutaArchivoDB = Application.StartupPath & "\" & My.Settings.nombreDBRespaldo
        LimpiarControles()
        InitLeagues()

    End Sub

    Private Sub LimpiarControles()
        'Filters
        txtData.Text = ""
        lblStatus.Text = ""
        lblNumRegs.Text = ""

        'Fixtures
        txtLeagueID.Text = ""
        txtFixtures.Text = ""
    End Sub
#End Region


#Region "Get Filter"


    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        GetData()
    End Sub

    Private Sub GetData()
        'Obtener respaldo de firestore, usando rutinas de npm
        'node_modules\.bin\firestore-export -a "<ruta archivo datos credenciales firestore>" -b "<nombre archivo backup>" -p -n <nombre coleccion>
        LimpiarControles()

        Try
            If System.IO.File.Exists(_rutaArchivoDB) Then
                System.IO.File.Delete(_rutaArchivoDB)
            End If

            Dim comando As String = String.Format("{0}firestore-export", My.Settings.rutaNPM)

            Dim args As String = String.Format("-a {0} -b {1} -n games",
                                       My.Settings.rutaDBCredentials,
                                       _rutaArchivoDB)

            Dim p As Process = New Process()
            Dim pi As ProcessStartInfo = New ProcessStartInfo()
            pi.Arguments = " " + args
            pi.FileName = comando
            p.StartInfo = pi
            p.Start()

            lblStatus.Text = "GetData OK"

        Catch ex As Exception
            lblStatus.Text = "SNE GetData > " & ex.Message
        End Try



    End Sub

    Private Sub btnDoAll_Click(sender As Object, e As EventArgs) Handles btnDoAll.Click
        GenerateData(False)
    End Sub

    Private Sub btnDoFilter_Click(sender As Object, e As EventArgs) Handles btnDoFilter.Click
        GenerateData(True)
    End Sub

    Private Sub GenerateData(conFiltro As Boolean)
        LimpiarControles()

        If Not System.IO.File.Exists(_rutaArchivoDB) Then
            lblStatus.Text = "Respaldo BD no encontrado "
            Exit Sub
        End If

        Try
            Dim fileReader As System.IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader(_rutaArchivoDB)
            Dim stringReader As String = fileReader.ReadToEnd
            'Reemplazar date para que no tenga conflicto con el tipo dato date
            stringReader = stringReader.Replace("""date"":", """dateGame"":")

            'el json viene en cada objeto separado por , (no como array), por lo que se agrega de forma individual
            Dim listaGames As New List(Of Game)

            Dim o = JObject.Parse(stringReader)

            For Each child As JToken In o.Children
                For Each item As JToken In child
                    Dim oGame As Game = JsonConvert.DeserializeObject(Of Game)(item.ToString)
                    listaGames.Add(oGame)
                Next
            Next

            'Mostrar resultados
            If listaGames IsNot Nothing Then
                Dim texto As String = ""
                Dim datoJuego As String
                Dim contador As Integer = 0
                Dim esSoccer As Boolean
                Dim etiquetaJuego As String
                Dim hayDifWin As Boolean
                Dim ganadorSoccer As Integer

                For Each oGame As Game In listaGames
                    If oGame.DateReal = Now.Date Then
                        esSoccer = oGame.IdSport.ToLower.Contains("soccer")

                        etiquetaJuego = oGame.IdSport
                        If esSoccer Then etiquetaJuego = etiquetaJuego.Replace("Soccer", "FB")

                        Dim teamAway As String = Microsoft.VisualBasic.Left(oGame.AwayTeam.Abbreviation & Space(3), 3)
                        Dim teamHome As String = Microsoft.VisualBasic.Left(oGame.HomeTeam.Abbreviation & Space(3), 3)

                        datoJuego = String.Format("{0} ({1})> {2} {3} {4} | ",
                                              etiquetaJuego,
                                              oGame.Time,
                                              IIf(esSoccer, teamHome, teamAway),
                                              IIf(esSoccer, "v", "@"),
                                              IIf(esSoccer, teamAway, teamHome))

                        'MAIN ///////////////////////////////////////////////////////////////////////////
                        If esSoccer Then
                            ganadorSoccer = -1
                            hayDifWin = False

                            '-- DIFERENCIA CON MAS DE +2 votos en la suma del resto
                            'Gana Visitante 
                            If oGame.CountAway - (oGame.CountHome + oGame.CountDraw) > 2 Then
                                ganadorSoccer = 2
                                hayDifWin = True
                            End If
                            'Gana Local
                            If Not hayDifWin Then
                                If oGame.CountHome - (oGame.CountAway + oGame.CountDraw) > 2 Then
                                    ganadorSoccer = 1
                                    hayDifWin = True
                                End If
                            End If
                            'Empate
                            If Not hayDifWin Then
                                If oGame.CountDraw - (oGame.CountHome + oGame.CountAway) > 2 Then
                                    ganadorSoccer = 0
                                    hayDifWin = True
                                End If
                            End If

                        Else
                            'US Sports > Gana cualquier con +2 diferencia (visitante o local)
                            hayDifWin = Math.Abs(oGame.CountAway - oGame.CountHome) > 2
                        End If

                        If Not conFiltro Or (conFiltro And hayDifWin) Then
                            Dim etiqueta As String
                            If (oGame.IdSport.ToLower = "nba" Or oGame.IdSport.ToLower = "nfl") Then
                                etiqueta = "sp+/- "
                            Else
                                etiqueta = "ml "
                            End If

                            If esSoccer Then
                                contador += 1
                                texto &= datoJuego & etiqueta
                                Select Case ganadorSoccer
                                    Case 0 : texto &= "X"
                                    Case 1 : texto &= teamHome
                                    Case 2 : texto &= teamAway
                                End Select
                                texto &= " (" & oGame.CountHome & "." & oGame.CountDraw & "." & oGame.CountAway & ") | " & vbCrLf

                            Else
                                If oGame.CountAway > oGame.CountHome Then
                                    contador += 1
                                    texto &= datoJuego & etiqueta & teamAway & " (" & oGame.CountAway & "." & oGame.CountHome & ") | " & vbCrLf
                                Else
                                    contador += 1
                                    texto &= datoJuego & etiqueta & teamHome & " (" & oGame.CountHome & "." & oGame.CountAway & ") | " & vbCrLf
                                End If
                            End If
                        End If

                        'OVER / UNDER ///////////////////////////////////////////////////////////////////////////
                        If Not conFiltro Or (conFiltro And Math.Abs(oGame.CountOverUnder) > 2) Then
                            contador += 1
                            texto &= datoJuego & IIf(oGame.CountOverUnder > 0, "over ", "under ") & "(" & oGame.CountOverUnder & ") | " & vbCrLf
                        End If

                        'EXTRA ///////////////////////////////////////////////////////////////////////////
                        If Not conFiltro Or (conFiltro And Math.Abs(oGame.CountExtra) > 2) Then
                            Dim etiqueta As String = ""
                            contador += 1

                            If esSoccer Then
                                etiqueta = "btts"
                                texto &= datoJuego & etiqueta & " " & IIf(oGame.CountExtra > 0, "Y", "N") & " (" & oGame.CountExtra & ") |  " & vbCrLf

                            Else 'US Sports
                                If (oGame.IdSport.ToLower = "nba" Or oGame.IdSport.ToLower = "nfl") Then
                                    etiqueta = "ml "
                                ElseIf oGame.IdSport.ToLower = "mlb" Then
                                    etiqueta = "f5-ml "
                                End If
                                texto &= datoJuego & etiqueta & " " & IIf(oGame.CountExtra > 0, teamAway, teamHome) & " (" & oGame.CountExtra & ") |  " & vbCrLf
                            End If



                        End If
                    End If

                Next

                lblNumRegs.Text = contador & " / " & listaGames.Count
                txtData.Text = texto
                txtData.Text = texto
            End If

            lblStatus.Text = "GenerateData OK"

        Catch Ex As Exception
            lblStatus.Text = "SNE GenerateData > " & Ex.Message
        End Try

    End Sub

#End Region

#Region "Fixtures"


    Private Sub cboLeagues_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLeagues.SelectedIndexChanged
        If cboLeagues.SelectedIndex > -1 Then
            txtLeagueID.Text = TryCast(cboLeagues.SelectedItem, League).id
        End If
    End Sub

    Private Sub btnSaveFixtures_Click(sender As Object, e As EventArgs) Handles btnSaveFixtures.Click
        If cboLeagues.SelectedIndex > -1 Then GetFixtures()
        'If cboLeagues.SelectedIndex > -1 Then GetTeams()
    End Sub

    Private Sub GetFixtures()
        Dim url As String = ""
        Dim response As String
        Dim dicHeader As New Dictionary(Of String, String)

        If cboLeagues.Text = "League NL" Then 'Demo
            url = Secrets.cRapidAPIUrlDemo & txtLeagueID.Text
        Else
            url = Secrets.cRapidAPIUrl & txtLeagueID.Text
            dicHeader.Add("X-RapidAPI-Host", Secrets.cRapidAPIHost)
            dicHeader.Add("X-RapidAPI-Key", Secrets.cRapidAPIKey)
        End If

        lblStatus.Text = "fetching ... "
        lblStatus.Refresh()
        lblNumRegs.Text = ""
        txtFixtures.Text = ""

        response = GetAPIData(url, dicHeader)
        If String.IsNullOrEmpty(response) Then
            lblStatus.Text = "Datos no obtenidos"
        Else
            lblStatus.Text = "Datos obtenidos de API..."
            txtFixtures.Text = response

            Dim oFixtures As New FixtureApi
            oFixtures = JsonConvert.DeserializeObject(Of FixtureApi)(response)

            lblNumRegs.Text = oFixtures.api.results

            If chkFixturesSave.Checked Then
                fnSaveFixtures(cboLeagues.Text, oFixtures.api.fixtures)
            End If
        End If

        lblStatus.Text = IIf(String.IsNullOrEmpty(txtFixtures.Text), "Datos NO obtenidos", "Datos obtenidos con exito")

    End Sub

    Private Sub GetTeams()
        Dim url As String = ""
        Dim response As String
        Dim dicHeader As New Dictionary(Of String, String)

        If cboLeagues.Text = "League NL" Then 'Demo
            MsgBox("No valido")
            Exit Sub
        Else
            url = Secrets.cRapidAPIUrlTeams & txtLeagueID.Text
            dicHeader.Add("X-RapidAPI-Host", Secrets.cRapidAPIHost)
            dicHeader.Add("X-RapidAPI-Key", Secrets.cRapidAPIKey)
        End If

        lblStatus.Text = "fetching ... "
        lblStatus.Refresh()
        lblNumRegs.Text = ""
        txtFixtures.Text = ""

        response = GetAPIData(url, dicHeader)
        If String.IsNullOrEmpty(response) Then
            lblStatus.Text = "Datos no obtenidos"
        Else
            lblStatus.Text = "Datos obtenidos de API..."

            Dim oTeams As New TeamApi
            oTeams = JsonConvert.DeserializeObject(Of TeamApi)(response)

            lblNumRegs.Text = oTeams.api.results

            For Each t As Teams In oTeams.api.teams.OrderBy(Function(f) f.name)
                txtFixtures.Text &= t.name & vbCrLf
            Next

        End If

        lblStatus.Text = IIf(String.IsNullOrEmpty(txtFixtures.Text), "Datos NO obtenidos", "Datos obtenidos con exito")

    End Sub
#End Region

End Class
