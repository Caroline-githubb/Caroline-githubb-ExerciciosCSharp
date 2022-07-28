namespace Ex03
{
    public class Calculadora
    {
        public static void Triple(int x)
        {
            x = x*3;
        }

        public static void Triple2(ref int x)
        {
            x = x*3;
        }

        public static void Triple3(int origin, out  int result)
        {
            result = origin * 3;
        }
        
    
    
    
    }
}