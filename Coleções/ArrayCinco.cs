namespace Coleções
{
    public class ArrayCinco
    {
        private class Aluno
        {
            public string Nome;
            public int Idade;
        }
        public static void Main48(string[] args)
        {

            Aluno[] alunos = new Aluno[5];

            for (int i = 0; i < alunos.Length; i++)
            {
                alunos[i] = LerAluno();
            }
            
            OrdenarSort(ref alunos);
            ArrayCinco.ExibirAlunos(alunos);

        }

        private static Aluno LerAluno()
        {
            Console.WriteLine("Digite o nome e a idade do aluno: ");
            
            Aluno aluno = new Aluno();
            aluno.Nome = Console.ReadLine();
            aluno.Idade = Convert.ToInt32(Console.ReadLine());

            return aluno;
        }

        private static void OrdenarSort(ref Aluno[] alunos)
        {
            alunos = alunos.OrderBy(x => x.Idade).ToArray();
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