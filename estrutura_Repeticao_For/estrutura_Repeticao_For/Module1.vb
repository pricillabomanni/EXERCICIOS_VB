Module Module1

    Sub Main()

        Dim num, soma As Integer

        For i As Integer = 1 To 5 Step 1
            Console.Write("Digite um número: ")
            num = Console.ReadLine()
            soma = soma + num
        Next



        Console.WriteLine("soma = {0}", soma)
        Console.Write("Pressione qualquer tecla para sair do programa")
        Console.ReadKey()
    End Sub

End Module
