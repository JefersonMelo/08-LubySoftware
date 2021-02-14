using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine.DTO
{
    //17
    public class estoque_DTO
    {
        private int qtdEstoque;
        private int saidaEstoque;
        private int qtdVenda;
        private double precoUnidade;
        private double precoTotal;
        private string nomeProduto;

        public int QtdEstoque { get => qtdEstoque; set => qtdEstoque = value; }
        public int SaidaEstoque { get => saidaEstoque; set => saidaEstoque = value; }
        public int QtdVenda { get => qtdVenda; set => qtdVenda = value; }
        public double PrecoUnidade { get => precoUnidade; set => precoUnidade = value; }
        public double PrecoTotal { get => precoTotal; set => precoTotal = value; }
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
    }
}
