namespace Coleções
{
    public class TresNumeros
    {
        public static void Main45(string[] args)
        {            
            System.Console.WriteLine("Escreva X: ");
            int numeroX = System.Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Escreva X: ");
            int numeroY = System.Convert.ToInt32(Console.ReadLine()); 
            System.Console.WriteLine("Escreva X: ");       
            int numeroZ = System.Convert.ToInt32(Console.ReadLine());
            int aux = 0;

            if (numeroX > numeroY)
            {
                aux = numeroX;
                numeroX = numeroY;
                numeroY = aux;
            }

            if(numeroX > numeroZ)
            {
                aux = numeroX;
                numeroX = numeroZ;
                numeroZ = aux;
            }            

            if(numeroY > numeroZ)
            {
                aux = numeroY;
                numeroY = numeroZ;
                numeroZ = aux;
            }

            Console.WriteLine(numeroX + " " + numeroY + " " + numeroZ);

            
            




        }
    }
}