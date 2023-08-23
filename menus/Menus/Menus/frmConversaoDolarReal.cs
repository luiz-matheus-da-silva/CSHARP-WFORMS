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
    public partial class frmConversaoDolarReal : Form
    {
        public frmConversaoDolarReal()
        {
            InitializeComponent();
        }

        private void btnConversao_Click(object sender, EventArgs e)
        {
            numResultado.Value = numCotacao.Value * numDolar.Value;
        }
    }
}
