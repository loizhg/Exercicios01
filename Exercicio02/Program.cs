using System;

namespace senac
{
    class Program
    {
        public static void Main()
        {
            decimal altura;
            decimal peso;
            decimal IMC;

            Console.WriteLine("Insira sua altura em metros LEMBRE-SE da virgula: ");
            altura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("insira seu peso em kilos: ");
            peso = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("sua altura é:" + altura);

            Console.WriteLine("seu peso é:" + peso);

            IMC = (peso / altura * 2);

            Console.WriteLine("seu IMC é:" + IMC);
        }
    }
}







