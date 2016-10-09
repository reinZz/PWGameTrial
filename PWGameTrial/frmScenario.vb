Public Class frmScenario
    Private Sub frmScenario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        populatescene()

    End Sub

    Private Sub btnO1_Click(sender As Object, e As EventArgs) Handles btnO1.Click

        scnbtnaction(1)

    End Sub

    Private Sub btnO2_Click(sender As Object, e As EventArgs) Handles btnO2.Click

        scnbtnaction(2)

    End Sub

    Private Sub btnO3_Click(sender As Object, e As EventArgs) Handles btnO3.Click

        scnbtnaction(3)

    End Sub

    Private Sub btnO4_Click(sender As Object, e As EventArgs) Handles btnO4.Click

        scnbtnaction(4)

    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click

        If bookno = booknos Then
            frmMessage.Show()
            Me.Close()
        Else
            Select Case bookno
                Case 1
                    parseC1()
            End Select

            bookno += 1
            redimvars()
            frmIntro.Show()
            Me.Close()
        End If

    End Sub
End Class