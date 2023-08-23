namespace Menus
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dólarRealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Maximizar = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviçosToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dólarRealToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // dólarRealToolStripMenuItem
            // 
            this.dólarRealToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dólarRealToolStripMenuItem.Image")));
            this.dólarRealToolStripMenuItem.Name = "dólarRealToolStripMenuItem";
            this.dólarRealToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dólarRealToolStripMenuItem.Text = "Dólar > Real";
            this.dólarRealToolStripMenuItem.Click += new System.EventHandler(this.dólarRealToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Vendas";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurarToolStripMenuItem,
            this.Maximizar,
            this.minimizarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            this.sistemaToolStripMenuItem.Click += new System.EventHandler(this.sistemaToolStripMenuItem_Click);
            // 
            // restaurarToolStripMenuItem
            // 
            this.restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            this.restaurarToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.restaurarToolStripMenuItem.Text = "Restaurar";
            this.restaurarToolStripMenuItem.Click += new System.EventHandler(this.restaurarToolStripMenuItem_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(129, 22);
            this.Maximizar.Text = "Maximizar";
            this.Maximizar.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // minimizarToolStripMenuItem
            // 
            this.minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            this.minimizarToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.minimizarToolStripMenuItem.Text = "Minimizar";
            this.minimizarToolStripMenuItem.Click += new System.EventHandler(this.minimizarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sistema de Cálculos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Maximizar;
        private System.Windows.Forms.ToolStripMenuItem minimizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dólarRealToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
    }
}

