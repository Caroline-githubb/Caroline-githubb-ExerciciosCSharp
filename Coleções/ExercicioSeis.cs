namespace Coleções
{
    public class ExercicioSeis
    {
        public static void Main32(string[] args)
        {          
            System.Console.WriteLine("Qual a quantidade de números que deseja digitar? ");
            int quantidadeNumeros = System.Convert.ToInt32(Console.ReadLine());

            decimal[] numeros = new decimal[quantidadeNumeros];
            int i = 0;
            int a = 2;
            decimal totalPar = 0;
            decimal totalImpar = 0;
            decimal somaPares = 0;
            decimal somaImpares = 0;
            decimal mediaPares = 0;
            decimal mediaGeral = 0;

            numeros = lerNumeros(quantidadeNumeros);

            for (i = 0; i < quantidadeNumeros; i++)
            {

                if (numeros[i] % a == 0)
                {
                    totalPar++;
                    somaPares = somaPares + numeros[i];
                }

                else
                {
                    totalImpar++;
                    somaImpares = somaImpares + numeros[i];
                }

            }

            mediaPares = media(somaPares, totalPar);
            mediaGeral = somaPares + somaImpares;

            Console.WriteLine("Quantidade de números Pares: " + totalPar);
            Console.WriteLine("Quantidade de números Impares: " + totalImpar);
            Console.WriteLine("Media dos números Geral: " + mediaGeral);
        }

        public static decimal media(decimal numero, decimal total) {
            if (total == 0) {
                return 0;
            }
            return numero / total;
        }

        public static decimal[] lerNumeros(int quantidadeNumeros) {
            decimal[] numeros = new decimal[quantidadeNumeros];

            for (int i = 0; i < quantidadeNumeros; i++)
            {
                System.Console.WriteLine("Digite um número positivo: ");
                numeros[i] = System.Convert.ToDecimal(Console.ReadLine());

                if (numeros[i] == 0)
                {
                    Console.WriteLine("Programa encerrado.");
                    break;
                }

            }

            return numeros;
        }
    }
}