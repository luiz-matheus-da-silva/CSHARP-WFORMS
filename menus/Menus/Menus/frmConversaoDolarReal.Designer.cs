namespace Menus
{
    partial class frmConversaoDolarReal
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
            this.btnConversao = new System.Windows.Forms.Button();
            this.txtReal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numCotacao = new System.Windows.Forms.NumericUpDown();
            this.numDolar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numResultado = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numCotacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConversao
            // 
            this.btnConversao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConversao.Location = new System.Drawing.Point(17, 138);
            this.btnConversao.Name = "btnConversao";
            this.btnConversao.Size = new System.Drawing.Size(435, 53);
            this.btnConversao.TabIndex = 0;
            this.btnConversao.Text = "CALCULAR";
            this.btnConversao.UseVisualStyleBackColor = true;
            this.btnConversao.Click += new System.EventHandler(this.btnConversao_Click);
            // 
            // txtReal
            // 
            this.txtReal.AutoSize = true;
            this.txtReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReal.Location = new System.Drawing.Point(12, 38);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(199, 29);
            this.txtReal.TabIndex = 1;
            this.txtReal.Text = "Cotação do Dia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade em $$:";
            // 
            // numCotacao
            // 
            this.numCotacao.DecimalPlaces = 2;
            this.numCotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCotacao.Location = new System.Drawing.Point(251, 36);
            this.numCotacao.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numCotacao.Name = "numCotacao";
            this.numCotacao.Size = new System.Drawing.Size(201, 35);
            this.numCotacao.TabIndex = 3;
            this.numCotacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numDolar
            // 
            this.numDolar.DecimalPlaces = 2;
            this.numDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDolar.Location = new System.Drawing.Point(251, 85);
            this.numDolar.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numDolar.Name = "numDolar";
            this.numDolar.Size = new System.Drawing.Size(201, 35);
            this.numDolar.TabIndex = 4;
            this.numDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resultado:";
            // 
            // numResultado
            // 
            this.numResultado.DecimalPlaces = 2;
            this.numResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numResultado.Location = new System.Drawing.Point(156, 211);
            this.numResultado.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numResultado.Name = "numResultado";
            this.numResultado.Size = new System.Drawing.Size(120, 35);
            this.numResultado.TabIndex = 6;
            this.numResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmConversaoDolarReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(485, 283);
            this.Controls.Add(this.numResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numDolar);
            this.Controls.Add(this.numCotacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReal);
            this.Controls.Add(this.btnConversao);
            this.Name = "frmConversaoDolarReal";
            this.Text = "Dolar -> Real";
            ((System.ComponentModel.ISupportInitialize)(this.numCotacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConversao;
        private System.Windows.Forms.Label txtReal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCotacao;
        private System.Windows.Forms.NumericUpDown numDolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numResultado;
    }
}