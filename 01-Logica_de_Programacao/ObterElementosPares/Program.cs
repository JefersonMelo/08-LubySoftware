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
            Console.Write("Entre com o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());
            int[] vet = new int[n];// vetor comescolha do usuário
            ArrayList lista = new ArrayList();

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());// entrada de dados nas posições i

                if (vet[i] % 2 == 0)// Condição par
                {
                    j = vet[i];
                    lista.Add(j);// Adicionando pares na lista
                }

            }

            foreach (var item in lista)
            {
                Console.Write($"{item} ");// impressão dos pares
            }
        }
    }
}
