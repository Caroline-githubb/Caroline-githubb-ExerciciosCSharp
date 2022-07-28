namespace Coleções
{
    public class ExercicioSete
    {
        public static void Main34(string[] args)
        {
                        
            decimal numero = 100;
            decimal a = 2;  
            string mensagem = "";          

            while (numero <= 200)
            {                   
                if (numero >= 100 && numero <=200)
                {
                    if (numero % a != 0)
                    {
                        mensagem += numero + " ";
                    } 
                }
                numero++;
            }
            Console.WriteLine("numeros impares: {0}", mensagem);

            


        }
    }
}