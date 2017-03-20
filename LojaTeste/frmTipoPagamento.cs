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
    public partial class frmTipoPagamento: Form
    {
        public frmTipoPagamento()
        {
            InitializeComponent();
        }

        private void BtCancelarPagamento_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
