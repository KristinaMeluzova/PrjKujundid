Public Class formKujundid

    Private Sub tootleKujund(ByRef kujund As Kujund)
        'kujundi tüübi väljastamine
        lblTyyp.Text = kujund.annaTyyp

        'Pindala ja ümbermõõdu arvutamine ja väljastamine
        txtPindala.Text = kujund.leiaPindala
        txtYmbermoot.Text = kujund.leiaYmberMoot
    End Sub

    Private Sub btnKolmnurk_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles btnKolmnurk.Click
        'Objekt kolmnurga klassist
        Dim objektKolmnurk As New Kolmnurk(txtKylgA.Text, txtKylgB.Text)
        tootleKujund(objektKolmnurk)
    End Sub

    Private Sub btnRuut_Click(ByVal sender As Object, ByVal e As EventArgs) _
        Handles btnRuut.Click
        'Objekt ruudu klassist
        Dim objektRuut As New Ruut(txtKylgA.Text)
        tootleKujund(objektRuut)
    End Sub

    Private Sub btnRistkylik_Click(sender As Object, e As EventArgs) _
        Handles btnRistkylik.Click
        'Aga saab ka nii...Otsene väljakutse meetodil tootleKujund
        tootleKujund(New Ristkülik(txtKylgA.Text, txtKylgB.Text))
    End Sub
End Class
