
namespace Vending_Machine
{
    partial class MDI
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.vendas = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizar_Estoque = new System.Windows.Forms.ToolStripMenuItem();
            this.sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçõesDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendas,
            this.visualizar_Estoque,
            this.sobre});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(524, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // vendas
            // 
            this.vendas.Name = "vendas";
            this.vendas.Size = new System.Drawing.Size(56, 20);
            this.vendas.Text = "Vendas";
            this.vendas.Click += new System.EventHandler(this.vendas_Click);
            // 
            // visualizar_Estoque
            // 
            this.visualizar_Estoque.Name = "visualizar_Estoque";
            this.visualizar_Estoque.Size = new System.Drawing.Size(113, 20);
            this.visualizar_Estoque.Text = "Visualizar Estoque";
            this.visualizar_Estoque.Click += new System.EventHandler(this.visualizar_Estoque_Click);
            // 
            // sobre
            // 
            this.sobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaçõesDoSistemaToolStripMenuItem});
            this.sobre.Name = "sobre";
            this.sobre.Size = new System.Drawing.Size(49, 20);
            this.sobre.Text = "Sobre";
            // 
            // informaçõesDoSistemaToolStripMenuItem
            // 
            this.informaçõesDoSistemaToolStripMenuItem.Name = "informaçõesDoSistemaToolStripMenuItem";
            this.informaçõesDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.informaçõesDoSistemaToolStripMenuItem.Text = "Informações do Sistema";
            this.informaçõesDoSistemaToolStripMenuItem.Click += new System.EventHandler(this.informaçõesDoSistemaToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 474);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(524, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(524, 496);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDI";
            this.Text = "Vending Machine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem visualizar_Estoque;
        private System.Windows.Forms.ToolStripMenuItem vendas;
        private System.Windows.Forms.ToolStripMenuItem sobre;
        private System.Windows.Forms.ToolStripMenuItem informaçõesDoSistemaToolStripMenuItem;
    }
}



