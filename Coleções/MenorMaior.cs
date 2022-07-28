namespace Coleções
{
    public class MenorMaior
    {
        public static void Main18(string[] args)
        {

            System.Console.WriteLine("Quantos numeros voce quer digitar?");
            int quantidadeNumeros = System.Convert.ToInt32(Console.ReadLine());

            decimal[] array = new decimal[quantidadeNumeros];
            int passo = 0;

            while (passo < quantidadeNumeros)
            {
                System.Console.WriteLine("Escreva o valor de numero " + passo + ": ");
                array[passo] = System.Convert.ToDecimal(Console.ReadLine());

                passo = passo + 1;
            }

            decimal maior = array[0];
            decimal menor = array[0];

            passo = 1;
            while (passo < quantidadeNumeros)
            {
                if (array[passo] > menor) {
                    maior = array[passo];
                }

                if (array[passo] < maior) {
                    menor = array[passo];
                }

                passo = passo + 1;
            }

            Console.WriteLine("Maior número: " + maior);
            Console.WriteLine("Menor número: " + menor);

        }
    }
}