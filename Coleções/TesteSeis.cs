namespace Coleções
{
    public class TesteSeis
    {
        public static void Main40(string[] args)
        {
            System.Console.WriteLine("n: ");
            int n = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n);

            int quociente, resto, nota;
            resto = n;

            nota = 100;
            quociente = resto / 100;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % 100;

            int nota2 = 50;
            quociente = resto / nota2;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota2},00");
            resto = resto % nota2;

            int nota3 = 20;
            quociente = resto / nota3;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota3},00");
            resto = resto % nota3;

            int nota4 = 10;
            quociente = resto / nota4;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota4},00");
            resto = resto % nota4;

            int nota5 = 5;
            quociente = resto / nota5;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota5},00");
            resto = resto % nota5;

            int nota6 = 2;
            quociente = resto / nota6;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota6},00");
            resto = resto % nota6;

            int nota7 = 1;
            quociente = resto / nota7;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota7},00");
            resto = resto % nota7;


        }
    }
}

