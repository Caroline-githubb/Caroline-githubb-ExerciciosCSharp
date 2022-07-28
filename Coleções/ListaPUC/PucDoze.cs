using System;

namespace Coleções.ListaPUC
{
    public class PucDoze
    {
        public static void Main61(string[] args)
        {
            System.Console.WriteLine("Digite qual número gostaria de ver a tabuada.");
            int n = Convert.ToInt32(Console.ReadLine());
            int tabuada;

            for (int i = 1; i <= n; i++)
            {
                tabuada = i * n;
                Console.WriteLine($"{i} x {n} = tabuada");

            }


        }

    }

}


