namespace Coleções.ListaPUC
{
    public class PucSeis
    {
        public static void Main56(string[] args)
        {            
            int voto = 1;
            int presidenteA = 0;
            int presidenteB = 0;
            int presidenteC = 0;
            int presidenteD = 0;
            int votoNulo = 0;
            int votoBranco = 0;

            while (voto != 0)
            {
                System.Console.WriteLine("Para votar, digite o número correspondente e aperte ENTER: \n 1) Presidente A \n 2) Presidente B \n 3) Presidente C \n 4) Presidente D \n -5) Voto nulo \n -6) Voto em branco");
                voto = int.Parse(Console.ReadLine());

                switch (voto)
                {
                    case 1:
                        {
                            Console.WriteLine("VOTO COMPUTADO COM SUCESSO!!!");
                            presidenteA += 1;
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("VOTO COMPUTADO COM SUCESSO!!!");
                            presidenteB += 1;
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("VOTO COMPUTADO COM SUCESSO!!!");
                            presidenteC += 1;
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("VOTO COMPUTADO COM SUCESSO!!!");
                            presidenteD += 1;
                            break;
                        }
                    case -5:
                        {
                            Console.WriteLine("VOTO COMPUTADO COM SUCESSO!!!");
                            votoNulo += 1;
                            break;
                        }
                    case -6:
                        {
                            Console.WriteLine("VOTO COMPUTADO COM SUCESSO!!!");
                            votoBranco += 1;
                            break;
                        }                     
                }              
            }
            
            Console.WriteLine($"Total de votos no presidente A: {presidenteA}");
            Console.WriteLine($"Total de votos no presidente B: {presidenteB}");
            Console.WriteLine($"Total de votos no presidente C: {presidenteC}");
            Console.WriteLine($"Total de votos no presidente D: {presidenteD}");
            Console.WriteLine($"Total de votos nulos: {votoNulo}");
            Console.WriteLine($"Total de votos em branco: {votoBranco}");
        }


    }
}