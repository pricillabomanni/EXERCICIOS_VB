Imports System

Module Program
    Sub Main(args As String())

        'Declarar variáveis

        Dim c, l, h, v As Double

        'Atribuir variáveis
        Console.Write("Digite o comprimento desejado: ")
        c = Console.ReadLine()

        Console.Write("Digite a largura desejada: ")
        l = Console.ReadLine()

        Console.Write("Digite a altura desejada: ")
        h = Console.ReadLine()

        'Processamento
        v = c * l * h

        'saida 
        Console.Write("O volume do seu objeto é: {0} ", v)
        Console.ReadKey()


    End Sub
End Module
