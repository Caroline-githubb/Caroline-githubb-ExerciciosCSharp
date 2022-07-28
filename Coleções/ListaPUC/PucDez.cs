using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Coleções.ListaPUC
{
    public class PucDez
    {
        private class Aluno
        {
            public int Codigo;
            public List<decimal> Notas = new List<decimal>();
        }

        public static void Main61(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();
            Aluno codigo;
            
            do
            {
                codigo = LerAluno();

                if (codigo != null)
                {
                    alunos.Add(codigo);
                    decimal notaUm = codigo.Notas[0] * 4;
                    decimal notadois = codigo.Notas[1] * 3;
                    decimal notaTres = codigo.Notas[2] * 3;
                    decimal mediaPonderada = (notaUm + notadois + notaTres) / 10;

                    if(mediaPonderada > 5)
                    {
                        Console.WriteLine($"Média nota 1: {codigo.Notas[0] / 4}");
                        Console.WriteLine($"Média nota 2: {codigo.Notas[1] / 3}");
                        Console.WriteLine($"Média nota 3: {codigo.Notas[2] / 3}");
                        Console.WriteLine($"Média final: {mediaPonderada}");
                        Console.WriteLine("\n APROVADO!!!!\n");
                        
                    }
                    else
                    {
                        Console.WriteLine($"Média nota 1: {codigo.Notas[0] / 4}");
                        Console.WriteLine($"Média nota 2: {codigo.Notas[1] / 3}");
                        Console.WriteLine($"Média nota 3: {codigo.Notas[2] / 3}");
                        Console.WriteLine($"Média final: {mediaPonderada}");
                        Console.WriteLine("\n REPROVADO!!!\n");
                    }
                    
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