using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciadorDeProdutos
{
    public partial class frmCadastroProdutos : Form
    {
        public frmCadastroProdutos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //verifica se os campos estão preenchidos
            if (numCodigo.Value == 0 || txtDescricao.Text == "" || numQuantidade.Value == 0 || numPrecoUnitario.Value == 0 || 
            numPrecoTotal.Value == 0 || txtNome.Text == "" || mtbCpf.Text == "" || cbxFormaDePagamento.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Informação Importante",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numCodigo.Focus();
                return;
            }

            //cria o arquivo
            string codigoProduto = Convert.ToString(numCodigo.Value) + " .txt";

            //verifica se existe o codigo cadastrado
            if (File.Exists(codigoProduto))
            {
                MessageBox.Show("Desculpe, o CPF inserido já está cadastrado em nosso sistema. Por favor, verifique se digitou corretamente.", "CPF Já Cadastrado",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numCodigo.Focus();
                return;
            }

            //salva os campos
            var arquivo = File.CreateText(codigoProduto);

            arquivo.WriteLine(Convert.ToString(numCodigo.Value));
            arquivo.WriteLine(txtDescricao.Text);
            arquivo.WriteLine(Convert.ToString(numQuantidade.Value));
            arquivo.WriteLine(Convert.ToString(numPrecoUnitario.Value));
            arquivo.WriteLine(Convert.ToString(numPrecoTotal.Value));
            arquivo.WriteLine(txtNome.Text);
            arquivo.WriteLine(mtbCpf.Text);
            arquivo.WriteLine(cbxFormaDePagamento.Text);
            arquivo.Flush();
            arquivo.Close();

            MessageBox.Show("As informações foram salvas com sucesso!", "Salvo com Sucesso",
            MessageBoxButtons.OK, MessageBoxIcon.Information);


            //limpa os campos
            numCodigo.Value = 0;
            txtDescricao.Clear();
            numQuantidade.Value = 0;
            numPrecoUnitario.Value = 0;
            numPrecoTotal.Value = 0;
            txtNome.Clear();
            mtbCpf.Clear();
            cbxFormaDePagamento.Text = "";
            numCodigo.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //cria o arquivo
            string codigoProduto = Convert.ToString(numCodigo.Value) + " .txt";

            //verifica se existe o codigo cadastrado
            if (!File.Exists(codigoProduto))
            {
                MessageBox.Show("Desculpe, o CPF inserido NÃO está cadastrado em nosso sistema. Por favor, verifique se digitou corretamente.", "CPF Já Cadastrado",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numCodigo.Focus();
                return;
            }

            //exibe os campos
            var arquivo = File.OpenText(codigoProduto);

            numCodigo.Value = Convert.ToDecimal(arquivo.ReadLine());
            txtDescricao.Text = arquivo.ReadLine();
            numQuantidade.Value = Convert.ToDecimal(arquivo.ReadLine()); ;
            numPrecoUnitario.Value = Convert.ToDecimal(arquivo.ReadLine()); ;
            numPrecoTotal.Value = Convert.ToDecimal(arquivo.ReadLine()); ;
            txtNome.Text = arquivo.ReadLine();
            mtbCpf.Text = arquivo.ReadLine();
            cbxFormaDePagamento.Text = arquivo.ReadLine();
            arquivo.Close();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //verifica se os campos estão preenchidos
            if (numCodigo.Value == 0 || txtDescricao.Text == "" || numQuantidade.Value == 0 || numPrecoUnitario.Value == 0 ||
            numPrecoTotal.Value == 0 || txtNome.Text == "" || mtbCpf.Text == "" || cbxFormaDePagamento.Text == ""
            )
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Informação Importante",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numCodigo.Focus();
                return;
            }

            //cria o arquivo
            string codigoProduto = Convert.ToString(numCodigo.Value) + " .txt";

            //verifica se existe o codigo cadastrado
            if (!File.Exists(codigoProduto))
            {
                MessageBox.Show("Desculpe, o CPF inserido NÃO está cadastrado em nosso sistema. Por favor, verifique se digitou corretamente.", "CPF Já Cadastrado",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numCodigo.Focus();
                return;
            }

            //salva os campos
            var arquivo = File.CreateText(codigoProduto);

            arquivo.WriteLine(Convert.ToString(numCodigo.Value));
            arquivo.WriteLine(txtDescricao.Text);
            arquivo.WriteLine(Convert.ToString(numQuantidade.Value));
            arquivo.WriteLine(Convert.ToString(numPrecoUnitario.Value));
            arquivo.WriteLine(Convert.ToString(numPrecoTotal.Value));
            arquivo.WriteLine(txtNome.Text);
            arquivo.WriteLine(mtbCpf.Text);
            arquivo.WriteLine(cbxFormaDePagamento.Text);
            arquivo.Flush();
            arquivo.Close();

            MessageBox.Show("As alterações foram salvas com sucesso.", "Alteração Concluída",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            //limpa os campos
            numCodigo.Value = 0;
            txtDescricao.Clear();
            numQuantidade.Value = 0;
            numPrecoUnitario.Value = 0;
            numPrecoTotal.Value = 0;
            txtNome.Clear();
            mtbCpf.Clear();
            cbxFormaDePagamento.Text = "";
            numCodigo.Focus();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            //cria o arquivo
            string codigoProduto = Convert.ToString(numCodigo.Value) + " .txt";

            //verifica se existe o codigo cadastrado
            if (!File.Exists(codigoProduto))
            {
                MessageBox.Show("Desculpe, o CPF inserido NÃO está cadastrado em nosso sistema. Por favor, verifique se digitou corretamente.", "CPF Já Cadastrado",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numCodigo.Focus();
                return;
            }

            File.Delete(codigoProduto);

            MessageBox.Show("O registro foi deletado com sucesso.", "Exclusão Concluída",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //limpa os campos
            numCodigo.Value = 0;
            txtDescricao.Clear();
            numQuantidade.Value = 0;
            numPrecoUnitario.Value = 0;
            numPrecoTotal.Value = 0;
            txtNome.Clear();
            mtbCpf.Clear();
            cbxFormaDePagamento.Text = "";
            numCodigo.Focus();
        }

        private void numPrecoUnitario_ValueChanged(object sender, EventArgs e)
        {
            //atribui valor ao preço total
            numPrecoTotal.Value = numPrecoUnitario.Value * numQuantidade.Value;
        }

        private void numValorPago_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
