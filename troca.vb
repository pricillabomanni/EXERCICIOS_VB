Imports System

Module Program
    Sub Main(args As String())

        'Declarar Variaveis
        Dim a, b, troca As Integer


        'Atribuir variavel
        Console.Write("Digite o 1º valor: ")
        a = Console.ReadLine()

        Console.Write("Digite o 2º valor: ")
        b = Console.ReadLine()

        'Processamento
        troca = b
        b = a
        a = troca

        'Saida
        Console.Write("A inversão dos numeros será: o 1º valor {0} e o 2º valor {1} ", a, b)



        Console.ReadKey()

    End Sub
End Module
