Public Class Rööpkülik
    Inherits Nelinurk
    Protected korgus As Double
    'Konstruktor atribuutide algväärtustamiseks
    'ning klassi atribuudi kylgD väärtustamiseks
    Public Sub New(ByVal alus As Double, ByVal kylg As Double, ByVal korgus As Double)
        'Baasklassi konstruktori väljakutse
        MyBase.New("Rööpkülik", alus, kylg, alus, kylg)
        Me.korgus = korgus
    End Sub

    'Funktsioon arvutab ja tagastab rööpküliku pindala
    Public Overrides Function leiaPindala() As Double
        Return kylgA * korgus
    End Function
End Class
