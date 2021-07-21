using System;

namespace fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, fat = 1;
            Console.Write("Digite um número para saber seu fatorial: ");
            num = double.Parse(Console.ReadLine());

            for (double i = num; i >= num; i--)
            {
                if (i > 1)
                {
                    Console.Write("{0} * ", i);
                    fat = fat * i;
                }
                else
                {
                    Console.Write("{0} = {1} ", i, fat);
                }                            
            }

            if (fat == 1)
            {
                Console.WriteLine("O fatorial de 0 é {0}", fat);
            }

            Console.ReadKey();
        }
    }
}
