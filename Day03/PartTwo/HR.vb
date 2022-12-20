Imports System.Data

Namespace PartTwo
    Public Class HR
        Implements IHR

        Public Sub DisplayEmployee(listEmp As List(Of Employee)) Implements IHR.DisplayEmployee

            For Each emp In listEmp
                Console.Write(emp)
            Next
        End Sub

        Public Function InitEmployee() As List(Of Employee) Implements IHR.InitEmployee
            Dim listEmp As New List(Of Employee) From {
               
                New Programmer("Anton", "Pratama", #03/03/2015#, 6_000_000, 500_000),
                New Programmer("Budi", "Junaedi", #08/15/2016#, 6_000_000, 500_000),
                New Programmer("Charlie", "Van Dijk", #09/05/2017#, 6_000_000, 500_000),
                New Sales("Dian", "Permana", #10/12/2017#, 3_000_000, 500_000, 200_000),
                New Sales("Fatur", "Rohman", #01/15/2019#, 3_000_000, 350_000, 250_000),
                New QA("Ellise", "Toon", #01/15/2019#, 4_500_000, 10_000),
                New QA("Gita", "Gutawa", #03/01/2019#, 4_500_000, 10_000)
            }
            'Dim emp3 As New Programmer("Widi", "Amalia", DateTime.Now, 5_600, 100)
            'listEmp.Add(emp3)
            Return listEmp
        End Function

        Public Function FindEmployeeById(listEmps As List(Of Employee), Id As Integer) As Employee Implements IHR.FindEmployeeById
            'declare variable untuk hold data employee
            'Dim emp As Employee = Nothing

            For Each list In listEmps
                If (list.EmpId.Equals(Id)) Then
                    Return list
                End If
            Next

            Return Nothing
        End Function

        Public Function TotalEmployeeByRole(listEmps As List(Of Employee), role As String) As Double Implements IHR.TotalEmployeeByRole
            Dim totalrole As Integer
            For Each list In listEmps
                If TypeName(list) = role Then
                    totalrole += 1
                End If
            Next
            Return totalrole
        End Function

        Public Function TotalSalaryByRole(listEmps As List(Of Employee), role As String) As Double Implements IHR.TotalSalaryByRole
            Dim totalbyrole As Integer
            For Each list In listEmps
                If TypeName(list) = role Then
                    totalbyrole += list.TotalSalary
                End If
            Next
            Return totalbyrole
        End Function

        Public Function TotalSalaryAll(listEmps As List(Of Employee)) As Double Implements IHR.TotalSalaryAll
            Dim total As Integer
            For Each list In listEmps
                total += list.TotalSalary
            Next
            Return total
        End Function
    End Class
End Namespace
