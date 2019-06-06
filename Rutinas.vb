Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Module Rutinas
    Dim oLeagues As New List(Of League)

    Public Sub PonEstatus(Msj As String)
        frmMain.lblStatus.Text = Msj
    End Sub


    Public Sub InitLeagues()
        'Leer de archivo texto
        Try
            Dim archivo As String = "Ligas.txt"
            If Not File.Exists(archivo) Then
                PonEstatus("No se encontro el archivo " & archivo)
            Else
                Using sr As StreamReader = New StreamReader(archivo)
                    While sr.Peek() >= 0
                        Dim linea As String = sr.ReadLine
                        'Texto viene como <Clave>|<Nombre>|<id>
                        Dim oLiga As New League(linea.Split("|")(0), linea.Split("|")(1), linea.Split("|")(2))
                        oLeagues.Add(oLiga)
                    End While
                End Using
            End If

            frmMain.cboLeagues.DataSource = oLeagues.OrderBy(Function(x) x.nombre).ToList
            frmMain.cboLeagues.DisplayMember = "Nombre"
            frmMain.cboLeagues.SelectedIndex = -1
            frmMain.txtLeagueID.Text = ""

        Catch ex As Exception
            PonEstatus("SNE InitLeagues > " & ex.Message)
        End Try

    End Sub


    Public Function GetAPIData(myURL As String, myHeader As Dictionary(Of String, String)) As String
        Dim responseStream As System.IO.Stream
        Dim stringStreamReader As System.IO.StreamReader
        Dim responseString As String = Nothing

        Try
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            Dim webRequest As WebRequest = WebRequest.Create(myURL)

            'Header (si aplica)
            If myHeader IsNot Nothing AndAlso myHeader.Count > 0 Then
                Dim webHeaderCollection As WebHeaderCollection = webRequest.Headers
                For Each item In myHeader
                    webHeaderCollection.Add(item.Key, item.Value)
                Next
            End If



            Dim webResponse As HttpWebResponse = CType(webRequest.GetResponse(), HttpWebResponse)
            responseStream = webResponse.GetResponseStream()
            stringStreamReader = New StreamReader(responseStream)
            responseString = stringStreamReader.ReadToEnd.ToString

            webResponse.Close()

        Catch ex As Exception
            MsgBox("SNE GetAPIData > " & ex.Message)
        End Try

        Return responseString

    End Function


    Public Sub fnSaveFixtures(idSport As String, listaFix As List(Of Fixture))
        If listaFix IsNot Nothing AndAlso listaFix.Count > 0 Then
            Dim textoJson As String = ""
            Dim textoAux As String

            For i As Integer = 0 To listaFix.Count - 1
                Dim oGameEntry As New Gameentry(idSport, listaFix(i))

                'Cada objeto sera "idSport_fixtureid" : {<json seriealizado>},
                'idSport_fixtureid = Key en firestore
                textoAux = String.Format("""{0}_{1}"":", idSport, oGameEntry.idGame)
                textoAux &= JsonConvert.SerializeObject(oGameEntry)
                textoAux &= IIf(i < listaFix.Count - 1, ",", "")

                textoJson &= textoAux
            Next

            'Desplegar en forma principal
            textoJson = "{""fixtures"":{" & textoJson & "}}"
            frmMain.txtFixtures.Text = textoJson

            'Guardar archivo json
            Try
                Dim archivo = My.Settings.rutaImportJson & "/fixtures.json"
                If File.Exists(archivo) Then File.Delete(archivo)
                File.AppendAllText(archivo, textoJson)

            Catch ex As Exception
                PonEstatus("SNE fnSaveFixtures > " & ex.Message)
            End Try



        End If
    End Sub


    Public Function fnGetDateFromTimestamp(seconds As Integer) As DateTime
        Dim nTimestamp As Double = seconds
        Dim nDateTime As System.DateTime = New System.DateTime(1970, 1, 1, 0, 0, 0, 0)
        nDateTime = nDateTime.AddSeconds(nTimestamp).ToLocalTime

        Return nDateTime
    End Function
End Module
