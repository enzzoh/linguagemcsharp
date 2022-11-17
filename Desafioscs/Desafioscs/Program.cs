using System;

namespace Desafioscs
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                
                Console.WriteLine("informe um valor");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Número");
            }
            catch (FormatException)
            {

                Console.WriteLine("Texto");
            }
            
            
         
        }
    }
}
