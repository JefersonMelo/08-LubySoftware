using System;

namespace TransformarEmMatriz
{
    class Program
    {
        /*
        1.9 Implemente a função abaixo que obtém uma string com números separados por vírgula e transforma em um array de array de 
        inteiros com no máximo dois elementos.
        TransformarEmMatriz("1,2,3,4,5,6") == new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } }; //true 
        https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/arrays/jagged-arrays
        https://www.portugal-a-programar.pt/forums/topic/10201-ajuda-cria%C3%A7%C3%A3o-de-matrizes-em-c/
        https://pt.stackoverflow.com/questions/145897/diferen%C3%A7as-entre-jagged-array-e-multidimensional-array-em-c
        https://dev.to/codebuns/c-jagged-array-array-of-arrays-f7g
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
