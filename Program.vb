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
        'ModulePartOne.InitEmployee()
        'ModulePartTwo.InitEmployee()
        'ModuleArray.DisplayArray()
        'ModuleArray.InitListGeneric()

        'call interface kiri & implementation kanan
        Dim IHr As IHR = New HR

        Dim listEmp = IHr.InitEmployee()

        IHr.DisplayEmployee(listEmp)

        Dim emp = IHr.FindEmployeeById(listEmp, 100)
        If emp IsNot Nothing Then
            Console.WriteLine($"Employee Found: (emp)")
        Else
            Console.WriteLine($"Employee Not Found")
        End If

        Dim totalEmployee = IHr.TotalEmployeeByRole(listEmp, "Programmer")
        Console.WriteLine($"totalEmployee : {totalEmployee}")

        Dim totalSalaryEmployee = IHr.TotalSalaryByRole(listEmp, "Programmer")
        Console.WriteLine($"totalSalaryEmployee : {totalSalaryEmployee}")

        Console.WriteLine($"totalSalaryAll : {IHr.TotalSalaryAll(listEmp)}")
    End Sub
    Sub SayMyName()
        'declaration variabel
        Dim MyName As String
        Console.Write("Enter your name: ")
    End Sub
End Module
