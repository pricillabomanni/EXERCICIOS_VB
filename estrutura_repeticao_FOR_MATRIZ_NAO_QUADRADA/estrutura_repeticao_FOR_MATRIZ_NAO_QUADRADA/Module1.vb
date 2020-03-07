Module Module1

    Sub Main()
        'Declarar o vetor/array/variavel indexada 
        Dim i, j, num(2, 2) As Integer
        Dim soma, media As Double

        'Ler os valores para cada posicao do vetor

        For i = 1 To 2 Step 1
            For j = 1 To 2 Step 1
                Console.Write("Digite um valor: ")
                num(i, j) = Console.ReadLine
                soma = soma + num(i, j)
            Next
        Next

        For i = 1 To 2 Step 1
            For j = 1 To 2 Step 1
                Console.WriteLine("Matriz [{0},{1}]", i, j, num(1, 1))
            Next
        Next

        media = soma / (i - 1 + j - 1)
        'media = soma / 4

        Console.WriteLine("Soma: {0}", soma)
        Console.WriteLine("Media: {0}", media)
        Console.Write("Pressione qualquer tecla para sair")
        Console.Read()


    End Sub

End Module
