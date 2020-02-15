Imports System

Module Program
    Sub Main()

        'Declarar variaveis
        Dim num As Double
        Dim resultado As Double

        'Atribuir variaveis 
        Console.Write("Digite um número: ")
        num = Console.ReadLine()

        'Processamento
        resultado = Math.Pow(num, 5)


        'Saida
        Console.Write("num {0} ^ 2 = {1}", num, resultado)

        Console.ReadKey()



    End Sub
End Module
