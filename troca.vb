Imports System

Module Program
    Sub Main(args As String())

        'Declarar Variaveis
        Dim a, b, troca As Integer


        'Atribuir variavel
        Console.Write("Digite o 1� valor: ")
        a = Console.ReadLine()

        Console.Write("Digite o 2� valor: ")
        b = Console.ReadLine()

        'Processamento
        troca = b
        b = a
        a = troca

        'Saida
        Console.Write("A invers�o dos numeros ser�: o 1� valor {0} e o 2� valor {1} ", a, b)



        Console.ReadKey()

    End Sub
End Module
