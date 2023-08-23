using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Menus
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           tbxProduct.Text = lbxItems.Text;
           numQuant.Value = 0;
           numPrice.Value = 0;
           numResult.Value = 0;
           numDiscount.Value = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Var Selects
            int quant = (int)numQuant.Value;
            int price = (int)numPrice.Value;
            int discountInput = (int)numDiscount.Value;

            //Var Calc
            int total = quant * price;
            int discountValue = price * discountInput / 100;
            int totalDesc = total - discountValue;

            numResult.Value = (int)totalDesc;

        }

        private void txtDiscount_Click(object sender, EventArgs e) {

        }
    }
}
