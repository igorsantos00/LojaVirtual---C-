namespace LojaTeste
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.dgUsuario = new System.Windows.Forms.DataGridView();
            this.btnBusca = new System.Windows.Forms.Button();
            this.lblIdNomeCategoria = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.btnSelecionarUsuario = new System.Windows.Forms.Button();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.btnInserirUsuario = new System.Windows.Forms.Button();
            this.btnAlterarUsuario = new System.Windows.Forms.Button();
            this.btnSairUsuario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.ckAtivo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(9, 384);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(46, 16);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.Location = new System.Drawing.Point(9, 345);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(119, 16);
            this.lblNomeCompleto.TabIndex = 1;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(12, 401);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(139, 20);
            this.txtLogin.TabIndex = 1;
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(12, 361);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(464, 20);
            this.txtNomeCompleto.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(154, 385);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(52, 16);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            // 
            // txtSenha1
            // 
            this.txtSenha1.Location = new System.Drawing.Point(157, 401);
            this.txtSenha1.Name = "txtSenha1";
            this.txtSenha1.Size = new System.Drawing.Size(130, 20);
            this.txtSenha1.TabIndex = 3;
            this.txtSenha1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(498, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(498, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ativo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "A",
            "C"});
            this.cmbTipo.Location = new System.Drawing.Point(501, 361);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 4;
            this.cmbTipo.Text = "Selecione";
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.BackColor = System.Drawing.Color.MediumTurquoise;
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(634, 24);
            this.mnuPrincipal.TabIndex = 8;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // dgUsuario
            // 
            this.dgUsuario.AllowUserToAddRows = false;
            this.dgUsuario.AllowUserToDeleteRows = false;
            this.dgUsuario.AllowUserToResizeRows = false;
            this.dgUsuario.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgUsuario.Location = new System.Drawing.Point(12, 96);
            this.dgUsuario.MultiSelect = false;
            this.dgUsuario.Name = "dgUsuario";
            this.dgUsuario.ReadOnly = true;
            this.dgUsuario.RowHeadersVisible = false;
            this.dgUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsuario.Size = new System.Drawing.Size(610, 197);
            this.dgUsuario.TabIndex = 11;
            this.dgUsuario.DoubleClick += new System.EventHandler(this.btnSelecionarUsuario_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.Location = new System.Drawing.Point(12, 43);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(98, 36);
            this.btnBusca.TabIndex = 12;
            this.btnBusca.Text = "Busca";
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // lblIdNomeCategoria
            // 
            this.lblIdNomeCategoria.AutoSize = true;
            this.lblIdNomeCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblIdNomeCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdNomeCategoria.Location = new System.Drawing.Point(131, 40);
            this.lblIdNomeCategoria.Name = "lblIdNomeCategoria";
            this.lblIdNomeCategoria.Size = new System.Drawing.Size(107, 16);
            this.lblIdNomeCategoria.TabIndex = 13;
            this.lblIdNomeCategoria.Text = "Nome Usuario";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(134, 59);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(193, 20);
            this.txtNomeUsuario.TabIndex = 14;
            // 
            // btnSelecionarUsuario
            // 
            this.btnSelecionarUsuario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSelecionarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionarUsuario.Location = new System.Drawing.Point(12, 299);
            this.btnSelecionarUsuario.Name = "btnSelecionarUsuario";
            this.btnSelecionarUsuario.Size = new System.Drawing.Size(118, 36);
            this.btnSelecionarUsuario.TabIndex = 15;
            this.btnSelecionarUsuario.Text = "Selecionar";
            this.btnSelecionarUsuario.UseVisualStyleBackColor = false;
            this.btnSelecionarUsuario.Click += new System.EventHandler(this.btnSelecionarUsuario_Click);
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.AutoEllipsis = true;
            this.btnExcluirUsuario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnExcluirUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirUsuario.Location = new System.Drawing.Point(154, 299);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExcluirUsuario.Size = new System.Drawing.Size(118, 36);
            this.btnExcluirUsuario.TabIndex = 16;
            this.btnExcluirUsuario.Text = "Excluir";
            this.btnExcluirUsuario.UseVisualStyleBackColor = false;
            this.btnExcluirUsuario.Click += new System.EventHandler(this.btnExcluirUsuario_Click);
            // 
            // btnInserirUsuario
            // 
            this.btnInserirUsuario.AutoEllipsis = true;
            this.btnInserirUsuario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnInserirUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserirUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirUsuario.Location = new System.Drawing.Point(12, 443);
            this.btnInserirUsuario.Name = "btnInserirUsuario";
            this.btnInserirUsuario.Size = new System.Drawing.Size(118, 36);
            this.btnInserirUsuario.TabIndex = 17;
            this.btnInserirUsuario.Text = "Inserir";
            this.btnInserirUsuario.UseVisualStyleBackColor = false;
            this.btnInserirUsuario.Click += new System.EventHandler(this.btnInserirUsuario_Click);
            // 
            // btnAlterarUsuario
            // 
            this.btnAlterarUsuario.AutoEllipsis = true;
            this.btnAlterarUsuario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAlterarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarUsuario.Location = new System.Drawing.Point(154, 443);
            this.btnAlterarUsuario.Name = "btnAlterarUsuario";
            this.btnAlterarUsuario.Size = new System.Drawing.Size(118, 36);
            this.btnAlterarUsuario.TabIndex = 18;
            this.btnAlterarUsuario.Text = "Alterar";
            this.btnAlterarUsuario.UseVisualStyleBackColor = false;
            this.btnAlterarUsuario.Click += new System.EventHandler(this.btnAlterarUsuario_Click);
            // 
            // btnSairUsuario
            // 
            this.btnSairUsuario.AutoEllipsis = true;
            this.btnSairUsuario.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSairUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSairUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairUsuario.Location = new System.Drawing.Point(293, 443);
            this.btnSairUsuario.Name = "btnSairUsuario";
            this.btnSairUsuario.Size = new System.Drawing.Size(118, 36);
            this.btnSairUsuario.TabIndex = 19;
            this.btnSairUsuario.Text = "Sair";
            this.btnSairUsuario.UseVisualStyleBackColor = false;
            this.btnSairUsuario.Click += new System.EventHandler(this.btnSairUsuario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Confirma Senha";
            // 
            // txtSenha2
            // 
            this.txtSenha2.Location = new System.Drawing.Point(293, 401);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.Size = new System.Drawing.Size(183, 20);
            this.txtSenha2.TabIndex = 3;
            this.txtSenha2.UseSystemPasswordChar = true;
            // 
            // ckAtivo
            // 
            this.ckAtivo.AutoSize = true;
            this.ckAtivo.Location = new System.Drawing.Point(501, 404);
            this.ckAtivo.Name = "ckAtivo";
            this.ckAtivo.Size = new System.Drawing.Size(15, 14);
            this.ckAtivo.TabIndex = 20;
            this.ckAtivo.UseVisualStyleBackColor = true;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaTeste.Properties.Resources.layoutTelas1;
            this.ClientSize = new System.Drawing.Size(634, 491);
            this.Controls.Add(this.ckAtivo);
            this.Controls.Add(this.btnSairUsuario);
            this.Controls.Add(this.btnAlterarUsuario);
            this.Controls.Add(this.btnInserirUsuario);
            this.Controls.Add(this.btnExcluirUsuario);
            this.Controls.Add(this.btnSelecionarUsuario);
            this.Controls.Add(this.lblIdNomeCategoria);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.dgUsuario);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.txtSenha2);
            this.Controls.Add(this.txtSenha1);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.lblLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.DataGridView dgUsuario;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Label lblIdNomeCategoria;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Button btnSelecionarUsuario;
        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.Button btnInserirUsuario;
        private System.Windows.Forms.Button btnAlterarUsuario;
        private System.Windows.Forms.Button btnSairUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.CheckBox ckAtivo;
    }
}