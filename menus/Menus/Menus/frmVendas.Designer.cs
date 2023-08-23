namespace Menus
{
    partial class frmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendas));
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.txtProduct = new System.Windows.Forms.Label();
            this.tbxProduct = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.numQuant = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.numResult = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numQuant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxItems
            // 
            this.lbxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.ItemHeight = 20;
            this.lbxItems.Items.AddRange(new object[] {
            "10 - Mouse",
            "20 - Teclado",
            "30 - Memória",
            "40 - Monitor",
            "50 - HD"});
            this.lbxItems.Location = new System.Drawing.Point(63, 108);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(120, 104);
            this.lbxItems.TabIndex = 1;
            this.lbxItems.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtProduct
            // 
            this.txtProduct.AutoSize = true;
            this.txtProduct.BackColor = System.Drawing.Color.Transparent;
            this.txtProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct.Location = new System.Drawing.Point(270, 100);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(89, 24);
            this.txtProduct.TabIndex = 2;
            this.txtProduct.Text = "Produto:";
            this.txtProduct.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxProduct
            // 
            this.tbxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProduct.Location = new System.Drawing.Point(365, 104);
            this.tbxProduct.Name = "tbxProduct";
            this.tbxProduct.Size = new System.Drawing.Size(98, 22);
            this.tbxProduct.TabIndex = 3;
            // 
            // txtQuant
            // 
            this.txtQuant.AutoSize = true;
            this.txtQuant.BackColor = System.Drawing.Color.Transparent;
            this.txtQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.Location = new System.Drawing.Point(236, 130);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(124, 24);
            this.txtQuant.TabIndex = 4;
            this.txtQuant.Text = "Quantidade:";
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(241, 162);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(119, 24);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.Text = "Preço Unit.:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.AutoSize = true;
            this.txtDiscount.BackColor = System.Drawing.Color.Transparent;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(239, 193);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(120, 24);
            this.txtDiscount.TabIndex = 10;
            this.txtDiscount.Text = "Desconto %";
            this.txtDiscount.Click += new System.EventHandler(this.txtDiscount_Click);
            // 
            // txtFinal
            // 
            this.txtFinal.AutoSize = true;
            this.txtFinal.BackColor = System.Drawing.Color.Transparent;
            this.txtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.Location = new System.Drawing.Point(236, 220);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(123, 24);
            this.txtFinal.TabIndex = 11;
            this.txtFinal.Text = "Preço Final:";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.Transparent;
            this.btnCalc.Location = new System.Drawing.Point(327, 260);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(138, 47);
            this.btnCalc.TabIndex = 12;
            this.btnCalc.Text = "CALCULAR";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // numQuant
            // 
            this.numQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuant.Location = new System.Drawing.Point(365, 134);
            this.numQuant.Name = "numQuant";
            this.numQuant.Size = new System.Drawing.Size(98, 22);
            this.numQuant.TabIndex = 13;
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrice.Location = new System.Drawing.Point(365, 164);
            this.numPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(98, 22);
            this.numPrice.TabIndex = 14;
            // 
            // numDiscount
            // 
            this.numDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDiscount.Location = new System.Drawing.Point(365, 193);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(98, 22);
            this.numDiscount.TabIndex = 15;
            // 
            // numResult
            // 
            this.numResult.DecimalPlaces = 2;
            this.numResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numResult.Location = new System.Drawing.Point(365, 222);
            this.numResult.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numResult.Name = "numResult";
            this.numResult.Size = new System.Drawing.Size(98, 22);
            this.numResult.TabIndex = 16;
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(548, 351);
            this.Controls.Add(this.numResult);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.numQuant);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.tbxProduct);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.lbxItems);
            this.Name = "frmVendas";
            this.Text = "Controle de Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.numQuant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.Label txtProduct;
        private System.Windows.Forms.TextBox tbxProduct;
        private System.Windows.Forms.Label txtQuant;
        private System.Windows.Forms.Label txtPrice;
        private System.Windows.Forms.Label txtDiscount;
        private System.Windows.Forms.Label txtFinal;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.NumericUpDown numQuant;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.NumericUpDown numResult;
    }
}