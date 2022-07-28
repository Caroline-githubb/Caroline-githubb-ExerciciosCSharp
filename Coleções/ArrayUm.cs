namespace Coleções
{
    public class ArrayUm
    {
        public static void Main44(string[] args)
        {
            int[] numeros = new int[10];
            int[] pares = new int[10];
            int[] impares = new int[10];
            int aux = 0;

            System.Console.WriteLine("Informe 10 numeros maiores que zero: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
                                
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                for ( int j = i; j < numeros.Length;j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }                   
                }
                
            } 
            
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    pares[i] = numeros[i];                   
                }
                else
                {
                    impares[i] = numeros[i];
                }
            }

            Console.WriteLine("Os números escolhidos foram: ");
            for (int i = 0; i < numeros.Length; i++) 
            {
                Console.Write(numeros[i] + " ");                   
            }   
            Console.WriteLine("");    

            Console.WriteLine("Os números pares são:  ");
            for (int i = 0; i < pares.Length; i++) 
            {
                if(pares[i] != 0)
                {
                    Console.Write(pares[i] + " ");  
                }                         
            }   
            Console.WriteLine("");    

            Console.WriteLine("Os números impares são: ");
            for (int i = 0; i < impares.Length; i++) 
            {
                if(impares[i] != 0)
                {
                    Console.Write(impares[i] + " ");  
                }                                 
            }   
            Console.WriteLine("");     

            
              
            

            
            
        }
    }
}