
namespace Vending_Machine
{
    partial class Vendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.label1 = new System.Windows.Forms.Label();
            this.radioCocaCola = new System.Windows.Forms.RadioButton();
            this.radioPepsi = new System.Windows.Forms.RadioButton();
            this.radioItubaina = new System.Windows.Forms.RadioButton();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.textBoxUnidade = new System.Windows.Forms.TextBox();
            this.labelUnidade = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridVerCompra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVerCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha Seu Refri";
            // 
            // radioCocaCola
            // 
            this.radioCocaCola.AutoSize = true;
            this.radioCocaCola.Location = new System.Drawing.Point(57, 103);
            this.radioCocaCola.Name = "radioCocaCola";
            this.radioCocaCola.Size = new System.Drawing.Size(74, 17);
            this.radioCocaCola.TabIndex = 4;
            this.radioCocaCola.TabStop = true;
            this.radioCocaCola.Text = "Coca-Cola";
            this.radioCocaCola.UseVisualStyleBackColor = true;
            // 
            // radioPepsi
            // 
            this.radioPepsi.AutoSize = true;
            this.radioPepsi.Location = new System.Drawing.Point(201, 103);
            this.radioPepsi.Name = "radioPepsi";
            this.radioPepsi.Size = new System.Drawing.Size(51, 17);
            this.radioPepsi.TabIndex = 5;
            this.radioPepsi.TabStop = true;
            this.radioPepsi.Text = "Pepsi";
            this.radioPepsi.UseVisualStyleBackColor = true;
            // 
            // radioItubaina
            // 
            this.radioItubaina.AutoSize = true;
            this.radioItubaina.Location = new System.Drawing.Point(325, 103);
            this.radioItubaina.Name = "radioItubaina";
            this.radioItubaina.Size = new System.Drawing.Size(65, 17);
            this.radioItubaina.TabIndex = 6;
            this.radioItubaina.TabStop = true;
            this.radioItubaina.Text = "Itubaína";
            this.radioItubaina.UseVisualStyleBackColor = true;
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(54, 179);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(65, 13);
            this.labelQuantidade.TabIndex = 7;
            this.labelQuantidade.Text = "Quantidade:";
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(122, 176);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(130, 20);
            this.textBoxQuantidade.TabIndex = 8;
            // 
            // textBoxUnidade
            // 
            this.textBoxUnidade.Location = new System.Drawing.Point(122, 141);
            this.textBoxUnidade.Name = "textBoxUnidade";
            this.textBoxUnidade.Size = new System.Drawing.Size(130, 20);
            this.textBoxUnidade.TabIndex = 10;
            // 
            // labelUnidade
            // 
            this.labelUnidade.AutoSize = true;
            this.labelUnidade.Location = new System.Drawing.Point(54, 144);
            this.labelUnidade.Name = "labelUnidade";
            this.labelUnidade.Size = new System.Drawing.Size(67, 13);
            this.labelUnidade.TabIndex = 9;
            this.labelUnidade.Text = "Unidade R$:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(122, 211);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(130, 20);
            this.textBoxTotal.TabIndex = 12;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(54, 214);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(51, 13);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "Total R$:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 247);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pagar R$:";
            // 
            // dataGridVerCompra
            // 
            this.dataGridVerCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVerCompra.Location = new System.Drawing.Point(57, 287);
            this.dataGridVerCompra.Name = "dataGridVerCompra";
            this.dataGridVerCompra.Size = new System.Drawing.Size(333, 136);
            this.dataGridVerCompra.TabIndex = 15;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(442, 450);
            this.Controls.Add(this.dataGridVerCompra);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBoxUnidade);
            this.Controls.Add(this.labelUnidade);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.radioItubaina);
            this.Controls.Add(this.radioPepsi);
            this.Controls.Add(this.radioCocaCola);
            this.Controls.Add(this.label1);
            this.Name = "Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVerCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioCocaCola;
        private System.Windows.Forms.RadioButton radioPepsi;
        private System.Windows.Forms.RadioButton radioItubaina;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.TextBox textBoxUnidade;
        private System.Windows.Forms.Label labelUnidade;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridVerCompra;
    }
}