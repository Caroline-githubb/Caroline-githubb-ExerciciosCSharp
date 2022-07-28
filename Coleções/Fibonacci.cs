namespace Coleções
{
    public class Fibonacci
    {
        public static void Main20(string[] args)
        {
            int anterior = 0;
            int atual = 1;
            int aux = 0;
        
            Console.Write(anterior + " ");
            while(atual<=100)
            {
                Console.Write(atual + " ");
                aux = atual;
                atual = anterior + atual;
                anterior = aux;
            }
            Console.WriteLine(" ");
            
        }
    }
}
