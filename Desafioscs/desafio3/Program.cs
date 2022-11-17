using System;

namespace desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Digite o valor da base");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura");
            double h = Convert.ToDouble(Console.ReadLine());
            double resultado1 = b * h;
            double resultado2 = 2 * (b + h);
            Console.WriteLine("O valor da área é: {0}",resultado1);
            Console.WriteLine("O valor do perimetro é: {0}", resultado2);



        }
    }
}
