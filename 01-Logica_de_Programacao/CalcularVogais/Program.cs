using System;

namespace CalcularVogais
{
    class Program
    {
        /*
        1.4 Implemente a função abaixo que conta e calcula a quantidade de vogais dentro de uma string.
        CalcularVogais("Luby Software") == 4//true 
        https://docs.microsoft.com/pt-br/dotnet/api/system.char?view=net-5.0
         */

        static int CalcularVogais( string s )
        {
            int cont = 0;
            foreach (var ch in s)
            {
                if (ch.ToString().ToLower() == "a" ||
                    ch.ToString().ToLower() == "e" ||
                    ch.ToString().ToLower() == "i" ||
                    ch.ToString().ToLower() == "o" ||
                    ch.ToString().ToLower() == "u")
                {
                    cont++;
                }
            }
            return cont;
        }

        static void Main( string[] args )
        {
            string s = Console.ReadLine();

            Console.WriteLine(CalcularVogais(s));
        }
    }
}
