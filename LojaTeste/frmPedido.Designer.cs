namespace LojaTeste
{
    partial class frmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblIdStatus = new System.Windows.Forms.Label();
            this.txtIdStatus = new System.Windows.Forms.TextBox();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.txtDataPadido = new System.Windows.Forms.TextBox();
            this.lblIdTipoPagto = new System.Windows.Forms.Label();
            this.txtIdTipoPagto = new System.Windows.Forms.TextBox();
            this.lblIdEndereco = new System.Windows.Forms.Label();
            this.txtIdEndereco = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblIdPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPedido.Location = new System.Drawing.Point(80, 39);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(58, 16);
            this.lblIdPedido.TabIndex = 0;
            this.lblIdPedido.Text = "Pedido";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(80, 88);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(56, 16);
            this.lblIdCliente.TabIndex = 1;
            this.lblIdCliente.Text = "Cliente";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Location = new System.Drawing.Point(83, 55);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(100, 20);
            this.txtIdPedido.TabIndex = 2;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(83, 105);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 2;
            // 
            // lblIdStatus
            // 
            this.lblIdStatus.AutoSize = true;
            this.lblIdStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblIdStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdStatus.Location = new System.Drawing.Point(80, 138);
            this.lblIdStatus.Name = "lblIdStatus";
            this.lblIdStatus.Size = new System.Drawing.Size(51, 16);
            this.lblIdStatus.TabIndex = 1;
            this.lblIdStatus.Text = "Status";
            // 
            // txtIdStatus
            // 
            this.txtIdStatus.Location = new System.Drawing.Point(83, 155);
            this.txtIdStatus.Name = "txtIdStatus";
            this.txtIdStatus.Size = new System.Drawing.Size(100, 20);
            this.txtIdStatus.TabIndex = 2;
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblDataPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPedido.Location = new System.Drawing.Point(80, 189);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(91, 16);
            this.lblDataPedido.TabIndex = 1;
            this.lblDataPedido.Text = "DataPedido";
            // 
            // txtDataPadido
            // 
            this.txtDataPadido.Location = new System.Drawing.Point(83, 205);
            this.txtDataPadido.Name = "txtDataPadido";
            this.txtDataPadido.Size = new System.Drawing.Size(100, 20);
            this.txtDataPadido.TabIndex = 2;
            // 
            // lblIdTipoPagto
            // 
            this.lblIdTipoPagto.AutoSize = true;
            this.lblIdTipoPagto.BackColor = System.Drawing.Color.Transparent;
            this.lblIdTipoPagto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTipoPagto.Location = new System.Drawing.Point(80, 244);
            this.lblIdTipoPagto.Name = "lblIdTipoPagto";
            this.lblIdTipoPagto.Size = new System.Drawing.Size(123, 16);
            this.lblIdTipoPagto.TabIndex = 1;
            this.lblIdTipoPagto.Text = "Tipo Pagamento";
            // 
            // txtIdTipoPagto
            // 
            this.txtIdTipoPagto.Location = new System.Drawing.Point(83, 260);
            this.txtIdTipoPagto.Name = "txtIdTipoPagto";
            this.txtIdTipoPagto.Size = new System.Drawing.Size(100, 20);
            this.txtIdTipoPagto.TabIndex = 2;
            // 
            // lblIdEndereco
            // 
            this.lblIdEndereco.AutoSize = true;
            this.lblIdEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblIdEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEndereco.Location = new System.Drawing.Point(80, 298);
            this.lblIdEndereco.Name = "lblIdEndereco";
            this.lblIdEndereco.Size = new System.Drawing.Size(75, 16);
            this.lblIdEndereco.TabIndex = 1;
            this.lblIdEndereco.Text = "Endereço";
            // 
            // txtIdEndereco
            // 
            this.txtIdEndereco.Location = new System.Drawing.Point(83, 314);
            this.txtIdEndereco.Name = "txtIdEndereco";
            this.txtIdEndereco.Size = new System.Drawing.Size(100, 20);
            this.txtIdEndereco.TabIndex = 2;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoEllipsis = true;
            this.btnConfirmar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(83, 351);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(118, 50);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.AutoEllipsis = true;
            this.btnSair.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(232, 351);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(118, 50);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
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
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LojaTeste.Properties.Resources.layoutTelas1;
            this.ClientSize = new System.Drawing.Size(630, 557);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtIdEndereco);
            this.Controls.Add(this.txtIdTipoPagto);
            this.Controls.Add(this.lblIdEndereco);
            this.Controls.Add(this.txtDataPadido);
            this.Controls.Add(this.lblIdTipoPagto);
            this.Controls.Add(this.txtIdStatus);
            this.Controls.Add(this.lblDataPedido);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.lblIdStatus);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.lblIdPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblIdStatus;
        private System.Windows.Forms.TextBox txtIdStatus;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.TextBox txtDataPadido;
        private System.Windows.Forms.Label lblIdTipoPagto;
        private System.Windows.Forms.TextBox txtIdTipoPagto;
        private System.Windows.Forms.Label lblIdEndereco;
        private System.Windows.Forms.TextBox txtIdEndereco;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
    }
}