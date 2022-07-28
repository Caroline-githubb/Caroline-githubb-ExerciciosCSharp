namespace Coleções
{
    public class Valores
    {
        public static void Main13(string[] args)
        {
            System.Console.WriteLine("Valor A: ");
            decimal a = System.Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("Valor B: ");
            decimal b = System.Convert.ToDecimal(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a + " é maior que " + b);
            }

            else
            {
                if (b > a)
                {
                    Console.WriteLine(b + "é maior que " + a);
                }
                if (a == b)
                {
                    Console.WriteLine("Os valores de A e B não podem ser iguais!!!");
                }
            }
        }


    }
}