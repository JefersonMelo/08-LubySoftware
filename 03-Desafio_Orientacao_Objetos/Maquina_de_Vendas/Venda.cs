using System;
using System.Collections.Generic;
using System.Text;

namespace Maquina_de_Vendas
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
    class Venda
    {        
        public double vendido( Produto p )
        {
            Estoque e = new Estoque();
            return e.valorUniade(p.Nome) * p.QtdItem;
        }

        public int contadorVendas( Produto p )
        {
            int contItu = 0, contCoca = 0, contPepsi = 0, cont = 0;

            switch (p.Nome)
            {
                case "itubaina"://Itubaina
                    contItu++;
                    cont = contItu;
                    break;

                case "pepsi"://Pepsi
                    contPepsi++;
                    cont = contPepsi;
                    break;

                case "coca"://Coca
                    contCoca++;
                    cont = contCoca;
                    break;

                case "total":
                    cont =  contItu + contCoca + contPepsi;
                    break;
            }
            return cont;
        }

        public double contabilidade( Produto p )
        {
            Estoque e = new Estoque();
            double totalVendas = 0;
            totalVendas += e.valorUniade(p.Nome) * p.QtdItem;
            return totalVendas;
        }
    }
}
