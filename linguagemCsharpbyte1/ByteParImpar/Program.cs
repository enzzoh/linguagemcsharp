using System;

namespace ByteParImpar
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("digite 10 valore");
            string[] valores = new string[10];





            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Diite o {0} valor: ", i + 1);
                valores[i] = Console.ReadLine();
            }
            byte[] pares = new byte[10];
            byte[] impares = new byte[10];
            int qtderros = 0;
            int indicepar = 0;
            int indiceimpar = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                try
                {
                    byte v = Convert.ToByte(valores[0]);

                    if ( v % 2 == 0)
                    {
                        pares[indiceimpar] = v;
                        indicepar++;
                    }
                    else
                    {
                        impares[indiceimpar] = v;
                        indiceimpar++;
                    }




                }
                catch (Exception)
                {
                    qtderros++;
                    
                }
            }


            Console.WriteLine("pares");
            for (int i = 0; i < 10; i++)
            {
                if (pares[i] != 0) { Console.WriteLine(pares[i]); }
                
            }
            Console.WriteLine("Impares");
            for (int i = 0; i < 10; i++)
            {
                if (impares[i] != 0) { Console.WriteLine(impares[i]); }
            }

            Console.WriteLine("Quantidade de erros: {0}",qtderros);







            B




        }


        
    }
}
