Public Class frmLaunch

    Private Sub frmLaunch_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        lblVersion.Text = "V" + Application.ProductVersion

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'quit application
        Application.Exit()

    End Sub

    Private Sub btnTryAgain_Click(sender As Object, e As EventArgs) Handles btnTryAgain.Click

        LoadingInternet()

    End Sub

    Private Sub btnLaunch_Click(sender As Object, e As EventArgs) Handles btnLaunch.Click
        btnLaunch.Visible = False
        btnLaunch.Enabled = False
        LoadingInternet()

    End Sub

    Private Sub btnEditor_Click(sender As Object, e As EventArgs) Handles btnEditor.Click

        If InputBox("Password:") = "eleg" Then
            frmEditor.Show()
            Me.Close()
        End If

    End Sub
End Class
