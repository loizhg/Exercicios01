using System;

public class Program
{
	public static void Main()
	{

		decimal dab;

		decimal xa;
		decimal xb;
		decimal somaX;
		decimal quadradoX;

		decimal ya;
		decimal yb;
		decimal somaY;
		decimal quadradoY;


		decimal resultado;

		xa = 10;
		xb = 20;

		ya = -30;
		yb = -10;


		somaX = xa - xb;
		quadradoX = somaX * somaX;

		somaY = ya - yb;
		quadradoY = somaY * somaY;

		dab = (quadradoX + quadradoY) / 2;

		resultado = dab;

		Console.WriteLine("o ponto xa é: " + xa);
		Console.WriteLine("o ponto xb é: " + xb);
		Console.WriteLine("o ponto ya é: " + ya);
		Console.WriteLine("o ponto yb é: " + yb);

		Console.WriteLine("o resultado é: " + resultado);


	}
}