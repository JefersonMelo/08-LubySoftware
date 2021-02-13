using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Maquina_de_Vendas
{

    class Produto
    {
        private string nome;
        private int qtdEstoque = 100; 
        private int qtdItem;
        private double valor;

        public string Nome { get => nome; set => nome = value; }
        public int QtdItem { get => qtdItem; set => qtdItem = value; }
        public int QtdEstoque { get => qtdEstoque; set => qtdEstoque = value; }
        public double Valor { get => valor; set => valor = value; }

    }

}
