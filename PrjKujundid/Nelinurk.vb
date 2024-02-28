Public MustInherit Class Nelinurk
    Inherits Kujund

    Protected kylgD As Double

    'Konstruktor atribuutide algväärtustamiseks
    'ning klassi atribuudi kylgD väärtustamiseks
    Public Sub New(ByVal tyyp As String, ByVal kylgA As Double,
                   ByVal kylgB As Double, ByVal kylgC As Double, ByVal kylgD As Double)
        'Baasklassi konstruktori väljakutse
        MyBase.New(tyyp, kylgA, kylgB, kylgC)

        'Atribuudi kylgD algväärtustamine
        Me.kylgD = kylgD
    End Sub

    'Funktsioon arvutab ja tagstab nelinurga ümbermõõdu
    Public Overrides Function leiaYmberMoot() As Double
        Return kylgA + kylgB + kylgC + kylgD
    End Function

    'Funktsioon arvutab ja tagstab nelinurga pindala
    Public Overrides Function leiaPindala() As Double
        Return 0
    End Function
End Class
