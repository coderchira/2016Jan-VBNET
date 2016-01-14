Module LogicDemo
    'Logic
    '   Procedures
    '       Functions
    '           return a value
    '       Subroutines
    '           do not return value
    'Lifecycle of logic
    '   Declare
    '   Implement/ use / body
    '   Call
    Function AddNumbers() As Boolean
        'add two numbers
        ' DoThis()
        Return True
    End Function

    Sub DoThis()
        'do something
        AddNumbers()
        ' Dim rtr As Integer = AddNumbers(5.4, 30.0, "Joy")
    End Sub

    'Signature of the function
    '   function keyword
    '   name of the function
    '   no. of parameters
    '   type of parameters
    '   sequence of parameters
    '   return type
    '   security

    'function overloading 
    Function DemoFunction(height As Single, weight As Double, name As String) As Integer
        'conditional statements
        If height < 2.0 Then
            Console.WriteLine("Sorry, please enter through other door")
        ElseIf height = 2.0 Then
            Console.WriteLine("The person is tall enough to enter through the door!")
        ElseIf height > 5.0 Then
            Console.WriteLine("The person is greater than 5 and can  enter through the door!")
        Else
            Console.WriteLine("for all other cases come here")
        End If

        'Select statements
        Dim anotherVar As Single = 10.0
        Select Case anotherVar
            Case 2.0
                'do something
            Case 5.0
                'do something
            Case Is >= 3.0
                'do something
            Case 4.0, 4.1, 6.0
                'do something
            Case Else
                'do something else
        End Select

        'nested ifs
        If height > 6 Then
            If name = "Joey" Then
                'do something
            ElseIf name = "Ruchira" Then

            End If
        End If

        'looping / iterations 
        'for loops
        For index = 1 To 10 ' default step is 1
            'If height > 2.0 Then
            '    Console.WriteLine(index)
            'End If
            Console.WriteLine(index)
        Next

        For counter = 1 To 5 Step 2
            Console.WriteLine(counter)
        Next

        For i = 10 To 5 Step -1.5
            Console.WriteLine(i)
        Next

        'while loops
        While height >= 3.0
            Console.WriteLine(height)
            height = height - 1
        End While

        'do while loops
        'will execute atleast once
        Do
            Console.WriteLine(height)
            height = height - 1
        Loop While height = 2.0

        Dim myColl As New Collection
        ' add items to the collection and make use of for loop
        For i = 1 To 5
            myColl.Add(i)
        Next

        'retrive using for each loop
        For Each item In myColl
            Console.WriteLine("The items in myColl are" & item)
        Next

        Return 0
    End Function

End Module
