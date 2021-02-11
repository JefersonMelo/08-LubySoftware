﻿using System;
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
     */
    public partial class MDI : Form
    {
        private int childFormNumber = 0;

        public MDI( )
        {
            InitializeComponent();
        }

        private void geralToolStripMenuItem_Click( object sender, EventArgs e )
        {
            /*Chamada do Form Visualizar_Estoque no formato de MDI*/

            Form childForm = new Visualizar_Estoque();
            childForm.MdiParent = this;
            childForm.Show();
        }

        //private void ShowNewForm( object sender, EventArgs e )
        //{
        //    Form childForm = new Form();
        //    childForm.MdiParent = this;
        //    childForm.Text = "Janela " + childFormNumber++;
        //    childForm.Show();
        //}

        //private void OpenFile( object sender, EventArgs e )
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //    openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
        //    if (openFileDialog.ShowDialog(this) == DialogResult.OK)
        //    {
        //        string FileName = openFileDialog.FileName;
        //    }
        //}

        //private void SaveAsToolStripMenuItem_Click( object sender, EventArgs e )
        //{
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //    saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
        //    if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
        //    {
        //        string FileName = saveFileDialog.FileName;
        //    }
        //}

        //private void ExitToolsStripMenuItem_Click( object sender, EventArgs e )
        //{
        //    this.Close();
        //}

        //private void CutToolStripMenuItem_Click( object sender, EventArgs e )
        //{
        //}

        //private void CopyToolStripMenuItem_Click( object sender, EventArgs e )
        //{
        //}

        //private void PasteToolStripMenuItem_Click( object sender, EventArgs e )
        //{
        //}

        //private void ToolBarToolStripMenuItem_Click( object sender, EventArgs e )
        //{
        //    toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        //}

        //private void StatusBarToolStripMenuItem_Click( object sender, EventArgs e )
        //{
        //    statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        //}

        //private void CascadeToolStripMenuItem_Click( object sender, EventArgs e )
        //{
        //    LayoutMdi(MdiLayout.Cascade);
        //}

        //private void TileVerticalToolStripMenuItem_Click( object sender, EventArgs e )
        //{
        //    LayoutMdi(MdiLayout.TileVertical);
        //}

        //private void TileHorizontalToolStripMenuItem_Click( object sender, EventArgs e )
        //{
        //    LayoutMdi(MdiLayout.TileHorizontal);
        //}

        //private void ArrangeIconsToolStripMenuItem_Click( object sender, EventArgs e )
        //{
        //    LayoutMdi(MdiLayout.ArrangeIcons);
        //}

        //private void CloseAllToolStripMenuItem_Click( object sender, EventArgs e )
        //{
        //    foreach (Form childForm in MdiChildren)
        //    {
        //        childForm.Close();
        //    }
        //}
    }
}