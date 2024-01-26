using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe {
    public partial class frmPrincipal : Form {
        string simbolo = "";

        public frmPrincipal() {
            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e) {
            if (simbolo == "O") {
                simbolo = "X";
                btn1.ForeColor = Color.Red;
            } else {
                simbolo = "O";
                btn1.ForeColor = Color.Black;
            }

            btn1.Text = simbolo;
            verificaVitoria();
        }

        private void button2_Click(object sender, EventArgs e) {
            if (simbolo == "O") {
                simbolo = "X";
                button2.ForeColor = Color.Red;
            } else {
                simbolo = "O";
                button2.ForeColor = Color.Black;
            }

            button2.Text = simbolo;
            verificaVitoria();
        }

        private void button3_Click(object sender, EventArgs e) {
            if (simbolo == "O") {
                simbolo = "X";
                button3.ForeColor = Color.Red;
            } else {
                simbolo = "O";
                button3.ForeColor = Color.Black;
            }

            button3.Text = simbolo;
            verificaVitoria();
        }

        private void button9_Click(object sender, EventArgs e) {
            if (simbolo == "O") {
                simbolo = "X";
                button9.ForeColor = Color.Red;
            } else {
                simbolo = "O";
                button9.ForeColor = Color.Black;
            }

            button9.Text = simbolo;
            verificaVitoria();
        }

        private void button8_Click(object sender, EventArgs e) {
            if (simbolo == "O") {
                simbolo = "X";
                button8.ForeColor = Color.Red;
            } else {
                simbolo = "O";
                button8.ForeColor = Color.Black;
            }

            button8.Text = simbolo;
            verificaVitoria();
        }

        private void button7_Click(object sender, EventArgs e) {
            if (simbolo == "O") {
                simbolo = "X";
                button7.ForeColor = Color.Red;
            } else {
                simbolo = "O";
                button7.ForeColor = Color.Black;
            }

            button7.Text = simbolo;
            verificaVitoria();
        }

        private void button4_Click(object sender, EventArgs e) {
            if (simbolo == "O") {
                simbolo = "X";
                button4.ForeColor = Color.Red;
            } else {
                simbolo = "O";
                button4.ForeColor = Color.Black;
            }

            button4.Text = simbolo;
            verificaVitoria();
        }

        private void button5_Click(object sender, EventArgs e) {
            if (simbolo == "O") {
                simbolo = "X";
                button5.ForeColor = Color.Red;
            } else {
                simbolo = "O";
                button5.ForeColor = Color.Black;
            }

            button5.Text = simbolo;
            verificaVitoria();
        }

        private void button6_Click(object sender, EventArgs e) {
            if (simbolo == "O") {
                simbolo = "X";
                button6.ForeColor = Color.Red;
            } else {
                simbolo = "O";
                button6.ForeColor = Color.Black;
            }

            button6.Text = simbolo;
            verificaVitoria();
        }

        public void limpaBotoes() {
            btn1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        public bool TodosBotoesPreenchidos() {
            // Verifica se todos os botões têm texto não vazio
            return
                !string.IsNullOrWhiteSpace(btn1.Text) &&
                !string.IsNullOrWhiteSpace(button2.Text) &&
                !string.IsNullOrWhiteSpace(button3.Text) &&
                !string.IsNullOrWhiteSpace(button4.Text) &&
                !string.IsNullOrWhiteSpace(button5.Text) &&
                !string.IsNullOrWhiteSpace(button6.Text) &&
                !string.IsNullOrWhiteSpace(button7.Text) &&
                !string.IsNullOrWhiteSpace(button8.Text) &&
                !string.IsNullOrWhiteSpace(button9.Text);
        }

        private void verificaVitoria() {
            if (
               btn1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || btn1.Text == "O" && button8.Text == "O" && button6.Text == "O"
                || btn1.Text == "O" && button9.Text == "O" && button4.Text == "O"
                || button2.Text == "O" && button8.Text == "O" && button5.Text == "O"
                || button3.Text == "O" && button7.Text == "O" && button6.Text == "O"
                || button3.Text == "O" && button8.Text == "O" && button4.Text == "O"
                || button9.Text == "O" && button8.Text == "O" && button7.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                )
            {
                MessageBox.Show("O é o vencedor!", "FIM DE JOGO!", MessageBoxButtons.OK);
                limpaBotoes();
            } else if (
                btn1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || btn1.Text == "X" && button8.Text == "X" && button6.Text == "X"
                || btn1.Text == "X" && button9.Text == "X" && button4.Text == "X"
                || button2.Text == "X" && button8.Text == "X" && button5.Text == "X"
                || button3.Text == "X" && button7.Text == "X" && button6.Text == "X"
                || button3.Text == "X" && button8.Text == "X" && button4.Text == "X"
                || button9.Text == "X" && button8.Text == "X" && button7.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                ) {
                MessageBox.Show("X é o vencedor!", "FIM DE JOGO!", MessageBoxButtons.OK);
                limpaBotoes();
            }
            else if(TodosBotoesPreenchidos()) {
                MessageBox.Show("Deu Velha!", "FIM DE JOGO!", MessageBoxButtons.OK);
                limpaBotoes();
            }
        }
    }
}
