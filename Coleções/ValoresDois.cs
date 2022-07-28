namespace Coleções
{
    public class ValoresDois
    {
        public static void Main14(string[] args)
        {
            System.Console.WriteLine("Escreva o valor de X: ");
            decimal x = System.Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("Escreva o valor de Y: ");
            decimal y = System.Convert.ToDecimal(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine(x + "," + y);
            }

            else
            {
                if (y > x)
                {
                    Console.WriteLine(y + "," + x);
                }

                if (x == y)
                {
                    Console.WriteLine("Os valores de X e Y, não podem ser iguais!!!");
                }
            }
        }
    }
}