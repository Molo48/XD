Module Module1

    Sub ispis(ByVal niz As Integer(,))
        For red As Integer = 0 To niz.GetUpperBound(0)
            For stupac As Integer = 0 To niz.GetUpperBound(1)
                Console.Write("{0} ", niz(red, stupac))


            Next
            Console.WriteLine()

        Next
    End Sub

    Sub unosMatrice(ByRef niz As Integer(,))
        For red As Integer = 0 To niz.GetUpperBound(0)
            For stupac As Integer = 0 To niz.GetUpperBound(1)
                Console.Write("Unesi ({0},{1}) element matrice: ", (red + 1), (stupac + 1))
                niz(red, stupac) = Console.ReadLine()


            Next

        Next
    End Sub

    Sub zbroj(ByVal prva, ByVal druga, ByRef rezult)
        For red As Integer = 0 To rezult.GetUpperBound(0)
            For stupac As Integer = 0 To rezult.GetUpperBound(1)

                rezult(red, stupac) = prva(red, 0) * druga(0, stupac) + prva(red, 1) * druga(1, stupac)
            Next
        Next
    End Sub

    Sub Main()
        Dim x As Integer
        Dim y As Integer
        Console.WriteLine("Unesi velicinu prve matrice:")
        x = Console.ReadLine()
        y = Console.ReadLine()
        Dim matricaA As Integer(,) = New Integer(x, y) {}
        Console.WriteLine("Unesi velicinu druge matrice:")
        x = Console.ReadLine()
        y = Console.ReadLine()
        Dim matricaB As Integer(,) = New Integer(x, y) {}

        Dim matricaC As Integer(,) = New Integer(x, x) {}

        Console.WriteLine("Unesi elemente prve matrice")
        unosMatrice(matricaA)
        Console.WriteLine("Unesi elemente druge matrice")
        unosMatrice(matricaB)

        zbroj(matricaA, matricaB, matricaC)


        ispis(matricaC)
    End Sub

End Module
