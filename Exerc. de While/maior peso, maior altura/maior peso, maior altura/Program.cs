/*Crie um algoritmo que peça o nome, a altura e o peso de cinco pessoas 
e apresente o nome e peso da mais pesada e o nome e altura da mais alta.*/

using System;

public class Program
{
	public static void Main()
	{
		int cont = 1;
		double altura, peso, maior_peso = 0, maior_altura = 0;
		string nome, nome1 = "", nome2 = "";

		while (cont <= 5)

		{
			Console.Write("Qual o {0}º nome ? ", cont);
			nome = Console.ReadLine();

			Console.Write("Qual a {0}ª altura ? ", cont);
			altura = double.Parse(Console.ReadLine());

			Console.Write("Qual o {0}º peso ? ", cont);
			peso = double.Parse(Console.ReadLine());

			Console.WriteLine("--------------------------------------");

			if (peso > maior_peso)
			{
				maior_peso = peso;
				nome1 = nome;
			}

			if (altura > maior_altura)
			{
				maior_altura = altura;
				nome2 = nome;
			}

			cont++;
		}

		Console.WriteLine("O (a) {0} é a pessoa que possui o maior peso, sendo {1} quilogramas", nome1, maior_peso);

		Console.WriteLine("O (a) {0} é a pessoa que possui a maior altura, sendo de {1}", nome2, maior_altura);

		Console.ReadKey();

	}
}
