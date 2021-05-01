using System;
using System.Collections.Generic;

namespace TransformarEmMatriz
{

    class Program
    {
        /*
        1.9 Implemente a função abaixo que obtém uma string com números 
        separados por vírgula e transforma em um array de array de 
        inteiros com no máximo dois elementos.
        TransformarEmMatriz("1,2,3,4,5,6") == new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } }; //true 
         */
        
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(',');
            int[] vet = new int[s.Length];
            int pos = s.Length / 2;
            int[][] arr = new int[pos][];
            int j;

            for ( int i = 0; i < vet.Length; i++ )
            {
                vet[i] = int.Parse(s[i]);
            }

            for ( int i = 0; i < arr.Length; i++ )
            {
                for ( j = 0; j < 1; j++ )
                {
                    arr[i] = new int[] { vet[i] };
                    arr[i][j] = vet[j + 1];
                }
            }
        }
    }
}
