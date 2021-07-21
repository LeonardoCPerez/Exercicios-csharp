using System;

namespace Idade_média___alunos
{
    class Program
    {
        static void Main(string[] args)
        {
			/* 3) Para uma turma de 15 alunos, construa um algoritmo que determine:
			a) A idade média dos alunos com menos de 1,70m de altura;
			b) A altura média dos alunos com mais de 20 anos.*/

			double altura = 0, idade = 0, somaaltura = 0, mediaaltura = 0, somaidade = 0, 
			mediaidade = 0, cont = 1, qtde_170 = 0, qtde_20 = 0; ;

			while (cont <= 3)
			{
				Console.Write("--------------------------------------");

				Console.Write("Escreva a idade do {0} aluno: ", i);
				idade = double.Parse(Console.ReadLine());
				Console.Write("Escreva a altura do {0} aluno: ", i);
				altura = double.Parse(Console.ReadLine());
				
				if (altura < 1.70)
				{
					somaidade += idade;
					qtde_170++;
				}
				if (idade > 20)
				{
					somaaltura += altura;
					qtde_20++;
				}
				cont++;
			}
			if (qtde_170 > 0)
			{
				mediaidade = somaidade / qtde_170;
			}
			if (qtde_20 > 0)
			{
				mediaaltura = somaaltura / qtde_20;
			}
			
			Console.WriteLine("A idade média dos alunos com menos de 1,70m de altura é: {0}", mediaidade);

			Console.WriteLine("A altura média dos alunos com mais de 20 anos: {0:N}", mediaaltura);

			Console.ReadKey();
		}
    }
}
