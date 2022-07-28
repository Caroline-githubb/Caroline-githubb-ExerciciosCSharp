using System;

namespace Coleções
{
    public class DesafioOito
    {
        public static void Main42(string[] args)
        {
            System.Console.WriteLine("total de casos: ");
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());

            for (int caso = 0; caso < totalDeCasosDeTeste; caso++)
            {
                String[] palavras = Console.ReadLine().Split(' ');
                String[] lista = new String[palavras.Length];

                for (int i = 0; i < palavras.Length; i++)
                {
                    bool adicionar = true;

                    for (int j = 0; j < lista.Length; j++)
                    {
                        if (palavras[i] == lista[j])
                        {
                            adicionar = false;
                        }
                    }

                    if (adicionar == true)
                    {
                        lista[i] = palavras[i];
                        Console.Write(lista[i] + " ");
                    }                    
                }
                Console.WriteLine("");                
            }
        }
    }
}
