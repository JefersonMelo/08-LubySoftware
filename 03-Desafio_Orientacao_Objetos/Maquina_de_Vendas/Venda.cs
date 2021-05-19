using System;
using System.Collections.Generic;
using System.Text;

namespace Maquina_de_Vendas
{
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
