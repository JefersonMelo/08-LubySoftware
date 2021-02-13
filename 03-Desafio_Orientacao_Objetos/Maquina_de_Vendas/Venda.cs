using System;
using System.Collections.Generic;
using System.Text;

namespace Maquina_de_Vendas
{
    class Venda
    {
        Produto p = new Produto();// Stack Overflow

        public double vendido( string nome )
        {
            return p.valorUniade(nome) * p.QtdItem;
        }

        public int contadorVendas( string nome )
        {
            //p.Nome = nome;
            int contItu = 0, contCoca = 0, contPepsi = 0, cont = 0;
            switch (nome)
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
                    return contItu + contCoca + contPepsi;

                default:
                    Console.WriteLine("Valor Inválido");
                    break;
            }
           
            return cont;
        }
    }
}
