Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class frmMain
    Private _rutaArchivoDB As String

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        _rutaArchivoDB = Application.StartupPath & "\" & My.Settings.nombreDBRespaldo
        LimpiarControles()
    End Sub

    Private Sub LimpiarControles()
        txtData.Text = ""
        lblStatus.Text = ""
        lblNumRegs.Text = ""
    End Sub

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

            Dim comando As String = String.Format("{0}\node_modules\.bin\firestore-export", My.Settings.rutaNPM)

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

                For Each oGame As Game In listaGames
                    If oGame.DateReal = Now.Date Then

                        Dim teamAway As String = Microsoft.VisualBasic.Left(oGame.AwayTeam.Abbreviation & Space(3), 3)
                        Dim teamHome As String = Microsoft.VisualBasic.Left(oGame.HomeTeam.Abbreviation & Space(3), 3)

                        datoJuego = String.Format("{0} ({1})> {2} @ {3} | ",
                                              oGame.IdSport,
                                              oGame.Time,
                                              teamAway,
                                              teamHome)

                        'MAIN
                        If Not conFiltro Or (conFiltro And Math.Abs(oGame.CountAway - oGame.CountHome) > 2) Then
                            Dim etiqueta As String
                            If (oGame.IdSport.ToLower = "nba" Or oGame.IdSport.ToLower = "nfl") Then
                                etiqueta = "sp+/- "
                            Else
                                etiqueta = "ml "
                            End If

                            If oGame.CountAway > oGame.CountHome Then
                                contador += 1
                                texto &= datoJuego & etiqueta & teamAway & " (" & oGame.CountAway & "." & oGame.CountHome & ") | " & vbCrLf
                            Else
                                contador += 1
                                texto &= datoJuego & etiqueta & teamHome & " (" & oGame.CountHome & "." & oGame.CountAway & ") | " & vbCrLf
                            End If
                        End If

                        'OVER / UNDER
                        If Not conFiltro Or (conFiltro And Math.Abs(oGame.CountOverUnder) > 2) Then
                            contador += 1
                            texto &= datoJuego & IIf(oGame.CountOverUnder > 0, "over ", "under ") & "(" & oGame.CountOverUnder & ") | " & vbCrLf
                        End If

                        'EXTRA
                        If Not conFiltro Or (conFiltro And Math.Abs(oGame.CountExtra) > 2) Then
                            contador += 1
                            texto &= datoJuego & "ML " & IIf(oGame.CountExtra > 0, teamAway, teamHome) & " (" & oGame.CountExtra & ") |  " & vbCrLf
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




End Class
