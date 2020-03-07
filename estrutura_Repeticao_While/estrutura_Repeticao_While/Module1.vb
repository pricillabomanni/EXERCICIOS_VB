Module Module1

    Sub Main()

        Dim num, soma, media As Integer
        Dim i As Integer = 1

        While i <= 5  'index(ou simplesmente i) sempre com nº inteiros 
            Console.Write("Digite um numero:")
            num = Console.ReadLine()
            soma += num
            i += 1
        End While

        media = soma / 5

        Console.WriteLine("Soma é: {0} e a média é: {1}", soma, media)
        Console.Write("Pressione qualquer tecla para sair do programa!")
        Console.ReadKey()

    End Sub

End Module
