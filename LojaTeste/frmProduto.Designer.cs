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
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtdescontoPromocao = new System.Windows.Forms.TextBox();
            this.lbldescontoPromocao = new System.Windows.Forms.Label();
            this.txtqtdMinEstoque = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgProduto = new System.Windows.Forms.DataGridView();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.lbCodigoProduto = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCarregarFoto = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnSelecionarProduto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // txtnomeProduto
            // 
            this.txtnomeProduto.Location = new System.Drawing.Point(15, 299);
            this.txtnomeProduto.Name = "txtnomeProduto";
            this.txtnomeProduto.Size = new System.Drawing.Size(359, 20);
            this.txtnomeProduto.TabIndex = 7;
            this.txtnomeProduto.TextChanged += new System.EventHandler(this.txtnomeProduto_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição";
            // 
            // txtdescProduto
            // 
            this.txtdescProduto.Location = new System.Drawing.Point(15, 436);
            this.txtdescProduto.Multiline = true;
            this.txtdescProduto.Name = "txtdescProduto";
            this.txtdescProduto.Size = new System.Drawing.Size(332, 69);
            this.txtdescProduto.TabIndex = 13;
            this.txtdescProduto.TextChanged += new System.EventHandler(this.txtdescProduto_TextChanged_1);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(119, 325);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(49, 16);
            this.lblPreco.TabIndex = 7;
            this.lblPreco.Text = "Preço";
            this.lblPreco.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtprecProduto
            // 
            this.txtprecProduto.Location = new System.Drawing.Point(122, 346);
            this.txtprecProduto.Name = "txtprecProduto";
            this.txtprecProduto.Size = new System.Drawing.Size(116, 20);
            this.txtprecProduto.TabIndex = 9;
            this.txtprecProduto.TextChanged += new System.EventHandler(this.txtprecProduto_TextChanged_1);
            // 
            // txtidCategoria
            // 
            this.txtidCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtidCategoria.FormattingEnabled = true;
            this.txtidCategoria.Location = new System.Drawing.Point(257, 346);
            this.txtidCategoria.MaxDropDownItems = 10;
            this.txtidCategoria.Name = "txtidCategoria";
            this.txtidCategoria.Size = new System.Drawing.Size(115, 21);
            this.txtidCategoria.TabIndex = 10;
            this.txtidCategoria.Click += new System.EventHandler(this.txtidCategoria_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(254, 325);
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
            this.lblImagem.Location = new System.Drawing.Point(377, 280);
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
            this.lblStatus.Location = new System.Drawing.Point(102, 375);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 16);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status";
            // 
            // chkativoProduto
            // 
            this.chkativoProduto.AutoSize = true;
            this.chkativoProduto.BackColor = System.Drawing.Color.Transparent;
            this.chkativoProduto.Location = new System.Drawing.Point(105, 397);
            this.chkativoProduto.Name = "chkativoProduto";
            this.chkativoProduto.Size = new System.Drawing.Size(50, 17);
            this.chkativoProduto.TabIndex = 12;
            this.chkativoProduto.Text = "Ativo";
            this.chkativoProduto.UseVisualStyleBackColor = false;
            // 
            // lblqtdMinEstoque
            // 
            this.lblqtdMinEstoque.AutoSize = true;
            this.lblqtdMinEstoque.BackColor = System.Drawing.Color.Transparent;
            this.lblqtdMinEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtdMinEstoque.Location = new System.Drawing.Point(12, 325);
            this.lblqtdMinEstoque.Name = "lblqtdMinEstoque";
            this.lblqtdMinEstoque.Size = new System.Drawing.Size(88, 16);
            this.lblqtdMinEstoque.TabIndex = 16;
            this.lblqtdMinEstoque.Text = "Quantidade";
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.BackColor = System.Drawing.Color.MediumTurquoise;
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(745, 24);
            this.mnuPrincipal.TabIndex = 18;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // imgImagem
            // 
            this.imgImagem.Location = new System.Drawing.Point(380, 299);
            this.imgImagem.Name = "imgImagem";
            this.imgImagem.Size = new System.Drawing.Size(353, 206);
            this.imgImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgImagem.TabIndex = 11;
            this.imgImagem.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.AutoEllipsis = true;
            this.btnSair.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(150, 511);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(118, 45);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.AutoEllipsis = true;
            this.btnInserir.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(15, 511);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(118, 45);
            this.btnInserir.TabIndex = 15;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtdescontoPromocao
            // 
            this.txtdescontoPromocao.Location = new System.Drawing.Point(15, 394);
            this.txtdescontoPromocao.Name = "txtdescontoPromocao";
            this.txtdescontoPromocao.Size = new System.Drawing.Size(46, 20);
            this.txtdescontoPromocao.TabIndex = 11;
            this.txtdescontoPromocao.TextChanged += new System.EventHandler(this.txtdescontoPromocao_TextChanged_1);
            // 
            // lbldescontoPromocao
            // 
            this.lbldescontoPromocao.AutoSize = true;
            this.lbldescontoPromocao.BackColor = System.Drawing.Color.Transparent;
            this.lbldescontoPromocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescontoPromocao.Location = new System.Drawing.Point(12, 375);
            this.lbldescontoPromocao.Name = "lbldescontoPromocao";
            this.lbldescontoPromocao.Size = new System.Drawing.Size(74, 16);
            this.lbldescontoPromocao.TabIndex = 10;
            this.lbldescontoPromocao.Text = "Desconto";
            // 
            // txtqtdMinEstoque
            // 
            this.txtqtdMinEstoque.Location = new System.Drawing.Point(15, 344);
            this.txtqtdMinEstoque.Name = "txtqtdMinEstoque";
            this.txtqtdMinEstoque.Size = new System.Drawing.Size(85, 20);
            this.txtqtdMinEstoque.TabIndex = 8;
            this.txtqtdMinEstoque.TextChanged += new System.EventHandler(this.txtqtdMinEstoque_TextChanged_1);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            // 
            // dgProduto
            // 
            this.dgProduto.AllowUserToAddRows = false;
            this.dgProduto.AllowUserToDeleteRows = false;
            this.dgProduto.AllowUserToResizeRows = false;
            this.dgProduto.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgProduto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgProduto.Location = new System.Drawing.Point(15, 78);
            this.dgProduto.Name = "dgProduto";
            this.dgProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProduto.Size = new System.Drawing.Size(718, 199);
            this.dgProduto.TabIndex = 6;
            this.dgProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduto_CellContentClick_1);
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProduto.Location = new System.Drawing.Point(15, 45);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(99, 27);
            this.btnBuscarProduto.TabIndex = 1;
            this.btnBuscarProduto.Text = "Buscar";
            this.btnBuscarProduto.UseVisualStyleBackColor = false;
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(135, 52);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(144, 20);
            this.txtIdProduto.TabIndex = 2;
            // 
            // lbCodigoProduto
            // 
            this.lbCodigoProduto.AutoSize = true;
            this.lbCodigoProduto.BackColor = System.Drawing.Color.Transparent;
            this.lbCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoProduto.Location = new System.Drawing.Point(132, 34);
            this.lbCodigoProduto.Name = "lbCodigoProduto";
            this.lbCodigoProduto.Size = new System.Drawing.Size(106, 15);
            this.lbCodigoProduto.TabIndex = 24;
            this.lbCodigoProduto.Text = "Código Produto";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnCarregarFoto
            // 
            this.btnCarregarFoto.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCarregarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarFoto.ForeColor = System.Drawing.Color.Black;
            this.btnCarregarFoto.Location = new System.Drawing.Point(598, 516);
            this.btnCarregarFoto.Name = "btnCarregarFoto";
            this.btnCarregarFoto.Size = new System.Drawing.Size(135, 34);
            this.btnCarregarFoto.TabIndex = 18;
            this.btnCarregarFoto.Text = "Carregar Foto";
            this.btnCarregarFoto.UseVisualStyleBackColor = false;
            this.btnCarregarFoto.Click += new System.EventHandler(this.btnCarregarFoto_Click);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnExcluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProduto.Location = new System.Drawing.Point(425, 45);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(110, 27);
            this.btnExcluirProduto.TabIndex = 4;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = false;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click_1);
            // 
            // btnSelecionarProduto
            // 
            this.btnSelecionarProduto.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSelecionarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarProduto.ForeColor = System.Drawing.Color.Black;
            this.btnSelecionarProduto.Location = new System.Drawing.Point(297, 45);
            this.btnSelecionarProduto.Name = "btnSelecionarProduto";
            this.btnSelecionarProduto.Size = new System.Drawing.Size(104, 26);
            this.btnSelecionarProduto.TabIndex = 3;
            this.btnSelecionarProduto.Text = "Selecionar";
            this.btnSelecionarProduto.UseVisualStyleBackColor = false;
            this.btnSelecionarProduto.Click += new System.EventHandler(this.btnSelecionarProduto_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(297, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(564, 45);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(82, 26);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaTeste.Properties.Resources.layoutTelas1;
            this.ClientSize = new System.Drawing.Size(745, 557);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSelecionarProduto);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.btnCarregarFoto);
            this.Controls.Add(this.lbCodigoProduto);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.btnBuscarProduto);
            this.Controls.Add(this.dgProduto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnInserir);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).EndInit();
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
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtdescontoPromocao;
        private System.Windows.Forms.Label lbldescontoPromocao;
        private System.Windows.Forms.TextBox txtqtdMinEstoque;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridView dgProduto;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label lbCodigoProduto;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCarregarFoto;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnSelecionarProduto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpar;
    }
}