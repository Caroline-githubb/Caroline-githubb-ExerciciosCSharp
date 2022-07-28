namespace Coleções
{
    public class ExercicioFor
    {
        public static void Main25(string[] args)
        {
            double valorInvestido = 1000.00;
            
            for(int i=1 ; i<=12 ; i++)
            {
                valorInvestido = valorInvestido*0.01+valorInvestido;
            }

            Console.WriteLine("O total do valor investido agora é: "+ valorInvestido);
        }
    }
}