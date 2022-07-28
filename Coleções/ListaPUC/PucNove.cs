using System;
using System.Collections.Generic;
using System.Linq;
namespace Coleções.ListaPUC
{
    public class PucNove
    {
        public static void Main60(string[] args)
        {            
            int[] valores = new int[10];

            for(int i = 0; i < valores.Length;i++)
            {
                valores[i] = int.Parse(Console.ReadLine());
            }

            var minimo = valores.Min();
            var maximo = valores.Max();

            Console.WriteLine($"Valor minimo: {minimo}");
            Console.WriteLine($"Valor maximo: {maximo}");



        }

        
    }
}