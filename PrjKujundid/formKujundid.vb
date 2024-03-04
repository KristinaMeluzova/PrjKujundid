Public Class formKujundid

    Dim Tapsus As Double
    Private Sub tootleKujund(ByRef kujund As Kujund)
        'kujundi tüübi väljastamine
        lblTyyp.Text = kujund.annaTyyp
        Dim pindala As Double = kujund.leiaPindala
        Dim ymbermoot As Double = kujund.leiaYmberMoot
        'Pindala ja ümbermõõdu arvutamine ja väljastamine
        If (cmbTapsus.SelectedIndex = -1) Then
            txtPindala.Text = kujund.leiaPindala
            txtYmbermoot.Text = kujund.leiaYmberMoot
        Else
            txtPindala.Text = Math.Round(pindala, cmbTapsus.SelectedIndex)
            txtYmbermoot.Text = Math.Round(ymbermoot, cmbTapsus.SelectedIndex)
        End If
    End Sub

    Private Sub btnKolmnurk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnKolmnurk.Click
        'See tingimus on tehtud juhul kui txtKylgA või txtKylgB on tühi
        If (String.IsNullOrEmpty(txtKylgA.Text) OrElse String.IsNullOrEmpty(txtKylgB.Text)) Then
            txtPindala.Text = 0
            txtYmbermoot.Text = 0
        Else
            'Objekt kolmnurga klassist
            Dim objektKolmnurk As New Kolmnurk(txtKylgA.Text, txtKylgB.Text)
            tootleKujund(objektKolmnurk)
        End If
    End Sub

    Private Sub btnRuut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnRuut.Click
        'See tingimus on tehtud juhul kui txtKylgA on tühi
        If (String.IsNullOrEmpty(txtKylgA.Text)) Then
            txtPindala.Text = 0
            txtYmbermoot.Text = 0
        Else
            'Objekt ruudu klassist
            Dim objektRuut As New Ruut(txtKylgA.Text)
            tootleKujund(objektRuut)
        End If
    End Sub

    Private Sub btnRistkylik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnRistkylik.Click
        'See tingimus on tehtud juhul kui txtKylgA või txtKylgB on tühi
        If (String.IsNullOrEmpty(txtKylgA.Text) OrElse String.IsNullOrEmpty(txtKylgB.Text)) Then
            txtPindala.Text = 0
            txtYmbermoot.Text = 0
        Else
            'Aga saab ka nii...Otsene väljakutse meetodil tootleKujund
            tootleKujund(New Ristkülik(txtKylgA.Text, txtKylgB.Text))
        End If
    End Sub

    Private Sub cmbTapsus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles cmbTapsus.SelectedIndexChanged
        Select Case cmbTapsus.SelectedIndex
            Case (0)
                Tapsus = 0
            Case (1)
                Tapsus = 1
            Case (2)
                Tapsus = 2
            Case (3)
                Tapsus = 3
        End Select
    End Sub
    Private Sub btnRoopkulik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnRoopkulik.Click
        'See tingimus on tehtud juhul kui txtKylgA või txtKylgB või txtKorgus(kõrgus) on tühi
        If (String.IsNullOrEmpty(txtKylgA.Text) OrElse String.IsNullOrEmpty(txtKylgB.Text) OrElse String.IsNullOrEmpty(txtKorgus.Text)) Then
            txtPindala.Text = 0
            txtYmbermoot.Text = 0
        Else
            tootleKujund(New Rööpkülik(txtKylgA.Text, txtKylgB.Text, txtKorgus.Text))
        End If
    End Sub

    Private Sub bntRomb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles bntRomb.Click
        'See tingimus on tehtud juhul kui txtKylgA või txtKoorgus on tühi
        If (String.IsNullOrEmpty(txtKylgA.Text) OrElse String.IsNullOrEmpty(txtKorgus.Text)) Then
            txtPindala.Text = 0
            txtYmbermoot.Text = 0
        Else
            'Objekt ruudu klassist
            Dim objektRomb As New Romb(txtKylgA.Text, txtKorgus.Text)
            tootleKujund(objektRomb)
        End If
    End Sub
End Class
