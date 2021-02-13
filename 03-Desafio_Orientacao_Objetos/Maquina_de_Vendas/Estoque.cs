using System;
using System.Collections.Generic;
using System.Text;

namespace Maquina_de_Vendas
{
    class Estoque : Produto
    {

        public int visualizarEstoque( string nome )
        {
            Venda v = new Venda();
            Produto p = new Produto();
            int estoqueAtual = 0;

            switch (nome)
            {
                case "itubaina":
                    QtdEstoque -= v.contadorVendas(p);
                    int itubaina = QtdEstoque - QtdItem;// QtdEstoque iniciado com 100
                    estoqueAtual = itubaina;
                    break;

                case "pepsi":
                    QtdEstoque -= v.contadorVendas(p);
                    int pepsi = QtdEstoque - QtdItem;// QtdEstoque iniciado com 100
                    estoqueAtual = pepsi;
                    break;

                case "coca":
                    QtdEstoque -= v.contadorVendas(p);
                    int coca = QtdEstoque - QtdItem;// QtdEstoque iniciado com 100
                    estoqueAtual = coca;
                    break;
            }
            return estoqueAtual;
        }

        // Retorna o valor da unidade do refrigerante
        public double valorUniade( string nome )
        {
            double valor = 0;
            switch (nome)
            {
                case "itubaina":
                    valor = 2.5;
                    break;
                case "pepsi":
                    valor = 3.5;
                    break;
                case "coca":
                    valor = 4.5;
                    break;
            }
            //Valor = valor;
            return valor;
        }
    }
}
