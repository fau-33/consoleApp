using System;

namespace ConsoleApp.OperacoesAritmeticas
{
    public class Soma
{
    public void Executar()
    {
        Console.WriteLine("Escreva um número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Escreva outro número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int total = num1 + num2;

        Console.WriteLine("O total é: " + total);
    }
    }
}
