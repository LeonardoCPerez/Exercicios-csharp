using System;

namespace Chico
{
    class Program
    {
        static void Main(string[] args)
        {
            double altZe = 1.10, altChico = 1.50;
            int ano = 0;

            while (altChico > altZe)
            {
                altChico = altChico + 0.02;
                altZe = altZe + 0.03;
                ano++;
                Console.WriteLine("{0}º ano --> Altura do Zé -> {1:N}  //  Altura do Chico -> {2:N}",ano, altZe, altChico);
                Console.WriteLine("========================================================================================");
            }

            Console.WriteLine("Demorará {0} anos para que Zé seja maior que Chico", ano);

            Console.ReadKey();
        }
    }
}
