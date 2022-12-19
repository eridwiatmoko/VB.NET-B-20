Module ModuleIteration
    'DoWhile
    Sub DoWhile(n As Integer)
        Dim i As Integer = 1
        Do While i <= n
            Console.WriteLine(i)
            i += 1
        Loop
    End Sub

    Sub DoWhileExit(n As Integer)
        Dim i As Integer = 1
        Do While i <= n
            Console.WriteLine(i)
            If (i = 8) Then
                Exit Do
            Else
                i += 1
            End If
        Loop
    End Sub

    Sub ForLoop()
        For index = 1 To 5
            Console.Write("* ")
        Next
    End Sub

    Sub KotakBintang(num As Integer)

        For i = 1 To num
            For j = 1 To num - i
                'cetak horizontal
                Console.Write("* ")
            Next
            'pindah baris
            Console.WriteLine()
        Next
    End Sub
End Module
