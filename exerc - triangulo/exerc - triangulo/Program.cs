using System;

public class Program
{
	public static void Main()
	{
		int ladoA, ladoB, ladoC;

		Console.Write("Digite o valor do lado A ");
		ladoA = int.Parse(Console.ReadLine());

		Console.Write("Digite o valor do lado B ");
		ladoB = int.Parse(Console.ReadLine());

		Console.Write("Digite o valor do lado C ");
		ladoC = int.Parse(Console.ReadLine());

		if ((ladoA < (ladoB + ladoC)) && (ladoB < (ladoA + ladoC)) && (ladoC < (ladoA + ladoB)))
		{

			if ((ladoA == ladoB) && (ladoA == ladoC))
			{
				Console.WriteLine("Você possui um triângulo equilátero!!!");
			}

			else if ((ladoA == ladoB) || (ladoA == ladoC) || (ladoB == ladoC))
			{
				Console.WriteLine("Você possui um triângulo isósceles!!!");
			}

			else 
			{
				Console.WriteLine("Você possui um triângulo escaleno!!!");
			}
		}
		else
		{
			Console.WriteLine("A figura não é um triângulo ");
		}

	}
}