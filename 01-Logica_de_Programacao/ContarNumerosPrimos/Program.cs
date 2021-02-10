using System;

namespace ContarNumerosPrimos
{
    class Program
    {
        /*
        1.3 Implemente a função abaixo para contar quantos números primos existe até o número informado.
        //Número primo: 2
        //Número primo: 3
        //Número primo: 5
        //Número primo: 7
        //Total de números primos: 4
        ContarNumerosPrimos(10) == 4//true 
         */

        static int ContarNumerosPrimos(int n)
        {
            int qtd = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    qtd++;
                }
                ContarNumerosPrimos(n - 1);
            }
            return qtd;
        }

        static void Main( string[] args )
        {
            Console.Write("Número: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(ContarNumerosPrimos(n));
        }
    }
}
