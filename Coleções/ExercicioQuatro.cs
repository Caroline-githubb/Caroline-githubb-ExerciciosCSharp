namespace Coleções
{
    public class ExercicioQuatro
    {
        public static void Main33(string[] args)
        {
            System.Console.WriteLine("Quantos números deseja digitar?");
            int quantidadeNumeros = System.Convert.ToInt32(Console.ReadLine());

            decimal[] array = new decimal[quantidadeNumeros];
            decimal soma = 0;
            decimal media = 0;
            int i = 0;
            decimal positivo = 0;
            decimal negativo = 0;

            for (i = 0; i < quantidadeNumeros; i++)
            {
                System.Console.WriteLine("Digite um número: ");
                array[i] = System.Convert.ToInt32(Console.ReadLine());
            }

            soma = array[0];

            for (i = 1; i < quantidadeNumeros; i++)
            {
                soma = soma + array[i];
            }
            Console.WriteLine("Somatoria dos números: " + soma);

            media = soma / quantidadeNumeros;
            Console.WriteLine("Média dos números: " + media);

            for (i = 0; i < quantidadeNumeros; i++)
            {
                if (array[i] >= 0)
                {
                    positivo++;
                }
            }
            negativo = quantidadeNumeros - positivo;
            Console.WriteLine("Positivos: " + positivo);
            Console.WriteLine("Negativos: " + negativo);

            decimal percentualTotal = quantidadeNumeros;
            percentualTotal = 100;
            decimal percentualPositivo = positivo;
            decimal percentualNegativo = negativo;
            percentualPositivo = (positivo * percentualTotal) / quantidadeNumeros;
            Console.WriteLine("Percentual de números positivos: " + percentualPositivo + "%");
            percentualNegativo = (negativo * percentualTotal) / quantidadeNumeros;
            Console.WriteLine("Percentual de números negativos: " + percentualNegativo + "%");

        }
    }
}