using System;
using System.Collections.Generic;

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
        https://www.alura.com.br/conteudo/csharp-collections
        http://www.linhadecodigo.com.br/artigo/3444/arrays-em-csharp-teoria-e-pratica.aspx
         */
        static List<int> list = new List<int>();

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
                //Array.Resize(ref vet, 2);

                for ( j = 0; j < 1; j++ )
                {
                    arr[i] = new int[] { vet[i] };
                    arr[i][j] = vet[j + 1];
                }
                //Console.WriteLine(arr[i][j]);
            }


            //TransformarEmMatriz(vet);
        }
        //private static void TransformarEmMatriz(int[] n)
        //{
        //    for ( int i = 0; i < n.Length; i++ )
        //    {
        //        Console.WriteLine(n[i]);
        //    }
        //}
    }
}
