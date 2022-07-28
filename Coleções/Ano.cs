namespace Coleções
{
    public class Ano
    {
        public static void Main12(string[] args)
        {
            System.Console.WriteLine("Digite o ano em que nasceu: ");
            int anoNascimento = System.Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Digite o ano em que está atualmente: ");
            int anoAtual = System.Convert.ToInt32(Console.ReadLine());
            int idade = anoAtual-anoNascimento;

            if(idade>=16)
            {
                Console.WriteLine("PODE VOTAR!!!");
              
            }

            else
            {
                Console.WriteLine("NÃO PODE VOTAR!!!");
            }

        }
    }
}