Module Module1

    Sub Main()

        'Variaveis
        Dim mf, n1, n2, n3, n4 As Integer

        'Declarar

        Console.Write("Digite sua nota 1:")
        n1 = Console.ReadLine()

        Console.Write("Digite sua nota 2:")
        n2 = Console.ReadLine()

        Console.Write("Digite sua nota 3:")
        n3 = Console.ReadLine()

        Console.Write("Digite sua nota 4:")
        n4 = Console.ReadLine()


        'Processamento + saida

        mf = (n1 + n2 + n3 + n4) / 4

        If (mf >= 70) Then
            Console.Write("APROVADO")

        ElseIf (mf < 50) Then
            Console.Write("REPROVADO")
        Else
            Console.Write("RECUPERAÇÃO")
        End If


        Console.ReadKey()

    End Sub

End Module
