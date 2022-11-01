using System;

namespace ByteVetor1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] valores = { 4, "gota", 300, 500, 3 };
            byte[] vbytes = new byte[5];
            string[] vtexto = new string[5];
            int[] vforafaixa = new int[5];



            for (int i = 0; i < valores.Length; i++)
            {

                try
                {
                    var v = Convert.ToByte(valores[i]);
                    vbytes[i] = v;
                }
                catch (FormatException)
                {

                    vtexto[i] = valores[i].ToString();

                }
                catch (OverflowException)
                {


                    vforafaixa[i] = Convert.ToInt32(valores[i]);  

                }








            }

            Console.ReadKey();
        
        
        
        
        
        }    



    }
}
