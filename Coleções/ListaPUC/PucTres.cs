using System;
using System.Collections.Generic;
using System.Linq;


namespace Coleções.ListaPUC
{
    public class PucTres
    {
        private class Pessoa
        {
            public string Nome;
            public int Filho;
            public decimal Salario;            
        }
        public static void Main52(string[] args)
        {
            
            System.Console.WriteLine
            ("Digite a quantidade de pessoas que serão entrevistadas:");
            int quantidade = int.Parse(Console.ReadLine());
            Pessoa[] pessoa = new Pessoa[quantidade];
            decimal soma = 0;
            decimal somaFilho = 0;
            decimal mediaSalario = 0;
            decimal mediaFilho = 0;
            decimal auxSalario = 0;
            decimal somaPessoas = 0;   


            for(int i = 0; i < pessoa.Length; i++)
            {   
                pessoa[i] = LerPessoa();                        
            }

            for(int i = 0; i < pessoa.Length; i++)
            {
                for(int j = i+1; j < pessoa.Length; j++)
                {
                    if(pessoa[i].Salario > pessoa[j].Salario)
                    {
                        auxSalario = pessoa[i].Salario;
                        pessoa[i].Salario = pessoa[j].Salario;
                        pessoa[j].Salario = auxSalario;                  
                    }                    
                }
                                        
                soma = soma + pessoa[i].Salario;              
                somaFilho = somaFilho + pessoa[i].Filho;    

                if(pessoa[i].Salario <= 100)
                {
                    somaPessoas++;
                }                                         
            }

            mediaSalario = soma / quantidade;
            mediaFilho = somaFilho / quantidade;   
            decimal percentual = (somaPessoas*100)/quantidade;

            Console.WriteLine("Media de salário por habitante: " + Math.Round(mediaSalario, 2));          
            Console.WriteLine("Media de filho por habitante: " + mediaFilho);                    
            Console.WriteLine("Percentual de pessoas com salário de menor que R$ 100,00: " + Math.Round(percentual, 2));
                   
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

       

        

    }
}