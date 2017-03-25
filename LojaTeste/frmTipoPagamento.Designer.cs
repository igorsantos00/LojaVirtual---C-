namespace LojaTeste
{
    partial class frmTipoPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoPagamento));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbTipoPagamento = new System.Windows.Forms.TextBox();
            this.TbDescricao = new System.Windows.Forms.TextBox();
            this.BtEnviarPagamento = new System.Windows.Forms.Button();
            this.BtCancelarPagamento = new System.Windows.Forms.Button();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoPagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descrição";
            // 
            // TbTipoPagamento
            // 
            this.TbTipoPagamento.Location = new System.Drawing.Point(15, 78);
            this.TbTipoPagamento.Name = "TbTipoPagamento";
            this.TbTipoPagamento.Size = new System.Drawing.Size(100, 20);
            this.TbTipoPagamento.TabIndex = 1;
            // 
            // TbDescricao
            // 
            this.TbDescricao.Location = new System.Drawing.Point(15, 166);
            this.TbDescricao.Name = "TbDescricao";
            this.TbDescricao.Size = new System.Drawing.Size(100, 20);
            this.TbDescricao.TabIndex = 1;
            // 
            // BtEnviarPagamento
            // 
            this.BtEnviarPagamento.Location = new System.Drawing.Point(11, 239);
            this.BtEnviarPagamento.Name = "BtEnviarPagamento";
            this.BtEnviarPagamento.Size = new System.Drawing.Size(75, 23);
            this.BtEnviarPagamento.TabIndex = 2;
            this.BtEnviarPagamento.Text = "Enviar";
            this.BtEnviarPagamento.UseVisualStyleBackColor = true;
            // 
            // BtCancelarPagamento
            // 
            this.BtCancelarPagamento.Location = new System.Drawing.Point(184, 239);
            this.BtCancelarPagamento.Name = "BtCancelarPagamento";
            this.BtCancelarPagamento.Size = new System.Drawing.Size(75, 23);
            this.BtCancelarPagamento.TabIndex = 2;
            this.BtCancelarPagamento.Text = "Cancelar";
            this.BtCancelarPagamento.UseVisualStyleBackColor = true;
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.BackColor = System.Drawing.Color.MediumTurquoise;
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.movimentaçõesToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(284, 24);
            this.mnuPrincipal.TabIndex = 5;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.fileToolStripMenuItem.Text = "Sair";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.statusPedidoToolStripMenuItem,
            this.tipoPagamentoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // statusPedidoToolStripMenuItem
            // 
            this.statusPedidoToolStripMenuItem.Name = "statusPedidoToolStripMenuItem";
            this.statusPedidoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.statusPedidoToolStripMenuItem.Text = "Status Pedido";
            // 
            // tipoPagamentoToolStripMenuItem
            // 
            this.tipoPagamentoToolStripMenuItem.Name = "tipoPagamentoToolStripMenuItem";
            this.tipoPagamentoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.tipoPagamentoToolStripMenuItem.Text = "Tipo Pagamento";
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidoToolStripMenuItem,
            this.pedidoToolStripMenuItem1});
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.pedidoToolStripMenuItem.Text = "Estoque";
            // 
            // pedidoToolStripMenuItem1
            // 
            this.pedidoToolStripMenuItem1.Name = "pedidoToolStripMenuItem1";
            this.pedidoToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.pedidoToolStripMenuItem1.Text = "Pedido";
            // 
            // frmTipoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaTeste.Properties.Resources.layoutTelas1;
            this.ClientSize = new System.Drawing.Size(284, 278);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.BtCancelarPagamento);
            this.Controls.Add(this.BtEnviarPagamento);
            this.Controls.Add(this.TbDescricao);
            this.Controls.Add(this.TbTipoPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTipoPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TipoPagamento";
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbTipoPagamento;
        private System.Windows.Forms.TextBox TbDescricao;
        private System.Windows.Forms.Button BtEnviarPagamento;
        private System.Windows.Forms.Button BtCancelarPagamento;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoPagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem1;
    }
}