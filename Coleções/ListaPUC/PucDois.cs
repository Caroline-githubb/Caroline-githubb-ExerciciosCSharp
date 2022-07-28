using System;
using System.Linq;
using System.Collections.Generic;

namespace Coleções.ListaPUC
{
    public class PucDois
    {
        public static void Main50(string[] args)
        {
            //Escrever um algoritmo que lê um valor N inteiro e positivo e que calcula e escreve o valor de E.  
            // E = 1 + 1 / 1! + 1 / 2! + 1 / 3! + 1 / N!
         
            int n = int.Parse(Console.ReadLine());
            double fatorial = 1;
            double divisao = 1;
            double soma = 0;
            double E = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    fatorial = fatorial * i;
                }

                if (i != 1)
                {
                    fatorial = i;

                    for (int j = i - 1; j >= 1; j--)
                    {
                       fatorial =  fatorial*j;
                    }
                }

                divisao = 1.0 / fatorial;
                soma = soma + divisao;

            }

            E = 1.0 + soma;

            System.Console.WriteLine("E = " + E);

        }



    }
}