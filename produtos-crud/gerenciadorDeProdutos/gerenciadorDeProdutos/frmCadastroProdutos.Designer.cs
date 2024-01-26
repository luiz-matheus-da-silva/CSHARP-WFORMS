namespace gerenciadorDeProdutos
{
    partial class frmCadastroProdutos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlProduto = new System.Windows.Forms.Panel();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.numPrecoTotal = new System.Windows.Forms.NumericUpDown();
            this.lblPrecoTotal = new System.Windows.Forms.Label();
            this.numPrecoUnitario = new System.Windows.Forms.NumericUpDown();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDescrição = new System.Windows.Forms.Label();
            this.numCodigo = new System.Windows.Forms.NumericUpDown();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cbxFormaDePagamento = new System.Windows.Forms.ComboBox();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            this.pnlProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCodigo)).BeginInit();
            this.pnlCliente.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(6);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(980, 83);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitulo.Location = new System.Drawing.Point(6, 20);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(640, 47);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CRUD - Cadastro de Produtos com C#";
            // 
            // pnlProduto
            // 
            this.pnlProduto.Controls.Add(this.btnDeletar);
            this.pnlProduto.Controls.Add(this.btnCadastrar);
            this.pnlProduto.Controls.Add(this.txtDescricao);
            this.pnlProduto.Controls.Add(this.numPrecoTotal);
            this.pnlProduto.Controls.Add(this.lblPrecoTotal);
            this.pnlProduto.Controls.Add(this.numPrecoUnitario);
            this.pnlProduto.Controls.Add(this.lblPrecoUnitario);
            this.pnlProduto.Controls.Add(this.numQuantidade);
            this.pnlProduto.Controls.Add(this.lblQuantidade);
            this.pnlProduto.Controls.Add(this.lblDescrição);
            this.pnlProduto.Controls.Add(this.numCodigo);
            this.pnlProduto.Controls.Add(this.lblProduto);
            this.pnlProduto.Controls.Add(this.lblCodigo);
            this.pnlProduto.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProduto.Location = new System.Drawing.Point(0, 0);
            this.pnlProduto.Name = "pnlProduto";
            this.pnlProduto.Size = new System.Drawing.Size(489, 538);
            this.pnlProduto.TabIndex = 0;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Red;
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.White;
            this.btnDeletar.Location = new System.Drawing.Point(327, 456);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(127, 53);
            this.btnDeletar.TabIndex = 11;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(168)))), ((int)(((byte)(77)))));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(168)))), ((int)(((byte)(77)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(168)))), ((int)(((byte)(77)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(99, 456);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(127, 53);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Location = new System.Drawing.Point(20, 164);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(446, 26);
            this.txtDescricao.TabIndex = 2;
            // 
            // numPrecoTotal
            // 
            this.numPrecoTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.numPrecoTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPrecoTotal.DecimalPlaces = 2;
            this.numPrecoTotal.Enabled = false;
            this.numPrecoTotal.Location = new System.Drawing.Point(20, 377);
            this.numPrecoTotal.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numPrecoTotal.Name = "numPrecoTotal";
            this.numPrecoTotal.Size = new System.Drawing.Size(446, 29);
            this.numPrecoTotal.TabIndex = 5;
            // 
            // lblPrecoTotal
            // 
            this.lblPrecoTotal.AutoSize = true;
            this.lblPrecoTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoTotal.Location = new System.Drawing.Point(15, 349);
            this.lblPrecoTotal.Name = "lblPrecoTotal";
            this.lblPrecoTotal.Size = new System.Drawing.Size(116, 25);
            this.lblPrecoTotal.TabIndex = 9;
            this.lblPrecoTotal.Text = "Preço Total:";
            // 
            // numPrecoUnitario
            // 
            this.numPrecoUnitario.BackColor = System.Drawing.Color.Gainsboro;
            this.numPrecoUnitario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPrecoUnitario.DecimalPlaces = 2;
            this.numPrecoUnitario.Location = new System.Drawing.Point(20, 305);
            this.numPrecoUnitario.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numPrecoUnitario.Name = "numPrecoUnitario";
            this.numPrecoUnitario.Size = new System.Drawing.Size(446, 29);
            this.numPrecoUnitario.TabIndex = 4;
            this.numPrecoUnitario.ValueChanged += new System.EventHandler(this.numPrecoUnitario_ValueChanged);
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoUnitario.Location = new System.Drawing.Point(15, 277);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(146, 25);
            this.lblPrecoUnitario.TabIndex = 7;
            this.lblPrecoUnitario.Text = "Preço Unitário:";
            // 
            // numQuantidade
            // 
            this.numQuantidade.BackColor = System.Drawing.Color.Gainsboro;
            this.numQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numQuantidade.Location = new System.Drawing.Point(20, 232);
            this.numQuantidade.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(446, 29);
            this.numQuantidade.TabIndex = 3;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(15, 204);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(121, 25);
            this.lblQuantidade.TabIndex = 5;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblDescrição
            // 
            this.lblDescrição.AutoSize = true;
            this.lblDescrição.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrição.Location = new System.Drawing.Point(15, 136);
            this.lblDescrição.Name = "lblDescrição";
            this.lblDescrição.Size = new System.Drawing.Size(211, 25);
            this.lblDescrição.TabIndex = 3;
            this.lblDescrição.Text = "Descrição do Produto:";
            // 
            // numCodigo
            // 
            this.numCodigo.BackColor = System.Drawing.Color.Gainsboro;
            this.numCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numCodigo.Location = new System.Drawing.Point(20, 93);
            this.numCodigo.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numCodigo.Name = "numCodigo";
            this.numCodigo.Size = new System.Drawing.Size(446, 29);
            this.numCodigo.TabIndex = 1;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(12, 6);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(155, 47);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(15, 65);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(82, 25);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.btnAlterar);
            this.pnlCliente.Controls.Add(this.btnConsultar);
            this.pnlCliente.Controls.Add(this.cbxFormaDePagamento);
            this.pnlCliente.Controls.Add(this.mtbCpf);
            this.pnlCliente.Controls.Add(this.txtNome);
            this.pnlCliente.Controls.Add(this.lblPagamento);
            this.pnlCliente.Controls.Add(this.lblCpf);
            this.pnlCliente.Controls.Add(this.lblCliente);
            this.pnlCliente.Controls.Add(this.lblNome);
            this.pnlCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCliente.Location = new System.Drawing.Point(489, 0);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(491, 538);
            this.pnlCliente.TabIndex = 10;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(69, 456);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(127, 53);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cbxFormaDePagamento
            // 
            this.cbxFormaDePagamento.BackColor = System.Drawing.Color.Gainsboro;
            this.cbxFormaDePagamento.FormattingEnabled = true;
            this.cbxFormaDePagamento.Items.AddRange(new object[] {
            "",
            "DINHEIRO",
            "CARTÃO DE CRÉDITO",
            "CARTÃO DE DÉBITO",
            "BOLETO",
            "PIX"});
            this.cbxFormaDePagamento.Location = new System.Drawing.Point(20, 228);
            this.cbxFormaDePagamento.Name = "cbxFormaDePagamento";
            this.cbxFormaDePagamento.Size = new System.Drawing.Size(446, 33);
            this.cbxFormaDePagamento.TabIndex = 9;
            // 
            // mtbCpf
            // 
            this.mtbCpf.BackColor = System.Drawing.Color.Gainsboro;
            this.mtbCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbCpf.Location = new System.Drawing.Point(20, 169);
            this.mtbCpf.Mask = "000.000.000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(446, 26);
            this.mtbCpf.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Location = new System.Drawing.Point(20, 93);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(446, 26);
            this.txtNome.TabIndex = 7;
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamento.Location = new System.Drawing.Point(15, 204);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(208, 25);
            this.lblPagamento.TabIndex = 5;
            this.lblPagamento.Text = "Forma de Pagamento:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(15, 136);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(51, 25);
            this.lblCpf.TabIndex = 3;
            this.lblCpf.Text = "CPF:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(12, 6);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(135, 47);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(15, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(163, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Completo:";
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Controls.Add(this.pnlCliente);
            this.pnlFormulario.Controls.Add(this.pnlProduto);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Location = new System.Drawing.Point(0, 83);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(980, 538);
            this.pnlFormulario.TabIndex = 1;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(275, 456);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(127, 53);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 621);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlProduto.ResumeLayout(false);
            this.pnlProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCodigo)).EndInit();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.pnlFormulario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlProduto;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.NumericUpDown numPrecoTotal;
        private System.Windows.Forms.Label lblPrecoTotal;
        private System.Windows.Forms.NumericUpDown numPrecoUnitario;
        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblDescrição;
        private System.Windows.Forms.NumericUpDown numCodigo;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.ComboBox cbxFormaDePagamento;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAlterar;
    }
}

