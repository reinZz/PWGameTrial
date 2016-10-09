Public Module Actions

    '-----------------------------------------------
    'GLOBAL VARIABLES

    'def numbers
    Public totalqns As Integer = 0
    Public sceneno As Integer = 1
    Public qnData(,) As String
    Public ans1list As String = "NOT AN ANSWER"
    Public ans2list As String = "NOT AN ANSWER"
    Public ans1Data() As String
    Public ans2Data() As String
    Public ans1DataParsed() As String
    Public ans2DataParsed() As String
    Public bookno As Integer = 1


    'urls
    Public urlBase As String = "https://dl.dropboxusercontent.com/u/19630140/"
    Public urlIntro As String = urlBase + "pwapp/introtext.txt"
    Public urlDisclaimer As String = urlBase + "pwapp/disclaimer.txt"
    Public urlBooknos As String = urlBase + "pwapp/booknos.txt"
    Public urlMessage As String = urlBase + "pwapp/message.txt"
    Public urlInstructions As String = urlBase + "pwapp/instructions" + Convert.ToString(bookno) + ".txt"
    Public urlQnno As String = urlBase + "pwapp/qnno" + Convert.ToString(bookno) + ".txt"
    Public urlQnloc As String = urlBase + "/pwapp/scenes" + Convert.ToString(bookno) + "/"

    Public urlSurvey As String = "https://docs.google.com/forms/d/e/1FAIpQLScZWTR1OaRH3RrLGLAS7_M1jF5CsZCYtJH5L0xhhWYq0EdIyw/viewform"


    'retrieved numbers
    Public booknos As Integer = Convert.ToInt32(gettext(urlBooknos))



    '-----------------------------------------------
    'LOW LEVEL ACTIONS



    Function redimvars() As Action

        urlInstructions = urlBase + "pwapp/instructions" + Convert.ToString(bookno) + ".txt"
        urlQnno = urlBase + "pwapp/qnno" + Convert.ToString(bookno) + ".txt"
        urlQnloc = urlBase + "/pwapp/scenes" + Convert.ToString(bookno) + "/"
        sceneno = 1

    End Function



    'Checks internet internet status
    Function CheckInternet() As Boolean
        If My.Computer.Network.IsAvailable Then
            Return True
        Else
            Return False
        End If
    End Function



    'gets string from online .txt file
    Function gettext(ByVal url As String) As String

        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(url)
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim text As String = sr.ReadToEnd()

        Return text

    End Function



    '-----------------------------------------------
    'HIGHER LEVEL FUNCTIONS



    'checks internet status for loading screen
    'and launches app if successful
    Function LoadingInternet() As Action
        frmLaunch.btnTryAgain.Enabled = False
        If CheckInternet() Then
            'success
            frmSplash.Show()
            frmLaunch.Close()
        Else
            MsgBox("This application requires internet access. Please try again.")
            frmLaunch.btnTryAgain.Enabled = True
        End If
    End Function



    'prepare scenarios
    'qnData = question, option 1, option 2, option 3, option 4, option 1 direct, option 2 direct, option 3 direct, option 4 direct, saved ans if needed
    Function preparescenes() As Action
        totalqns = Convert.ToInt32(gettext(urlQnno))

        ReDim qnData(12, totalqns - 1)
        For i As Integer = 0 To totalqns - 1

            Dim thisqnRaw = gettext(urlQnloc + Convert.ToString(i + 1) + ".txt")
            Dim rawArr() As String
            rawArr = thisqnRaw.Split("|")

            'put question into first column (0)
            qnData(0, i) = rawArr(0)

            'put next question into last column (5)
            qnData(5, i) = rawArr(5)


            For j As Integer = 1 To 4

                'put choices into column 1 to 4
                qnData(j, i) = rawArr(j)

                'put choice results into column 5 to 8
                qnData(j + 4, i) = rawArr(j + 4)

                'put results into column 9 to 12
                qnData(j + 8, i) = rawArr(j + 8)
            Next
        Next

        'done. move onto scenarios page
        frmScenario.Show()
        frmIntro.Close()

    End Function



    'populates scenario screen
    Function populatescene() As Action

        'populate bar and title
        frmScenario.Text = "Scenario " + Convert.ToString(sceneno)
        frmScenario.lblQuestion.Text = qnData(0, sceneno - 1)


        'check for lack of option and set labels accordingly
        If String.Compare(qnData(1, sceneno - 1), "NIL") Then
            frmScenario.btnO1.Text = qnData(1, sceneno - 1)
            frmScenario.btnO1.Enabled = True
        Else
            frmScenario.btnO1.Text = "NO OPTION"
            frmScenario.btnO1.Enabled = False
        End If

        If String.Compare(qnData(2, sceneno - 1), "NIL") Then
            frmScenario.btnO2.Text = qnData(2, sceneno - 1)
            frmScenario.btnO2.Enabled = True
        Else
            frmScenario.btnO2.Text = "NO OPTION"
            frmScenario.btnO2.Enabled = False
        End If

        If String.Compare(qnData(3, sceneno - 1), "NIL") Then
            frmScenario.btnO3.Text = qnData(3, sceneno - 1)
            frmScenario.btnO3.Enabled = True
        Else
            frmScenario.btnO3.Text = "NO OPTION"
            frmScenario.btnO3.Enabled = False
        End If

        If String.Compare(qnData(4, sceneno - 1), "NIL") Then
            frmScenario.btnO4.Text = qnData(4, sceneno - 1)
            frmScenario.btnO4.Enabled = True
        Else
            frmScenario.btnO4.Text = "NO OPTION"
            frmScenario.btnO4.Enabled = False
        End If


        ''check for final scene
        'If sceneno = totalqns Then
        '    frmScenario.btnFinish.Enabled = True
        'End If


    End Function



    'disable all buttons on scenes screen
    Function disablescnbtns() As Action

        frmScenario.btnO1.Enabled = False
        frmScenario.btnO2.Enabled = False
        frmScenario.btnO3.Enabled = False
        frmScenario.btnO4.Enabled = False

    End Function



    'determine if ans needs to be added to list
    Function scnbtnaction(ByVal btnno As Integer) As Action

        disablescnbtns()

        'add answers if needed
        If qnData(btnno + 8, sceneno - 1) = 0 Then
            'do nothing as there is no results to add
        Else
            ans1list = ans1list + "," + qnData(btnno + 8, sceneno - 1)
        End If

        'check for final scene
        If sceneno = totalqns Then
            frmScenario.btnFinish.Enabled = True
            Exit Function
        End If


        'check for scene prerequisites [qnData(btnno + 4, sceneno - 1) >= 100]

        If qnData(btnno + 4, sceneno - 1) > 99 Then
            'there are prerequisites
            Select Case ans1DataParsed((qnData(btnno + 4, sceneno - 1) \ 100) - 1)
                Case "a"
                    sceneno = sceneno + 1
                Case "b"
                    sceneno = sceneno + 2
                Case "c"
                    sceneno = sceneno + 3
                Case "d"
                    sceneno = sceneno + 4
            End Select
            populatescene()
        Else
                'do the usual
                sceneno = qnData(btnno + 4, sceneno - 1)
                populatescene()
        End If


    End Function



    'parse chapt1 ans
    Function parseC1() As Action

        ans1Data = ans1list.Split(",")
        ReDim ans1DataParsed(ans1Data.Length - 2)

        For i As Integer = 1 To ans1Data.Length - 1

            Select Case ans1Data(i)
                Case 100 + ((i - 1) * 10)
                    ans1DataParsed(i - 1) = "a"
                Case 101 + ((i - 1) * 10)
                    ans1DataParsed(i - 1) = "b"
                Case 102 + ((i - 1) * 10)
                    ans1DataParsed(i - 1) = "c"
                Case 103 + ((i - 1) * 10)
                    ans1DataParsed(i - 1) = "d"
            End Select

        Next

    End Function

End Module
