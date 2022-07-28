using System.Collections;

namespace Ex04_Listas
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2,"Marco"); //adiciona na posiçao que eu quero
            
            foreach(var obj in list)
            {
                Console.WriteLine(obj);
            }

            //retorna o tamanho da lista
            Console.WriteLine("List count: " + list.Count());
            
            //Recebe como argumento uma funcao que faz o teste
            //string s1 = list.Find(Test);
            
            //outra opcao sem usar funcao (expressao lambda)
            string? s1 = list.Find(x => x[0] == 'A'); //quero que me retorne a primeira palavra, cuja  a primeira letra inicia com A
            Console.WriteLine("First A: " + s1);

            string? s2 = list.FindLast(x => x[0] == 'A'); //quero que me retorne a ultima palavra, cuja  a primeira letra inicia com A
            Console.WriteLine("Last A: " + s2);

            //Encontrar a posicao da primeira palavra iniciada com A
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First Position  A: " + pos1);
            
            //Encontrar a posicao da ultima palavra iniciada com A
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last Position  A: " + pos2);

            //Filtrar os nomes que possuem ate 5 letras
            //Sera criado uma lista somente com os nomes desejados
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-------------------------");
            foreach(var obj in list)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("-------------------------");
            foreach(var obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-------------------------");

            foreach(var obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remove pela posicao
            list.RemoveAt(2);
            Console.WriteLine("-------------------------");
            foreach(var obj in list)
            {
                Console.WriteLine(obj);
            }

            //Remove os elementos de uma faixa
            list.RemoveRange(2,2);//Quero que ele remove a partir da posicao 2, dois elementos
            Console.WriteLine("-------------------------");
            foreach(var obj in list)
            {
                Console.WriteLine(obj);
            }





            // static bool Test(string s)
            // {
            //     return s[0] == 'A';
            // }


        }
    }

}