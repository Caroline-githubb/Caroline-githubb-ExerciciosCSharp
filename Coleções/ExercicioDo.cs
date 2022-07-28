namespace Coleções
{
    public class ExercicioDo
    {
        public static void Main27(string[] args)
        {
            double valorInvestido = 1000.00;
            int meses = 1;

            do
            {
                valorInvestido = valorInvestido*0.01+valorInvestido;
                meses++;
            }
            while(meses<=12);
            Console.WriteLine("O total do valor investido agora é: "+ valorInvestido);
        }
    }
}