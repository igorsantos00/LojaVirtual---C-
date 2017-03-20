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
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            //estoque
            //Suele 1703
        }

        private void TbCancelarProduto_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
