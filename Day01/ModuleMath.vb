Module ModuleMath

    Sub OperationMath()
        Dim y As Double
        y = 12 + (15 + 3) - 2 ^ 3 / 4 * 5
        Console.WriteLine(y)
    End Sub

    'pembagian dan sisa
    Sub BagiSisa()
        Dim num1, num2, bagi, sisa As Integer

        Console.Write("Enter number1 : ")
        num1 = Console.ReadLine()

        Console.Write("Enter number2 : ")
        num2 = Console.ReadLine()

        'result
        bagi = num1 \ num2 'return integer
        sisa = num1 Mod num2

        Console.WriteLine("Result bagi : " & bagi & ", Sisa : " & sisa)
    End Sub
End Module
