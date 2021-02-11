using System;

namespace BuscarPessoa
{
    class Program
    {
        /*
        1.8 Implemente a função abaixo que deve buscar um ou mais elementos no vetor que contém o valor ou parte do valor informado na busca.
        string[] vetor = new string[] {
                            "John Doe",
                            "Jane Doe",
                            "Alice Jones",
                            "Bobby Louis",
                            "Lisa Romero"
        };
        BuscarPessoa(vetor, "Doe") == new string[] { "John Doe", "Jane Doe" };//true
        BuscarPessoa(vetor, "Alice") == new string[] { "Alice Jones" };//true
        BuscarPessoa(vetor, "Louis") == new string[] { };//true 
         */

        static void Main( string[] args )
        {
            string[] vetor = new string[] {
                            "John Doe",
                            "Jane Doe",
                            "Alice Jones",
                            "Bobby Louis",
                            "Lisa Romero"
            };
            Console.Write("Pesquisa: ");
            string pesquisa = Console.ReadLine();
            foreach (var item in vetor)
            {
                if (item.Contains(pesquisa))
                {
                    Console.WriteLine($"\n{item}");
                }
            }
        }
    }
}
