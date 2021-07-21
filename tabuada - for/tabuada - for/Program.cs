using System;

namespace tabuada___for
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resposta;

            Console.WriteLine("Qual número deseja calcular a tabuada? ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                resposta = num * i;
                Console.WriteLine("{0} * {1} = {2}", i, num, resposta);
            }
            Console.ReadKey();
        }
    }
}
