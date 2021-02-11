using System;
using System.Collections;

namespace ObterElementosFaltantes
{
    class Program
    {
        /*
        1.10 Implemente a função abaixo que compara dois vetores e cria um novo vetor com os elementos faltantes de ambos.
        // faltam elementos no vetor2
        int[] vetor1 = new int[] { 1,2,3,4,5 };
        int[] vetor2 = new int[] { 1,2,5 };
        ObterElementosFaltantes(vetor1, vetor2) == new int[] { 3, 4 }; //true 

        // faltam elementos no vetor3
        int[] vetor3 = new int[] { 1,4,5 };
        int[] vetor4 = new int[] { 1,2,3,4,5 };
        ObterElementosFaltantes(vetor3, vetor4) == new int[] { 2, 3 }; //true

        // faltam elementos em ambos vetores
        int[] vetor5 = new int[] { 1,2,3,4 };
        int[] vetor6 = new int[] { 2,3,4,5 };
        ObterElementosFaltantes(vetor5, vetor6) == new int[] { 1, 5 }; //true

        // não faltam items
        int[] vetor7 = new int[] { 1,3,4,5 };
        int[] vetor8 = new int[] { 1,3,4,5 };
        ObterElementosFaltantes(vetor7, vetor8) == new int[] { }; //true 
        https://docs.microsoft.com/pt-br/dotnet/api/system.array.clone?view=net-5.0#System_Array_Clone
        https://docs.microsoft.com/pt-br/dotnet/api/system.array.resize?view=net-5.0
        https://www.clubedohardware.com.br/topic/1078955-comparar-valores-dentro-de-um-%C3%BAnico-vetor/

         */

        static void Main( string[] args )
        {
            int[] vetor1 = new int[] { 1, 2, 5 };
            int[] vetor2 = new int[] { 1, 2, 3, 4, 5 };
            ArrayList list = new ArrayList(); 
            if (vetor1.Length < vetor2.Length)// Garantir vetor1 sempre o maior 
            {
                int[] vetaux = (int[])vetor2.Clone();
                vetor2 = (int[])vetor1.Clone();
                vetor1 = (int[])vetaux.Clone();
                
            }

            for (int i = 0; i < vetor1.Length; i++)
            {
                Array.Resize(ref vetor2, vetor2.Length + (vetor1.Length / 2));
                
                if (vetor1[i] != vetor2[i])
                {
                    list.Add(vetor1[i]);
                }
            }
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
