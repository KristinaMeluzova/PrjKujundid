﻿Imports System.Math
Public Class Kolmnurk
    Inherits Kujund

    Private korgus As Double

    'Konstruktor baasklassi atribuutide väärtustamiseks
    Public Sub New(ByVal alus As Double, ByVal haar As Double)
        'Kutsume välja baasklassi konstruktori
        MyBase.New("Võrdhaarne kolmnurk", alus, haar, haar)

        'Kolmnurga kõrgus
        Me.korgus = Sqrt(haar * haar - (alus * alus / 4))
    End Sub
    'Kolmnurga ümbermõõdu arvutamine
    Public Overrides Function leiaPindala() As Double
        Return kylgA * korgus / 2
    End Function

    'Kolmnurga pindala arvutamine
    Public Overrides Function leiaYmberMoot() As Double
        Return kylgA + kylgB + kylgC
    End Function
End Class
