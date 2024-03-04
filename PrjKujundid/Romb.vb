Public Class Romb
    Inherits Nelinurk
    Protected korgus As Double
    Public Sub New(ByRef kylg As Double, ByRef korgus As Double)
        'Baasklassi konstruktori väljakutse
        MyBase.New("Romb", kylg, kylg, kylg, kylg)
        Me.korgus = korgus
    End Sub

    'Funktsioon arvutab ja tagastab rombi pindala
    Public Overrides Function leiaPindala() As Double
        Return kylgA * korgus
    End Function
End Class
