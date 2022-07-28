using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Coleções.ListaPUC
{
    public class PucTresMetodo
    {
        private class Pessoa
        {
            public string Nome;
            public decimal Filho;
            public decimal Salario;
        }
        public static void Main53(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            Pessoa pessoa;
            
            do
            {
                pessoa = LerPessoa();
                pessoas.Add(pessoa);
            } while (pessoa.Salario > 0);

            Console.WriteLine("Média de salario por pessoa: " + Math.Round(MediaSalario(pessoas), 2));
            Console.WriteLine("Média de número de filhos por pessoa: " + Math.Round(MediaFilho(pessoas), 2));
            Console.WriteLine("Maior salario: " + Math.Round(MaximoSalario(pessoas), 2));
            decimal percentual = (SomaSalarios(pessoas)* 100) / pessoas.Count;
            Console.WriteLine("Percentual de pessoas com salário de até R$ 100,00: " + Math.Round(percentual, 2) + "%");

        }

        private static Pessoa LerPessoa()
        {
            Console.WriteLine("Digite o nome, salário, e número de filhos: ");

            Pessoa pessoa = new Pessoa();
            pessoa.Nome = Console.ReadLine();
            pessoa.Salario = decimal.Parse(Console.ReadLine());
            pessoa.Filho = int.Parse(Console.ReadLine());

            return pessoa;
        }


        private static decimal MediaSalario(List<Pessoa> pessoas)
        {
            var mediaSalario = pessoas.Average(s => s.Salario);
            return mediaSalario;
        }

        private static decimal MediaFilho(List<Pessoa> pessoas)
        {
            var mediaFilho = pessoas.Average(f => f.Filho);
            return mediaFilho;
        }

        private static decimal MaximoSalario(List<Pessoa> pessoas)
        {
            var maximoSalario = pessoas.Max(max => max.Salario);
            return maximoSalario;
        }

        private static decimal SomaSalarios(List<Pessoa> pessoas)
        {   
            decimal somaPessoas = 0;
            for(int i = 0; i<pessoas.Count;i++)
            {
                if(pessoas[i].Salario <= 100)
                {
                    somaPessoas = i++;
                }
            }
            return somaPessoas;     
        }

        






    }
}
