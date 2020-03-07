Module Module1

    Sub Main()

        'variaveis
        Dim num As Integer

        'declarar
        Console.Write("Digite um número: ")
        num = Console.ReadLine()

        'processamento + saida
        If num > 0 Then
            Console.Write("Esse número é positivo!")
        ElseIf num < 0 Then
            Console.Write("Esse número é negativo!")
        Else num = 0
            Console.Write("Esse número é neutro")

        End If


        Console.ReadKey()
    End Sub

End Module
