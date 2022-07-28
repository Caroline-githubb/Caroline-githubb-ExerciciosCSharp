namespace Coleções
{
    public class TesteFaculdadeCinco
    {
        static void Main71(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Tabuada do "+ i);
                for(int j = 1; i <= 10;i++)
                {
                    Console.WriteLine(i + " X " + j + " = " + i*j);
                }
            }
        }
    }
}