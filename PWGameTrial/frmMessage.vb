Public Class frmMessage
    Private Sub frmMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblMessage.Text = gettext(urlMessage)

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        MsgBox("Thank you for participating in this trial. Please do help us fill up this survey form. Thank you!", MsgBoxStyle.OkOnly, "The End.")
        Process.Start(urlSurvey)
        Me.Close()

    End Sub
End Class