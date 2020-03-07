Module Module1

    Sub Main()


        'Declarar o vetor/array/variavel indexada 
        Dim num(10), numPar As Double
        Dim i As Integer

        'Ler os valores para cada posicao do vetor

        For i = 1 To 10 Step 1
            Console.Write("Digite o {0}º numero: ", i)
            num(i) = Console.ReadLine()

            If num(i) Mod 2 = 0 Then
                Console.WriteLine("É numero par")

            End If


        Next


        'exibir os valores para cada posicao do vetor para entender

        For i = 1 To 5 Step 1
            Console.WriteLine("num{0} = {1}", i, num(i))
        Next


        Console.Write("Pressione qualquer tecla para sair")
        Console.Read()


    End Sub

End Module
