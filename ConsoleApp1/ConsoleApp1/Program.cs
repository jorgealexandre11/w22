using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

/*Ex 9 pag 82*/
/*
{
    class Program
    {
        static void Main(string[] args)
        {

            const double irs = 0.15;
            const double ss = 0.12;
            double salario, valorirs, valorss;

            Console.WriteLine("Diga valor do salario");
            salario = double.Parse(Console.ReadLine());

            valorirs = salario * irs;
            valorss = salario * ss;
            Console.WriteLine("retenção para irs={0}",valorirs);
            Console.WriteLine("retenção para seg.social={0}",valorss);
            Console.WriteLine("salario liquido = {0}",salario-valorirs-valorss);
            Console.ReadKey();


        }
    }
}
*/

/*
{
    class program
    {

        static void Main(string[]args)
        {

            double consumo, combustivelatual, kilometros, consumo1, despesa;

            Console.WriteLine("Qual o preço atual do combustivel por litro");
            combustivelatual = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos quilometros percorreu?");
            kilometros = double.Parse(Console.ReadLine());
            Console.WriteLine("Indique o consumo registado");
            consumo = double.Parse(Console.ReadLine());

            consumo1 = consumo / kilometros * 100;
            despesa = combustivelatual * consumo;
            Console.WriteLine("O consumo de {0}/100km gastou {1}", consumo1, despesa);
            Console.ReadKey();
        }
    }
}

*/

/*Ex11 pag 86*/
/*
{
    class program
    {
        static void Main(string[]args)
        {

            int CandA, CandB, CandC, CandD;
            int eleitores, voto, vencedorVotos;
            string vencedorCand = "";

            CandA = CandB = CandC = CandD = eleitores = vencedorVotos = 0;

            do
            {
                Console.WriteLine("Indique o código do candidato(1 a 4):");
                voto = int.Parse(Console.ReadLine());

                switch (voto)
                {
                    case 1:
                        ++CandA;
                        if (CandA > vencedorVotos)
                        {
                            vencedorVotos = CandA;
                            vencedorCand = "A";
                        }
                        break;
                    case 2:
                        ++CandB;
                        if (CandB > vencedorVotos)
                        {
                            vencedorVotos = CandB;
                            vencedorCand = "B";
                        }
                        break;
                    case 3:
                        ++CandC;
                        if (CandC > vencedorVotos)
                        {
                            vencedorVotos = CandB;
                            vencedorCand = "C";
                        }
                        break;
                    case 4:
                        ++CandD;
                        if (CandD > vencedorVotos)
                        {
                            vencedorVotos = CandB;
                            vencedorCand = "D";
                        }
                        break;

                }
                ++eleitores;
                Console.Clear();
            } while (voto != 0);

            --eleitores;
            Console.WriteLine("total de eleitores{0}",eleitores);
            Console.WriteLine("Candidato A obteve {0} votos={1:N1}%",CandA,(double)CandA /(double)eleitores*100);

            Console.WriteLine("Candidato B obteve {0} votos={1:N1}%", CandB, (double)CandB / (double)eleitores * 100);

            Console.WriteLine("Candidato C obteve {0} votos={1:N1}%", CandC, (double)CandC / (double)eleitores * 100);

            Console.WriteLine("Candidato D obteve {0} votos={1:N1}%", CandD, (double)CandD / (double)eleitores * 100);
            Console.WriteLine("O vencedor é o candidato {0}",vencedorCand);

            Console.ReadKey();

        }
    }
}

*/

/*Ex13 pag 89*/

{
    class program
    {
        static void Main(string[]args)
        {


        }
    }
}