Module Module1

    Sub Main()
        ' This is our first comment
        'What is a Program?
        '   set of instructions
        '       Data <---> logic
        '           Data
        '              1. Variables -- they change their value over time
        '                   Native/ Value type variables -- stored on stack(memory management)
        '                       faster to access
        '                       fixed in size
        '                       Dispose on their own
        '                   Object Type/ Reference type variables -- stored on heap(memory management)
        '                       slower to access
        '                       not fixed in size
        '                       Dispose them explicitly
        '              2. Constants -- fixed value
        '                   Pi etc.

        'Ctrl + K + C and Ctrl + K + U
        'Lifecycle of variables
        '      Declare
        '      Use them/ Assign them a value
        '      Dispose them

        'Declare
        '   Dim
        '   Name / identifier
        '   Data type
        Dim flag As Boolean '2 bytes
        Dim num As Integer '4 bytes
        Dim sng As Single   '4 bytes -- 7 digits
        Dim dbl As Double   ' 8 bytes -- 16 digits
        Dim accuracy As Decimal ' 16 bytes -- more accuracy / financial/ scientific calculations
        Dim str As String ' depending on the string length

        'Use
        flag = False ' assigned a value to the variable
        num = 25
        sng = 1.2213123
        dbl = 1.29379323432
        accuracy = 1.12752979179797
        str = "This is the session 1 of VB"

        Console.WriteLine("The flag value is " & flag)
        Console.WriteLine("The num value is " & num)
        Console.ReadLine()

        'Data operations on integers
        Dim num1 As Integer
        Dim num2 As Integer
        Dim result As Integer
        Dim subResult As Integer
        Dim prodResult As Integer
        Dim divResult As Double
        Dim quotient As Double
        Dim remainder As Integer
        num1 = 3
        num2 = 10

        'add two numbers
        result = num1 + num2
        Console.WriteLine("The sum of two numbers is " & result)

        'subtraction of two numbers
        subResult = num2 - num1

        'prod of two numbers
        prodResult = num1 * num2

        'Division of two numbers
        divResult = num2 / num1
        Console.WriteLine("Division with / operator " & divResult)

        'quotient = num2 \ num1
        'Console.WriteLine("Division with \ operator " & quotient)
        quotient = Math.DivRem(num2, num1, remainder)
        Console.WriteLine("Quotient using Math function " & quotient)
        Console.WriteLine("Remainder " & remainder)

        'remainder = num2 Mod num1
        'Console.WriteLine("Remainder " & remainder)
        Console.ReadLine()

        ' string operations
        Dim str1 As String
        Dim str2 As String
        Dim strResult As String
        Dim str3 As String = "10"
        str1 = "This is our day one of VB"
        str2 = " and we are confident of learning VB!"

        'joining/ concatenate
        strResult = str1 & str2 ' recommended method when you want to concatenate
        'strResult = str1 + str2

        ' following statement gives the unexpected result
        'strResult = num + str3
        Console.WriteLine(strResult)

        'Left portions / Right portions
        Dim leftStr As String
        Dim rightStr As String
        leftStr = Left(strResult, 10)
        rightStr = Right(strResult, 20)
        Console.WriteLine(leftStr)
        Console.WriteLine(rightStr)

        'Search for a string within a string
        Dim position As Integer
        position = InStr(strResult.ToUpper, "VB")
        'position = InStr(strResult.ToLower, "vb")
        'position = InStr(strResult, "vb")
        'position = InStr(strResult, "VB")
        Console.WriteLine("Position of VB is " & position)
        Console.ReadLine()

        ' Conversion of data types
        Dim x As Integer
        Dim numStr As String = "123"
        x = CInt(numStr)
        x = numStr.ToString()
        'The following fails
        ' x = CInt(name)

        Dim y As Double
        Dim dblStr As String = "123.23213122"
        y = CDbl(dblStr)
        ' see what happens and how this behaves
        ' x = CDbl(y)

        Dim name As String = "Ruchira"
        Dim anotherName As String
        Dim z As Integer = 30
        anotherName = CStr(z)

        'Object type variable
        'Declare, Use and Dispose
        Dim pColl As New Collection

        'use
        pColl.Add("name") 'string data type
        pColl.Add(12)
        pColl.Add(True)

        'retrieve
        Console.WriteLine("The items in the collection are {0}, {1}, {2}", pColl.Item(1), pColl.Item(2), pColl.Item(3))

        'Remove
        pColl.Remove(2)
        Console.WriteLine("The items in the collection are {0}, {1}", pColl.Item(1), pColl.Item(2))
        Console.ReadLine()

        'Dispose
        pColl = Nothing
        'This fails
        'Console.WriteLine(pColl.Item(1))

        Dim pColl2 As New Collection
        pColl.Add(pColl2)
        'add some items in pColl2 and retrieve the first item of pColl2
        'Console.WriteLine(pColl.Item(1))
    End Sub
End Module
