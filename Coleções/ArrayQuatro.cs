using System;

namespace Coleções
{
    public class ArrayQuatro
    {
        private class Aluno
        {
            public string Nome;
            public int Idade;
        }
        public static void Main47(string[] args)
        {
            Aluno[] aluno = new Aluno[1];

            ArrayQuatro.CriarExibirAluno(aluno);

        }

        private static void CriarExibirAluno(Aluno[] aluno)
        {
            for (int i = 0; i < aluno.Length; i++)
            {
                Console.WriteLine("Digite o nome e a idade do aluno: ");
                aluno[i] = new Aluno();
                aluno[i].Nome = Console.ReadLine();
                aluno[i].Idade = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < aluno.Length; i++)
            {
                Console.WriteLine(aluno[i].Nome + " " + " tem " + aluno[i].Idade + " anos ");
                Console.WriteLine(" ");
            }           

        }


    }
}