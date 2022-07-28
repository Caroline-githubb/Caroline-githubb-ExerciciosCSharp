namespace Ex03
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TIPO VALOR
            int a = 10;
            Calculadora.Triple(a);
            Console.WriteLine(a); //imprimira 10

            //TIPO REF
            int b = 10;
            Calculadora.Triple2(ref b);
            Console.WriteLine(b); //imprimira 30

            //TIPO OUT
            int c = 10;
            int triple;
            Calculadora.Triple3(c, out triple); //passa a variavel, e com o out é onde queremos guardar a variavel
            Console.WriteLine(triple); //imprimira 30
            Console.WriteLine(c); //imprimira 10

        }
    }

}