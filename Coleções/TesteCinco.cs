namespace Coleções
{
    public class TesteCinco
    {
        public static void Main40(string[] args)
        {
            System.Console.WriteLine("n: ");
            double n = Convert.ToDouble(Console.ReadLine());

            for (double i = 1; i <= n; i++)
            {
                double x = i;
                double y = i;
                double z = i;
                double elevadoY = 2;
                double elevadoZ = 3;

                y = Math.Pow(i, elevadoY);
                z = Math.Pow(i, elevadoZ);
                Console.WriteLine(i + " " + y + " " + z);

                y = y + 1;
                z = z + 1;
                Console.WriteLine(i + " " + y + " " + z);
            }
        }
    }
}
