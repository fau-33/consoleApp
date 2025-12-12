using System;

namespace ConsoleApp.OperacoesAritmeticas
{
    public class Calculadora1
{
    public void Calcular1()
    {
        Console.WriteLine("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        // Mostre um menu de operações
        Console.WriteLine("Escolha a operação: ");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        double operacoes = Convert.ToDouble(Console.ReadLine());

        // Verificação da divisão por zero
        if (operacoes == 4 && numero2 == 0)
        {
            Console.WriteLine("Erro: divisão por zero!");
            return;
        }

        if (operacoes == 1)
        {
            Console.WriteLine("A soma é: " + (numero1 + numero2));
        }
        else if (operacoes == 2)
        {
            Console.WriteLine("A subtração é: " + (numero1 - numero2));
        }
        else if (operacoes == 3)
        {
            Console.WriteLine("A multiplicação é: " + (numero1 * numero2));
        }
        else if (operacoes == 4)
        {
            Console.WriteLine("A divisão é: " + (numero1 / numero2));
        }
    }
    }
}