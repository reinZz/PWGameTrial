Public Class frmSplash
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblIntro.Text = gettext(urlIntro)
        txtDisclaimer.Text = gettext(urlDisclaimer)

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        Application.Exit()

    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click

        frmIntro.Show()
        Me.Close()

    End Sub
End Class