Public Class Vehicle 'entity /noun
    Implements ISound


    ' classes = responsibility = (data/ members/ fields/properties/attributes) + (related logic / behaviour)
    Private _type As String
    Private _color As String
    Private _brand As String

    Function CalculateSpeed() As Integer

        Return 0
    End Function
    ' different functions

    Public Function MakeNoise() As String Implements ISound.MakeNoise
        Return " bzzz"
    End Function

    Public Property Name As String Implements ISound.Name
End Class
