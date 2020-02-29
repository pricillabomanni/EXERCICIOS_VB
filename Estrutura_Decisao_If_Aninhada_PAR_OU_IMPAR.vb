Module Module1

    Sub Main()

        'variaveis
        Dim num As Integer

        'declarar
        Console.Write("digite um número: ")
        num = Console.ReadLine()

        'processamento + saida

        If num Mod 2 = 0 Then
            Console.WriteLine("PAR")
        Else
            Console.WriteLine("IMPAR")
        End If

        Console.ReadKey()



    End Sub

End Module
