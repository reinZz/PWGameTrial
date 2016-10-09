Public Class frmEditor
    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click



    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        lblSave.Text = "Save As: /scenes" + Convert.ToString(nbrNewBook.Value) + "/" + Convert.ToString(nbrNewQn.Value) + ".txt"
        txtGenerate.Text = txtQn.Text + "|" + txtO1.Text + "|" + txtO2.Text + "|" + txtO3.Text + "|" + txtO4.Text + "|" +
            Convert.ToString(nbrO1Q.Value) + "|" + Convert.ToString(nbrO2Q.Value) + "|" + Convert.ToString(nbrO3Q.Value) + "|" + Convert.ToString(nbrO4Q.Value) + "|" +
            Convert.ToString(nbrO1R.Value) + "|" + Convert.ToString(nbrO2R.Value) + "|" + Convert.ToString(nbrO3R.Value) + "|" + Convert.ToString(nbrO4R.Value)

    End Sub

    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged

        If rb1.Checked = True Then
            nbrO1R.Value = 0
            nbrO1R.Enabled = False
        Else
            nbrO1R.Enabled = True
        End If

    End Sub

    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged

        If rb2.Checked = True Then
            nbrO2R.Value = 0
            nbrO2R.Enabled = False
        Else
            nbrO2R.Enabled = True
        End If

    End Sub

    Private Sub rb3_CheckedChanged(sender As Object, e As EventArgs) Handles rb3.CheckedChanged

        If rb3.Checked = True Then
            nbrO3R.Value = 0
            nbrO3R.Enabled = False
        Else
            nbrO3R.Enabled = True
        End If

    End Sub

    Private Sub rb4_CheckedChanged(sender As Object, e As EventArgs) Handles rb4.CheckedChanged

        If rb4.Checked = True Then
            nbrO4R.Value = 0
            nbrO4R.Enabled = False
        Else
            nbrO4R.Enabled = True
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        frmLaunch.Show()
        Me.Close()

    End Sub

    Private Sub cbO1_CheckedChanged(sender As Object, e As EventArgs) Handles cbO1.CheckedChanged

        If cbO1.Checked = True Then
            txtO1.Enabled = True
            txtO1.Text = ""
        Else
            txtO1.Enabled = False
            txtO1.Text = "NIL"
        End If

    End Sub

    Private Sub cbO2_CheckedChanged(sender As Object, e As EventArgs) Handles cbO2.CheckedChanged

        If cbO2.Checked = True Then
            txtO2.Enabled = True
            txtO2.Text = ""
        Else
            txtO2.Enabled = False
            txtO2.Text = "NIL"
        End If

    End Sub

    Private Sub cbO3_CheckedChanged(sender As Object, e As EventArgs) Handles cbO3.CheckedChanged

        If cbO3.Checked = True Then
            txtO3.Enabled = True
            txtO3.Text = ""
        Else
            txtO3.Enabled = False
            txtO3.Text = "NIL"
        End If

    End Sub

    Private Sub cbO4_CheckedChanged(sender As Object, e As EventArgs) Handles cbO4.CheckedChanged

        If cbO4.Checked = True Then
            txtO4.Enabled = True
            txtO4.Text = ""
        Else
            txtO4.Enabled = False
            txtO4.Text = "NIL"
        End If

    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click

        txtGenerate.Focus()
        txtGenerate.SelectionStart = 0
        txtGenerate.SelectionLength = txtGenerate.Text.Length
        My.Computer.Clipboard.SetText(txtGenerate.Text)

    End Sub
End Class