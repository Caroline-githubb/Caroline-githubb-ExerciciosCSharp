namespace Coleções
{
    public class MultiplosFor
    {
        public static void Main30(string[] args)
        {
            int a = 0;
            int b = 3;
            int c = 2;
            int soma = 0;

            for (a = 0; a <= 500; a++)
            {
                if (a % b == 0 && a % c != 0)
                {
                    soma += a;
                }
            }
            Console.WriteLine("A soma dos números impares de 0 a 500 e multiplos de 3: " + soma);

        }
    }
}