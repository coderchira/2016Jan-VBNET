Module AccessSpecifiersDemo
    'module level variable
    Dim name As String
    'Public anothername As String
    Public Function DoThis() As Integer
        Dim num As Integer = 10
        'the following will not work as we are trying to use local variable with the before it's declared 
        'name = "Ruby"

        'to access the module level variable give a fully qualified name using the module's name
        AccessSpecifiersDemo.name = "Ruby"
        Console.WriteLine("The value of module level variable is " & AccessSpecifiersDemo.name)

        Dim name As String = "Rita"
        Console.WriteLine("The value of the local variable is " & name)

        'Let's call another function to check the module level variable's value
        DoThisAsWell()
        Return 0
    End Function

    Public Function DoThisAsWell() As Boolean
        'scope/visibility of variable is limited to where it is defined
        Dim rtr As Integer = 5
        Console.WriteLine("The value of module level variable is still " & name)
        name = "Reena"
        Console.WriteLine("The value of local variable is" & name)
        Return True
    End Function

    Private Sub MySub()
        ' num = 10
        name = "asgdgas"
    End Sub

End Module
