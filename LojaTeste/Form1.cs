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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text.Equals(""))
            {
                MessageBox.Show("Informe o nome!");
            }
            else
            {
                MessageBox.Show("Olá mundo " + TxtNome.Text);
                lblTexto.Text = "Olá mundo " + TxtNome.Text;
                //FrmTela2.sh
            }
                           
        }

        private void frnTeste2_Click(object sender, EventArgs e)
        {
            Form tela = new FrmTela2();
            tela.ShowDialog();
            //this.Close();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tela = new FrmTela2();
            tela.ShowDialog();
        }
    }
}
