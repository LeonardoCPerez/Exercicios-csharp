using System;

/*Para uma turma de 45 alunos, construa um algoritmo que determine:
a) A idade média dos alunos com menos de 1,70m de altura;
b) A altura média dos alunos com mais de 20 anos. */

namespace média_de_altura___alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, somaIdade = 0, qtdemenos170 = 0, qtdemais20 = 0;
            double altura, idade_media = 0, somaAltura = 0, altura_media = 0;

            for (int i = 1; i <= 3; i++)
            {

                Console.WriteLine("------------------------------------");

                Console.Write("Qual a altura do {0}º aluno: ", i);
                altura = double.Parse(Console.ReadLine());                    

                Console.Write("Qual a idade do {0}º aluno: ", i);
                idade = int.Parse(Console.ReadLine());

                if (altura < 1.70)
                {
                    somaIdade = idade + somaIdade;
                    qtdemenos170++;
                }

                if (idade > 20)
                {
                    somaAltura = altura + somaAltura;
                    qtdemais20++;
                }
              
            }

            Console.WriteLine("=====================================");

            if (qtdemenos170 > 0)
            {
                idade_media = (double) somaIdade / qtdemenos170;
            }

            if (qtdemais20 > 0)
            {
                altura_media = somaAltura / qtdemais20;
            }

                Console.WriteLine("A idade média dos alunos com menos de 1,70m é de {0} anos", idade_media);
          
                Console.WriteLine("A altura média dos alunos com mais de 20 anos é de {0:N}m", altura_media);
            

            Console.ReadKey();
            
        }
    }
}
