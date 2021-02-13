using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Maquina_de_Vendas
{
    /*
        https://docs.microsoft.com/pt-br/dotnet/api/system.collections.generic.list-1?view=net-5.0#code-try-3
        https://pt.stackoverflow.com/questions/2913/em-orienta%c3%a7%c3%a3o-a-objetos-por-que-interfaces-s%c3%a3o-%c3%bateis
        https://pt.stackoverflow.com/questions/107524/como-e-quando-usar-interface
        
     */

    class Produto
    {
        private string nome;
        private int qtdEstoque = 100;// 
        private int qtdItem;
        private double valor;

        public string Nome { get => nome; set => nome = value; }
        public int QtdItem { get => qtdItem; set => qtdItem = value; }
        public int QtdEstoque { get => qtdEstoque; set => qtdEstoque = value; }
        public double Valor { get => valor; set => valor = value; }

        Venda v = new Venda();

        public int visualizarEstoque( string nome )
        {
            this.Nome = nome;
            int estoqueAtual = 0;

            switch (this.Nome)
            {
                case "itubaina":
                    QtdEstoque -= v.contadorVendas(this.Nome);
                    int itubaina = QtdEstoque - QtdItem;//inicia com 100
                    estoqueAtual = itubaina;
                    break;

                case "pepsi":
                    QtdEstoque -= v.contadorVendas(this.Nome);
                    int pepsi = QtdEstoque - QtdItem;//inicia com 100
                    estoqueAtual = pepsi;
                    break;

                case "coca":
                    QtdEstoque -= v.contadorVendas(this.Nome);
                    int coca = QtdEstoque - QtdItem;//inicia com 100
                    estoqueAtual = coca;
                    break;

                default:
                    Console.WriteLine("Valor Inválido");
                    break;
            }
            return estoqueAtual;
        }

        // Retorna o valor da unidade do refrigerante
        public double valorUniade( string nome )
        {
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

                default:
                    break;
            }
            return valor;
        }

    }

}
