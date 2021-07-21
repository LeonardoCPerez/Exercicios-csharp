using System;

namespace hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int quartos = 3;
            double diaria, servico, total;

            for (int i = 1; i <= quartos; i++ )
            {
                Console.Write("Nome -> ");
                nome = Console.ReadLine();

                Console.Write("Quantidade de diárias -> ");
                diaria = double.Parse(Console.ReadLine());
            }


            Console.ReadKey();
        }
    }
}
