Module ModuleDateTime

    Sub ShowDate()
        Dim date1 As Date = #12/15/2022 10:53:01 AM#
        Console.WriteLine("Date : " & date1)

        Dim currentDate As Date = Date.Now
        Console.WriteLine("Now : " & currentDate)
        currentDate = currentDate.AddDays(2)
        Console.WriteLine("Lusa : " & currentDate)

        Dim tanggal, bulan, tahun As Integer
        tanggal = Day(currentDate)
        bulan = Month(currentDate)
        tahun = Year(currentDate)

        Console.WriteLine("Tanggal : " & tanggal & "Bulan : " & bulan & "Tahun : " & tahun)
    End Sub
End Module
