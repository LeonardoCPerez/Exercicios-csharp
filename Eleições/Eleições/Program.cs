using System;

namespace Eleições
{
    class Program
    {
        static void Main(string[] args)
        {
            int voto, candidato1 = 0, candidato2 = 0, candidato3 = 0, candidato4 = 0, nulo = 0, branco = 0;
            int total_votos = 0;
            double perc_brancos_nulos;

            Console.WriteLine("Bem vindo as eleições");

            Console.Write("Qual seu voto ? ");
            voto = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            while (voto != 0)  
            {
                if (voto == 1) 
                {
                    candidato1++;
                }     

                else if (voto == 2)
                {
                    candidato2++;
                }

                else if (voto == 3)
                {
                    candidato3++;
                }

                else if (voto == 4)
                {
                    candidato4++;
                }

                else if (voto == 6)
                {
                    branco++;
                }

                else
                {
                    nulo++;
                }

                total_votos++;

                Console.Write("Qual seu voto ? ");
                voto = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------");

            }

            Console.WriteLine("Votos do candidato 1 -> {0}", candidato1);
            Console.WriteLine("Votos do candidato 2 -> {0}", candidato2);
            Console.WriteLine("Votos do candidato 3 -> {0}", candidato3);
            Console.WriteLine("Votos do candidato 4 -> {0}", candidato4);
            Console.WriteLine("Votos Brancos -> {0}", branco);
            Console.WriteLine("Votos Nulos -> {0}", nulo);

            perc_brancos_nulos = ((branco + nulo) * 100.0) / total_votos;

            Console.WriteLine("Percentual de votos brancos e nulos em relação ao total de votos -> {0}%", perc_brancos_nulos);
            Console.ReadKey();
        }
    }
}
