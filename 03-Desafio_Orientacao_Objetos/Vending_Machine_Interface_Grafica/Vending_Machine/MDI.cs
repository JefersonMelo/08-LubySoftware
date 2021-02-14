using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vending_Machine
{

    /*
    1-Crie uma interface de usuário simples para execução da máquina.
    2-A máquina deverá possuir um estoque de produtos com valor e quantidade de cada produto. 
    A quantidade de produto no estoque da máquina deve ser alterado conforme realização de vendas dos produtos.
    3-A máquina deverá ter opção para visualizar estoque e quantidade disponível.
    4-A máquina só pode vender produtos com quantidade em estoque disponível.
    5-A máquina deverá contabilizar as vendas e mostrar o valor total das vendas realizadas.
    6-Uma venda só poderá ser concluída ao inserir o valor total do produto.
    7-A máquina deverá contabilizar e solicitar o valor faltante para finalizar a venda, caso haja valor 
    de troco para deverá informar o valor.
    8-A máquina não necessita de lógica de contagem de notas, será apenas necessário informar os valores.
    9-Caso necessário crie um documento simples com informações de como executar o programa.   
    https://github.com/lubysoftware/join/tree/asp-net
     */

    public partial class MDI : Form
    {
        private int childFormNumber = 0;

        public MDI( )
        {
            InitializeComponent();
        }

        private void visualizar_Estoque_Click( object sender, EventArgs e )
        {
            /*Chamada do Form Visualizar_Estoque no formato de MDI*/
            Form formFilho = new Visualizar_Estoque();
            formFilho.MdiParent = this;
            formFilho.Show();
        }

        private void vendas_Click( object sender, EventArgs e )
        {
            /*Chamada do Form Vendas*/
            Form formFilho = new Vendas();
            formFilho.MdiParent = this;
            formFilho.Show();
        }
    }
}
