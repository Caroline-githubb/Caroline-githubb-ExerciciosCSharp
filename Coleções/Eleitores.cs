namespace Coleções
{
    public class Eleitores
    {
        public static void Main5(string[] args)
        {
            System.Console.WriteLine("Número total de eleitores: ");
            decimal eleitores = System.Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("Número total de votos em branco: ");
            decimal votosBranco = System.Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("Número de votos nulos: ");
            decimal votosNulo = System.Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("Número de votos válidos: ");
            decimal votosValidos = System.Convert.ToDecimal(Console.ReadLine());

            decimal percentualBranco = (votosBranco*1/eleitores)*100;
            decimal percentualNulo = (votosNulo*1/eleitores)*100;
            decimal percentualValidos = (votosValidos*1/eleitores)*100;

            System.Console.WriteLine("Porcentagem de número de votos em brancos: " + percentualBranco + "%");
            System.Console.WriteLine("Porcentagem de número de votos em nulos: " + percentualNulo + "%");
            System.Console.WriteLine("Porcentagem de número de votos validos: " + percentualValidos + "%");
            
            
        }

    }
}