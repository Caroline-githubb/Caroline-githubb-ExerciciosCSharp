namespace Ex02
{
    public class Calculadora
    {
        public static int Sum(params int[] numbers) // Colocando a palavrinha params, não será necessário ficar instanciando o objeto na Program
        {
            int sum = 0;

            for(int i = 0; i <  numbers.Length;i++)
            {
                sum+=numbers[i];                
            }
            return sum;
        }
    
    }
}