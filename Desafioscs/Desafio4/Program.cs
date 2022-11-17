using System;

namespace Desafio4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int contador = 0; contador < 10 ; contador++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 == 0)
                    {
                    Console.WriteLine("par");
                }
                else
                {

                    Console.WriteLine("impar");
                }
            }

           



            
        }
    }
}
