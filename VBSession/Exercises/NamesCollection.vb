Module NamesCollection
    '   Create 2 collections
    '   First collection should have 10 names
    '   Second collection should be empty
    '   Code such that : transfer all the names from first collection to another except the one which has your name
 Dim myColl As New Collection
    Dim newcoll As New Collection
    Sub AddCollection()
        myColl.Add("Priya")
        myColl.Add("Rekha")
        myColl.Add("Amit")
        myColl.Add("Sasmita")
        myColl.Add("Kishore")
        myColl.Add("Junaid")
        myColl.Add("Vani")
        myColl.Add("Srikant")
        myColl.Add("Ruchira")
        myColl.Add("Agnes")

        For Each item In myColl
            If Not item.Equals("Rekha") Then
                newcoll.Add(item)
            End If
        Next
        For Each item In newcoll
            Console.WriteLine(item)
        Next
        Console.ReadLine()
    End Sub

End Module
