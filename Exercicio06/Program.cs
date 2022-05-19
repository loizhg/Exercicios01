using System;

public class Program
{
	public static void Main()
	{

		string nome;
		string sobrenome;

		Console.WriteLine("Insira seu nome: ");
		nome = Console.ReadLine();

		Console.WriteLine("Insira seu sobrenome: ");
		sobrenome = Console.ReadLine();

		Console.WriteLine($"Seu nome completo é: {nome} {sobrenome}.");

	}
}