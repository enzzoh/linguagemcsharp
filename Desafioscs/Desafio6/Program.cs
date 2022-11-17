using System;

namespace Desafio6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("informe um valor");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("inteiro");
            }
            catch (FormatException)
            {

                Console.WriteLine("real");
            }


        }
    }
}
