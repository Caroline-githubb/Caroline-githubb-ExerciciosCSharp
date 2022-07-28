namespace Coleções
{
    public class Fruta
    {
        public static void Main10(string[] args)
        {
            System.Console.WriteLine("Quantas maças deseja comprar? ");
            double quantidade = System.Convert.ToDouble(Console.ReadLine());
            double valorUnitario = 1.30;
            double valorDuziaUnitaria = 1.00;

            if(quantidade >= 12)
            {
                double valorTotal = valorDuziaUnitaria*quantidade;
                Console.WriteLine("Valor total da compra: R$ " + valorTotal);
            } 

            else
            {
                double valorTotal2 = valorUnitario*quantidade;
                Console.WriteLine("Valor total da compra: R$ " + valorTotal2);
            }

        }
    }
}