using System;
using System.Collections;

namespace ObterElementosPares
{
    class Program
    {
        /*
        1.7 Implemente a função abaixo que retorna um novo vetor com todos elementos pares do vetor informado.
        int[] vetor = new int[] { 1,2,3,4,5 };
        ObterElementosPares(vetor) == new int { 2, 4 }; //true  
        https://docs.microsoft.com/pt-br/dotnet/api/system.collections.arraylist?view=net-5.0
         */

        static void Main( string[] args )
        {
            int j;
            int n = int.Parse(Console.ReadLine());
            int[] vet = new int[n];
            ArrayList lista = new ArrayList();

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());

                if (vet[i] % 2 == 0)
                {
                    j = vet[i];
                    lista.Add(j);
                }
                
            }
            foreach (var item in lista)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
