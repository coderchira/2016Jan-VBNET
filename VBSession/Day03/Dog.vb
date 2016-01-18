Public Class Dog ' derived class / sub / child
    Inherits Animal
    'Encapsulation
    Private _breed As String
    Public Property Breed() As String
        Get
            Return _breed
        End Get
        Set(ByVal value As String)
            _breed = value
        End Set
    End Property

    Sub Bark()
        Console.WriteLine("This is the dog barking")
    End Sub

    Sub New()
        Console.WriteLine("This is the child/dog class's constructor")
    End Sub

    Overrides Sub Walk()
        'implementation
        Console.WriteLine("This is the Dog's way of walking")
    End Sub

    Public Overrides Function MakeNoise() As String
        Return string
    End Function
End Class
