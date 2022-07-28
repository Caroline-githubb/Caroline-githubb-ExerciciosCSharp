using System;
namespace Coleções.ListaPUC
{
    public class PucUm
    {
        public static void Main49(string[] args)
        {
            //Escrever um algoritmo que lê 5 valores para a, um de cada vez, 
            //e conta quantos destes valores são negativos,
            //escrevendo esta informação. 

            int[] a = new int[5];

            System.Console.WriteLine("Digite 5 valores: ");

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            int contador = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    contador = contador + 1;
                }
            }
            Console.WriteLine($"Quantidade de números negativos: {contador}");








        }


    }
}