using System;
using System.Globalization;

namespace CalcularValorComDescontoFormatado
{
    class Program
    {
        /*
        1.5 Implemente a função abaixo que aplica uma porcentagem de desconto a um valor e retorna o resultado.
        Lembre-se que as entradas e saídas dos dados são strings que devem ser tratadas.
        CalcularValorComDescontoFormatado("R$ 6.800,00", "30%") == "R$ 4.760,00"; //true  
         */

        static string CalcularValorComDescontoFormatado( string valor, string desconto)
        {
            string[] convertValor = valor.Split('R', '$', ' ', ',');
            string[] convertDesconto = desconto.Split('%');
            double cedula, moeda, v, d, r;
            cedula = double.Parse(convertValor[3]);
            moeda = double.Parse(convertValor[4]);
            d = double.Parse(convertDesconto[0]);
            v = cedula + (moeda / 100);
            r = v - v * (d / 100.0);
            return $"{r:C2}";
        }

        static void Main( string[] args )
        {
            Console.Write("Valor: ");
            string valor = Console.ReadLine();
            Console.Write("Desconto: ");
            string desconto = Console.ReadLine();
            Console.WriteLine(CalcularValorComDescontoFormatado(valor, desconto));
        }
    }
}
