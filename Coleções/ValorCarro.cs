namespace Coleções
{
    public class ValorCarro
    {
        public static void Main6(string[] args)
        {
            System.Console.WriteLine("Custo de fábrica: ");
            double custoFabrica = System.Convert.ToDouble(Console.ReadLine());
            double impostoDistribuidor = 28.0/100.0;
            double impostoGeral = 45.0/100.0;
            

            double totalImpostos = impostoDistribuidor+impostoGeral;
            double custoTotal = custoFabrica/(1-totalImpostos);

            System.Console.WriteLine("Custo final ao consumidor: R$ " + Math.Round(custoTotal));

        }
    }
}