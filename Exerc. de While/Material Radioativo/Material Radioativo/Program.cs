using System;

namespace Material_Radioativo
{

    /*Um determinado material radioativo perde metade de sua massa a cada 50 segundos. 
     * Dada a massa inicial, em gramas, faça um programa que determine o tempo necessário
     * para que essa massa se torne menor que 0,05 gramas.*/
    class Program
    {
        static void Main(string[] args)
        {
            double massa_inicial;
            int temp = 0;

            Console.WriteLine("Digite a massa inicial do material em gramas: ");
            massa_inicial = double.Parse(Console.ReadLine());

            while (massa_inicial > 0.05)
            {
                massa_inicial = massa_inicial / 2;
                temp += 50;
            }

            Console.WriteLine("A massa final é de : {0:N} ", massa_inicial);
            Console.WriteLine("O tempo foi de : {0:N} ", temp);

            Console.ReadKey();
        }
    }
}
