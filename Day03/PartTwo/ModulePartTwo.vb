Imports VBAppConsole.PartTwo

Namespace PartTwo
    Module ModulePartTwo
        Sub InitEmployee()
            'create object employee with encapsulation
            Dim emp1 As New Employee(1, "Kang", "Dian", DateTime.Now, 5_000)
            Console.WriteLine(emp1.ToString())

            emp1.FirstName = "Code"
            emp1.BasicSalary = 6_000
            Console.WriteLine(emp1.ToString())

            Dim emp2 As New Employee("Yuli", "Yuana", DateAndTime.Now, 5_500)
            Console.WriteLine(emp2.ToString())

            'create object programmer
            Dim emp3 As New Programmer("Widi", "Amalia", DateAndTime.Now, 5_600, 100)
            Console.WriteLine(emp3.ToString())
        End Sub

    End Module
End Namespace

