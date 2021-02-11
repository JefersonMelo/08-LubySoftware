
namespace Vending_Machine
{
    partial class Visualizar_Estoque
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
            this.estoque = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // estoque
            // 
            this.estoque.AutoSize = true;
            this.estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estoque.Location = new System.Drawing.Point(177, 9);
            this.estoque.Name = "estoque";
            this.estoque.Size = new System.Drawing.Size(114, 31);
            this.estoque.TabIndex = 0;
            this.estoque.Text = "Estoque";
            // 
            // Visualizar_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 378);
            this.Controls.Add(this.estoque);
            this.Name = "Visualizar_Estoque";
            this.Text = "Visualizar_Estoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label estoque;
    }
}