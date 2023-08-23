using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void dólarRealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConversaoDolarReal formCambio = new frmConversaoDolarReal();
            // formCambio.Show();
            formCambio.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendas formVendas = new frmVendas();
            // frmVendas.Show();
            formVendas.ShowDialog();
        }
    }
}
