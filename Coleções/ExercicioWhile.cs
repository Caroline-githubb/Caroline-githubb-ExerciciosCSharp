namespace Coleções
{
    public class ExercicioWhile
    {
        public static void Main26(string[] args)
        {
            double valorInvestido = 1000.00;
            int meses = 1;
            
            while(meses<=12)
            {
                valorInvestido = valorInvestido*0.01+valorInvestido;
                meses++;
            }
            Console.WriteLine("O total do valor investido agora é: "+ valorInvestido);

        }
    }
}