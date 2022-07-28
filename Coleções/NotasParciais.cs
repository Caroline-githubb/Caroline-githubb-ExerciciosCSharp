namespace Coleções
{
    public class NotasParciais
    {
        public static void Main15(string[] args)
        {
            System.Console.WriteLine("Digite sua nota do 1º Bimestre: ");
            decimal nota1 = System.Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("Digite sua nota do 1º Bimestre: ");
            decimal nota2 = System.Convert.ToDecimal(Console.ReadLine());
            decimal somaNotas = nota1 + nota2;
            decimal media = somaNotas / 2;

            if (media == 10)
            {
                Console.WriteLine("APROVADO COM DISTINÇÃO!!!");
            }

            else if (media >= 7)
            {
                Console.WriteLine("APROVADO!!");
            }
            else
            {
                Console.WriteLine("REPROVADO!!!");
            }



        }
    }
}