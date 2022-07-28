namespace Coleções
{
    public class ExercicioCinco
    {
        public static void Main32(string[] args)
        {
            
            System.Console.WriteLine("Quantos números deseja digitar? ");
            int quantidadeNumeros = System.Convert.ToInt32(Console.ReadLine());

            decimal[] numeros = new decimal[quantidadeNumeros];
            int i = 0;
            decimal a = 0;
            decimal b = 0;
            decimal c = 0;
            decimal d = 0;


            for (i = 0; i < quantidadeNumeros; i++)
            {
                System.Console.WriteLine("Digite um número: ");
                numeros[i] = System.Convert.ToDecimal(Console.ReadLine());
                if (numeros[i] < 0)
                {
                    Console.WriteLine("Programa encerrado.");
                    return;
                }
            }

            for (i = 0; i < quantidadeNumeros; i++)
            {
                if (numeros[i] >= 0 && numeros[i] <= 25)
                {
                    a++;
                }
                if (numeros[i] >= 26 && numeros[i] <= 50)
                {
                    b++;
                }
                if (numeros[i] >= 51 && numeros[i] <= 75)
                {
                    c++;
                }
                if (numeros[i] >= 76 && numeros[i] <= 100)
                {
                    d++;
                }

            }
            Console.WriteLine("Quantidades de números no intervalor de 0-25: " + a);
            Console.WriteLine("Quantidades de números no intervalor de 26-50: " + b);
            Console.WriteLine("Quantidades de números no intervalor de 51-75: " + c);
            Console.WriteLine("Quantidades de números no intervalor de 76-100: " + d);

        }
    }
}