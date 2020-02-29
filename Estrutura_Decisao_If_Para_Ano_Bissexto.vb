Module Module1

    Sub Main()

        'variaveis
        Dim ano As Integer

        'declarar

        Console.Write("Digite um ano: ")
        ano = Console.ReadLine()

        'processamento + saida

        If ano Mod 4 = 0 Then
            Console.Write("É ano bissexto")
        Else
            Console.Write("Não é ano bissexto")
        End If

        Console.ReadKey()





    End Sub

End Module
