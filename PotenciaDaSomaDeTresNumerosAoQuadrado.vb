Imports System

Module Program
    Sub Main()

        'Declarar Vari�veis
        Dim a, b, c, s, r As Integer

        'Atribuir variaveis
        Console.Write("Digite o 1� n�mero: ")
        a = Console.ReadLine()

        Console.Write("Digite o 2� n�mero: ")
        b = Console.ReadLine()

        Console.Write("Digite o 3� n�mero: ")
        c = Console.ReadLine()

        'Processamento
        s = (a + b + c)
        r = Math.Pow(s, 2)

        'Saida
        Console.Write("A soma dos seus tr�s n�meros �: {0} e o quadrado da soma �: {1} ", s, r)
        Console.ReadKey()


    End Sub
End Module
