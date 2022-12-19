Module ModuleVariabel
    Sub StoreVariable()
        Dim number As Integer = 200
        Dim myName As String = "Bootcamp .NET"
        Console.WriteLine("Number : " & number)
        Console.WriteLine("myName : " & myName)

    End Sub

    'store constant variabel
    Sub StoreConstant()
        Const PHI = 3.14159
        Console.WriteLine("Phi : " & PHI)
    End Sub

    Sub SwapVariable()
        'declare 3 variable
        Dim a, b, c As Integer

        Console.Write("Value A : ")
        a = Console.ReadLine()

        Console.Write("Value B : ")
        b = Console.ReadLine()

        Console.WriteLine("Before : A = " & a & " B = " & b)
        c = a
        a = b
        b = c
        Console.WriteLine("After : A = " & a & " B = " & b)
    End Sub
End Module
