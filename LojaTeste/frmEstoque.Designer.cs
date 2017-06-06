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
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.dgEstoque = new System.Windows.Forms.DataGridView();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtQtdProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Produto";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(119, 52);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(193, 20);
            this.txtIdProduto.TabIndex = 2;
            this.txtIdProduto.TextChanged += new System.EventHandler(this.txtIdProduto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(12, 369);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.ReadOnly = true;
            this.txtNomeProduto.Size = new System.Drawing.Size(269, 20);
            this.txtNomeProduto.TabIndex = 5;
            // 
            // dgEstoque
            // 
            this.dgEstoque.AllowUserToAddRows = false;
            this.dgEstoque.AllowUserToDeleteRows = false;
            this.dgEstoque.AllowUserToResizeRows = false;
            this.dgEstoque.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dgEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgEstoque.Location = new System.Drawing.Point(11, 96);
            this.dgEstoque.MultiSelect = false;
            this.dgEstoque.Name = "dgEstoque";
            this.dgEstoque.ReadOnly = true;
            this.dgEstoque.RowHeadersVisible = false;
            this.dgEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEstoque.Size = new System.Drawing.Size(575, 180);
            this.dgEstoque.TabIndex = 3;
            this.dgEstoque.DoubleClick += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.BackColor = System.Drawing.Color.MediumTurquoise;
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(596, 24);
            this.mnuPrincipal.TabIndex = 5;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // btnSair
            // 
            this.btnSair.AutoEllipsis = true;
            this.btnSair.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(152, 408);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(118, 50);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoEllipsis = true;
            this.btnAlterar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(12, 408);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(118, 50);
            this.btnAlterar.TabIndex = 7;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtQtdProduto
            // 
            this.txtQtdProduto.Location = new System.Drawing.Point(300, 369);
            this.txtQtdProduto.Name = "txtQtdProduto";
            this.txtQtdProduto.Size = new System.Drawing.Size(162, 20);
            this.txtQtdProduto.TabIndex = 6;
            this.txtQtdProduto.TextChanged += new System.EventHandler(this.txtQtdProduto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantidade Disponivel";
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.Location = new System.Drawing.Point(12, 36);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(98, 36);
            this.btnBusca.TabIndex = 1;
            this.btnBusca.Text = "Busca";
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(12, 286);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(118, 50);
            this.btnSelecionar.TabIndex = 4;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(344, 37);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(79, 35);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaTeste.Properties.Resources.layoutTelas1;
            this.ClientSize = new System.Drawing.Size(596, 480);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtQtdProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.dgEstoque);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgEstoque;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtQtdProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button btnSelecionar;
        protected System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Button btnLimpar;
    }
}