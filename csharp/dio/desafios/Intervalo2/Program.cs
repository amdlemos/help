using System;

namespace Intervalo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tc, a, i;
            int interval = 0;
            int outInterval = 0;

            tc = 4;
            int[] array2 = new int[] { 14, 123, 10, -25 };            
            for (i = 0; i < tc; i++)
            {
                
                a = array2[i];
                Console.WriteLine(a);
                if (a>=10 && a<=20)
                {
                    interval += 1;              
                }
                else                                                             //Insira sua lógica nos espaços em branco
                {
                    outInterval += 1;           
                }

            }
            Console.WriteLine("{0} in", interval);
            Console.WriteLine("{0} out", outInterval);


            
        }
    }
}
