Imports System

Module russianPeasant
    Sub Main(args As String())
        Console.WriteLine(russianPeasant(69, 67))
    End Sub
    Function isOdd(ByVal number As Integer) As Boolean
        Try
            If (number - 1) Mod 2 = 0 Then
                Return True
            Else
                Return False
            End If
        Catch oopsie As Exception
            Console.WriteLine("Error: Coundn't parse input")
            Return False
        End Try
    End Function
    Function russianPeasant(ByVal num1multiply As Integer, ByVal num2toMultiply As Integer) As Integer
        Dim sum, temp As Integer
        sum = 0
        temp = 0
        If num1multiply > num2toMultiply Then
            temp = num1multiply
            num1multiply = num2toMultiply
            num2toMultiply = temp
        End If
        Do
            If isOdd(num1multiply) Then
                sum = sum + num2toMultiply
                num2toMultiply = num2toMultiply * 2
            End If
            num1multiply = num1multiply \ 2
        Loop Until num1multiply <= 1
        Return sum
    End Function
End Module
