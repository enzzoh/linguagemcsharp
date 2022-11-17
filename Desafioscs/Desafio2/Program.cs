using System;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o valor correspondente ao lado");
            int L = Convert.ToInt32(Console.ReadLine());
            int resultado = L * 4;
            Console.WriteLine("O resultado é: {0}",resultado);
        }
    }
}
