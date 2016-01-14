Module AccessSpecifiersDemo
    'module level variable
    Dim name As String
    'Public anothername As String
    Public Function DoThis() As Integer
        Dim num As Integer = 10
        Dim name As String = "dsjfg"
        name = "sjgdja"
        Console.WriteLine(name)
        Return 0
    End Function

    Public Function DoThisAsWell() As Boolean
        'scope/visibility of variable is limited to where it is defined
        Dim rtr As Integer = 5
        name = "dgwe"
        Return True
    End Function

    Private Sub MySub()
        ' num = 10
        name = "asgdgas"
    End Sub

End Module
