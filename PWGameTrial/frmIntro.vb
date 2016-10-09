Public Class frmIntro
    Private Sub frmIntro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblInstructions.Text = gettext(urlInstructions)
        Me.Text = "Chapter " + Convert.ToString(bookno)

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        btnNext.Text = "Setting up..."
        btnNext.Enabled = False
        preparescenes()

    End Sub
End Class