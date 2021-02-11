using System;

namespace CalcularPremio
{
    class Program
    {
        /*
        1.2 Implemente a função abaixo que calcula o valor total do prêmio somando fator do tipo do prêmio conforme valores:
        Tipo: "basic" fator multiplicação do prêmio: 1
        Tipo: "vip" fator multiplicação do prêmio: 1.2
        Tipo: "premium" fator multiplicação do prêmio: 1.5
        Tipo: "deluxe" fator multiplicação do prêmio: 1.8
        Tipo: "special" fator multiplicação do prêmio: 2
        Regras
        A função também deverá provir um parâmetro para que seja passado fator de multiplicação próprio.
        Quando parâmetro de fator de multiplicação próprio for informado e válido o mesmo deve sobrescrever o cálculo do tipo de prêmio.
        O prêmio nunca deve ter um valor negativo ou igual a zero.
        CalcularPremio(100, "vip", null) == 120.00;//true
        CalcularPremio(100, "basic", 3) == 300.00;//true 
         */

        // Entrada completa, com os três parâmetros
        static double CalcularPremio( int valor, string tipo, int qtd )
        {
            double premio = 0;
            if (tipo.ToLower() == "basic")
            {
                premio = valor * 1 * qtd;
            }
            if (tipo.ToLower() == "vip")
            {
                premio = valor * 1.2 * qtd;
            }
            if (tipo.ToLower() == "premium")
            {
                premio = valor * 1.5 * qtd;
            }
            if (tipo.ToLower() == "deluxe")
            {
                premio = valor * 1.8 * qtd;
            }
            if (tipo.ToLower() == "special")
            {
                premio = valor * 2.0 * qtd;
            }
            return premio; ;
        }

        //Sobrecarga Entrada faltando a quantidade, apenas com dois parâmetros
        //Quando parâmetro de fator de multiplicação próprio for informado e válido o mesmo deve sobrescrever o cálculo do tipo de prêmio.
        static double CalcularPremio( int valor, string tipo )
        {
            double premio = 0;
            if (tipo.ToLower() == "basic")
            {
                premio = valor * 1;
            }
            if (tipo.ToLower() == "vip")
            {
                premio = valor * 1.2;
            }
            if (tipo.ToLower() == "premium")
            {
                premio = valor * 1.5;
            }
            if (tipo.ToLower() == "deluxe")
            {
                premio = valor * 1.8;
            }
            if (tipo.ToLower() == "special")
            {
                premio = valor * 2.0;
            }
            return premio; ;
        }
        static void Main( string[] args )
        {
            Console.WriteLine("Entre com um Tipo:\nbasic\nvip\npremium\ndeluxe\nspecial");
            string tipo = Console.ReadLine();
            do
            {
                Console.Write("Entre com o Valor do Prêmio: ");
                int premio = int.Parse(Console.ReadLine());

                if (premio < 1)//O prêmio nunca deve ter um valor negativo ou igual a zero.
                {
                    Console.WriteLine("Só são aceitos números positivos maiores que 1");
                }
                else
                {
                    Console.WriteLine("Mais de Um Prêmio? Sim:(S) Não:(N)");
                    char verificar = char.Parse(Console.ReadLine());

                    //A função também deverá provir um parâmetro para que seja passado fator de multiplicação próprio.
                    if (verificar.Equals('s') || verificar.Equals('S'))
                    {
                        Console.WriteLine("Entre com o Fator de Multiplicação");
                        int mult = int.Parse(Console.ReadLine());
                        Console.WriteLine(CalcularPremio(premio, tipo, mult).ToString("F0"));
                        break;
                    }
                    else
                    {
                        //Quando parâmetro de fator de multiplicação próprio for informado e válido o mesmo deve sobrescrever o cálculo do tipo de prêmio.
                        Console.WriteLine(CalcularPremio(premio, tipo).ToString("F0"));
                        break;
                    }
                }
                
            } while (true);
        }
    }
}
