using System;

namespace TipoByte
{
    class Program
    {
        static void Main(string[] args)
        {
            byte? x;
            try
            {
                x = Convert.ToByte(Console.ReadLine());
              
            }
            catch (OverflowException)
            {
                Console.WriteLine("O valor Digitado está muito grande ou muito pequeno");
                Console.WriteLine("Tente numeros de 0 a 255");
                x = 0; 
            }
            catch (FormatException)
            {
                Console.WriteLine("tenta digitar numeros, burro do klh");
                x = 0;


           
            }
           

            

            byte y = Convert.ToByte(Console.ReadLine());


       
           
            Console.WriteLine("os valores digitados são: {0} e {1}",x,y);






        }


    }
}
