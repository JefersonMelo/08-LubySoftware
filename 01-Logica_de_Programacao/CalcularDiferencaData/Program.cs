using System;

namespace CalcularDiferencaData
{
    class Program
    {
        /*
        1.6 Implemente a função abaixo que obtém duas string de datas e calcula a diferença de dias entre elas.
        CalcularDiferencaData("10122020", "25122020") == 15; //true  
        https://docs.microsoft.com/pt-br/dotnet/api/system.datetime?view=net-5.0
        https://social.msdn.microsoft.com/Forums/pt-BR/ec4c4b23-2800-4572-bccd-469b1078ce69/pegar-2-primeiras-casa-de-um-int
        https://docs.microsoft.com/pt-br/dotnet/api/system.convert.toint32?view=net-5.0
         */

        static Int32 CalcularDiferencaData( string a, string b )
        {
            Int32 data1, data2;
            data1 = Int32.Parse(a);
            data2 = Int32.Parse(b);
            
            if (data2 > data1)
            {
                return Convert.ToInt32((data2 - data1).ToString().Substring(0, 2));
            }
            else
            {
                return Convert.ToInt32((data1 - data2).ToString().Substring(0, 2));
            }
        }

        static void Main( string[] args )
        {
            string a, b;

            Console.WriteLine("Entradas: ");
            a = Console.ReadLine();
            b = Console.ReadLine();
            
            Console.WriteLine(CalcularDiferencaData(a, b));
        }
    }
}
