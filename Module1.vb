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
'.................................druga vjezba....................................
Module Module1

    Structure koordinata
        Dim x As Integer
        Dim y As Integer
        Function udaljenost() As Double
            Return Math.Sqrt((x * x) + (y * y))
        End Function
    End Structure


    Sub Main()
        Dim koodrinate As koordinata() = New koordinata() {}

        Dim i As Integer = 0
       

        While True
            unosKoordinate(koodrinate(i))
            i = i + 1
            If (koodrinate(i).x = 0 And koodrinate(i).y = 0) Then
                Exit While
            End If
        End While

    End Sub

    Sub unosKoordinate(ByRef koord As koordinata)
        Console.Write("Unesi x koordinatu: ")
        koord.x = Console.ReadLine()

        Console.Write("Unesi y koordinatu: ")
        koord.y = Console.ReadLine()
    End Sub

End Module
'.................................vj3
Module Module1

    Structure ComplexNumber
        Dim real As Integer
        Dim imag As Integer
        Function zbroji(ByVal zaZbroj As ComplexNumber) As ComplexNumber

            zbroji.real = real + zaZbroj.real
            zbroji.imag = imag + zaZbroj.imag
            Return zbroji
        End Function
    End Structure


    Sub Main()
        Dim Z1, Z2, x As ComplexNumber
        Dim Z3 As ComplexNumber
        Z1.real = 1
        Z1.imag = 2

        Z2.real = 1
        Z2.imag = 2

        Z3 = Z1.zbroji(Z2).zbroji(Z2)

        
        Console.WriteLine("Realin dio zbroja je {0}, imaginarni dio je {1}", Z3.real, Z3.imag)
    End Sub



End Module
