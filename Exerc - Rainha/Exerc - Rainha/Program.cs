using System;

namespace Exerc___Rainha

/*Uma rainha requisitou os serviços de um monge e disse-lhe que pagaria 
 * qualquer preço. O monge, necessitando de alimentos, indagou à rainha
 * sobre o pagamento, se poderia ser feito com grãos de trigo dispostos
 * em um tabuleiro de xadrez (que possui 64 casas), de tal forma que o
 * primeiro quadro deveria conter apenas um grão e os quadros subsequentes,
 * o dobro do quadro anterior. Crie um algoritmo para calcular o total de
 * grãos que o monge recebeu. */
{
    class Program
    {
        static void Main(string[] args)
        {
            double graos = 1, soma_graos = 0;
            int dia = 2;

            Console.WriteLine("Dia 1 => {0}", graos);

            while (dia <= 64)
            {
                graos = graos * 2;
                soma_graos = soma_graos + graos;
                Console.WriteLine("{0} dia => {1:N0}", dia, graos);
                dia++;
            }

            Console.WriteLine("O total de grãos que o monge recebeu é de {0:N0}", soma_graos);

            Console.ReadKey();
        }
    }
}
