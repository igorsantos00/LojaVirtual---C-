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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descrição";
            // 
            // TbTipoPagamento
            // 
            this.TbTipoPagamento.Location = new System.Drawing.Point(16, 56);
            this.TbTipoPagamento.Name = "TbTipoPagamento";
            this.TbTipoPagamento.Size = new System.Drawing.Size(100, 20);
            this.TbTipoPagamento.TabIndex = 1;
            // 
            // TbDescricao
            // 
            this.TbDescricao.Location = new System.Drawing.Point(16, 144);
            this.TbDescricao.Name = "TbDescricao";
            this.TbDescricao.Size = new System.Drawing.Size(100, 20);
            this.TbDescricao.TabIndex = 1;
            // 
            // BtEnviarPagamento
            // 
            this.BtEnviarPagamento.Location = new System.Drawing.Point(12, 217);
            this.BtEnviarPagamento.Name = "BtEnviarPagamento";
            this.BtEnviarPagamento.Size = new System.Drawing.Size(75, 23);
            this.BtEnviarPagamento.TabIndex = 2;
            this.BtEnviarPagamento.Text = "Enviar";
            this.BtEnviarPagamento.UseVisualStyleBackColor = true;
            // 
            // BtCancelarPagamento
            // 
            this.BtCancelarPagamento.Location = new System.Drawing.Point(185, 217);
            this.BtCancelarPagamento.Name = "BtCancelarPagamento";
            this.BtCancelarPagamento.Size = new System.Drawing.Size(75, 23);
            this.BtCancelarPagamento.TabIndex = 2;
            this.BtCancelarPagamento.Text = "Cancelar";
            this.BtCancelarPagamento.UseVisualStyleBackColor = true;
            this.BtCancelarPagamento.Click += new System.EventHandler(this.BtCancelarPagamento_Click);
            // 
            // frmTipoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 471);
            this.Controls.Add(this.BtCancelarPagamento);
            this.Controls.Add(this.BtEnviarPagamento);
            this.Controls.Add(this.TbDescricao);
            this.Controls.Add(this.TbTipoPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTipoPagamento";
            this.Text = "TipoPagamento";
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
    }
}