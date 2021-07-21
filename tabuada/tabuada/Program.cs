using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1, numero, resultado;

            Console.Write("Informe o número que deseja saber a tabuada: ");
            numero = int.Parse(Console.ReadLine());

            while (cont <= 10)
            {
                resultado = numero * cont;
                Console.WriteLine("{0} x {1} = {2}", numero, cont, resultado);
                cont++;
            }
            Console.ReadKey();
        }
    }
}
