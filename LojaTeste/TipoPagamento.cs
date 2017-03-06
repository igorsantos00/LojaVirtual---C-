using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaTeste
{
    public partial class TipoPagamento: Form
    {
        public TipoPagamento()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TipoPagamento
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "TipoPagamento";
            this.Load += new System.EventHandler(this.TipoPagamento_Load);
            this.ResumeLayout(false);

        }
        //teste
        private void TipoPagamento_Load(object sender, EventArgs e)
        {

        }
    }
}
