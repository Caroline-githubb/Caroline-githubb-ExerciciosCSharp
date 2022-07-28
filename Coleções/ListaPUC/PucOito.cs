using System;
using System.Collections.Generic;
using System.Linq;

namespace Coleções.ListaPUC
{
    public class PucOito
    {

        public static void Main59(string[] args)
        {
            List<decimal> numeros = new List<decimal>();
            decimal numero;
            decimal media;            

            do
            {
               numero = LerNumero();
               numeros.Add(numero);           
            }while(numero !=0);
            
            Console.WriteLine($"Media dos números pares: {media = numeros.Average(x => numero)}");

        }

        static decimal LerNumero()
        {   
            System.Console.WriteLine("Digite um numero e para sair digite 0: ");
            decimal numero = decimal.Parse(Console.ReadLine());
            return numero;           
        }
    }
}