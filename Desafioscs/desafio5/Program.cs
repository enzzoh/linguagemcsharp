using System;

namespace desafio5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("digite o valor de a");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite o valor de b");
            double b = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("digite o valor de c");
            double c = Convert.ToDouble(Console.ReadLine());
            double delta;


            delta = (b * b) - 4 * a * c;

            Console.WriteLine("O resultado é: {0}",delta);



        }  
    }
}
