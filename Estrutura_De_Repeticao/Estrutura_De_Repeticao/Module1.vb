Module Module1

    Sub Main()

        'variaveis
        Dim num As Integer

        'declarar + processamento + saida

        For i As Integer = 1 To 5 Step 1
            Console.Write("Digite o {0}º número: ", i)
            num = Console.ReadLine()
            Console.WriteLine("{0}º numero = {1}", i, num)
        Next

        Console.ReadKey()

    End Sub

End Module
