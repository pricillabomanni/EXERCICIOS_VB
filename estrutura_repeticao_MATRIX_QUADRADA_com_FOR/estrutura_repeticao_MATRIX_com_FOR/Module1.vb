Module Module1

    Sub Main()

        'Declarar o vetor/array/variavel indexada 
        Dim i, j As Integer
        Dim num(2, 2) As Integer

        'Ler os valores para cada posicao do vetor

        For i = 1 To 2 Step 1
            For j = 1 To 2 Step 1
                Console.Write("Digite um valor: ")
                num(i, j) = Console.ReadLine

            Next

        Next



        Console.Write("Pressione qualquer tecla para sair")
        Console.Read()

    End Sub

End Module
