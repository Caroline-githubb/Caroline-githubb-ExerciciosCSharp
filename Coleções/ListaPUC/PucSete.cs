using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Coleções.ListaPUC
{
    public class PucSete
    {
        private class Aluno
        {
            public int Codigo;
            public List<decimal> Notas = new List<decimal>();
        }

        public static void Main58(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();
            Aluno codigo;

            do
            {
                codigo = LerAluno();

                if (codigo != null)
                {
                    alunos.Add(codigo);
                    var media = codigo.Notas.Average();
                    Console.WriteLine("A média é: " + Math.Round(media, 2));
                }

            } while (codigo != null);

        }

        private static Aluno LerAluno()
        {
            System.Console.WriteLine("Digite o código do aluno: ");
            Aluno aluno = new Aluno();
            aluno.Codigo = int.Parse(Console.ReadLine());
            if (aluno.Codigo <= 0)
            {
                return null;
            }

            int contador = 1;

            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine($"Digite a nota {contador++}: ");
                aluno.Notas.Add(decimal.Parse(Console.ReadLine()));

            }
            return aluno;
        }




    }





}