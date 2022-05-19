using System;
namespace Luiz
{

    public class Program
    {
        public static void Main()
        {
            decimal[] numeros = new decimal[3];
            decimal soma = 0;
            decimal media = 0;
            int contador = 0;

            decimal menor = 0, maior = 0, posicao_menor = 0, posicao_maior = 0;


            for (int p = 0; p < numeros.Length; p++)
            {
                Console.Write("Digite a m" + p + " do aluno: ");
                numeros[p] = Convert.ToDecimal(Console.ReadLine());
                decimal valor = numeros[p];
                soma = soma + valor;
                contador++;


                if (p == 0)
                {
                    menor = numeros[0];
                    maior = numeros[0];
                }

                if (numeros[p] < menor)
                {

                    menor = numeros[p];
                    posicao_menor = p;

                }
                else if (numeros[p] > maior)
                {
                    maior = numeros[p];
                    posicao_maior = p;
                }




            }

            media = soma / contador;

            Array.Sort(numeros);
            Console.Write("\n\n");
            foreach (decimal p in numeros) Console.WriteLine(p);

            Console.WriteLine(media);



            Console.WriteLine("O menor número é:" + menor);
            Console.WriteLine("A posição do menor número é:" + posicao_menor);
            Console.WriteLine("O maior número é:" + maior);
            Console.WriteLine("A posição do maior número é:" + posicao_maior);






        }
    }
}