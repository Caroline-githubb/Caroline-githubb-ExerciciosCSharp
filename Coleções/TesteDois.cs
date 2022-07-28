namespace Coleções
{
    public class TesteDois
    {
        public static void Main37(string[] args)
        {
            System.Console.WriteLine("Digite N: ");
            int N = System.Convert.ToInt32(Console.ReadLine());

            int primeiro = 1;
            int aux = primeiro;
            for (int i = 1; i <= N; i++)
            {
                for (int verificador = 0; verificador <= 3; verificador++)
                {
                    if (aux % 4 != 0)
                    {
                        Console.Write(aux + " ");
                    }
                    aux = primeiro + aux;

                }
                Console.Write("PUM");
                Console.WriteLine("");






            }



        }






    }
}
