Namespace PartTwo
    Public Interface IHR
        Function InitEmployee() As List(Of Employee)

        Function FindEmployeeById(listEmps As List(Of Employee), Id As Integer) As Employee

        Function TotalEmployeeByRole(listEmps As List(Of Employee), role As String) As Double

        Function TotalSalaryByRole(listEmps As List(Of Employee), role As String) As Double

        Function TotalSalaryAll(listEmps As List(Of Employee)) As Double

        Sub DisplayEmployee(listEmps As List(Of Employee))
    End Interface
End Namespace
