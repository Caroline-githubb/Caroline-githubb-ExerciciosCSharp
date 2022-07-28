namespace Coleções
{
    public class teste
    {
        public static void Main36(string[] args)
        {
            System.Console.WriteLine("digite N: ");
            int N = System.Convert.ToInt32(Console.ReadLine());
            string mensagem = "";
            string mensagem2 = "";
            
            for (int i = 0; i < N; i++)
            {                             
                if (mensagem == "")
                {   
                    mensagem = "Ho";
                    mensagem = mensagem + " ";
                }
                mensagem2 = mensagem + mensagem2;                                
            }
            mensagem2 = mensagem2.TrimEnd() + "!";
            Console.WriteLine(mensagem2);            
        }
    }
}