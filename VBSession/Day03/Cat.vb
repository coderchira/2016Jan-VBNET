Public Class Cat
    Inherits Animal

    Private _breed As String
    Sub Meows()

    End Sub

    Public Overrides Sub Walk()
        Console.WriteLine("This is the cat walking")
    End Sub
End Class
