Module Module1

    Sub Main()

        Dim num, somaPar, somaGeral As Integer
        Dim i As Integer = 1  'i tem que ser numero inteiro positivo ou negativo

        Do While i < 6
            Console.Write("Digite um numero: ")
            num = Console.ReadLine()
            If num Mod 2 = 0 Then
                Console.WriteLine("O numero é par")
                somaPar = somaPar + num
            End If
            somaGeral = somaGeral + num

            i += 1
        Loop

        Console.WriteLine("Soma dos pares é igual: {0} e a soma geral é: {1}", somaPar, somaGeral)
        Console.Write("Pressione qualquer tecla para sair do programa!")
        Console.ReadKey()
    End Sub

End Module
