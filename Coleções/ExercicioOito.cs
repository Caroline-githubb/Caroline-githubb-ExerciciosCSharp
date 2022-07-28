namespace Coleções
{
    public class ExercicioOito
    {
        public static void Main35(string[] args)
        {            
            System.Console.WriteLine("Digite um valor N: ");
            decimal N = System.Convert.ToDecimal(Console.ReadLine());            
            decimal tabuada = 0;

            Console.WriteLine("Tabuada do número " + N + ": ");
            for (int i = 0; i <=10; i++)
            {
                tabuada = N*i;
                Console.WriteLine(N + "*" + i + " = " + tabuada );
            }                                                    
        
        }
    }
}