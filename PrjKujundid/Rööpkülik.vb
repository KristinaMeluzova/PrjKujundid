Public Class Rööpkülik
    Inherits Nelinurk
    'Konstruktor atribuutide algväärtustamiseks
    'ning klassi atribuudi kylgD väärtustamiseks
    Public Sub New(ByVal tyyp As String, ByVal kylgA As Double,
                   ByVal kylgB As Double, ByVal kylgC As Double, ByVal kylgD As Double)
        'Baasklassi konstruktori väljakutse
        MyBase.New(tyyp, kylgA, kylgB, kylgC, kylgD)
    End Sub

End Class
