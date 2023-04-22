Module Module1
    Dim a As Decimal
    Dim aa As Decimal
    Dim b As Decimal
    Dim t As Decimal
    Dim p As Decimal
    Dim pic As Decimal = 0
    Dim n As ULong
    Sub Main()

        For n = 1 To 10000000000 Step 1
            pic = pic + (4 / (4 * n - 3) - 4 / (4 * n - 1))
            Console.WriteLine(pic)

        Next
    End Sub

End Module
