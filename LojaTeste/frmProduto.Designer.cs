namespace LojaTeste
{
    partial class frmProduto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.label2 = new System.Windows.Forms.Label();
            this.txtnomeProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescProduto = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtprecProduto = new System.Windows.Forms.TextBox();
            this.txtidCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblImagem = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkativoProduto = new System.Windows.Forms.CheckBox();
            this.lblqtdMinEstoque = new System.Windows.Forms.Label();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.imgImagem = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtdescontoPromocao = new System.Windows.Forms.TextBox();
            this.lbldescontoPromocao = new System.Windows.Forms.Label();
            this.txtqtdMinEstoque = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // txtnomeProduto
            // 
            this.txtnomeProduto.Location = new System.Drawing.Point(12, 185);
            this.txtnomeProduto.Name = "txtnomeProduto";
            this.txtnomeProduto.Size = new System.Drawing.Size(147, 20);
            this.txtnomeProduto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição";
            // 
            // txtdescProduto
            // 
            this.txtdescProduto.Location = new System.Drawing.Point(12, 227);
            this.txtdescProduto.Name = "txtdescProduto";
            this.txtdescProduto.Size = new System.Drawing.Size(606, 20);
            this.txtdescProduto.TabIndex = 6;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(12, 310);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(49, 16);
            this.lblPreco.TabIndex = 7;
            this.lblPreco.Text = "Preço";
            this.lblPreco.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtprecProduto
            // 
            this.txtprecProduto.Location = new System.Drawing.Point(12, 331);
            this.txtprecProduto.Name = "txtprecProduto";
            this.txtprecProduto.Size = new System.Drawing.Size(119, 20);
            this.txtprecProduto.TabIndex = 8;
            // 
            // txtidCategoria
            // 
            this.txtidCategoria.FormattingEnabled = true;
            this.txtidCategoria.Location = new System.Drawing.Point(137, 331);
            this.txtidCategoria.Name = "txtidCategoria";
            this.txtidCategoria.Size = new System.Drawing.Size(121, 21);
            this.txtidCategoria.TabIndex = 9;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(134, 310);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 16);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.BackColor = System.Drawing.Color.Transparent;
            this.lblImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagem.Location = new System.Drawing.Point(195, 253);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(63, 16);
            this.lblImagem.TabIndex = 12;
            this.lblImagem.Text = "Imagem";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(205, 388);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 16);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status";
            // 
            // chkativoProduto
            // 
            this.chkativoProduto.AutoSize = true;
            this.chkativoProduto.BackColor = System.Drawing.Color.Transparent;
            this.chkativoProduto.Location = new System.Drawing.Point(208, 410);
            this.chkativoProduto.Name = "chkativoProduto";
            this.chkativoProduto.Size = new System.Drawing.Size(50, 17);
            this.chkativoProduto.TabIndex = 14;
            this.chkativoProduto.Text = "Ativo";
            this.chkativoProduto.UseVisualStyleBackColor = false;
            // 
            // lblqtdMinEstoque
            // 
            this.lblqtdMinEstoque.AutoSize = true;
            this.lblqtdMinEstoque.BackColor = System.Drawing.Color.Transparent;
            this.lblqtdMinEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtdMinEstoque.Location = new System.Drawing.Point(12, 463);
            this.lblqtdMinEstoque.Name = "lblqtdMinEstoque";
            this.lblqtdMinEstoque.Size = new System.Drawing.Size(131, 16);
            this.lblqtdMinEstoque.TabIndex = 16;
            this.lblqtdMinEstoque.Text = "Quantide Estoque";
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.BackColor = System.Drawing.Color.MediumTurquoise;
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(630, 24);
            this.mnuPrincipal.TabIndex = 18;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // imgImagem
            // 
            this.imgImagem.Location = new System.Drawing.Point(264, 253);
            this.imgImagem.Name = "imgImagem";
            this.imgImagem.Size = new System.Drawing.Size(353, 249);
            this.imgImagem.TabIndex = 11;
            this.imgImagem.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.AutoEllipsis = true;
            this.btnSair.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(164, 511);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(118, 45);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoEllipsis = true;
            this.btnConfirmar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(15, 511);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(118, 45);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtdescontoPromocao
            // 
            this.txtdescontoPromocao.Location = new System.Drawing.Point(15, 408);
            this.txtdescontoPromocao.Name = "txtdescontoPromocao";
            this.txtdescontoPromocao.Size = new System.Drawing.Size(147, 20);
            this.txtdescontoPromocao.TabIndex = 8;
            // 
            // lbldescontoPromocao
            // 
            this.lbldescontoPromocao.AutoSize = true;
            this.lbldescontoPromocao.BackColor = System.Drawing.Color.Transparent;
            this.lbldescontoPromocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescontoPromocao.Location = new System.Drawing.Point(12, 389);
            this.lbldescontoPromocao.Name = "lbldescontoPromocao";
            this.lbldescontoPromocao.Size = new System.Drawing.Size(150, 16);
            this.lbldescontoPromocao.TabIndex = 10;
            this.lbldescontoPromocao.Text = "Desconto/Promoção";
            // 
            // txtqtdMinEstoque
            // 
            this.txtqtdMinEstoque.Location = new System.Drawing.Point(15, 482);
            this.txtqtdMinEstoque.Name = "txtqtdMinEstoque";
            this.txtqtdMinEstoque.Size = new System.Drawing.Size(128, 20);
            this.txtqtdMinEstoque.TabIndex = 8;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            // 
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaTeste.Properties.Resources.layoutTelas1;
            this.ClientSize = new System.Drawing.Size(630, 557);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.lblqtdMinEstoque);
            this.Controls.Add(this.chkativoProduto);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblImagem);
            this.Controls.Add(this.imgImagem);
            this.Controls.Add(this.lbldescontoPromocao);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtidCategoria);
            this.Controls.Add(this.txtdescontoPromocao);
            this.Controls.Add(this.txtqtdMinEstoque);
            this.Controls.Add(this.txtprecProduto);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtdescProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnomeProduto);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnomeProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdescProduto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtprecProduto;
        private System.Windows.Forms.ComboBox txtidCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.PictureBox imgImagem;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkativoProduto;
        private System.Windows.Forms.Label lblqtdMinEstoque;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtdescontoPromocao;
        private System.Windows.Forms.Label lbldescontoPromocao;
        private System.Windows.Forms.TextBox txtqtdMinEstoque;
        private System.Windows.Forms.BindingSource produtoBindingSource;
    }
}