namespace Coleções
{
    public class TesteFaculdadeDois
    {
        static void Main68(string[] args)
        {
            int par = 0;
            int impar = 0;
            int soma = 0;   
            int num = 0;  
            int contador = 0;       

            num = int.Parse(Console.ReadLine());

            while(num != 0)
            {
                
                if(num % 2 == 0)
                {
                    par+=1;
                }

                else
                {
                    impar+=1;
                }

                soma+= num;
                contador++;
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("quantidade de numeros: " + (contador));
            Console.WriteLine("quantidade de numeros pares: " + par);
            Console.WriteLine("quantidade de impares: " + impar);
            Console.WriteLine("média: " + soma/contador);


            


            
        }
    }
}