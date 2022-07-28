namespace Coleções.ListaPUC
{
    public class PucTreze
    {
        public static void Main63(string[] args)
        {            
            System.Console.WriteLine("Digite um número");
            int n = Convert.ToInt32(Console.ReadLine());
            int fatorial;
            int aux= n;
            string mensagem = " ";
                        
            for(int i = n-1; i >= 1; i--)
            {                   
                fatorial = aux * i;
                aux = fatorial; 
                Console.WriteLine($"Fatorial = {aux} * {i} = {fatorial}");                               
            }
            
        }
    }
}