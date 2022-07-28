namespace Coleções
{
    public class MaiorQue
    {
        public static void Main8(string[] args)
        {
            System.Console.WriteLine("Escreva um valor: ");
            decimal valor = System.Convert.ToDecimal(Console.ReadLine());

            if (valor == 10)
            {
                Console.WriteLine("VALOR IGUAL A 10");
            }
            else if (valor > 10)
            {
                Console.WriteLine("VALOR MAIOR QUE 10!!!");
            }
            else
            {
                Console.WriteLine("VALOR MENOR QUE 10!!!");
            }
        }
    }
}