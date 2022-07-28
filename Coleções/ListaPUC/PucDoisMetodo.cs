using System;
using System.Linq;
using System.Collections.Generic;

namespace Coleções.ListaPUC
{
    public class PucDoisMetodo
    {
        static void Main51(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            double divisao, fatorial;
            double soma = 0;

            for (int i = 1; i <= numero; i++)
            {
                fatorial = Fatorial(i);
                divisao = 1.0 / fatorial;
                soma += divisao;
            }
            double E = 1.0 + soma;
            Console.WriteLine("E = " + E);
        }

        static long Fatorial(int numero)
        {
            if (numero <= 1)
                return 1;
            else
                return numero * Fatorial(numero - 1);
        }

    }

}