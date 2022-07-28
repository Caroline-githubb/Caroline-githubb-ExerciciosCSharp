using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Coleções.ListaPUC
{
    public class PucOnze
    {
        public static void Main62(string[] args)
        {
            System.Console.WriteLine("Digite a quantidade de números que haverão na P.A: ");
            int quantidade = int.Parse(Console.ReadLine());
            int[] a = new int[quantidade];
            int aux = 0;
            int contador = 1;

            for (int i = 0; i < a.Length; i++)
            {
                aux = aux + 5;
                a[i] = aux;
                Console.WriteLine($"a{contador++} = {a[i]}");
            }
            
            Console.WriteLine($"r = {a[1] - a[0]}");
            Console.WriteLine($"Soma dos elementos = {a.Sum()}");        
      
        }
    }
}