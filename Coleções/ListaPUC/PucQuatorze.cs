using System;
using System.Collections.Generic;
using System.Linq;

namespace Coleções.ListaPUC
{    
    public class PucQuatorze
    {
        public static void Main73(string[] args)//63
        {       
            List<decimal> numeros = new List<decimal>();                      
            LerNumeros(numeros);
            ExibirDados(numeros);
            Console.ReadKey();             

        }

        private static int LerQuantidadeDeNumeros()
        {
            Console.Write("Digite a quantidade de numeros que deseja informar: ");
            int quantidade = int.Parse(Console.ReadLine() + "");
            return quantidade;
        }

        private static void LerNumeros(List<decimal>numeros)
        {
            int quantidade = LerQuantidadeDeNumeros();
            decimal numero = 0;

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                decimal.TryParse(Console.ReadLine(), out numero);
                numeros.Add(numero);
            }              
        }

        private static decimal Media(List<decimal>numeros)
        {          
            return numeros.Average();
        }

        private static decimal Maior(List<decimal>numeros)
        {            
            int maior = 0;           
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] > 0) maior +=1;                           
            }            
            return maior;
        }
        private static decimal Menor(List<decimal>numeros)
        {           
            int menor = 0;
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] < 0) menor+=1;                        
            }            
            return menor;
        }

        private static void ExibirDados(List<decimal>numeros)
        {
            
            Console.WriteLine($"Média dos valores lidos: {Media(numeros)}");
            Console.WriteLine($"% de valores menores que 0: {(Menor(numeros)*100)/numeros.Count} %");
            Console.WriteLine($"% de valores maiores que 0: {(Maior(numeros)*100)/numeros.Count} %");
        }






  
    }
}