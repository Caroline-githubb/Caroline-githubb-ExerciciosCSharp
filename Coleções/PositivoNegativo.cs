namespace Coleções
{
    public class PositivoNegativo
    {
        public static void Main9(string[] args)
        {
            System.Console.WriteLine("Escreva um valor: ");
            decimal valor = System.Convert.ToDecimal(Console.ReadLine());

            if(valor >= 0)
                Console.WriteLine("VALOR POSITIVO!!!");
            else
                Console.WriteLine("VALOR NEGATIVO!!!");
        }
    }
}