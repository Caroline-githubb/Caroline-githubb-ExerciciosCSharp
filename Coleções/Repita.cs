

namespace Coleções
{
    public class Repita
    {
        public static void Main23(string[] args)
        {

            int numeroX;
            int numeroY;

            System.Console.WriteLine("Digite um número X: ");
            numeroX = System.Convert.ToInt32(Console.ReadLine());

            do
            {
                System.Console.WriteLine("Digite um número Y desde que ele não seja 0: ");
                numeroY = System.Convert.ToInt32(Console.ReadLine());
            }
            while (numeroY != 0);

            if (numeroY == 0)
            {
                Console.WriteLine("VALOR INVÁLIDO");
            }

            else
            {
                int divisao = numeroX / numeroY;
                Console.WriteLine("A divisão de de X por Y=  " + divisao);
            }

        }
    }
}