using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioTabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nome: Nilton Kazuo Hasegawa Haji
            //RA: 6322507

            //Primeira parte do exercicio

            int numero, multiplicacao, contador = 0;
            Console.WriteLine("Digite o numero da tabuada: ");
            numero = int.Parse(Console.ReadLine());
            multiplicacao = numero * contador;

            while (contador <= 10)
            {
                Console.WriteLine(numero + " x " + contador++ + " = " + multiplicacao);
                multiplicacao = numero * contador;
            }

            //Segunda parte do exercicio
            int numero2, multiplicacao2, contador2 = 10;
            Console.WriteLine("Digite o numero da tabuada (ordem decrescente): ");
            numero2 = int.Parse(Console.ReadLine());
            multiplicacao2 = numero2 * contador2;

            while (contador2 > 0)
            {
                Console.WriteLine(numero2 + " x " + contador2-- + " = " + multiplicacao2);
                multiplicacao2 = numero2 * contador2;
            }

            //Terceira parte do exercicio
            int a = 1, b = 1;
            while (a <= 10)
            {
                Console.WriteLine("Tabuada do: " + a);

                while (b <= 10)
                {
                    Console.WriteLine(a + " x " + b + " = " + a * b);
                    b = b + 1;
                }
                Console.WriteLine();
                a++;
                b = b - 10;
            }

            Console.ReadKey();
        }
    }
}
