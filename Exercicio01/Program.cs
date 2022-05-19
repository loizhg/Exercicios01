using System;

namespace senac
{
    class Program
    {
        public static void Main()
        {
            string nome;
            int idade;

            Console.WriteLine("Insira seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("insira sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("seu nome é:" + nome);

            Console.WriteLine("sua idade é:" + idade);

            if (idade < 18)
            {
                Console.WriteLine("Você é menor de idade!");
            }

            else
            {
                Console.WriteLine("Você é maior de idade!");
            }

        }
    }
}







