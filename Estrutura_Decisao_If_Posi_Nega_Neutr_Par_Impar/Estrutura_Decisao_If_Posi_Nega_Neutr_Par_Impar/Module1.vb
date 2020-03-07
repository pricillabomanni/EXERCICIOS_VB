Module Module1

    Sub Main()

        'variaveis
        Dim num As Integer

        'declarar
        Console.Write("Digite um número: ")
        num = Console.ReadLine()

        'processamento + saida
        If num > 0 Then
            Console.Write("Esse número é positivo")

        ElseIf num < 0 Then
            Console.Write("Esse numero é negativo")

        Else
            Console.Write("esse numero é neutro")

        End If

        If num Mod 2 = 0 Then
            Console.Write(" e PAR")
        Else
            Console.Write(" e Impar")
        End If


        Console.ReadKey()

    End Sub

End Module
