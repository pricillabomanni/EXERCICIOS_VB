Imports System

Module Program
    Sub Main(args As String())

        'Declarar vari�veis

        Dim c, l, h, v As Double

        'Atribuir vari�veis
        Console.Write("Digite o comprimento desejado: ")
        c = Console.ReadLine()

        Console.Write("Digite a largura desejada: ")
        l = Console.ReadLine()

        Console.Write("Digite a altura desejada: ")
        h = Console.ReadLine()

        'Processamento
        v = c * l * h

        'saida 
        Console.Write("O volume do seu objeto �: {0} ", v)
        Console.ReadKey()


    End Sub
End Module
