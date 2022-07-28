namespace Coleções
{
    public class TesteSete
    {
        public static void Main41(string[] args)
        {   
            System.Console.WriteLine("Digite um mês: ");
            int mes = System.Convert.ToInt32(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:                 //continue o código com sua solução
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                  break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Digite um número válido de 1 a 12");
                    break;
            }
            Console.ReadLine();
        }
    }
}