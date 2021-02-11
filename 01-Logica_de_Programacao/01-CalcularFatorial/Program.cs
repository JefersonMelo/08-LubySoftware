using System;

namespace CalcularFatorial
{
    class Program
    {
        /*
        1.1 Implemente a função abaixo para calcular fatorial de um número.
        // 5! = 5 · 4 · 3 · 2 · 1 = 120
        CalcularFatorial(5) == 120//true 
         */

        static int fatorial( int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * fatorial(n - 1);
            }
        }

        static void Main( string[] args )
        {
            Console.Write("Enre com o Valor: ");
            int n = int.Parse(Console.ReadLine());

            int resultado = fatorial(n);

            Console.WriteLine(resultado);

        }
    }
}
