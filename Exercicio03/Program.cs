using System;

namespace senac
{
    class Program
    {
        public static void Main()
        {
            decimal primeiro;
            decimal segundo;

            Console.WriteLine("Insira o primeiro valor: ");
            primeiro = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            segundo = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("sua altura é:" + primeiro);

            Console.WriteLine("seu peso é:" + segundo);

            // dar opções ao usuario
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t+ - somar");
            Console.WriteLine("\t- - subtrair");
            Console.WriteLine("\t* - multiplicar");
            Console.WriteLine("\t/ - dividir");
            Console.Write("Sua opção? ");

            // case em c#
            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"Your result: {primeiro} + {segundo} = " + (primeiro + segundo));
                    break;
                case "-":
                    Console.WriteLine($"Your result: {primeiro} - {segundo} = " + (primeiro - segundo));
                    break;
                case "*":
                    Console.WriteLine($"Your result: {primeiro} * {segundo} = " + (primeiro * segundo));
                    break;
                case "/":
                    Console.WriteLine($"Your result: {primeiro} / {segundo} = " + (primeiro / segundo));
                    break;
            }
            // CURIOSIDADE, AQUI SERVE PARA FECHAR O CODIGO APOS RODADO
            Console.Write("Aperte algum botão para finalizar.");
            Console.ReadKey();




        }
    }
}







