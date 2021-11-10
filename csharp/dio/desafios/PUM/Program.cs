using System;

namespace PUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 78;          
            int controladorLinhas = 0;
            string meuTexto = "";

            for (int i = 1; i <= N; i++)
            {

                controladorLinhas = i*4;
                
                meuTexto += (controladorLinhas - 3).ToString() + " ";
                meuTexto += (controladorLinhas - 2).ToString() + " ";
                meuTexto += (controladorLinhas - 1).ToString() + " ";
                meuTexto += "PUM";
                Console.WriteLine(meuTexto);
                meuTexto = "";
            }

        }
    }
}
