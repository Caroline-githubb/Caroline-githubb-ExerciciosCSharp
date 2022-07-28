using System;


namespace Coleções.ListaPUC
{
    using System;

    public class PucUmMetodo
    {        
        private class Valores
        {
            public int a;
        }
        public static void Main49(string[] args)
        {            
            Valores[] a = new Valores[5];
            System.Console.WriteLine("Digite 5 valores: ");

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = LerNumero();
            }    
            
            quantidadeNegativo(ref a);                              
            
        }

        private static Valores LerNumero()
        {
            Valores a = new Valores();
            a.a = int.Parse(Console.ReadLine());
            return a;
        }
        private static void quantidadeNegativo(ref Valores[] negativo)
        {
            int contador = 0;
            for (int i = 0; i < negativo.Length; i++)
            {
                if (negativo[i].a < 0)
                {
                    contador = contador + 1;
                }
            }  
            Console.WriteLine("Quantidade de números negativos: " + contador.ToString());
        }      

     

        
        

           
        

       

         
           

            

        

    }
}