using System;
using System.Collections.Generic;
using System.Linq;



namespace Coleções.ListaPUC
{
    public class PucCinco
    {
        public static void Main55(string[] args)
        {
            List<int> numeros = new List<int>();
            int valor = 0;

            while(valor >= 0)
            {
                System.Console.WriteLine("Digite um numero inteiro positivo, e caso queira parar de digitar, digite um número negativo");
                valor = int.Parse(Console.ReadLine());
                numeros.Add(valor);
            }

            var media = numeros.Average();
            Console.WriteLine("A media de numeros é " + Math.Round(media, 2));
            
        }

    }
}