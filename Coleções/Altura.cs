namespace Coleções
{
    public class Altura
    {
        public static void Main30(string[] args)
        {
            decimal[] array = new decimal[4];
            int i = 0;
            decimal maior = 0;
            decimal menor = 0;
            
            for (i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine("Digite a altura da Pessoa " + (i++) + ": ");
                array[i] = System.Convert.ToDecimal(Console.ReadLine());
            }

            i=0;
            maior = array[0];
            menor = array[0];

            for (i = 1 ; i < array.Length; i++)
            {
                if (array[i] > maior)
                {
                    maior = array[i];
                }
                if (array[i] < menor)
                {
                    menor = array[i];
                }
            }
            System.Console.WriteLine("maior: " + maior);
            System.Console.WriteLine("menor: " + menor);
        }
    }
}