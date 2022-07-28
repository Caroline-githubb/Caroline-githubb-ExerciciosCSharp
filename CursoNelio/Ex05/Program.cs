namespace Ex05
{
    public class Program
    {
        static void Main(string[] args)
        {
            // double[,] mat = new double[2,3];

            // //Quantidade de elementos no total
            // Console.WriteLine(mat.Length);

            // //Quantidade da primeira dimensao da matriz(2)
            // Console.WriteLine(mat.Rank);

            // //a dimensao 0 da matriz tem tamanho 2
            // Console.WriteLine(mat.GetLength(0));

            // //a dimensao 1 da matriz tem tamanho 3
            // Console.WriteLine(mat.GetLength(1));

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);
        }
    }
}