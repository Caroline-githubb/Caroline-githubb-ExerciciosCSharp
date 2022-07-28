namespace Coleções
{
    public class Notas
    {
        public static void Main11(string[] args)
        {
            System.Console.WriteLine("Nota 1º Bimestre: ");
            decimal nota1 = System.Convert.ToDecimal(Console.ReadLine());
            System.Console.WriteLine("Nota 2º Bimestre: ");
            decimal nota2 = System.Convert.ToDecimal(Console.ReadLine());
            decimal bimestres = 2;
            decimal somatoriaMedias = (nota1+nota2);
            decimal mediaTotal = somatoriaMedias/bimestres;
            

            if(mediaTotal>=6)
            {
                
                Console.WriteLine("Parabéns, você foi aprovado!!!");
                Console.WriteLine("A sua média foi: " + mediaTotal);
            }

            else
            {
                Console.WriteLine("Infelizmente, você foi reprovado!!!");
                Console.WriteLine("A sua média foi: " + mediaTotal);
            }
        }

    
    }
}