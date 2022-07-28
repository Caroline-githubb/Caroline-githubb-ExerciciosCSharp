namespace Coleções
{
    public class TesteFaculdadeQuatro
    {
        static void Main70(string[] args)
        {

            int contador = 0;
            int num = 0;
            int maior = 0;
            int menor = 0;
            bool primeiro = true;         
            double media = 0;
            
            num = int.Parse(Console.ReadLine());

            while(num > 0)
            {
                
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
                media+= num;
                
                num = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Média: " + (media/contador));
            Console.WriteLine("Maior número: " + maior);
            Console.WriteLine("Menor número: " + menor);

             
        }
    }
}