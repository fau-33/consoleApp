using System;

namespace ConsoleApp.OperacoesAritmeticas
{
    public class Calculadora
{
    public void Calcular()

    {
        Console.WriteLine("Escreva um número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Escreva outro número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int soma = num1 + num2;
        int subtracao = num1 - num2;
        int multiplicacao = num1 * num2;
        int divisao = num1 / num2;

        Console.WriteLine("A Soma é: " + soma);
        Console.WriteLine("A Subtração é: " + subtracao);
        Console.WriteLine("A Multiplicação é: " + multiplicacao);
        Console.WriteLine("A Divisão é: " + divisao);
    }
    }
}