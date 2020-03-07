Module Module1

    Sub Main()

        'variaveis
        Dim num, soma As Integer

        'entrada + processamento + saida
        For i As Integer = 1 To 5 Step 1
            Console.Write("Digite o {0}º numero: ", i)
            num = Console.ReadLine()
            soma = soma + num

        Next

        Console.Write("A soma dos seus numeros é: {0}", soma)

        Console.ReadKey()


    End Sub

End Module
