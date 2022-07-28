using System;

namespace Coleções
{
    public class ArrayDois
    {
        public static void Main45(string[] args)
        {
            //Escreva uma aplicação que leia dois vetores, nome de 10 estudantes e sua respectiva idade.
            //Ordene os vetores e informe qual é o estudante mais velho e o mais novo.

            string[] nomeEstudante = new string[10];
            int[] idadeEstudante = new int[10];
            

            Console.WriteLine("Digite o nome e idade de 10 estudantes: ");

            for(int i = 0; i < nomeEstudante.Length; i++)
            {
                Console.WriteLine("Estudante: ");
                nomeEstudante[i] = Console.ReadLine();

                Console.WriteLine("Idade: ");
                idadeEstudante[i] = Convert.ToInt32(Console.ReadLine());    
            }

            for(int i = 0; i < idadeEstudante.Length; i++)
            {
                int auxIdade = 0;
                string auxNome = "";

                for(int j = i+1 ; j < idadeEstudante.Length; j++)
                {
                    if (idadeEstudante[i] > idadeEstudante[j])
                    {
                        auxIdade = idadeEstudante[i];
                        idadeEstudante[i] = idadeEstudante[j];
                        idadeEstudante[j] = auxIdade;

                        auxNome = nomeEstudante[i];
                        nomeEstudante[i] = nomeEstudante[j];
                        nomeEstudante[j] = auxNome;                    
                    }                    
                }   
            }

            for (int i = 0; i < idadeEstudante.Length; i++) 
            {
                Console.WriteLine(nomeEstudante[i] + " " + idadeEstudante[i] + " anos");                                   
            }   
            Console.WriteLine(" ");

            Console.WriteLine("Estudante mais novo: " + nomeEstudante[0] + " com " + idadeEstudante[0] + " anos ");
            Console.WriteLine("Estudante mais velho: " + nomeEstudante[9] + " com " + idadeEstudante[9] + " anos ");

             

            

            


            

        }

    }
}