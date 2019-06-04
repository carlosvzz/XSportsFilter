Imports System.IO
Imports System.Net
Imports Google.Apis
Imports Newtonsoft.Json

Module Rutinas
    Dim oLeagues As New List(Of League)

    Public Sub InitLeagues()
        'api Football
        oLeagues.Add(New League("Soccer USA", "US", 294))
        oLeagues.Add(New League("Soccer America", "World", 311))
        oLeagues.Add(New League("Soccer NL", "NL", 10))


        frmMain.cboLeagues.DataSource = oLeagues.OrderBy(Function(x) x.nombre).ToList
        frmMain.cboLeagues.DisplayMember = "Nombre"
        frmMain.cboLeagues.SelectedIndex = -1
        frmMain.txtLeagueID.Text = ""
    End Sub


    Public Function GetAPIData(myURL As String, myHeader As String) As String
        Dim responseStream As System.IO.Stream
        Dim stringStreamReader As System.IO.StreamReader
        Dim responseString As String = Nothing

        Try
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            Dim webRequest As WebRequest = WebRequest.Create(myURL)

            'Header (si aplica)
            If Not String.IsNullOrEmpty(myHeader) Then
                Dim webHeaderCollection As WebHeaderCollection = webRequest.Headers
                webHeaderCollection.Add(myHeader)
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

            For i As Integer = 0 To 4
                Dim oGameEntry As New Gameentry(idSport, listaFix(i))

                'Cada objeto sera "idSport_fixtureid" : {<json seriealizado>},
                'idSport_fixtureid = Key en firestore
                textoAux = String.Format("""{0}_{1}"":", idSport, oGameEntry.iD)
                textoAux &= JsonConvert.SerializeObject(oGameEntry)
                textoAux &= IIf(i < 4, ",", "")

                textoJson &= textoAux
            Next

            textoJson = "{""fixtures"":{" & textoJson & "}}"
            frmMain.txtFixtures.Text = textoJson
        End If
    End Sub

End Module
