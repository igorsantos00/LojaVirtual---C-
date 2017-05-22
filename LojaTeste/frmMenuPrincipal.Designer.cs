namespace LojaTeste
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.imgUsuario = new System.Windows.Forms.PictureBox();
            this.LbMenu = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btPedido = new System.Windows.Forms.Button();
            this.btUsuario = new System.Windows.Forms.Button();
            this.btClientes = new System.Windows.Forms.Button();
            this.btStatuPedido = new System.Windows.Forms.Button();
            this.btCategoria = new System.Windows.Forms.Button();
            this.btEstoque = new System.Windows.Forms.Button();
            this.btPagamento = new System.Windows.Forms.Button();
            this.btProduto = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.mnuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
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
            this.mnuPrincipal.Size = new System.Drawing.Size(1148, 24);
            this.mnuPrincipal.TabIndex = 4;
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
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
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
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
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
            this.pedidoToolStripMenuItem1.Click += new System.EventHandler(this.pedidoToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuário Logado:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblLogin.Location = new System.Drawing.Point(161, 35);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(71, 20);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Usuário";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // imgUsuario
            // 
            this.imgUsuario.Image = global::LojaTeste.Properties.Resources.UsuarioWhite21;
            this.imgUsuario.Location = new System.Drawing.Point(-350, 172);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(140, 140);
            this.imgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgUsuario.TabIndex = 0;
            this.imgUsuario.TabStop = false;
            this.imgUsuario.Click += new System.EventHandler(this.imgUsuario_Click);
            // 
            // LbMenu
            // 
            this.LbMenu.AutoSize = true;
            this.LbMenu.BackColor = System.Drawing.Color.Transparent;
            this.LbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LbMenu.Location = new System.Drawing.Point(401, 101);
            this.LbMenu.Name = "LbMenu";
            this.LbMenu.Size = new System.Drawing.Size(176, 25);
            this.LbMenu.TabIndex = 6;
            this.LbMenu.Text = "Movimentações";
            this.LbMenu.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(321, 40);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(73, 13);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "HH/MM/SS";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LojaTeste.Properties.Resources.TimeWrite;
            this.pictureBox1.Location = new System.Drawing.Point(287, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.imgCliente_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LojaTeste.Properties.Resources.Risco1;
            this.pictureBox2.Location = new System.Drawing.Point(236, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 38);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.imgUsuario_Click);
            // 
            // btPedido
            // 
            this.btPedido.BackColor = System.Drawing.Color.Transparent;
            this.btPedido.BackgroundImage = global::LojaTeste.Properties.Resources.Bookman_Old_Style2;
            this.btPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPedido.Location = new System.Drawing.Point(421, 168);
            this.btPedido.Name = "btPedido";
            this.btPedido.Size = new System.Drawing.Size(140, 140);
            this.btPedido.TabIndex = 9;
            this.btPedido.UseVisualStyleBackColor = false;
            this.btPedido.Click += new System.EventHandler(this.Pedido_Click);
            // 
            // btUsuario
            // 
            this.btUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btUsuario.BackgroundImage = global::LojaTeste.Properties.Resources.UsuarioMenu;
            this.btUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUsuario.Location = new System.Drawing.Point(594, 168);
            this.btUsuario.Name = "btUsuario";
            this.btUsuario.Size = new System.Drawing.Size(140, 140);
            this.btUsuario.TabIndex = 9;
            this.btUsuario.UseVisualStyleBackColor = false;
            this.btUsuario.Click += new System.EventHandler(this.Usuario_Click);
            // 
            // btClientes
            // 
            this.btClientes.BackColor = System.Drawing.Color.Transparent;
            this.btClientes.BackgroundImage = global::LojaTeste.Properties.Resources.Verdana_16;
            this.btClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClientes.Location = new System.Drawing.Point(767, 168);
            this.btClientes.Name = "btClientes";
            this.btClientes.Size = new System.Drawing.Size(140, 140);
            this.btClientes.TabIndex = 9;
            this.btClientes.UseVisualStyleBackColor = false;
            this.btClientes.Click += new System.EventHandler(this.Cliente_Click);
            // 
            // btStatuPedido
            // 
            this.btStatuPedido.BackColor = System.Drawing.Color.Transparent;
            this.btStatuPedido.BackgroundImage = global::LojaTeste.Properties.Resources.StatuPedidoMenu;
            this.btStatuPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btStatuPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStatuPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStatuPedido.Location = new System.Drawing.Point(943, 168);
            this.btStatuPedido.Name = "btStatuPedido";
            this.btStatuPedido.Size = new System.Drawing.Size(140, 140);
            this.btStatuPedido.TabIndex = 9;
            this.btStatuPedido.UseVisualStyleBackColor = false;
            this.btStatuPedido.Click += new System.EventHandler(this.StatusPedido_Click);
            // 
            // btCategoria
            // 
            this.btCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btCategoria.BackgroundImage = global::LojaTeste.Properties.Resources.CategoriasMenu1;
            this.btCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCategoria.Location = new System.Drawing.Point(421, 356);
            this.btCategoria.Name = "btCategoria";
            this.btCategoria.Size = new System.Drawing.Size(140, 140);
            this.btCategoria.TabIndex = 9;
            this.btCategoria.UseVisualStyleBackColor = false;
            this.btCategoria.Click += new System.EventHandler(this.Categoria_Click);
            // 
            // btEstoque
            // 
            this.btEstoque.BackColor = System.Drawing.Color.Transparent;
            this.btEstoque.BackgroundImage = global::LojaTeste.Properties.Resources.estoque__1_1;
            this.btEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEstoque.Location = new System.Drawing.Point(594, 356);
            this.btEstoque.Name = "btEstoque";
            this.btEstoque.Size = new System.Drawing.Size(140, 140);
            this.btEstoque.TabIndex = 9;
            this.btEstoque.UseVisualStyleBackColor = false;
            this.btEstoque.Click += new System.EventHandler(this.Estoque_Click);
            // 
            // btPagamento
            // 
            this.btPagamento.BackColor = System.Drawing.Color.Transparent;
            this.btPagamento.BackgroundImage = global::LojaTeste.Properties.Resources.calculadoraMenu;
            this.btPagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPagamento.Location = new System.Drawing.Point(767, 356);
            this.btPagamento.Name = "btPagamento";
            this.btPagamento.Size = new System.Drawing.Size(140, 140);
            this.btPagamento.TabIndex = 9;
            this.btPagamento.UseVisualStyleBackColor = false;
            this.btPagamento.Click += new System.EventHandler(this.Pagamento_Click);
            // 
            // btProduto
            // 
            this.btProduto.BackColor = System.Drawing.Color.Transparent;
            this.btProduto.BackgroundImage = global::LojaTeste.Properties.Resources.ProdutosWhite;
            this.btProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProduto.Location = new System.Drawing.Point(943, 356);
            this.btProduto.Name = "btProduto";
            this.btProduto.Size = new System.Drawing.Size(140, 140);
            this.btProduto.TabIndex = 9;
            this.btProduto.UseVisualStyleBackColor = false;
            this.btProduto.Click += new System.EventHandler(this.Produto_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::LojaTeste.Properties.Resources.Setings;
            this.pictureBox3.Location = new System.Drawing.Point(846, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.imgCliente_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::LojaTeste.Properties.Resources.Risco1;
            this.pictureBox4.Location = new System.Drawing.Point(996, 27);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 38);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.imgUsuario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(879, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Configuração";
            this.label2.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::LojaTeste.Properties.Resources.LogoffMenu11;
            this.pictureBox5.Location = new System.Drawing.Point(1100, 32);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.imgCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1040, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Logoff";
            this.label3.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(30, 135);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(233, 199);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.imgCliente_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::LojaTeste.Properties.Resources.Adiciona5;
            this.pictureBox7.Location = new System.Drawing.Point(30, 101);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(27, 28);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.imgCliente_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::LojaTeste.Properties.Resources.deletar1;
            this.pictureBox8.Location = new System.Drawing.Point(63, 101);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(27, 28);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.imgCliente_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaTeste.Properties.Resources.layoutMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1148, 645);
            this.Controls.Add(this.btProduto);
            this.Controls.Add(this.btPagamento);
            this.Controls.Add(this.btEstoque);
            this.Controls.Add(this.btCategoria);
            this.Controls.Add(this.btStatuPedido);
            this.Controls.Add(this.btClientes);
            this.Controls.Add(this.btUsuario);
            this.Controls.Add(this.btPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.LbMenu);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.imgUsuario);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1168, 688);
            this.MinimumSize = new System.Drawing.Size(1168, 688);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoPagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox imgUsuario;
        private System.Windows.Forms.Label LbMenu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btPedido;
        private System.Windows.Forms.Button btUsuario;
        private System.Windows.Forms.Button btClientes;
        private System.Windows.Forms.Button btStatuPedido;
        private System.Windows.Forms.Button btCategoria;
        private System.Windows.Forms.Button btEstoque;
        private System.Windows.Forms.Button btPagamento;
        private System.Windows.Forms.Button btProduto;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}

