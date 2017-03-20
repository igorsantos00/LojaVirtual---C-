namespace LojaTeste
{
    partial class frmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            this.label1 = new System.Windows.Forms.Label();
            this.TbCodigoProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbNomeProduto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TbPesquisarProduto = new System.Windows.Forms.Button();
            this.TbCancelarProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Produto";
            // 
            // TbCodigoProduto
            // 
            this.TbCodigoProduto.Location = new System.Drawing.Point(15, 37);
            this.TbCodigoProduto.Name = "TbCodigoProduto";
            this.TbCodigoProduto.Size = new System.Drawing.Size(100, 20);
            this.TbCodigoProduto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome Produto";
            // 
            // TbNomeProduto
            // 
            this.TbNomeProduto.Location = new System.Drawing.Point(15, 94);
            this.TbNomeProduto.Name = "TbNomeProduto";
            this.TbNomeProduto.Size = new System.Drawing.Size(100, 20);
            this.TbNomeProduto.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // TbPesquisarProduto
            // 
            this.TbPesquisarProduto.Location = new System.Drawing.Point(12, 292);
            this.TbPesquisarProduto.Name = "TbPesquisarProduto";
            this.TbPesquisarProduto.Size = new System.Drawing.Size(75, 23);
            this.TbPesquisarProduto.TabIndex = 3;
            this.TbPesquisarProduto.Text = "Pesquisar";
            this.TbPesquisarProduto.UseVisualStyleBackColor = true;
            // 
            // TbCancelarProduto
            // 
            this.TbCancelarProduto.Location = new System.Drawing.Point(282, 292);
            this.TbCancelarProduto.Name = "TbCancelarProduto";
            this.TbCancelarProduto.Size = new System.Drawing.Size(75, 23);
            this.TbCancelarProduto.TabIndex = 3;
            this.TbCancelarProduto.Text = "Cancelar";
            this.TbCancelarProduto.UseVisualStyleBackColor = true;
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 327);
            this.Controls.Add(this.TbCancelarProduto);
            this.Controls.Add(this.TbPesquisarProduto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TbNomeProduto);
            this.Controls.Add(this.TbCodigoProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstoque";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbCodigoProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNomeProduto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button TbPesquisarProduto;
        private System.Windows.Forms.Button TbCancelarProduto;
    }
}