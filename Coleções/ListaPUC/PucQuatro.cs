namespace Coleções.ListaPUC
{
    public class PucQuatro
    {
        public static void Main54(string[] args)
        {            
            double chico = 1.50;
            double ze = 1.10;
            int contador = 1;

            do
            {
                chico = chico + 0.02;
                ze = ze + 0.03;
                if(ze <= chico)
                {
                    contador++;
                }
            }while(chico > ze);

            Console.WriteLine($"Para que Zé seja maior que Chico, serão necessários {contador} anos");
        }
    }
}