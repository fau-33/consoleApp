using System;

namespace ConsoleApp.OperadoresLogicos
{
    public class Logicos
{
    public void Executar()
    {
        int numero1 = 1;
        int numero2 = 2;
        
        Console.WriteLine("Operadores Logicos");
        Console.WriteLine("AND: " + (numero1 < 2 && numero2 > 1));
        Console.WriteLine("OR: " + (numero1 < 2 || numero2 > 1));
        Console.WriteLine("NOT: " + !(numero1 < 2));
    }
    }
}
