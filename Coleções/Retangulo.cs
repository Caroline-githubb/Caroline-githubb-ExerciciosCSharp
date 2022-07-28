namespace Coleções
{
    public class Retangulo
    {
        
        public static void Main2(string[] args) 
        {
            System.Console.WriteLine("Digite a base do retangulo: ");
            int Base = System.Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Digite a altura do retangulo: ");
            int Altura = System.Convert.ToInt32(Console.ReadLine());

            int area = Base*Altura;
            
            System.Console.WriteLine("Resultado da área: " + area.ToString() + " m² ");

        }
    }
}