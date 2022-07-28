namespace Coleções
{
    public class Idade
    {
        public static void Main4(string[] args)
        {
            System.Console.WriteLine("Escreva a sua idade em anos: ");
            int idade = System.Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Escreva quantos meses se passaram do seu ultimo aniversário: ");
            int meses = System.Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Escreva quantos dias se passaram para completar mais um mês: ");
            int dias = System.Convert.ToInt32(Console.ReadLine());

            int idadeDias = (idade*365)+(meses*30)+dias;

            System.Console.WriteLine("Idade em dias: "+ idadeDias + "dias");
        


        }


    }
}