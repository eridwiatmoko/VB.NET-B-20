﻿Namespace PartTwo
    Public Class Sales
        Inherits Employee

        Private _bonus As Double
        Private _commission As Double

        Public Sub New(firstName As String, lastName As String,
                       joinDate As Date, basicSalary As Double, Optional bonus As Double = Nothing, Optional commission As Double = Nothing)
            MyBase.New(firstName, lastName, joinDate, basicSalary)
            _bonus = bonus
            _commission = commission
            MyBase.TotalSalary = MyBase.TotalSalary + bonus + commission
        End Sub

        Public Property Bonus As Double
            Get
                Return _bonus
            End Get
            Set(value As Double)
                _bonus = value
                TotalSalary = BasicSalary + value + Commission
            End Set
        End Property

        Public Property Commission As Double
            Get
                Return _commission
            End Get
            Set(value As Double)
                _commission = value
                TotalSalary = BasicSalary + value + Bonus
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()}, bonus: {Bonus}, commission: {Commission}, totalSalary: {TotalSalary}"
        End Function
    End Class
End Namespace
