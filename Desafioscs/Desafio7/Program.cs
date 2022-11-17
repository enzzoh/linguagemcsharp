using System;

namespace Desafio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double[] valores = new double[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Digite os valores");
                valores[i] = Convert.ToDouble(Console.ReadLine());

            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("");

            a = valores[0] + valores[1] + valores[2] + valores[3];
            b = (a / 4);


            Console.WriteLine("a soma dos valores é {0} é a média e de {1}", a, b);
        }
    }
}
