namespace Coleções
{
    public class TesteFaculdadeSeis
    {
        static void Main72(string[] args)
        {
            int[ , ] matriz = new int [3,2];

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    (matriz[j,i]) = int.Parse(Console.ReadLine());
                }
            }

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[j,i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            

        }
    }
}