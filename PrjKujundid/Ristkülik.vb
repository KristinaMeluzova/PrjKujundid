Public Class Ristkülik
    Inherits Nelinurk

    'Konstruktor baasklassi atribuutide väärtustamiseks
    Public Sub New(ByVal alus As Double, ByVal korgus As Double)
        'Baasklassi konstruktori väljakutse
        MyBase.New("Ristkülik", alus, korgus, alus, korgus)
    End Sub

    'Funktsioon arvutab ja tagastab ruudu pindala
    Public Overrides Function leiaPindala() As Double
        Return kylgA * kylgB
    End Function
End Class
