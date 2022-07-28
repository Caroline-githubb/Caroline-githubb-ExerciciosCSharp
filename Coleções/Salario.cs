namespace Coleções
{
    public class Salario
    {
        public static void Main3( string[] args)
        {
            System.Console.WriteLine("Digite o seu salário: ");
            int salarioAtual = System.Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Digite o percentual de reajuste: ");
            decimal percentual = System.Convert.ToDecimal(Console.ReadLine());

            decimal salarioNovo = (salarioAtual*percentual)+salarioAtual;

            System.Console.WriteLine("Salário novo: R$ " + salarioNovo);


        }

    }
}