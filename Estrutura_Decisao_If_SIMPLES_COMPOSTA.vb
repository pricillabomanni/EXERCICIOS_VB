Module Module1

    Sub Main()

        'variaveis
        Dim mf, n1, n2, n3, n4 As Integer

        'entradas

        Console.Write("Digite a nota 1: ")
        n1 = Console.ReadLine()

        Console.Write("Digite a nota 2: ")
        n2 = Console.ReadLine()

        Console.Write("Digite a nota 3: ")
        n3 = Console.ReadLine()

        Console.Write("Digite a nota 4: ")
        n4 = Console.ReadLine()

        'processamento + saida

        mf = (n1 + n2 + n3 + n4) / 4

        If mf >= 50 Then
            Console.Write("Parabéns você foi aprovado e a sua média final é: {0}", mf)

        Else
            Console.Write("Sinto muito, você foi reprovado e sua média final é: {0}", mf)

        End If

        Console.ReadKey()


    End Sub

End Module
