using System;

namespace Desafio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine(Math.Sqrt(x));
        }
    }
}
