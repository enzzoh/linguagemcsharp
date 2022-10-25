using System;

namespace ByteVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //vetor com 4 elementos estaticos
            byte[] vbytes = { 2, 4, 8, 10 };
            Console.WriteLine("lista de valores do primeiro vetor ");

            Console.WriteLine("valor 1 : {0}", vbytes[0]);
            Console.WriteLine("valor 2 : {0}", vbytes[1]);
            Console.WriteLine("valor 3 : {0}", vbytes[2]);
            Console.WriteLine("valor 4 : {0}", vbytes[3]);
            Console.WriteLine("o total de elementos é {0}", vbytes.Length);

            for (int i = 0; i < vbytes.Length; i++)
            {

                Console.WriteLine("Valor na posição {0} é igual a {1}", i, vbytes[i]);

            }
            byte[] vbytesB = new byte[3];
            Console.WriteLine("novos valores");
            for (int i = 0; i < vbytes.Length; i++)
            {

                Console.WriteLine("digite o {0} valor: ", i);
                try
                {
                    vbytesB[i] = Convert.ToByte(Console.ReadLine());

                }
                catch (Exception)
                {

                    vbytesB[i] = 0;
                }
                
            }

            int Contvalidos = 0;
            int ContINvalidos = 0;

            for (int i = 0; i < vbytes.Length; i++)
            {

                if (vbytesB[i] ==0){ ContINvalidos++;   }
                else { Contvalidos++; }


            }

            Console.WriteLine("Quantidade de validos é {0}", Contvalidos);
            Console.WriteLine("Quantidade de Invalidos é {0}", ContINvalidos);















        }
    }   
}