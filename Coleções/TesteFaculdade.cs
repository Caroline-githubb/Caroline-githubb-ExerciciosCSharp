using System;

namespace Coleções
{
    public class TesteFaculdade
    {
        static void Main67(string[] args)
        {
            int contador,maior, menor;
            maior = 0;
            menor = 0;
            bool primeiro = true;
           
            contador = 0;

            System.Console.WriteLine("qtde");
            int qtde = int.Parse(Console.ReadLine());          

            while(contador < qtde)
            {
                int num = int.Parse(Console.ReadLine());

                if (primeiro == true)
                {
                    maior = num;
                    menor = num;
                    primeiro = false;
                }

                else if (num > maior)
                {
                    maior = num;
                }

                else if (num < menor)
                {
                    menor = num;

                }

                contador++;            
               
            }  

            Console.WriteLine("maior" + maior);
            Console.WriteLine("menor" + menor);

        }
    }
}