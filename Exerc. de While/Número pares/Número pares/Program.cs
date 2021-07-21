using System;

namespace Aula
{
	class Program
	{
		static void Main(string[] args)
		{

			/* 1)Faça um algoritmo que imprima todos os números pares compreendidos entre
			//85 e 907.O algoritmo deve também calcular a soma destes valores.*/

			int cont = 85, soma = 0;

			while (cont <= 907)
			{
				if (cont % 2 == 0)
				{
					Console.WriteLine(cont);
					soma = soma + cont;
				}

				cont++;
			}

			Console.WriteLine(soma);
			Console.ReadKey();
		}
	}
}


