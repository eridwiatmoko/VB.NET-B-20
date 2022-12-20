Namespace PartTwo
    Public Class QA
        Inherits Employee

        Private _makan As Double

        Public Sub New(firstName As String, lastName As String,
                       joinDate As Date, basicSalary As Double, Optional makan As Double = Nothing)
            MyBase.New(firstName, lastName, joinDate, basicSalary)
            _makan = makan
            MyBase.TotalSalary = MyBase.TotalSalary + makan
        End Sub

        Public Property Makan As Double
            Get
                Return _makan
            End Get
            Set(value As Double)
                _makan = value
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()}, makan : {_makan},TotalSalary : {MyBase.TotalSalary}"
        End Function
    End Class
End Namespace
