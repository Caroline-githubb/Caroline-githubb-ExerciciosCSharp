namespace Coleções
{
    public class SalarioVendedor
    {
        public static void Main7(string[] args)
        {
            System.Console.WriteLine("Salário fixo: ");
            double salarioFixo = System.Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Comissão por carro vendido: ");
            double comissaoFixa = System.Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Número de carros vendidos: ");
            double carrosVendidos = System.Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Valor total das vendas: ");
            double totalVendido = System.Convert.ToDouble(Console.ReadLine());
            double comissaototalVendido = 5.0/100.0;

            double comissaoValorTotal = totalVendido*comissaototalVendido;
            double comissaoFixaVeiculos = comissaoFixa*carrosVendidos;
            double salarioFinal = salarioFixo+comissaoValorTotal+comissaoFixaVeiculos;

            System.Console.WriteLine("Salário final do vendedor: R$ " + Math.Round(salarioFinal));

        }
    }
}