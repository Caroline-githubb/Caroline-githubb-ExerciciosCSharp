using System;

namespace Coleções
{
    public class TesteNove
    {
        public static void Main44(string[] args)
        {
            string palavra1 = Console.ReadLine(); //insira suas variaveis
            string palavra2 = Console.ReadLine();
            string palavra3 = Console.ReadLine();

            if ((palavra1 == "vertebrado") && (palavra2 == "ave") && (palavra3 == "carnivoro"))
            {
                Console.WriteLine("aguia\n"); //complete o desafio
            }

            if ((palavra1 == "vertebrado") && (palavra2 == "ave") && (palavra3 == "onivoro"))
            {
                Console.WriteLine("pomba\n"); //complete o desafio
            }

            if ((palavra1 == "vertebrado") && (palavra2 == "mamifero") && (palavra3 == "onivoro"))
            {
                Console.WriteLine("homem\n");   //complete o desafio
            }

            if ((palavra1 == "vertebrado") && (palavra2 == "mamifero") && (palavra3 == "herbivoro"))
            {
                Console.WriteLine("vaca\n");
            }

            if ((palavra1 == "invertebrado") && (palavra2 == "inseto") && (palavra3 == "hematofago")) 
            {
                Console.WriteLine("pulga\n");
            }

            if ((palavra1 == "invertebrado") && (palavra2 == "inseto") && (palavra3 == "herbivoro")) 
            {
                Console.WriteLine("lagarta\n");
            }

            if ((palavra1 == "invertebrado") && (palavra2 == "anelideo") && (palavra3 == "hematofago"))
            {
                Console.WriteLine("sanguessuga\n");
            }

            if ((palavra1 == "invertebrado") && (palavra2 == "anelideo") && (palavra3 == "onivoro"))
            {
                Console.WriteLine("minhoca\n");
            }
        }
    }
}