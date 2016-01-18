Public Class Animal ' base class / parent class 
    Implements ISound

    Private _name As String
    Private _color As String
    Private _age As String
    'Methods
    Overridable Sub Walk()
        Console.WriteLine("This is the animal walking")
    End Sub

    'Sub SetName(value As String)
    '    _name = value
    '    Console.WriteLine("The animal name is " & _name)
    'End Sub

    'Function GetName() As String     
    '    Return _name
    'End Function

    'readonly / writeonly / access specifiers

    Public WriteOnly Property Name() As String
        Set(ByVal value As String)
            _name = value
        End Set
    End Property
    Public Property Color() As String
        Get
            Return _color
        End Get
        Set(ByVal value As String)
            _color = value
        End Set
    End Property

    Public Property Age() As String
        Get
            Return _age
        End Get
        Set(ByVal value As String)
            _age = value
        End Set
    End Property

    Sub New()
        Console.WriteLine("We are inside the parent/animal class's constructor")
    End Sub

    Sub New(name As String)
        Console.WriteLine("This is the overloaded constructor")
    End Sub


    Public Overridable Function MakeNoise() As String Implements ISound.MakeNoise
        'specific implementation 
        Return "Noise"
    End Function

    Public Property Name1 As String Implements ISound.Name
End Class
