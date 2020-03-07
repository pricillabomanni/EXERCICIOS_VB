Module Module1

    Sub Main()
        Dim num, somaPar, somaImpar, mediaGeral As Double ' com Integer ele arredonda o valor

        For i As Integer = 1 To 10 Step 1

            Console.Write("Digite um numero: ")
            num = Console.ReadLine()

            If num Mod 2 = 0 Then
                somaPar = somaPar + num
            Else
                somaImpar = somaImpar + num
            End If
        Next
        mediaGeral = (somaPar + somaPar) / 10


        Console.WriteLine("Soma dos pares: {0}, soma dos impares: {1} e media geral é: {2}", somaPar, somaImpar, mediaGeral)
        Console.Write("Pressione qualquer tecla para sair")
        Console.Read()
    End Sub

End Module
