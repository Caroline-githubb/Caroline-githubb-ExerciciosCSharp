namespace Coleções
{
    public class Multiplos
    {
        public static void Main19(string[] args)
        {
            int a = 0;
            int b = 5;
            string mensagem = "";

            while (a <= 100)
            {
                a = a + 1;

                if (a % b == 0)
                {
                    if (mensagem != "")
                    {
                        mensagem = mensagem + ", ";
                    }
                    mensagem += a;
                }
            }
            mensagem += " são multiplos de 5";
            Console.WriteLine(mensagem);
        }
    }
}