namespace LojaTeste
{
    partial class frmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.lblIdNomeCategoria = new System.Windows.Forms.Label();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescCategoria = new System.Windows.Forms.TextBox();
            this.lbldesCategoria = new System.Windows.Forms.Label();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.dgCategoria = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluirCategoria = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(119, 52);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(193, 20);
            this.txtIdCategoria.TabIndex = 1;
            // 
            // lblIdNomeCategoria
            // 
            this.lblIdNomeCategoria.AutoSize = true;
            this.lblIdNomeCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblIdNomeCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdNomeCategoria.Location = new System.Drawing.Point(116, 36);
            this.lblIdNomeCategoria.Name = "lblIdNomeCategoria";
            this.lblIdNomeCategoria.Size = new System.Drawing.Size(121, 16);
            this.lblIdNomeCategoria.TabIndex = 1;
            this.lblIdNomeCategoria.Text = "Nome Categoria";
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Location = new System.Drawing.Point(14, 391);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(238, 20);
            this.txtNomeCategoria.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtDescCategoria
            // 
            this.txtDescCategoria.Location = new System.Drawing.Point(269, 391);
            this.txtDescCategoria.Name = "txtDescCategoria";
            this.txtDescCategoria.Size = new System.Drawing.Size(349, 20);
            this.txtDescCategoria.TabIndex = 3;
            // 
            // lbldesCategoria
            // 
            this.lbldesCategoria.AutoSize = true;
            this.lbldesCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lbldesCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesCategoria.Location = new System.Drawing.Point(266, 375);
            this.lbldesCategoria.Name = "lbldesCategoria";
            this.lbldesCategoria.Size = new System.Drawing.Size(79, 16);
            this.lbldesCategoria.TabIndex = 1;
            this.lbldesCategoria.Text = "Descrição";
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.BackColor = System.Drawing.Color.MediumTurquoise;
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(630, 24);
            this.mnuPrincipal.TabIndex = 5;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // btnSair
            // 
            this.btnSair.AutoEllipsis = true;
            this.btnSair.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(269, 428);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(118, 36);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnInserir
            // 
            this.btnInserir.AutoEllipsis = true;
            this.btnInserir.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(14, 428);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(118, 36);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.Location = new System.Drawing.Point(12, 36);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(98, 36);
            this.btnBusca.TabIndex = 8;
            this.btnBusca.Text = "Busca";
            this.btnBusca.UseVisualStyleBackColor = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // dgCategoria
            // 
            this.dgCategoria.AllowUserToAddRows = false;
            this.dgCategoria.AllowUserToDeleteRows = false;
            this.dgCategoria.AllowUserToResizeRows = false;
            this.dgCategoria.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.dgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategoria.Location = new System.Drawing.Point(12, 90);
            this.dgCategoria.MultiSelect = false;
            this.dgCategoria.Name = "dgCategoria";
            this.dgCategoria.ReadOnly = true;
            this.dgCategoria.RowHeadersVisible = false;
            this.dgCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCategoria.Size = new System.Drawing.Size(606, 228);
            this.dgCategoria.TabIndex = 9;
            this.dgCategoria.DoubleClick += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.AutoEllipsis = true;
            this.btnAlterar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(145, 428);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(118, 36);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click_1);
            // 
            // btnExcluirCategoria
            // 
            this.btnExcluirCategoria.AutoEllipsis = true;
            this.btnExcluirCategoria.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnExcluirCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCategoria.Location = new System.Drawing.Point(153, 324);
            this.btnExcluirCategoria.Name = "btnExcluirCategoria";
            this.btnExcluirCategoria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExcluirCategoria.Size = new System.Drawing.Size(118, 36);
            this.btnExcluirCategoria.TabIndex = 6;
            this.btnExcluirCategoria.Text = "Excluir";
            this.btnExcluirCategoria.UseVisualStyleBackColor = false;
            this.btnExcluirCategoria.Click += new System.EventHandler(this.btnExcluirCategoria_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(12, 324);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(118, 36);
            this.btnSelecionar.TabIndex = 10;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaTeste.Properties.Resources.layoutTelas1;
            this.ClientSize = new System.Drawing.Size(630, 487);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.dgCategoria);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.btnExcluirCategoria);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.lbldesCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIdNomeCategoria);
            this.Controls.Add(this.txtDescCategoria);
            this.Controls.Add(this.txtNomeCategoria);
            this.Controls.Add(this.txtIdCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.Label lblIdNomeCategoria;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescCategoria;
        private System.Windows.Forms.Label lbldesCategoria;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.DataGridView dgCategoria;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluirCategoria;
        private System.Windows.Forms.Button btnSelecionar;
    }
}