using System;

namespace Coleções
{
    
    
    public class ArrayTres
    {
        private class Aluno
        {              
            public string Nome;
            public int Idade;
        }
        public static void Main46(string[] args)
        {           

            Aluno[] alunos = new Aluno[5];

            for(int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine("Digite o nome e a idade do aluno: ");
                alunos[i] = new Aluno();
                alunos[i].Nome = Console.ReadLine();
                alunos[i].Idade = Convert.ToInt32(Console.ReadLine());                
            }

            ArrayTres.OrdenarAlunosPorIdade(alunos);  
            ArrayTres.ExibirAlunos(alunos);                     

        }

        private static void OrdenarAlunosPorIdade(Aluno[] alunos)
        {   
            for(int i = 0; i < alunos.Length; i++)
            {
                Aluno aux = null;                

                for(int j = i+1 ; j < alunos.Length; j++)
                {
                    if (alunos[i].Idade > alunos[j].Idade)
                    {
                        aux = alunos[i];
                        alunos[i] = alunos[j];
                        alunos[j] = aux;                 
                    }                    
                }  
            } 
        }

        private static void ExibirAlunos(Aluno[] exibirAlunos)
        {
            for (int i = 0; i < exibirAlunos.Length; i++)
            {
                Console.WriteLine(exibirAlunos[i].Nome + " " + " tem " + exibirAlunos[i].Idade + " anos ");
                Console.WriteLine(" ");
            }
        }
    }
}