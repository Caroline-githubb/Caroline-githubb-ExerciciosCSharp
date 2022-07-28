namespace Coleções
{
    public class RepitaEnquanto
    {
        public static void Main24(string[] args)
        {
            System.Console.WriteLine("Digite um número X: ");
            int numero01 = System.Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Digite um número Y: ");
            int numero02 = System.Convert.ToInt32(Console.ReadLine());
            int divisao;

            while (numero02 == 0)
            {
                Console.WriteLine("VALOR INVÁLIDO");                                
                return;
            }

            divisao = numero01 / numero02;
            Console.WriteLine("A divisão de X por Y é igual a " + divisao);
        }
    }
}