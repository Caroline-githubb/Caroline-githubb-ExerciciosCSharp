namespace Coleções
{
    public class TesteQuatro
    {
        public static void Main32(string[] args)
        {
            System.Console.WriteLine("raio : ");
            double raio = System.Convert.ToDouble(Console.ReadLine());
            double elevado = 2;
            double pi = 3.14159;
            double area;

            raio = Math.Pow(raio, elevado);
            area = pi*raio;
            Console.WriteLine("A=" + area.ToString("0.0000"));






        }
    }
}