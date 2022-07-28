
namespace Coleções
{
    public class Primo
    {
        public static void Main21(string[] args)
        {
            Console.WriteLine("VERIFIQUE SE UM NÚMERO É PRIMO!!!");
            System.Console.WriteLine("Digite um número: ");
            int numero = System.Convert.ToInt32(Console.ReadLine());
            int checador = numero - 1;
            int divisores = 0;
            
            while (checador > 1)
            {
                if (numero % checador == 0)
                {
                    divisores = divisores + 1;
                }

                checador = checador - 1;
            }

            if (divisores > 0) {
                Console.WriteLine("Esse numero nao e primo");
            } else {
                Console.WriteLine("Esse numero e primo");
            }

        }

    }

}



