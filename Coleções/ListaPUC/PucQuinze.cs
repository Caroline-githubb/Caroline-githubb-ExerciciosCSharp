
using System;
using System.Collections.Generic;
using System.Linq;

namespace Coleções.ListaPUC
{
    public class PucQuinze
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            ContagemNumeros(numeros);

        }

        public static void LerNumero(List<int>numeros)
        {   
            int numero = -1;        
            Console.WriteLine("Digite os números que deseja e para parar digite qualquer número negativo.");
            do
            {
                numero = int.Parse(Console.ReadLine() ?? string.Empty);
                numeros.Add(numero);
            }while(numero >=0);
        }

        public static void ContagemNumeros(List<int>numeros)
        {
            LerNumero(numeros);
            int contagem1 = 0;
            int contagem2 = 0;
            int contagem3 = 0;
            int contagem4 = 0;
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] >= 0 && numeros[i] <= 25)
                {
                    contagem1++;
                }
                if (numeros[i] >= 26 && numeros[i] <= 50)
                {
                    contagem2++;
                }
                if (numeros[i] >= 51 && numeros[i] <= 75)
                {
                    contagem3++;
                }
                if (numeros[i] >= 76 && numeros[i] <= 100)
                {
                    contagem4++;
                }
            }
            ExibirDados(contagem1,contagem2,contagem3,contagem4);

        }

        public static void ExibirDados(int contagem1, int contagem2, int contagem3, int contagem4)
        {
            Console.WriteLine($"Quantidade de números no intervalo de [0,25]: {contagem1}");
            Console.WriteLine($"Quantidade de números no intervalo de [26,50]: {contagem2}");
            Console.WriteLine($"Quantidade de números no intervalo de [51,75]: {contagem3}");
            Console.WriteLine($"Quantidade de números no intervalo de [76,100]: {contagem4}");                  
        }


    }
}