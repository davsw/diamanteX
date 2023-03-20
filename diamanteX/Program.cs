using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamanteX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int metade;


            do
            {
                Console.Write("Digite um número ímpar: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (numero % 2 == 0)
                {
                    Console.WriteLine("Valor inválido. Tente novamente...");
                    Console.ReadLine();
                }
            } while (numero % 2 == 0);


            metade = (numero - 1) / 2;

            for (int i = 0; i <= metade; i++)
            {
                for (int espacoEmBranco = 0; espacoEmBranco < metade - i; espacoEmBranco++)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < 2 * i + 1; x++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }

            for (int i = metade - 1; i >= 0; i--)
            {
                for (int espacoBranco = 0; espacoBranco < metade - i; espacoBranco++)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < 2 * i + 1; x++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}