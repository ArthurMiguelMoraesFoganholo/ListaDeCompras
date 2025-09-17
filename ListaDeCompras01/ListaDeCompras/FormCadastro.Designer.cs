
using System;

namespace ListaDeCompras
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
        private void InitializeComponent()
        {
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.ddddd = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.NomeProdutoText = new System.Windows.Forms.Label();
            this.QuantidadeProdutoText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(129, 54);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(328, 23);
            this.txtProduto.TabIndex = 0;
            // 
            // ddddd
            // 
            this.ddddd.Location = new System.Drawing.Point(12, 159);
            this.ddddd.Name = "ddddd";
            this.ddddd.Size = new System.Drawing.Size(75, 23);
            this.ddddd.TabIndex = 1;
            this.ddddd.Text = "Cadastrar";
            this.ddddd.UseVisualStyleBackColor = true;
            this.ddddd.Click += new System.EventHandler(this.ddddd_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(129, 159);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(129, 109);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(120, 23);
            this.numQuantidade.TabIndex = 3;
            // 
            // NomeProdutoText
            // 
            this.NomeProdutoText.AutoSize = true;
            this.NomeProdutoText.Location = new System.Drawing.Point(12, 57);
            this.NomeProdutoText.Name = "NomeProdutoText";
            this.NomeProdutoText.Size = new System.Drawing.Size(106, 15);
            this.NomeProdutoText.TabIndex = 4;
            this.NomeProdutoText.Text = "Nome do produto:";
            // 
            // QuantidadeProdutoText
            // 
            this.QuantidadeProdutoText.AutoSize = true;
            this.QuantidadeProdutoText.Location = new System.Drawing.Point(12, 111);
            this.QuantidadeProdutoText.Name = "QuantidadeProdutoText";
            this.QuantidadeProdutoText.Size = new System.Drawing.Size(72, 15);
            this.QuantidadeProdutoText.TabIndex = 5;
            this.QuantidadeProdutoText.Text = "Quantidade:";
            this.QuantidadeProdutoText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 270);
            this.Controls.Add(this.QuantidadeProdutoText);
            this.Controls.Add(this.NomeProdutoText);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.ddddd);
            this.Controls.Add(this.txtProduto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastro";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ddddd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Button ddddd;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Label NomeProdutoText;
        private System.Windows.Forms.Label QuantidadeProdutoText;
    }
}