
using System;

namespace ListaDeCompras
{
    partial class FormAtualizar
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.NomeProdutoText = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.QuantidadeText = new System.Windows.Forms.Label();
            this.CheckBoxCompradoText = new System.Windows.Forms.Label();
            this.chkComprado = new System.Windows.Forms.CheckBox();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 192);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // NomeProdutoText
            // 
            this.NomeProdutoText.AutoSize = true;
            this.NomeProdutoText.Location = new System.Drawing.Point(12, 52);
            this.NomeProdutoText.Name = "NomeProdutoText";
            this.NomeProdutoText.Size = new System.Drawing.Size(106, 15);
            this.NomeProdutoText.TabIndex = 1;
            this.NomeProdutoText.Text = "Nome do produto:";
            this.NomeProdutoText.Click += new System.EventHandler(this.NomeProdutoText_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(138, 52);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(314, 23);
            this.txtProduto.TabIndex = 2;
            // 
            // QuantidadeText
            // 
            this.QuantidadeText.AutoSize = true;
            this.QuantidadeText.Location = new System.Drawing.Point(12, 98);
            this.QuantidadeText.Name = "QuantidadeText";
            this.QuantidadeText.Size = new System.Drawing.Size(72, 15);
            this.QuantidadeText.TabIndex = 3;
            this.QuantidadeText.Text = "Quantidade:";
            // 
            // CheckBoxCompradoText
            // 
            this.CheckBoxCompradoText.AutoSize = true;
            this.CheckBoxCompradoText.Location = new System.Drawing.Point(12, 138);
            this.CheckBoxCompradoText.Name = "CheckBoxCompradoText";
            this.CheckBoxCompradoText.Size = new System.Drawing.Size(69, 15);
            this.CheckBoxCompradoText.TabIndex = 4;
            this.CheckBoxCompradoText.Text = "Comprado?";
            // 
            // chkComprado
            // 
            this.chkComprado.AutoSize = true;
            this.chkComprado.Location = new System.Drawing.Point(138, 138);
            this.chkComprado.Name = "chkComprado";
            this.chkComprado.Size = new System.Drawing.Size(15, 14);
            this.chkComprado.TabIndex = 5;
            this.chkComprado.UseVisualStyleBackColor = true;
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(138, 98);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(100, 23);
            this.numQuantidade.TabIndex = 6;
            // 
            // FormAtualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 283);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.chkComprado);
            this.Controls.Add(this.CheckBoxCompradoText);
            this.Controls.Add(this.QuantidadeText);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.NomeProdutoText);
            this.Controls.Add(this.btnSalvar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAtualizar";
            this.Text = "FormAtualizar";
            this.Load += new System.EventHandler(this.FormAtualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FormAtualizar_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NomeProdutoText_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label NomeProdutoText;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label QuantidadeText;
        private System.Windows.Forms.Label CheckBoxCompradoText;
        private System.Windows.Forms.CheckBox chkComprado;
        private System.Windows.Forms.NumericUpDown numQuantidade;
    }
}