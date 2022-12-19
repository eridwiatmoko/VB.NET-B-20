Imports System
Imports VBAppConsole.PartOne
Imports VBAppConsole.PartTwo

Module Program
    Sub Main(args As String())
        'Console.WriteLine("Hello World!")
        'call method
        'ModuleMath.OperationMath()
        'ModuleMath.BagiSisa()
        'DecisionMudule.OddEvenNumber()
        'DecisionMudule.Grade()
        'DecisionMudule.GradeCase()
        'DecisionMudule.WhoIsTheGreatest()
        'ModuleDateTime.ShowDate()
        'ModuleIteration.DoWhile(10)
        'ModuleIteration.DoWhileExit(10)
        'ModuleIteration.KotakBintang(5)
        ModulePartOne.InitEmployee()
        ModulePartTwo.InitEmployee()
    End Sub
    Sub SayMyName()
        'declaration variabel
        Dim MyName As String
        Console.Write("Enter your name: ")
    End Sub
End Module
