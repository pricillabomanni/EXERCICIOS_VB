Imports System

Module Program
    Sub Main()

        'Declarar Variáveis
        Dim a, b, c, s, r As Integer

        'Atribuir variaveis
        Console.Write("Digite o 1º número: ")
        a = Console.ReadLine()

        Console.Write("Digite o 2º número: ")
        b = Console.ReadLine()

        Console.Write("Digite o 3º número: ")
        c = Console.ReadLine()

        'Processamento
        s = (a + b + c)
        r = Math.Pow(s, 2)

        'Saida
        Console.Write("A soma dos seus três números é: {0} e o quadrado da soma é: {1} ", s, r)
        Console.ReadKey()


    End Sub
End Module
