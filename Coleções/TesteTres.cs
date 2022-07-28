namespace Coleções
{
    public class TesteTres
    {
        public static void Main38(string[] args)
        {
            System.Console.WriteLine("digite n: ");
            int n = System.Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            { //escreva aqui o seu código
                Console.Write(i + " ");
                Console.Write(i * i + " ");
                Console.Write(i * i * i + " ");
                Console.WriteLine("");
            }


        }
    }    
}