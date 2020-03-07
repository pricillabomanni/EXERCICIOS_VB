Module Module1

    Sub Main()

        'Declarar o vetor/array/variavel indexada 
        Dim num(5), soma, media As Double
        Dim i As Integer

        'Ler os valores para cada posicao do vetor

        For i = 1 To 5 Step 1
            Console.Write("Digite o {0}º numero: ", i)
            num(i) = Console.ReadLine()
            soma = soma + num(i)
        Next
        media = soma / (i - 1)

        'exibir os valores para cada posicao do vetor
        For i = 1 To 5 Step 1
            Console.WriteLine("num{0} = {1}", i, num(i))
        Next




        Console.WriteLine("A soma é: {0} e a media é: {1} ", soma, media)
        Console.Write("Pressione qualquer tecla para sair")
        Console.Read()

    End Sub

End Module
