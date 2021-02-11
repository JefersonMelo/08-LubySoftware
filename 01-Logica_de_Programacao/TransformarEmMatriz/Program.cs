using System;

namespace TransformarEmMatriz
{
    class Program
    {
        /*
        1.9 Implemente a função abaixo que obtém uma string com números separados por vírgula e transforma em um array de array de 
        inteiros com no máximo dois elementos.
        TransformarEmMatriz("1,2,3,4,5,6") == new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } }; //true  
         */

        static void Main( string[] args )
        {
            string[] inteiros = Console.ReadLine().Split(',');
            int[] vet = new int[inteiros.Length];
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = int.Parse(inteiros[i]);
            }
            foreach (var item in vet)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
