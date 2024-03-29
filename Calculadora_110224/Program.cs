﻿using System;

class Program
{

    static void Main()
    {
        Console.WriteLine("Calculadora Simples");
        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o operador (+, -, *, /): ");
        char operador = Console.ReadKey().KeyChar;

        Console.Write("\nDigite o segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double? resultado = 0;

        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                    Console.WriteLine("Erro: Divisão por zero.");
                break;
            default:
                Console.WriteLine("Operador inválido.");
                break;
        }
        Console.WriteLine($"Resultado: {resultado}");
    }
}