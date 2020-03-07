Module Module1

    Sub Main()

        Dim num, soma As Integer

        For i As Integer = 5 To 1 Step -1 '[step -1 é um decremento ou i--]
            Console.Write("Digite um numero: ")
            num = Console.Read()
            soma = soma + num
        Next


        Console.WriteLine("Soma é igual: {0}", soma)
        Console.Write("Pressione qualquer tecla para sair do programa!")
        Console.ReadKey()

    End Sub

End Module
