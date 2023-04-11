'Isabella Dougherty
'RCET0265
'Spring 2023
'Better Calculator
'https://github.com/IsabellaDougherty/BetterCalculator.git

Option Explicit On
Option Strict On

Imports System

Module SimpleCalculator
    Sub Main()
        Dim first As Decimal
        Dim second As Decimal
        Dim answer As Decimal
        Dim choice As Integer

        'Gets user inputs
        Console.WriteLine("Enter your first number here: ")
        first = Console.Read()
        Console.WriteLine("Enter your second number here: ")
        second = Console.Read()

        Console.WriteLine("Would you like the sum, difference, product, or quotient of these numbers?
1. Sum
2. Difference
3. Product
4. Quotient")

        'Computes the answer from the users inputs
        choice = Console.Read()
        Select Case choice
            Case 1
                answer = first + second
            Case 2
                answer = first - second
            Case 3
                answer = first * second
            Case 4
                answer = first / second
        End Select

        'Displays the answer from the users inputs
        Console.WriteLine($"The answer is: {answer}")
    End Sub
End Module
