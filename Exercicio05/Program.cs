using System;

public class Program
{
	public static void Main()
	{

		decimal valor;
		decimal desconto;
		decimal percentual;
		decimal valorDescontado;
		int check;
		decimal tributo;

		Console.WriteLine("Insira valor do produto: ");
		valor = Convert.ToDecimal(Console.ReadLine());

		Console.WriteLine("insira o desconto a se aplicar: ");
		desconto = Convert.ToDecimal(Console.ReadLine());

		if (valor <= 100)
		{
			check = 5;
			tributo = (valor * check) / 100;
			Console.WriteLine("O valor tributado é:" + tributo);
			valor = valor + tributo;

		}
		else if (valor > 100 & valor <= 300)
		{
			check = 15;
			tributo = (valor * check) / 100;
			Console.WriteLine("O valor tributado é:" + tributo);
			valor = valor + tributo;
		}
		else if (valor > 301 & valor <= 1000)
		{
			check = 25;
			tributo = (valor * check) / 100;
			Console.WriteLine("O valor tributado é:" + tributo);
			valor = valor + tributo;
		}





		Console.WriteLine("O valor do produto é:" + valor);


		Console.WriteLine("O desconto a ser dado é:" + desconto);


		percentual = (valor * desconto) / 100;

		Console.WriteLine("O valor de desconto é:" + percentual);

		valorDescontado = valor - percentual;

		Console.WriteLine("O valor a ser pago é:" + valorDescontado);









	}
}